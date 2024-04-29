namespace MDK01._04.Kursach
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
            btnNewGame = new Button();
            label1 = new Label();
            nudLimit = new NumericUpDown();
            btnStart = new Button();
            lblTask = new Label();
            nudNumber = new NumericUpDown();
            btnCheck = new Button();
            lblInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)nudLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumber).BeginInit();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Segoe UI", 16F);
            btnNewGame.Location = new Point(12, 12);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(776, 64);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "Начать новую игру";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(315, 53);
            label1.TabIndex = 1;
            label1.Text = "Диапазон чисел от 1 до ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudLimit
            // 
            nudLimit.Enabled = false;
            nudLimit.Font = new Font("Segoe UI", 16F);
            nudLimit.Location = new Point(333, 85);
            nudLimit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudLimit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudLimit.Name = "nudLimit";
            nudLimit.Size = new Size(455, 43);
            nudLimit.TabIndex = 2;
            nudLimit.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 16F);
            btnStart.Location = new Point(12, 135);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(776, 64);
            btnStart.TabIndex = 0;
            btnStart.Text = "Поехали!";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblTask
            // 
            lblTask.Font = new Font("Segoe UI", 16F);
            lblTask.Location = new Point(12, 202);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(776, 53);
            lblTask.TabIndex = 1;
            lblTask.Text = "Я загадал число от 1 до 100. Попробуй угадать:";
            lblTask.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudNumber
            // 
            nudNumber.Font = new Font("Segoe UI", 16F);
            nudNumber.Location = new Point(12, 270);
            nudNumber.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumber.Name = "nudNumber";
            nudNumber.Size = new Size(315, 43);
            nudNumber.TabIndex = 2;
            nudNumber.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 16F);
            btnCheck.Location = new Point(333, 258);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(455, 64);
            btnCheck.TabIndex = 0;
            btnCheck.Text = "Проверить";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI", 16F);
            lblInfo.Location = new Point(12, 325);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(776, 53);
            lblInfo.TabIndex = 1;
            lblInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudNumber);
            Controls.Add(nudLimit);
            Controls.Add(lblInfo);
            Controls.Add(lblTask);
            Controls.Add(label1);
            Controls.Add(btnCheck);
            Controls.Add(btnStart);
            Controls.Add(btnNewGame);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Угадай число";
            ((System.ComponentModel.ISupportInitialize)nudLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewGame;
        private Label label1;
        private NumericUpDown nudLimit;
        private Button btnStart;
        private Label lblTask;
        private NumericUpDown nudNumber;
        private Button btnCheck;
        private Label lblInfo;
    }
}
