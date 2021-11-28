namespace ConsoleApp1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtWykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtWykres)).BeginInit();
            this.SuspendLayout();
            // 
            // chtWykres
            // 
            chartArea2.Name = "ChartArea1";
            this.chtWykres.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtWykres.Legends.Add(legend2);
            this.chtWykres.Location = new System.Drawing.Point(12, 12);
            this.chtWykres.Name = "chtWykres";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtWykres.Series.Add(series2);
            this.chtWykres.Size = new System.Drawing.Size(1302, 743);
            this.chtWykres.TabIndex = 0;
            this.chtWykres.Text = "chart1";
            this.chtWykres.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(444, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(493, 163);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wykres zmian ceny kolejnych lat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 767);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chtWykres);
            this.Name = "Form1";
            this.Text = "Cena w kolejne lata";
            ((System.ComponentModel.ISupportInitialize)(this.chtWykres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chtWykres;
        private System.Windows.Forms.Button button1;
    }
}