namespace Digital_Clock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            timeDisplayLabel = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            redButton = new Button();
            greenButton = new Button();
            purpleButton = new Button();
            yellowButton = new Button();
            whiteButton = new Button();
            style1 = new Button();
            style3 = new Button();
            style2 = new Button();
            cyanButton = new Button();
            dateDisplayLabel = new Label();
            style4 = new Button();
            silverButton = new Button();
            blueButton = new Button();
            SuspendLayout();
            // 
            // timeDisplayLabel
            // 
            timeDisplayLabel.Font = new Font("Segoe UI Semibold", 70F, FontStyle.Bold, GraphicsUnit.Point);
            timeDisplayLabel.ForeColor = Color.Red;
            timeDisplayLabel.Location = new Point(-4, 0);
            timeDisplayLabel.Name = "timeDisplayLabel";
            timeDisplayLabel.Size = new Size(951, 325);
            timeDisplayLabel.TabIndex = 0;
            timeDisplayLabel.Text = "Loading...";
            timeDisplayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // redButton
            // 
            redButton.BackColor = Color.Red;
            redButton.Location = new Point(12, 437);
            redButton.Name = "redButton";
            redButton.Size = new Size(44, 44);
            redButton.TabIndex = 1;
            redButton.UseVisualStyleBackColor = false;
            redButton.Click += redButton_Click;
            // 
            // greenButton
            // 
            greenButton.BackColor = Color.Lime;
            greenButton.Location = new Point(62, 437);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(44, 44);
            greenButton.TabIndex = 2;
            greenButton.UseVisualStyleBackColor = false;
            greenButton.Click += greenButton_Click;
            // 
            // purpleButton
            // 
            purpleButton.BackColor = Color.Fuchsia;
            purpleButton.Location = new Point(112, 437);
            purpleButton.Name = "purpleButton";
            purpleButton.Size = new Size(44, 44);
            purpleButton.TabIndex = 3;
            purpleButton.UseVisualStyleBackColor = false;
            purpleButton.Click += purpleButton_Click;
            // 
            // yellowButton
            // 
            yellowButton.BackColor = Color.Yellow;
            yellowButton.Location = new Point(162, 437);
            yellowButton.Name = "yellowButton";
            yellowButton.Size = new Size(44, 44);
            yellowButton.TabIndex = 4;
            yellowButton.UseVisualStyleBackColor = false;
            yellowButton.Click += yellowButton_Click;
            // 
            // whiteButton
            // 
            whiteButton.BackColor = Color.White;
            whiteButton.Location = new Point(362, 437);
            whiteButton.Name = "whiteButton";
            whiteButton.Size = new Size(44, 44);
            whiteButton.TabIndex = 5;
            whiteButton.UseVisualStyleBackColor = false;
            whiteButton.Click += whiteButton_Click;
            // 
            // style1
            // 
            style1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            style1.Location = new Point(473, 443);
            style1.Name = "style1";
            style1.Size = new Size(112, 39);
            style1.TabIndex = 6;
            style1.Text = "Style 1";
            style1.UseVisualStyleBackColor = true;
            style1.Click += style1_Click;
            // 
            // style3
            // 
            style3.Font = new Font("Cascadia Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            style3.Location = new Point(709, 443);
            style3.Name = "style3";
            style3.Size = new Size(112, 39);
            style3.TabIndex = 7;
            style3.Text = "Style 3";
            style3.UseVisualStyleBackColor = true;
            style3.Click += style3_Click;
            // 
            // style2
            // 
            style2.Font = new Font("Kristen ITC", 11F, FontStyle.Regular, GraphicsUnit.Point);
            style2.Location = new Point(591, 443);
            style2.Name = "style2";
            style2.Size = new Size(112, 39);
            style2.TabIndex = 8;
            style2.Text = "Style 2";
            style2.UseVisualStyleBackColor = true;
            style2.Click += style2_Click;
            // 
            // cyanButton
            // 
            cyanButton.BackColor = Color.Cyan;
            cyanButton.Location = new Point(212, 437);
            cyanButton.Name = "cyanButton";
            cyanButton.Size = new Size(44, 44);
            cyanButton.TabIndex = 9;
            cyanButton.UseVisualStyleBackColor = false;
            cyanButton.Click += cyanButton_Click;
            // 
            // dateDisplayLabel
            // 
            dateDisplayLabel.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            dateDisplayLabel.ForeColor = Color.Red;
            dateDisplayLabel.Location = new Point(94, 264);
            dateDisplayLabel.Name = "dateDisplayLabel";
            dateDisplayLabel.Size = new Size(747, 111);
            dateDisplayLabel.TabIndex = 10;
            dateDisplayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // style4
            // 
            style4.Font = new Font("Ink Free", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            style4.Location = new Point(827, 443);
            style4.Name = "style4";
            style4.Size = new Size(112, 39);
            style4.TabIndex = 11;
            style4.Text = "Style 4";
            style4.UseVisualStyleBackColor = true;
            style4.Click += style4_Click;
            // 
            // silverButton
            // 
            silverButton.BackColor = Color.Silver;
            silverButton.Location = new Point(262, 437);
            silverButton.Name = "silverButton";
            silverButton.Size = new Size(44, 44);
            silverButton.TabIndex = 12;
            silverButton.UseVisualStyleBackColor = false;
            silverButton.Click += silverButton_Click;
            // 
            // blueButton
            // 
            blueButton.BackColor = Color.Blue;
            blueButton.Location = new Point(312, 437);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(44, 44);
            blueButton.TabIndex = 13;
            blueButton.UseVisualStyleBackColor = false;
            blueButton.Click += blueButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(945, 486);
            Controls.Add(blueButton);
            Controls.Add(silverButton);
            Controls.Add(style4);
            Controls.Add(dateDisplayLabel);
            Controls.Add(cyanButton);
            Controls.Add(style2);
            Controls.Add(style3);
            Controls.Add(style1);
            Controls.Add(whiteButton);
            Controls.Add(yellowButton);
            Controls.Add(purpleButton);
            Controls.Add(greenButton);
            Controls.Add(redButton);
            Controls.Add(timeDisplayLabel);
            Cursor = Cursors.SizeAll;
            MaximumSize = new Size(967, 542);
            MinimumSize = new Size(967, 542);
            Name = "Form1";
            Text = "Digital Clock";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label timeDisplayLabel;
        private System.Windows.Forms.Timer Timer;
        private Button redButton;
        private Button greenButton;
        private Button purpleButton;
        private Button yellowButton;
        private Button whiteButton;
        private Button style1;
        private Button style3;
        private Button style2;
        private Button cyanButton;
        private Label dateDisplayLabel;
        private Button style4;
        private Button silverButton;
        private Button blueButton;
    }
}