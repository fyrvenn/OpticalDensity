namespace Disser
{
    partial class FormKit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKit));
            this.cbOD = new System.Windows.Forms.CheckBox();
            this.cbODmin = new System.Windows.Forms.CheckBox();
            this.cbODmax = new System.Windows.Forms.CheckBox();
            this.cbLEtalon = new System.Windows.Forms.CheckBox();
            this.cbLImg = new System.Windows.Forms.CheckBox();
            this.cbPoint = new System.Windows.Forms.CheckBox();
            this.bChancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.cbKpropusk = new System.Windows.Forms.CheckBox();
            this.cbKabsorption = new System.Windows.Forms.CheckBox();
            this.cbPabsorption = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbPerimeter = new System.Windows.Forms.CheckBox();
            this.cbSquare = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbOD
            // 
            this.cbOD.AutoSize = true;
            this.cbOD.Location = new System.Drawing.Point(215, 10);
            this.cbOD.Margin = new System.Windows.Forms.Padding(2);
            this.cbOD.Name = "cbOD";
            this.cbOD.Size = new System.Drawing.Size(166, 17);
            this.cbOD.TabIndex = 0;
            this.cbOD.Text = "OD (Оптическая плотность)";
            this.cbOD.UseVisualStyleBackColor = true;
            // 
            // cbODmin
            // 
            this.cbODmin.AutoSize = true;
            this.cbODmin.Location = new System.Drawing.Point(215, 28);
            this.cbODmin.Margin = new System.Windows.Forms.Padding(2);
            this.cbODmin.Name = "cbODmin";
            this.cbODmin.Size = new System.Drawing.Size(256, 17);
            this.cbODmin.TabIndex = 2;
            this.cbODmin.Text = "OD min (минимальная оптическая плотность)";
            this.cbODmin.UseVisualStyleBackColor = true;
            // 
            // cbODmax
            // 
            this.cbODmax.AutoSize = true;
            this.cbODmax.Location = new System.Drawing.Point(215, 46);
            this.cbODmax.Margin = new System.Windows.Forms.Padding(2);
            this.cbODmax.Name = "cbODmax";
            this.cbODmax.Size = new System.Drawing.Size(265, 17);
            this.cbODmax.TabIndex = 3;
            this.cbODmax.Text = "OD max (максимальная оптическая плотность)";
            this.cbODmax.UseVisualStyleBackColor = true;
            // 
            // cbLEtalon
            // 
            this.cbLEtalon.AutoSize = true;
            this.cbLEtalon.Location = new System.Drawing.Point(215, 10);
            this.cbLEtalon.Margin = new System.Windows.Forms.Padding(2);
            this.cbLEtalon.Name = "cbLEtalon";
            this.cbLEtalon.Size = new System.Drawing.Size(77, 17);
            this.cbLEtalon.TabIndex = 4;
            this.cbLEtalon.Text = "L Эталона";
            this.cbLEtalon.UseVisualStyleBackColor = true;
            // 
            // cbLImg
            // 
            this.cbLImg.AutoSize = true;
            this.cbLImg.Location = new System.Drawing.Point(215, 28);
            this.cbLImg.Margin = new System.Windows.Forms.Padding(2);
            this.cbLImg.Name = "cbLImg";
            this.cbLImg.Size = new System.Drawing.Size(105, 17);
            this.cbLImg.TabIndex = 5;
            this.cbLImg.Text = "L Изображения";
            this.cbLImg.UseVisualStyleBackColor = true;
            // 
            // cbPoint
            // 
            this.cbPoint.AutoSize = true;
            this.cbPoint.Location = new System.Drawing.Point(215, 10);
            this.cbPoint.Margin = new System.Windows.Forms.Padding(2);
            this.cbPoint.Name = "cbPoint";
            this.cbPoint.Size = new System.Drawing.Size(88, 17);
            this.cbPoint.TabIndex = 6;
            this.cbPoint.Text = "Координаты";
            this.cbPoint.UseVisualStyleBackColor = true;
            // 
            // bChancel
            // 
            this.bChancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bChancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bChancel.Image = ((System.Drawing.Image)(resources.GetObject("bChancel.Image")));
            this.bChancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bChancel.Location = new System.Drawing.Point(401, 330);
            this.bChancel.Margin = new System.Windows.Forms.Padding(2);
            this.bChancel.Name = "bChancel";
            this.bChancel.Size = new System.Drawing.Size(75, 20);
            this.bChancel.TabIndex = 8;
            this.bChancel.Text = "Отмена";
            this.bChancel.UseVisualStyleBackColor = true;
            this.bChancel.Click += new System.EventHandler(this.bChancel_Click);
            // 
            // bOk
            // 
            this.bOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Image = ((System.Drawing.Image)(resources.GetObject("bOk.Image")));
            this.bOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bOk.Location = new System.Drawing.Point(305, 330);
            this.bOk.Margin = new System.Windows.Forms.Padding(2);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 20);
            this.bOk.TabIndex = 7;
            this.bOk.Text = "Ок";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // cbKpropusk
            // 
            this.cbKpropusk.AutoSize = true;
            this.cbKpropusk.Location = new System.Drawing.Point(215, 10);
            this.cbKpropusk.Margin = new System.Windows.Forms.Padding(2);
            this.cbKpropusk.Name = "cbKpropusk";
            this.cbKpropusk.Size = new System.Drawing.Size(230, 17);
            this.cbKpropusk.TabIndex = 17;
            this.cbKpropusk.Text = "Коэффициент внутреннего пропускания";
            this.cbKpropusk.UseVisualStyleBackColor = true;
            // 
            // cbKabsorption
            // 
            this.cbKabsorption.AutoSize = true;
            this.cbKabsorption.Location = new System.Drawing.Point(215, 28);
            this.cbKabsorption.Margin = new System.Windows.Forms.Padding(2);
            this.cbKabsorption.Name = "cbKabsorption";
            this.cbKabsorption.Size = new System.Drawing.Size(161, 17);
            this.cbKabsorption.TabIndex = 18;
            this.cbKabsorption.Text = "Коэффициент поглощения";
            this.cbKabsorption.UseVisualStyleBackColor = true;
            // 
            // cbPabsorption
            // 
            this.cbPabsorption.AutoSize = true;
            this.cbPabsorption.Location = new System.Drawing.Point(215, 10);
            this.cbPabsorption.Margin = new System.Windows.Forms.Padding(2);
            this.cbPabsorption.Name = "cbPabsorption";
            this.cbPabsorption.Size = new System.Drawing.Size(152, 17);
            this.cbPabsorption.TabIndex = 19;
            this.cbPabsorption.Text = "Показатель поглощения";
            this.cbPabsorption.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPoint);
            this.groupBox1.Location = new System.Drawing.Point(4, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(483, 35);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Общие";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbLEtalon);
            this.groupBox2.Controls.Add(this.cbLImg);
            this.groupBox2.Location = new System.Drawing.Point(4, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(483, 48);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Световой поток";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbOD);
            this.groupBox3.Controls.Add(this.cbODmin);
            this.groupBox3.Controls.Add(this.cbODmax);
            this.groupBox3.Location = new System.Drawing.Point(5, 144);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(483, 70);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "4. Значения оптической плотности";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbKpropusk);
            this.groupBox4.Controls.Add(this.cbKabsorption);
            this.groupBox4.Location = new System.Drawing.Point(4, 95);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(483, 48);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "3. Оценка величин светового потока";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbPabsorption);
            this.groupBox6.Location = new System.Drawing.Point(5, 215);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(483, 35);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "5. Характеристика поглощающего слоя";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbSquare);
            this.groupBox5.Controls.Add(this.cbPerimeter);
            this.groupBox5.Location = new System.Drawing.Point(5, 254);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(483, 57);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "6.Измерение (в пикселях)";
            // 
            // cbPerimeter
            // 
            this.cbPerimeter.AutoSize = true;
            this.cbPerimeter.Location = new System.Drawing.Point(215, 10);
            this.cbPerimeter.Margin = new System.Windows.Forms.Padding(2);
            this.cbPerimeter.Name = "cbPerimeter";
            this.cbPerimeter.Size = new System.Drawing.Size(77, 17);
            this.cbPerimeter.TabIndex = 19;
            this.cbPerimeter.Text = "Периметр";
            this.cbPerimeter.UseVisualStyleBackColor = true;
            // 
            // cbSquare
            // 
            this.cbSquare.AutoSize = true;
            this.cbSquare.Location = new System.Drawing.Point(214, 33);
            this.cbSquare.Margin = new System.Windows.Forms.Padding(2);
            this.cbSquare.Name = "cbSquare";
            this.cbSquare.Size = new System.Drawing.Size(73, 17);
            this.cbSquare.TabIndex = 20;
            this.cbSquare.Text = "Площадь";
            this.cbSquare.UseVisualStyleBackColor = true;
            // 
            // FormKit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 375);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bChancel);
            this.Controls.Add(this.bOk);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(507, 377);
            this.Name = "FormKit";
            this.Text = "Сохраняемые характеристики";
            this.Load += new System.EventHandler(this.FormKit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbOD;
        private System.Windows.Forms.CheckBox cbODmin;
        private System.Windows.Forms.CheckBox cbODmax;
        private System.Windows.Forms.CheckBox cbLEtalon;
        private System.Windows.Forms.CheckBox cbLImg;
        private System.Windows.Forms.CheckBox cbPoint;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bChancel;
        private System.Windows.Forms.CheckBox cbKpropusk;
        private System.Windows.Forms.CheckBox cbKabsorption;
        private System.Windows.Forms.CheckBox cbPabsorption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbPerimeter;
        private System.Windows.Forms.CheckBox cbSquare;
    }
}