namespace Disser
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.qw = new System.Windows.Forms.Label();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.tbS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCountIntervals = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выборочное среднее";
            // 
            // qw
            // 
            this.qw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qw.AutoSize = true;
            this.qw.Location = new System.Drawing.Point(119, 107);
            this.qw.Name = "qw";
            this.qw.Size = new System.Drawing.Size(204, 17);
            this.qw.TabIndex = 1;
            this.qw.Text = "Средний квадрат отклонения";
            // 
            // tbM
            // 
            this.tbM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbM.Enabled = false;
            this.tbM.Location = new System.Drawing.Point(13, 80);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(100, 22);
            this.tbM.TabIndex = 3;
            // 
            // tbD
            // 
            this.tbD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbD.Enabled = false;
            this.tbD.Location = new System.Drawing.Point(13, 104);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(100, 22);
            this.tbD.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.tbS);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.tbMax);
            this.splitContainer1.Panel2.Controls.Add(this.tbMin);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.tbCountIntervals);
            this.splitContainer1.Panel2.Controls.Add(this.tbD);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.qw);
            this.splitContainer1.Panel2.Controls.Add(this.tbM);
            this.splitContainer1.Size = new System.Drawing.Size(882, 378);
            this.splitContainer1.SplitterDistance = 550;
            this.splitContainer1.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.Title = "Оптическая плотность";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.Title = "Количество";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Серия";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(550, 378);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Среднее отклонение";
            this.label5.Visible = false;
            // 
            // tbS
            // 
            this.tbS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbS.Enabled = false;
            this.tbS.Location = new System.Drawing.Point(13, 130);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(100, 22);
            this.tbS.TabIndex = 13;
            this.tbS.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Максимальная опт. плотн.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Минимальная опт. плотн.";
            // 
            // tbMax
            // 
            this.tbMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMax.Enabled = false;
            this.tbMax.Location = new System.Drawing.Point(13, 199);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 22);
            this.tbMax.TabIndex = 9;
            // 
            // tbMin
            // 
            this.tbMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMin.Enabled = false;
            this.tbMin.Location = new System.Drawing.Point(13, 171);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 22);
            this.tbMin.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Число интервалов";
            // 
            // tbCountIntervals
            // 
            this.tbCountIntervals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCountIntervals.Location = new System.Drawing.Point(13, 12);
            this.tbCountIntervals.Name = "tbCountIntervals";
            this.tbCountIntervals.Size = new System.Drawing.Size(100, 22);
            this.tbCountIntervals.TabIndex = 6;
            this.tbCountIntervals.TextChanged += new System.EventHandler(this.tbCountIntervals_TextChanged);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 378);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormStatistics";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.FormStatisticsCurrent_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label qw;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCountIntervals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.Label label5;
    }
}