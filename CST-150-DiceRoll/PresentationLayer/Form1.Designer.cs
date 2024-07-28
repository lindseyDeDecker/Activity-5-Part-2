namespace CST_150_DiceRoll
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
            btnDiceRoll = new Button();
            picDiceOne = new PictureBox();
            picDiceTwo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picDiceOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDiceTwo).BeginInit();
            SuspendLayout();
            // 
            // btnDiceRoll
            // 
            btnDiceRoll.AutoSize = true;
            btnDiceRoll.BackColor = Color.FromArgb(128, 128, 255);
            btnDiceRoll.Font = new Font("Papyrus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiceRoll.Location = new Point(327, 57);
            btnDiceRoll.Name = "btnDiceRoll";
            btnDiceRoll.Size = new Size(127, 59);
            btnDiceRoll.TabIndex = 0;
            btnDiceRoll.Text = "Roll Dice";
            btnDiceRoll.UseVisualStyleBackColor = false;
            btnDiceRoll.Click += btnDiceRoll_Click;
            // 
            // picDiceOne
            // 
            picDiceOne.Location = new Point(205, 170);
            picDiceOne.Name = "picDiceOne";
            picDiceOne.Size = new Size(152, 122);
            picDiceOne.TabIndex = 1;
            picDiceOne.TabStop = false;
            // 
            // picDiceTwo
            // 
            picDiceTwo.Location = new Point(427, 170);
            picDiceTwo.Name = "picDiceTwo";
            picDiceTwo.Size = new Size(152, 122);
            picDiceTwo.TabIndex = 2;
            picDiceTwo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picDiceTwo);
            Controls.Add(picDiceOne);
            Controls.Add(btnDiceRoll);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picDiceOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDiceTwo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDiceRoll;
        private PictureBox picDiceOne;
        private PictureBox picDiceTwo;
    }
}
