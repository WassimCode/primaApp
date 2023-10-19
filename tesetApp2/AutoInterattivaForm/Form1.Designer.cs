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
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(47, 57);
            button1.Name = "button1";
            button1.Size = new Size(291, 58);
            button1.TabIndex = 2;
            button1.Text = "Aggiungi quantità di carburante personalizzata";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(47, 135);
            button2.Name = "button2";
            button2.Size = new Size(291, 58);
            button2.TabIndex = 4;
            button2.Text = "Rifornisci";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 154);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 3;
            label3.Text = "Rifornisci del 10%";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Location = new Point(296, 388);
            button3.Name = "button3";
            button3.Size = new Size(112, 50);
            button3.TabIndex = 5;
            button3.Text = "Turn on";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 192);
            button4.Location = new Point(414, 388);
            button4.Name = "button4";
            button4.Size = new Size(112, 50);
            button4.TabIndex = 6;
            button4.Text = "Turn Off";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Location = new Point(471, 57);
            button5.Name = "button5";
            button5.Size = new Size(291, 58);
            button5.TabIndex = 7;
            button5.Text = "Speed Up";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(471, 135);
            button6.Name = "button6";
            button6.Size = new Size(291, 58);
            button6.TabIndex = 8;
            button6.Text = "Slow Down";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 255, 192);
            button7.Location = new Point(47, 212);
            button7.Name = "button7";
            button7.Size = new Size(291, 59);
            button7.TabIndex = 9;
            button7.Text = "Show Speed";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 255, 192);
            button8.Location = new Point(471, 212);
            button8.Name = "button8";
            button8.Size = new Size(291, 59);
            button8.TabIndex = 10;
            button8.Text = "Show State";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 255, 192);
            button9.Location = new Point(296, 315);
            button9.Name = "button9";
            button9.Size = new Size(230, 55);
            button9.TabIndex = 11;
            button9.Text = "Show Details";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.andrew_tate;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            MinimumSize = new Size(818, 497);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Commands Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label3;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}