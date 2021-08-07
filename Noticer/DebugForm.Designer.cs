namespace Noticer
{
    partial class DebugForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.debugChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pbOpacity = new System.Windows.Forms.ProgressBar();
            this.cbEnable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.debugChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(12, 9);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(19, 13);
            this.lblOpacity.TabIndex = 1;
            this.lblOpacity.Text = "00";
            // 
            // debugChart
            // 
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisX.MajorTickMark.LineWidth = 0;
            chartArea2.AxisX.ScrollBar.Enabled = false;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.LineWidth = 0;
            chartArea2.AxisY.MajorGrid.LineWidth = 0;
            chartArea2.AxisY.MajorTickMark.LineWidth = 0;
            chartArea2.AxisY.ScrollBar.Enabled = false;
            chartArea2.BorderWidth = 0;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 98F;
            chartArea2.InnerPlotPosition.Width = 98F;
            chartArea2.InnerPlotPosition.X = 2F;
            chartArea2.InnerPlotPosition.Y = 2F;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 98F;
            chartArea2.Position.Width = 98F;
            chartArea2.Position.X = 2F;
            chartArea2.Position.Y = 2F;
            this.debugChart.ChartAreas.Add(chartArea2);
            this.debugChart.Location = new System.Drawing.Point(15, 67);
            this.debugChart.Name = "debugChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            this.debugChart.Series.Add(series2);
            this.debugChart.Size = new System.Drawing.Size(273, 105);
            this.debugChart.TabIndex = 2;
            // 
            // pbOpacity
            // 
            this.pbOpacity.Location = new System.Drawing.Point(15, 36);
            this.pbOpacity.Name = "pbOpacity";
            this.pbOpacity.Size = new System.Drawing.Size(273, 23);
            this.pbOpacity.TabIndex = 3;
            // 
            // cbEnable
            // 
            this.cbEnable.AutoSize = true;
            this.cbEnable.Location = new System.Drawing.Point(208, 8);
            this.cbEnable.Name = "cbEnable";
            this.cbEnable.Size = new System.Drawing.Size(65, 17);
            this.cbEnable.TabIndex = 4;
            this.cbEnable.Text = "Enabled";
            this.cbEnable.UseVisualStyleBackColor = true;
            this.cbEnable.CheckedChanged += new System.EventHandler(this.cbEnable_CheckedChanged);
            // 
            // DebugForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 184);
            this.Controls.Add(this.cbEnable);
            this.Controls.Add(this.pbOpacity);
            this.Controls.Add(this.debugChart);
            this.Controls.Add(this.lblOpacity);
            this.MaximizeBox = false;
            this.Name = "DebugForm";
            this.ShowIcon = false;
            this.Text = "Debug window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.debugChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.DataVisualization.Charting.Chart debugChart;
        private System.Windows.Forms.ProgressBar pbOpacity;
        private System.Windows.Forms.CheckBox cbEnable;
    }
}

