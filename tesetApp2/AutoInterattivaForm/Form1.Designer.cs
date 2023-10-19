namespace AutoInterattivaForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //properties



        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button9 = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(37, 57);
            button2.Name = "button2";
            button2.Size = new Size(291, 58);
            button2.TabIndex = 4;
            button2.Text = "Rifornisci";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Location = new Point(37, 388);
            button3.Name = "button3";
            button3.Size = new Size(112, 50);
            button3.TabIndex = 5;
            button3.Text = "Turn on";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 192);
            button4.Location = new Point(216, 388);
            button4.Name = "button4";
            button4.Size = new Size(112, 50);
            button4.TabIndex = 6;
            button4.Text = "Turn Off";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(37, 135);
            button5.Name = "button5";
            button5.Size = new Size(291, 58);
            button5.TabIndex = 7;
            button5.Text = "Speed Up";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(37, 218);
            button6.Name = "button6";
            button6.Size = new Size(291, 58);
            button6.TabIndex = 8;
            button6.Text = "Slow Down";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 255, 192);
            button9.Location = new Point(37, 301);
            button9.Name = "button9";
            button9.Size = new Size(291, 55);
            button9.TabIndex = 11;
            button9.Text = "Show Details";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.FromArgb(192, 255, 192);
            progressBar1.Location = new Point(505, 409);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(283, 29);
            progressBar1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria Math", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 255, 192);
            label1.Location = new Point(711, 330);
            label1.Name = "label1";
            label1.Size = new Size(101, 129);
            label1.TabIndex = 13;
            label1.Text = "Fuel";
            // 
            // radialGauge1
            // 
            radialGauge1.ArcThickness = 2F;
            radialGauge1.BackgroundGradientEndColor = Color.FromArgb(178, 178, 178);
            radialGauge1.BackgroundGradientStartColor = Color.FromArgb(178, 178, 178);
            radialGauge1.EnableCustomNeedles = false;
            radialGauge1.FillColor = Color.FromArgb(1, 115, 199);
            radialGauge1.ForeColor = Color.White;
            radialGauge1.FrameThickness = 12;
            radialGauge1.GaugeArcColor = Color.FromArgb(38, 38, 38);
            radialGauge1.GaugeLabel = "Km/h";
            radialGauge1.GaugeLableColor = Color.FromArgb(0, 0, 0);
            radialGauge1.GaugeLableFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            radialGauge1.GaugeValueColor = Color.FromArgb(0, 0, 0);
            radialGauge1.GaugeValueFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            radialGauge1.InnerFrameGradientEndColor = Color.FromArgb(178, 178, 178);
            radialGauge1.InnerFrameGradientStartColor = Color.FromArgb(178, 178, 178);
            radialGauge1.InterLinesColor = Color.FromArgb(61, 61, 61);
            radialGauge1.Location = new Point(515, 110);
            radialGauge1.MajorDifference = 50F;
            radialGauge1.MajorTickMarkColor = Color.FromArgb(61, 61, 61);
            radialGauge1.MaximumValue = 500F;
            radialGauge1.MinimumSize = new Size(125, 125);
            radialGauge1.MinorTickMarkColor = Color.FromArgb(106, 106, 106);
            radialGauge1.Name = "radialGauge1";
            radialGauge1.NeedleColor = Color.FromArgb(1, 115, 199);
            radialGauge1.NeedleStyle = Syncfusion.Windows.Forms.Gauge.NeedleStyle.Advanced;
            radialGauge1.OuterFrameGradientEndColor = Color.FromArgb(106, 106, 106);
            radialGauge1.OuterFrameGradientStartColor = Color.FromArgb(106, 106, 106);
            radialGauge1.ScaleLabelColor = Color.FromArgb(0, 0, 0);
            radialGauge1.ShowTicks = true;
            radialGauge1.Size = new Size(257, 257);
            radialGauge1.TabIndex = 14;
            radialGauge1.TextOrientation = Syncfusion.Windows.Forms.Gauge.TextOrientation.SlideOver;
            radialGauge1.ThemeName = "Office2016DarkGray";
            radialGauge1.ThemeStyle.ArcThickness = 20F;
            radialGauge1.TickPlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            radialGauge1.Value = 20F;
            radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016DarkGray;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.andrew_tate;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(radialGauge1);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            MinimumSize = new Size(818, 497);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Commands Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button9;
        private ProgressBar progressBar1;
        private Label label1;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private System.Windows.Forms.Timer timer1;
    }
}