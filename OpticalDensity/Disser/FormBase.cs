using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Disser
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Metering". При необходимости она может быть перемещена или удалена.
            this.meteringTableAdapter.Fill(this.database1DataSet.Metering);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Exemplar". При необходимости она может быть перемещена или удалена.
            this.exemplarTableAdapter.Fill(this.database1DataSet.Exemplar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cytofotometryDataSet1.Metering". При необходимости она может быть перемещена или удалена.
            this.meteringTableAdapter.Fill(this.database1DataSet.Metering);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cytofotometryDataSet1.Exemplar". При необходимости она может быть перемещена или удалена.
            this.exemplarTableAdapter.Fill(this.database1DataSet.Exemplar);
            
        }

        private void BUpdateEx_Click(object sender, EventArgs e)
        {
            this.exemplarTableAdapter.Update(this.database1DataSet.Exemplar);
            this.exemplarTableAdapter.Fill(this.database1DataSet.Exemplar);
        }

        private void BUpdateMet_Click(object sender, EventArgs e)
        {
            this.meteringTableAdapter.Update(this.database1DataSet.Metering);
            this.meteringTableAdapter.Fill(this.database1DataSet.Metering);
        }
                      
    }
}
