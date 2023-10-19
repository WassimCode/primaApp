namespace AutoInterattivaForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //properties
        testApp2.AutoInterattiva auto = new testApp2.AutoInterattiva("Ferrari", "LaFerrari", "Rossa", testApp2.Auto.motori.diesel, 20, 20);



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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Car Commands Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 57);
            label2.Name = "label2";
            label2.Size = new Size(291, 20);
            label2.TabIndex = 1;
            label2.Text = "Aggiungi q.tà di carburante personalizzata";
            // 
            // button1
            // 
            button1.Location = new Point(47, 80);
            button1.Name = "button1";
            button1.Size = new Size(291, 58);
            button1.TabIndex = 2;
            button1.Text = "Apri finestra Carburante";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(47, 177);
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
            button3.Location = new Point(296, 388);
            button3.Name = "button3";
            button3.Size = new Size(112, 50);
            button3.TabIndex = 5;
            button3.Text = "Turn on";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(414, 388);
            button4.Name = "button4";
            button4.Size = new Size(112, 50);
            button4.TabIndex = 6;
            button4.Text = "Turn Off";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.andrew_tate;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Button button3;
        private Button button4;
    }
}