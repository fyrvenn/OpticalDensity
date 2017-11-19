using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disser
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }
        string _path = Application.ExecutablePath.Remove(Application.ExecutablePath.LastIndexOf(@"\") + 1);//путь откуда был запущен .exe программы
        private DataSet xmlDS = new DataSet();
        private DataSet _dsContent = null; //содержание
        private bool _exeption = false; // в случае отсутствия файлов справки - сообщить и закрыть форму справки

        private void FormHelp_Load(object sender, EventArgs e)
        {
            try
            {
                TreeViewLoad();
            }
            catch
            {
                if (MessageBox.Show("Справка находится в стадии разработки.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                    _exeption = true;
            }
        }
        private void TreeViewLoad() //построение дерева Содержания Справки
        {
            xmlDS.ReadXml(@"Help/content.xml");
            _dsContent = xmlDS;
            if (_dsContent.Tables.Count > 0)
            {
                var links = _dsContent.Tables[0].AsEnumerable().Where(l => Convert.ToInt32(l["parent_id"]) == 0).ToList();
                foreach (var row in links)
                {
                    TreeNode NewNode = new TreeNode(Convert.ToString(row["name"]));
                    NewNode.Tag = row["text_url"].ToString();
                    tvContent.Nodes.Add(NewNode);
                    PopulateTree(row, NewNode);
                }
                tvContent.ExpandAll(); //раскрыть все узлы дерева
            }
        }

        private void PopulateTree(DataRow dr, TreeNode pNode) //заполнение узла pNode дочерними элементами
        {
            var links = _dsContent.Tables[0].AsEnumerable().Where(l => Convert.ToInt32(l["parent_id"]) == Convert.ToInt32(dr["id"])).ToList();
            foreach (var row in links)
            {
                TreeNode NewChild = new TreeNode(row["name"].ToString());
                NewChild.Tag = row["text_url"].ToString();
                pNode.Nodes.Add(NewChild);
                PopulateTree(row, NewChild);
            }
        }

        private void tvContent_AfterSelect(object sender, TreeViewEventArgs e)
        {
            gbSelectPunct.Text = e.Node.Text.ToString();
            string textURL = Convert.ToString(e.Node.Tag);
            if (textURL.Length > 0)
            {
                wbText.Navigate("file:///" + _path + textURL);
            }
        }

        private void FormHelp_Paint(object sender, PaintEventArgs e)
        {
            if (_exeption)
                Close();
        }
    }
}
