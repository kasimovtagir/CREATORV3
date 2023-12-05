namespace CREATORV3
{
    partial class DefPasswordForUser
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
            this.buttonSaveDefPasswordForUser = new System.Windows.Forms.Button();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDefPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSaveDefPasswordForUser
            // 
            this.buttonSaveDefPasswordForUser.Location = new System.Drawing.Point(219, 76);
            this.buttonSaveDefPasswordForUser.Name = "buttonSaveDefPasswordForUser";
            this.buttonSaveDefPasswordForUser.Size = new System.Drawing.Size(180, 49);
            this.buttonSaveDefPasswordForUser.TabIndex = 0;
            this.buttonSaveDefPasswordForUser.Text = "Сохранить";
            this.buttonSaveDefPasswordForUser.UseVisualStyleBackColor = true;
            this.buttonSaveDefPasswordForUser.Click += new System.EventHandler(this.buttonSaveDefPasswordForUser_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(16, 71);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(182, 28);
            this.checkBoxShowPassword.TabIndex = 1;
            this.checkBoxShowPassword.Text = "Показать пароль";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пароль по умолчанию для пользователей";
            // 
            // textBoxDefPass
            // 
            this.textBoxDefPass.Location = new System.Drawing.Point(16, 36);
            this.textBoxDefPass.Name = "textBoxDefPass";
            this.textBoxDefPass.Size = new System.Drawing.Size(383, 29);
            this.textBoxDefPass.TabIndex = 3;
            this.textBoxDefPass.UseSystemPasswordChar = true;
            // 
            // DefPasswordForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 139);
            this.Controls.Add(this.textBoxDefPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.buttonSaveDefPasswordForUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DefPasswordForUser";
            this.Text = "DefPasswordForUser";
            this.Load += new System.EventHandler(this.DefPasswordForUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveDefPasswordForUser;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDefPass;
    }
}