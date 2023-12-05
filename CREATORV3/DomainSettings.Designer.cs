namespace CREATORV3
{
    partial class DomainSettings
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
            this.comboBoxListOU = new System.Windows.Forms.ComboBox();
            this.textBoxNetBios = new System.Windows.Forms.TextBox();
            this.buttonSaveDomainSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NETBIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "OU";
            // 
            // comboBoxListOU
            // 
            this.comboBoxListOU.FormattingEnabled = true;
            this.comboBoxListOU.Location = new System.Drawing.Point(110, 47);
            this.comboBoxListOU.Name = "comboBoxListOU";
            this.comboBoxListOU.Size = new System.Drawing.Size(269, 32);
            this.comboBoxListOU.TabIndex = 2;
            // 
            // textBoxNetBios
            // 
            this.textBoxNetBios.Location = new System.Drawing.Point(110, 12);
            this.textBoxNetBios.Name = "textBoxNetBios";
            this.textBoxNetBios.Size = new System.Drawing.Size(269, 29);
            this.textBoxNetBios.TabIndex = 3;
            // 
            // buttonSaveDomainSettings
            // 
            this.buttonSaveDomainSettings.Location = new System.Drawing.Point(242, 85);
            this.buttonSaveDomainSettings.Name = "buttonSaveDomainSettings";
            this.buttonSaveDomainSettings.Size = new System.Drawing.Size(137, 44);
            this.buttonSaveDomainSettings.TabIndex = 4;
            this.buttonSaveDomainSettings.Text = "Сохранить ";
            this.buttonSaveDomainSettings.UseVisualStyleBackColor = true;
            this.buttonSaveDomainSettings.Click += new System.EventHandler(this.buttonSaveDomainSettings_Click);
            // 
            // DomainSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 141);
            this.Controls.Add(this.buttonSaveDomainSettings);
            this.Controls.Add(this.textBoxNetBios);
            this.Controls.Add(this.comboBoxListOU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DomainSettings";
            this.Text = "DomainSettings";
            this.Load += new System.EventHandler(this.DomainSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxListOU;
        private System.Windows.Forms.TextBox textBoxNetBios;
        private System.Windows.Forms.Button buttonSaveDomainSettings;
    }
}