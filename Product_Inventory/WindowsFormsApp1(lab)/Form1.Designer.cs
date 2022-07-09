namespace WindowsFormsApp1_lab_
{
    partial class Form1
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
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.txt_InventoryNum = new System.Windows.Forms.TextBox();
            this.txtInventoryNum = new System.Windows.Forms.Label();
            this.txt_ObjName = new System.Windows.Forms.TextBox();
            this.txtObjName = new System.Windows.Forms.Label();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_Date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_Num
            // 
            this.txt_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num.Location = new System.Drawing.Point(51, 89);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(136, 24);
            this.txt_Num.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(203, 321);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(123, 36);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(48, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(55, 16);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Number";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(221, 54);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(36, 16);
            this.txtDate.TabIndex = 3;
            this.txtDate.Text = "Date";
            // 
            // txt_InventoryNum
            // 
            this.txt_InventoryNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InventoryNum.Location = new System.Drawing.Point(530, 89);
            this.txt_InventoryNum.Name = "txt_InventoryNum";
            this.txt_InventoryNum.Size = new System.Drawing.Size(219, 24);
            this.txt_InventoryNum.TabIndex = 1;
            // 
            // txtInventoryNum
            // 
            this.txtInventoryNum.AutoSize = true;
            this.txtInventoryNum.Location = new System.Drawing.Point(527, 54);
            this.txtInventoryNum.Name = "txtInventoryNum";
            this.txtInventoryNum.Size = new System.Drawing.Size(118, 16);
            this.txtInventoryNum.TabIndex = 3;
            this.txtInventoryNum.Text = "Inventory Number: ";
            // 
            // txt_ObjName
            // 
            this.txt_ObjName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ObjName.Location = new System.Drawing.Point(51, 173);
            this.txt_ObjName.Name = "txt_ObjName";
            this.txt_ObjName.Size = new System.Drawing.Size(698, 30);
            this.txt_ObjName.TabIndex = 1;
            // 
            // txtObjName
            // 
            this.txtObjName.AutoSize = true;
            this.txtObjName.Location = new System.Drawing.Point(48, 138);
            this.txtObjName.Name = "txtObjName";
            this.txtObjName.Size = new System.Drawing.Size(83, 16);
            this.txtObjName.TabIndex = 3;
            this.txtObjName.Text = "Object name";
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(51, 251);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(136, 22);
            this.txt_Count.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Count";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(224, 251);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(136, 22);
            this.txt_Price.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Price";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(428, 321);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(123, 36);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(224, 90);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(280, 22);
            this.txt_Date.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.txtInventoryNum);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txt_InventoryNum);
            this.Controls.Add(this.txtObjName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.txt_ObjName);
            this.Controls.Add(this.txt_Num);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.TextBox txt_InventoryNum;
        private System.Windows.Forms.Label txtInventoryNum;
        private System.Windows.Forms.TextBox txt_ObjName;
        private System.Windows.Forms.Label txtObjName;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DateTimePicker txt_Date;
    }
}

