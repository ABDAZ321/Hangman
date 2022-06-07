
namespace HangMan
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
            this.InputLetterBox = new System.Windows.Forms.TextBox();
            this.MainWordContainer = new System.Windows.Forms.TextBox();
            this.generateWord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputLetterBox
            // 
            this.InputLetterBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputLetterBox.Location = new System.Drawing.Point(12, 12);
            this.InputLetterBox.MaxLength = 1;
            this.InputLetterBox.Name = "InputLetterBox";
            this.InputLetterBox.Size = new System.Drawing.Size(100, 43);
            this.InputLetterBox.TabIndex = 0;
            this.InputLetterBox.TextChanged += new System.EventHandler(this.InputLetterBox_TextChanged);
            // 
            // MainWordContainer
            // 
            this.MainWordContainer.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainWordContainer.Location = new System.Drawing.Point(12, 352);
            this.MainWordContainer.Name = "MainWordContainer";
            this.MainWordContainer.Size = new System.Drawing.Size(776, 61);
            this.MainWordContainer.TabIndex = 1;
            // 
            // generateWord
            // 
            this.generateWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateWord.Location = new System.Drawing.Point(12, 252);
            this.generateWord.Name = "generateWord";
            this.generateWord.Size = new System.Drawing.Size(125, 60);
            this.generateWord.TabIndex = 2;
            this.generateWord.Text = "Generate Word";
            this.generateWord.UseVisualStyleBackColor = true;
            this.generateWord.Click += new System.EventHandler(this.GenerateWord);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(127, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enter Letter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Enter_letter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generateWord);
            this.Controls.Add(this.MainWordContainer);
            this.Controls.Add(this.InputLetterBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputLetterBox;
        private System.Windows.Forms.TextBox MainWordContainer;
        private System.Windows.Forms.Button generateWord;
        private System.Windows.Forms.Button button1;
    }
}

