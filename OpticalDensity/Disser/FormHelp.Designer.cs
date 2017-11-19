namespace Disser
{
    partial class FormHelp
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
            this.tvContent = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gbSelectPunct = new System.Windows.Forms.GroupBox();
            this.wbText = new System.Windows.Forms.WebBrowser();
            this.gbSelectPunct.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvContent
            // 
            this.tvContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvContent.Location = new System.Drawing.Point(0, 0);
            this.tvContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvContent.Name = "tvContent";
            this.tvContent.Size = new System.Drawing.Size(153, 412);
            this.tvContent.TabIndex = 0;
            this.tvContent.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvContent_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(153, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 412);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // gbSelectPunct
            // 
            this.gbSelectPunct.Controls.Add(this.wbText);
            this.gbSelectPunct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSelectPunct.Location = new System.Drawing.Point(155, 0);
            this.gbSelectPunct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSelectPunct.Name = "gbSelectPunct";
            this.gbSelectPunct.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSelectPunct.Size = new System.Drawing.Size(479, 412);
            this.gbSelectPunct.TabIndex = 2;
            this.gbSelectPunct.TabStop = false;
            this.gbSelectPunct.Text = " ";
            // 
            // wbText
            // 
            this.wbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbText.Location = new System.Drawing.Point(2, 15);
            this.wbText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wbText.MinimumSize = new System.Drawing.Size(15, 16);
            this.wbText.Name = "wbText";
            this.wbText.Size = new System.Drawing.Size(475, 395);
            this.wbText.TabIndex = 0;
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.gbSelectPunct);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tvContent);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHelp";
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.FormHelp_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormHelp_Paint);
            this.gbSelectPunct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvContent;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox gbSelectPunct;
        private System.Windows.Forms.WebBrowser wbText;
    }
}