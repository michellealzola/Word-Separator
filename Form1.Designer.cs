namespace Word_Separator
{
    partial class frmWordSeparator
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxEntryWord = new System.Windows.Forms.TextBox();
            this.lblOutSeparatedWord = new System.Windows.Forms.Label();
            this.btnSeparateWord = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter A Camel Case String:";
            // 
            // tboxEntryWord
            // 
            this.tboxEntryWord.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEntryWord.Location = new System.Drawing.Point(299, 55);
            this.tboxEntryWord.Name = "tboxEntryWord";
            this.tboxEntryWord.Size = new System.Drawing.Size(407, 31);
            this.tboxEntryWord.TabIndex = 1;
            // 
            // lblOutSeparatedWord
            // 
            this.lblOutSeparatedWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutSeparatedWord.Font = new System.Drawing.Font("Arsenal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutSeparatedWord.Location = new System.Drawing.Point(85, 114);
            this.lblOutSeparatedWord.Name = "lblOutSeparatedWord";
            this.lblOutSeparatedWord.Size = new System.Drawing.Size(621, 56);
            this.lblOutSeparatedWord.TabIndex = 2;
            this.lblOutSeparatedWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSeparateWord
            // 
            this.btnSeparateWord.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeparateWord.Location = new System.Drawing.Point(85, 194);
            this.btnSeparateWord.Name = "btnSeparateWord";
            this.btnSeparateWord.Size = new System.Drawing.Size(294, 41);
            this.btnSeparateWord.TabIndex = 3;
            this.btnSeparateWord.Text = "Separate Word";
            this.btnSeparateWord.UseVisualStyleBackColor = true;
            this.btnSeparateWord.Click += new System.EventHandler(this.btnSeparateWord_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(385, 194);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 41);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(571, 194);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 41);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmWordSeparator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 279);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSeparateWord);
            this.Controls.Add(this.lblOutSeparatedWord);
            this.Controls.Add(this.tboxEntryWord);
            this.Controls.Add(this.label1);
            this.Name = "frmWordSeparator";
            this.Text = "Word Separator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxEntryWord;
        private System.Windows.Forms.Label lblOutSeparatedWord;
        private System.Windows.Forms.Button btnSeparateWord;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

