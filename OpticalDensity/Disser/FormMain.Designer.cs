namespace Disser
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьЭталонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каталогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельТиповВыделенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельТекущихОбработокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборСохраняемыхХарактеристикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cnfnbcnbrfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текущегоОбъектаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.набораОбластейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbType = new System.Windows.Forms.GroupBox();
            this.bRing = new System.Windows.Forms.Button();
            this.bLasso = new System.Windows.Forms.Button();
            this.bEllipse = new System.Windows.Forms.Button();
            this.bRectangle = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.pCurrentResult = new System.Windows.Forms.Panel();
            this.pbRollUp = new System.Windows.Forms.PictureBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbH = new System.Windows.Forms.TextBox();
            this.lH = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMicroPlag = new System.Windows.Forms.CheckBox();
            this.cbMethodScanirovaniy = new System.Windows.Forms.CheckBox();
            this.cbMethodSrednego = new System.Windows.Forms.CheckBox();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.tbBlur = new System.Windows.Forms.TrackBar();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.pAllResult = new System.Windows.Forms.Panel();
            this.lbResultList = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.gbType.SuspendLayout();
            this.pCurrentResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRollUp)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.pAllResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.выборСохраняемыхХарактеристикToolStripMenuItem,
            this.cnfnbcnbrfToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьЭталонToolStripMenuItem,
            this.загрузитьИзображениеToolStripMenuItem,
            this.toolStripSeparator1,
            this.сохранитьToolStripMenuItem,
            this.каталогToolStripMenuItem});
            this.файлToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("файлToolStripMenuItem.Image")));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьЭталонToolStripMenuItem
            // 
            this.загрузитьЭталонToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("загрузитьЭталонToolStripMenuItem.Image")));
            this.загрузитьЭталонToolStripMenuItem.Name = "загрузитьЭталонToolStripMenuItem";
            this.загрузитьЭталонToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.загрузитьЭталонToolStripMenuItem.Text = "Загрузить Эталон";
            this.загрузитьЭталонToolStripMenuItem.Click += new System.EventHandler(this.загрузитьЭталонToolStripMenuItem_Click);
            // 
            // загрузитьИзображениеToolStripMenuItem
            // 
            this.загрузитьИзображениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("загрузитьИзображениеToolStripMenuItem.Image")));
            this.загрузитьИзображениеToolStripMenuItem.Name = "загрузитьИзображениеToolStripMenuItem";
            this.загрузитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.загрузитьИзображениеToolStripMenuItem.Text = "Загрузить Изображение";
            this.загрузитьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.загрузитьИзображениеToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // каталогToolStripMenuItem
            // 
            this.каталогToolStripMenuItem.Image = global::Disser.Properties.Resources.card_address1;
            this.каталогToolStripMenuItem.Name = "каталогToolStripMenuItem";
            this.каталогToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.каталогToolStripMenuItem.Text = "Каталог";
            this.каталогToolStripMenuItem.Click += new System.EventHandler(this.каталогToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.панельТиповВыделенийToolStripMenuItem,
            this.панельТекущихОбработокToolStripMenuItem,
            this.всеРезультатыToolStripMenuItem});
            this.видToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("видToolStripMenuItem.Image")));
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // панельТиповВыделенийToolStripMenuItem
            // 
            this.панельТиповВыделенийToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("панельТиповВыделенийToolStripMenuItem.Image")));
            this.панельТиповВыделенийToolStripMenuItem.Name = "панельТиповВыделенийToolStripMenuItem";
            this.панельТиповВыделенийToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.панельТиповВыделенийToolStripMenuItem.Tag = "1";
            this.панельТиповВыделенийToolStripMenuItem.Text = "Панель типов выделений";
            this.панельТиповВыделенийToolStripMenuItem.Click += new System.EventHandler(this.PanelVisibleClic);
            // 
            // панельТекущихОбработокToolStripMenuItem
            // 
            this.панельТекущихОбработокToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("панельТекущихОбработокToolStripMenuItem.Image")));
            this.панельТекущихОбработокToolStripMenuItem.Name = "панельТекущихОбработокToolStripMenuItem";
            this.панельТекущихОбработокToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.панельТекущихОбработокToolStripMenuItem.Tag = "2";
            this.панельТекущихОбработокToolStripMenuItem.Text = "Панель текущих обработок";
            this.панельТекущихОбработокToolStripMenuItem.Click += new System.EventHandler(this.PanelVisibleClic);
            // 
            // всеРезультатыToolStripMenuItem
            // 
            this.всеРезультатыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("всеРезультатыToolStripMenuItem.Image")));
            this.всеРезультатыToolStripMenuItem.Name = "всеРезультатыToolStripMenuItem";
            this.всеРезультатыToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.всеРезультатыToolStripMenuItem.Tag = "3";
            this.всеРезультатыToolStripMenuItem.Text = "Все результаты";
            this.всеРезультатыToolStripMenuItem.Click += new System.EventHandler(this.PanelVisibleClic);
            // 
            // выборСохраняемыхХарактеристикToolStripMenuItem
            // 
            this.выборСохраняемыхХарактеристикToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выборСохраняемыхХарактеристикToolStripMenuItem.Image")));
            this.выборСохраняемыхХарактеристикToolStripMenuItem.Name = "выборСохраняемыхХарактеристикToolStripMenuItem";
            this.выборСохраняемыхХарактеристикToolStripMenuItem.Size = new System.Drawing.Size(230, 20);
            this.выборСохраняемыхХарактеристикToolStripMenuItem.Text = "Выбор сохраняемых характеристик";
            this.выборСохраняемыхХарактеристикToolStripMenuItem.Click += new System.EventHandler(this.выборСохраняемыхХарактеристикToolStripMenuItem_Click);
            // 
            // cnfnbcnbrfToolStripMenuItem
            // 
            this.cnfnbcnbrfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текущегоОбъектаToolStripMenuItem,
            this.набораОбластейToolStripMenuItem});
            this.cnfnbcnbrfToolStripMenuItem.Image = global::Disser.Properties.Resources._1371469825_chart_bar;
            this.cnfnbcnbrfToolStripMenuItem.Name = "cnfnbcnbrfToolStripMenuItem";
            this.cnfnbcnbrfToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.cnfnbcnbrfToolStripMenuItem.Text = "Статистика";
            // 
            // текущегоОбъектаToolStripMenuItem
            // 
            this.текущегоОбъектаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("текущегоОбъектаToolStripMenuItem.Image")));
            this.текущегоОбъектаToolStripMenuItem.Name = "текущегоОбъектаToolStripMenuItem";
            this.текущегоОбъектаToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.текущегоОбъектаToolStripMenuItem.Text = "OD Текущей области";
            this.текущегоОбъектаToolStripMenuItem.Click += new System.EventHandler(this.текущегоОбъектаToolStripMenuItem_Click);
            // 
            // набораОбластейToolStripMenuItem
            // 
            this.набораОбластейToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("набораОбластейToolStripMenuItem.Image")));
            this.набораОбластейToolStripMenuItem.Name = "набораОбластейToolStripMenuItem";
            this.набораОбластейToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.набораОбластейToolStripMenuItem.Text = "OD Набора областей";
            this.набораОбластейToolStripMenuItem.Click += new System.EventHandler(this.набораОбластейToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripMenuItem.Image")));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Ellips.png");
            this.imageList1.Images.SetKeyName(1, "Lasso.png");
            this.imageList1.Images.SetKeyName(2, "Rect.png");
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.bRing);
            this.gbType.Controls.Add(this.bLasso);
            this.gbType.Controls.Add(this.bEllipse);
            this.gbType.Controls.Add(this.bRectangle);
            this.gbType.Location = new System.Drawing.Point(0, 24);
            this.gbType.Margin = new System.Windows.Forms.Padding(2);
            this.gbType.Name = "gbType";
            this.gbType.Padding = new System.Windows.Forms.Padding(2);
            this.gbType.Size = new System.Drawing.Size(38, 145);
            this.gbType.TabIndex = 5;
            this.gbType.TabStop = false;
            this.gbType.Tag = "";
            // 
            // bRing
            // 
            this.bRing.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bRing.Image = ((System.Drawing.Image)(resources.GetObject("bRing.Image")));
            this.bRing.Location = new System.Drawing.Point(4, 112);
            this.bRing.Margin = new System.Windows.Forms.Padding(2);
            this.bRing.Name = "bRing";
            this.bRing.Size = new System.Drawing.Size(30, 25);
            this.bRing.TabIndex = 3;
            this.bRing.Tag = "4";
            this.toolTip1.SetToolTip(this.bRing, "Выделение кольцевидной области. \r\nВычисляет параметры отдельно для ядра и цитопла" +
                    "змы. \r\nВыделите сначала внутреннюю гранцу (граница ядра), затем - внешнюю (грани" +
                    "ца клетки).");
            this.bRing.UseVisualStyleBackColor = false;
            this.bRing.Click += new System.EventHandler(this.bTypeLine_Click);
            // 
            // bLasso
            // 
            this.bLasso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bLasso.ImageIndex = 1;
            this.bLasso.ImageList = this.imageList1;
            this.bLasso.Location = new System.Drawing.Point(4, 80);
            this.bLasso.Margin = new System.Windows.Forms.Padding(2);
            this.bLasso.Name = "bLasso";
            this.bLasso.Size = new System.Drawing.Size(30, 25);
            this.bLasso.TabIndex = 2;
            this.bLasso.Tag = "3";
            this.bLasso.UseVisualStyleBackColor = false;
            this.bLasso.Click += new System.EventHandler(this.bTypeLine_Click);
            // 
            // bEllipse
            // 
            this.bEllipse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEllipse.ImageIndex = 0;
            this.bEllipse.ImageList = this.imageList1;
            this.bEllipse.Location = new System.Drawing.Point(4, 47);
            this.bEllipse.Margin = new System.Windows.Forms.Padding(2);
            this.bEllipse.Name = "bEllipse";
            this.bEllipse.Size = new System.Drawing.Size(30, 25);
            this.bEllipse.TabIndex = 1;
            this.bEllipse.Tag = "2";
            this.bEllipse.UseVisualStyleBackColor = false;
            this.bEllipse.Click += new System.EventHandler(this.bTypeLine_Click);
            // 
            // bRectangle
            // 
            this.bRectangle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bRectangle.ImageIndex = 2;
            this.bRectangle.ImageList = this.imageList1;
            this.bRectangle.Location = new System.Drawing.Point(4, 15);
            this.bRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.bRectangle.Name = "bRectangle";
            this.bRectangle.Size = new System.Drawing.Size(30, 25);
            this.bRectangle.TabIndex = 0;
            this.bRectangle.Tag = "1";
            this.bRectangle.UseVisualStyleBackColor = false;
            this.bRectangle.Click += new System.EventHandler(this.bTypeLine_Click);
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter4.Location = new System.Drawing.Point(944, 24);
            this.splitter4.Margin = new System.Windows.Forms.Padding(2);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(2, 548);
            this.splitter4.TabIndex = 10;
            this.splitter4.TabStop = false;
            // 
            // pCurrentResult
            // 
            this.pCurrentResult.Controls.Add(this.pbRollUp);
            this.pCurrentResult.Controls.Add(this.propertyGrid1);
            this.pCurrentResult.Controls.Add(this.panel2);
            this.pCurrentResult.Controls.Add(this.panel1);
            this.pCurrentResult.Controls.Add(this.splitter5);
            this.pCurrentResult.Controls.Add(this.tbBlur);
            this.pCurrentResult.Controls.Add(this.splitter3);
            this.pCurrentResult.Controls.Add(this.pb3);
            this.pCurrentResult.Controls.Add(this.splitter2);
            this.pCurrentResult.Controls.Add(this.pb2);
            this.pCurrentResult.Controls.Add(this.splitter1);
            this.pCurrentResult.Controls.Add(this.pb1);
            this.pCurrentResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.pCurrentResult.Location = new System.Drawing.Point(700, 24);
            this.pCurrentResult.Name = "pCurrentResult";
            this.pCurrentResult.Size = new System.Drawing.Size(244, 548);
            this.pCurrentResult.TabIndex = 11;
            this.pCurrentResult.Tag = "";
            // 
            // pbRollUp
            // 
            this.pbRollUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRollUp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbRollUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRollUp.Image = ((System.Drawing.Image)(resources.GetObject("pbRollUp.Image")));
            this.pbRollUp.Location = new System.Drawing.Point(230, 0);
            this.pbRollUp.Margin = new System.Windows.Forms.Padding(2);
            this.pbRollUp.Name = "pbRollUp";
            this.pbRollUp.Size = new System.Drawing.Size(15, 28);
            this.pbRollUp.TabIndex = 17;
            this.pbRollUp.TabStop = false;
            this.pbRollUp.Click += new System.EventHandler(this.pbRollUp_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 379);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(244, 169);
            this.propertyGrid1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbH);
            this.panel2.Controls.Add(this.lH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 352);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 27);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "мкм";
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(179, 5);
            this.tbH.Margin = new System.Windows.Forms.Padding(2);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(36, 20);
            this.tbH.TabIndex = 1;
            this.tbH.Text = "2";
            this.tbH.TextChanged += new System.EventHandler(this.tbH_TextChanged);
            // 
            // lH
            // 
            this.lH.AutoSize = true;
            this.lH.Location = new System.Drawing.Point(1, 7);
            this.lH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lH.Name = "lH";
            this.lH.Size = new System.Drawing.Size(164, 13);
            this.lH.TabIndex = 0;
            this.lH.Text = "Толщина поглощающего слоя:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbMicroPlag);
            this.panel1.Controls.Add(this.cbMethodScanirovaniy);
            this.panel1.Controls.Add(this.cbMethodSrednego);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 288);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 64);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Методы:";
            // 
            // cbMicroPlag
            // 
            this.cbMicroPlag.AutoSize = true;
            this.cbMicroPlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMicroPlag.Location = new System.Drawing.Point(54, 46);
            this.cbMicroPlag.Margin = new System.Windows.Forms.Padding(2);
            this.cbMicroPlag.Name = "cbMicroPlag";
            this.cbMicroPlag.Size = new System.Drawing.Size(81, 17);
            this.cbMicroPlag.TabIndex = 2;
            this.cbMicroPlag.Text = "микроплаг";
            this.cbMicroPlag.UseVisualStyleBackColor = true;
            this.cbMicroPlag.CheckedChanged += new System.EventHandler(this.cbMicroPlag_CheckedChanged);
            // 
            // cbMethodScanirovaniy
            // 
            this.cbMethodScanirovaniy.AutoSize = true;
            this.cbMethodScanirovaniy.Checked = true;
            this.cbMethodScanirovaniy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMethodScanirovaniy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMethodScanirovaniy.Location = new System.Drawing.Point(54, 24);
            this.cbMethodScanirovaniy.Margin = new System.Windows.Forms.Padding(2);
            this.cbMethodScanirovaniy.Name = "cbMethodScanirovaniy";
            this.cbMethodScanirovaniy.Size = new System.Drawing.Size(98, 17);
            this.cbMethodScanirovaniy.TabIndex = 1;
            this.cbMethodScanirovaniy.Text = "сканирования";
            this.cbMethodScanirovaniy.UseVisualStyleBackColor = true;
            this.cbMethodScanirovaniy.CheckedChanged += new System.EventHandler(this.cbMethodScanirovaniy_CheckedChanged);
            // 
            // cbMethodSrednego
            // 
            this.cbMethodSrednego.AutoSize = true;
            this.cbMethodSrednego.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMethodSrednego.Location = new System.Drawing.Point(54, 2);
            this.cbMethodSrednego.Margin = new System.Windows.Forms.Padding(2);
            this.cbMethodSrednego.Name = "cbMethodSrednego";
            this.cbMethodSrednego.Size = new System.Drawing.Size(177, 17);
            this.cbMethodSrednego.TabIndex = 0;
            this.cbMethodSrednego.Text = "сканирования с усреднением";
            this.cbMethodSrednego.UseVisualStyleBackColor = true;
            this.cbMethodSrednego.CheckedChanged += new System.EventHandler(this.cbMethodSrednego_CheckedChanged);
            // 
            // splitter5
            // 
            this.splitter5.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter5.Location = new System.Drawing.Point(0, 285);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(244, 3);
            this.splitter5.TabIndex = 8;
            this.splitter5.TabStop = false;
            // 
            // tbBlur
            // 
            this.tbBlur.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBlur.Enabled = false;
            this.tbBlur.Location = new System.Drawing.Point(0, 261);
            this.tbBlur.Maximum = 5;
            this.tbBlur.MaximumSize = new System.Drawing.Size(0, 24);
            this.tbBlur.Name = "tbBlur";
            this.tbBlur.Size = new System.Drawing.Size(244, 24);
            this.tbBlur.TabIndex = 7;
            this.tbBlur.ValueChanged += new System.EventHandler(this.tbBlur_ValueChanged);
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 258);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(244, 3);
            this.splitter3.TabIndex = 6;
            this.splitter3.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb3.Location = new System.Drawing.Point(0, 174);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(244, 84);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 5;
            this.pb3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 171);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(244, 3);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb2.Location = new System.Drawing.Point(0, 87);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(244, 84);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 3;
            this.pb2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 84);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(244, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb1.Location = new System.Drawing.Point(0, 0);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(244, 84);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // splitter6
            // 
            this.splitter6.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter6.Location = new System.Drawing.Point(697, 24);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(3, 548);
            this.splitter6.TabIndex = 13;
            this.splitter6.TabStop = false;
            // 
            // pAllResult
            // 
            this.pAllResult.Controls.Add(this.lbResultList);
            this.pAllResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pAllResult.Location = new System.Drawing.Point(0, 506);
            this.pAllResult.Margin = new System.Windows.Forms.Padding(2);
            this.pAllResult.Name = "pAllResult";
            this.pAllResult.Size = new System.Drawing.Size(697, 66);
            this.pAllResult.TabIndex = 15;
            // 
            // lbResultList
            // 
            this.lbResultList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResultList.FormattingEnabled = true;
            this.lbResultList.Location = new System.Drawing.Point(0, 0);
            this.lbResultList.Margin = new System.Windows.Forms.Padding(2);
            this.lbResultList.Name = "lbResultList";
            this.lbResultList.Size = new System.Drawing.Size(697, 66);
            this.lbResultList.TabIndex = 3;
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.SystemColors.HotTrack;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 572);
            this.Controls.Add(this.pAllResult);
            this.Controls.Add(this.splitter6);
            this.Controls.Add(this.pCurrentResult);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Главная форма";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.gbType.ResumeLayout(false);
            this.pCurrentResult.ResumeLayout(false);
            this.pCurrentResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRollUp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.pAllResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзображениеToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem панельТиповВыделенийToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьЭталонToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.Button bLasso;

        private System.Windows.Forms.Button bEllipse;
        private System.Windows.Forms.Button bRectangle;
        private System.Windows.Forms.ToolStripMenuItem панельТекущихОбработокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеРезультатыToolStripMenuItem;
        private System.Windows.Forms.Panel pCurrentResult;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.TrackBar tbBlur;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.Panel pAllResult;
        private System.Windows.Forms.ListBox lbResultList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbMethodSrednego;
        private System.Windows.Forms.ToolStripMenuItem выборСохраняемыхХарактеристикToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox cbMethodScanirovaniy;
        private System.Windows.Forms.ToolStripMenuItem cnfnbcnbrfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текущегоОбъектаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbMicroPlag;
        private System.Windows.Forms.ToolStripMenuItem набораОбластейToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.Label lH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbRollUp;
        private System.Windows.Forms.Button bRing;
        private System.Windows.Forms.ToolStripMenuItem каталогToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}