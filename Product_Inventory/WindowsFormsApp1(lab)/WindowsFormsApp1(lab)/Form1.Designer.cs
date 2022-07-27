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
            this.components = new System.ComponentModel.Container();
            this.txt_Num = new System.Windows.Forms.TextBox();
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
            this.txt_Date = new System.Windows.Forms.DateTimePicker();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.errPrvdr = new System.Windows.Forms.ErrorProvider(this.components);
            this.isAvailable = new System.Windows.Forms.CheckBox();
            this.chkListBox = new System.Windows.Forms.CheckedListBox();
            this.chkBox_simple = new System.Windows.Forms.RadioButton();
            this.chkBox_var = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_usrName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvdr)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Num
            // 
            this.txt_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num.Location = new System.Drawing.Point(51, 48);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(136, 24);
            this.txt_Num.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(48, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(55, 16);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Number";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(221, 30);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(36, 16);
            this.txtDate.TabIndex = 3;
            this.txtDate.Text = "Date";
            // 
            // txt_InventoryNum
            // 
            this.txt_InventoryNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InventoryNum.Location = new System.Drawing.Point(530, 48);
            this.txt_InventoryNum.Name = "txt_InventoryNum";
            this.txt_InventoryNum.Size = new System.Drawing.Size(219, 24);
            this.txt_InventoryNum.TabIndex = 1;
            // 
            // txtInventoryNum
            // 
            this.txtInventoryNum.AutoSize = true;
            this.txtInventoryNum.Location = new System.Drawing.Point(527, 30);
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
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(224, 49);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(280, 22);
            this.txt_Date.TabIndex = 4;
            // 
            // dtGridView
            // 
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(-4, 330);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.Size = new System.Drawing.Size(806, 123);
            this.dtGridView.TabIndex = 5;
            // 
            // errPrvdr
            // 
            this.errPrvdr.ContainerControl = this;
            // 
            // isAvailable
            // 
            this.isAvailable.AutoSize = true;
            this.isAvailable.Location = new System.Drawing.Point(442, 252);
            this.isAvailable.Name = "isAvailable";
            this.isAvailable.Size = new System.Drawing.Size(86, 20);
            this.isAvailable.TabIndex = 6;
            this.isAvailable.Text = "Available";
            this.isAvailable.UseVisualStyleBackColor = true;
            // 
            // chkListBox
            // 
            this.chkListBox.FormattingEnabled = true;
            this.chkListBox.Items.AddRange(new object[] {
            "Box1",
            "Box2",
            "Box3"});
            this.chkListBox.Location = new System.Drawing.Point(682, 208);
            this.chkListBox.Name = "chkListBox";
            this.chkListBox.Size = new System.Drawing.Size(120, 123);
            this.chkListBox.TabIndex = 7;
            // 
            // chkBox_simple
            // 
            this.chkBox_simple.AutoSize = true;
            this.chkBox_simple.Location = new System.Drawing.Point(16, 21);
            this.chkBox_simple.Name = "chkBox_simple";
            this.chkBox_simple.Size = new System.Drawing.Size(70, 20);
            this.chkBox_simple.TabIndex = 8;
            this.chkBox_simple.TabStop = true;
            this.chkBox_simple.Text = "Simple";
            this.chkBox_simple.UseVisualStyleBackColor = true;
            // 
            // chkBox_var
            // 
            this.chkBox_var.AutoSize = true;
            this.chkBox_var.Location = new System.Drawing.Point(120, 21);
            this.chkBox_var.Name = "chkBox_var";
            this.chkBox_var.Size = new System.Drawing.Size(79, 20);
            this.chkBox_var.TabIndex = 8;
            this.chkBox_var.TabStop = true;
            this.chkBox_var.Text = "Variable";
            this.chkBox_var.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBox_simple);
            this.groupBox1.Controls.Add(this.chkBox_var);
            this.groupBox1.Location = new System.Drawing.Point(530, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 63);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product type";
            // 
            // lbl_usrName
            // 
            this.lbl_usrName.AutoSize = true;
            this.lbl_usrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usrName.Location = new System.Drawing.Point(51, 91);
            this.lbl_usrName.Name = "lbl_usrName";
            this.lbl_usrName.Size = new System.Drawing.Size(95, 36);
            this.lbl_usrName.TabIndex = 10;
            this.lbl_usrName.Text = "label1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(285, 293);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 31);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(413, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 31);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbl_usrName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkListBox);
            this.Controls.Add(this.isAvailable);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.txtInventoryNum);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txt_InventoryNum);
            this.Controls.Add(this.txtObjName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.txt_ObjName);
            this.Controls.Add(this.txt_Num);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvdr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Num;
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
        private System.Windows.Forms.DateTimePicker txt_Date;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.ErrorProvider errPrvdr;
        private System.Windows.Forms.CheckBox isAvailable;
        private System.Windows.Forms.CheckedListBox chkListBox;
        private System.Windows.Forms.RadioButton chkBox_var;
        private System.Windows.Forms.RadioButton chkBox_simple;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_usrName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}

