namespace CREATORV3
{
    partial class TextMessage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.checkBoxRussianText = new System.Windows.Forms.CheckBox();
            this.checkBoxEnglishText = new System.Windows.Forms.CheckBox();
            this.buttonSaveTextMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тема письма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Текст письма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 669);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(12, 36);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(914, 29);
            this.textBoxSubject.TabIndex = 3;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(12, 108);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(914, 524);
            this.textBoxText.TabIndex = 4;
            // 
            // checkBoxRussianText
            // 
            this.checkBoxRussianText.AutoSize = true;
            this.checkBoxRussianText.Checked = true;
            this.checkBoxRussianText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRussianText.Location = new System.Drawing.Point(12, 638);
            this.checkBoxRussianText.Name = "checkBoxRussianText";
            this.checkBoxRussianText.Size = new System.Drawing.Size(315, 28);
            this.checkBoxRussianText.TabIndex = 5;
            this.checkBoxRussianText.Text = "Текст письма на Русском языке";
            this.checkBoxRussianText.UseVisualStyleBackColor = true;
            this.checkBoxRussianText.CheckedChanged += new System.EventHandler(this.checkBoxRussianText_CheckedChanged);
            // 
            // checkBoxEnglishText
            // 
            this.checkBoxEnglishText.AutoSize = true;
            this.checkBoxEnglishText.Location = new System.Drawing.Point(375, 638);
            this.checkBoxEnglishText.Name = "checkBoxEnglishText";
            this.checkBoxEnglishText.Size = new System.Drawing.Size(338, 28);
            this.checkBoxEnglishText.TabIndex = 6;
            this.checkBoxEnglishText.Text = "Текст письма на Англйском языке";
            this.checkBoxEnglishText.UseVisualStyleBackColor = true;
            this.checkBoxEnglishText.CheckedChanged += new System.EventHandler(this.checkBoxEnglishText_CheckedChanged);
            // 
            // buttonSaveTextMessage
            // 
            this.buttonSaveTextMessage.Location = new System.Drawing.Point(719, 638);
            this.buttonSaveTextMessage.Name = "buttonSaveTextMessage";
            this.buttonSaveTextMessage.Size = new System.Drawing.Size(207, 68);
            this.buttonSaveTextMessage.TabIndex = 7;
            this.buttonSaveTextMessage.Text = "Сохранить";
            this.buttonSaveTextMessage.UseVisualStyleBackColor = true;
            this.buttonSaveTextMessage.Click += new System.EventHandler(this.buttonSaveTextMessage_Click);
            // 
            // TextMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 759);
            this.Controls.Add(this.buttonSaveTextMessage);
            this.Controls.Add(this.checkBoxEnglishText);
            this.Controls.Add(this.checkBoxRussianText);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TextMessage";
            this.Text = "TextMessage";
            this.Load += new System.EventHandler(this.TextMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.CheckBox checkBoxRussianText;
        private System.Windows.Forms.CheckBox checkBoxEnglishText;
        private System.Windows.Forms.Button buttonSaveTextMessage;
    }
}