namespace WindowsFormsApp1_lab_
{
    partial class Login_Form
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.lbl_passwd = new System.Windows.Forms.Label();
            this.txtBox_passwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(192, 81);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(41, 16);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "name";
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(248, 81);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(277, 22);
            this.txtBox_name.TabIndex = 1;
            // 
            // lbl_passwd
            // 
            this.lbl_passwd.AutoSize = true;
            this.lbl_passwd.Location = new System.Drawing.Point(167, 143);
            this.lbl_passwd.Name = "lbl_passwd";
            this.lbl_passwd.Size = new System.Drawing.Size(66, 16);
            this.lbl_passwd.TabIndex = 0;
            this.lbl_passwd.Text = "password";
            // 
            // txtBox_passwd
            // 
            this.txtBox_passwd.Location = new System.Drawing.Point(248, 143);
            this.txtBox_passwd.Name = "txtBox_passwd";
            this.txtBox_passwd.Size = new System.Drawing.Size(277, 22);
            this.txtBox_passwd.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_passwd);
            this.Controls.Add(this.lbl_passwd);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.lbl_name);
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.Label lbl_passwd;
        private System.Windows.Forms.TextBox txtBox_passwd;
        private System.Windows.Forms.Button button1;
    }
}