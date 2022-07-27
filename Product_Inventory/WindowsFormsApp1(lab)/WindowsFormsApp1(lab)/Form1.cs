﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1_lab_.Model;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1_lab_
{
    public partial class Form1 : Form
    {
        public Form1(string name)
        {
            InitializeComponent();
            lbl_usrName.Text = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p;
            Regex re;
            try
            {
                re = new Regex(@"^[0-9]{4}");
                p = new Product
                {
                    Number = int.Parse(txt_Num.Text),
                    Date = txt_Date.Text,
                    InventoryNum = int.Parse(txt_InventoryNum.Text),
                    ObjName = txt_ObjName.Text,
                    Count = int.Parse(txt_Count.Text),
                    Price = float.Parse(txt_Price.Text),
                    IsAvailable = isAvailable.Checked
                };

                if (!re.IsMatch(txt_InventoryNum.Text) || string.IsNullOrEmpty(txt_ObjName.Text))
                {
                    if (string.IsNullOrEmpty(txt_ObjName.Text))
                        errPrvdr.SetError(txt_ObjName, "Name is required");

                    else
                        errPrvdr.SetError(txt_InventoryNum, "Is not correct format");
                }
                else
                {
                    if (chkListBox.CheckedItems.Count > 0)
                    {
                        string checkedNames = "";
                        foreach (string str in chkListBox.CheckedItems)
                        {
                            checkedNames += str + " ";
                        }
                        MessageBox.Show(checkedNames);
                    }
                    errPrvdr.Clear();
                    p.save();
                    MessageBox.Show(
                    $"Product Number: {p.Number}\n " +
                    $"Product Date: {p.Date}\n" +
                    $"Product inventory number: {p.InventoryNum}\n" +
                    $"Product name: {p.ObjName}\n" +
                    $"Count: {p.Count}\n" +
                    $"Price: {p.Price}\n" +
                    $"Avalability: {p.IsAvailable}"
                    );
                    dtGridView.DataSource = null;
                    dtGridView.DataSource = Product.getAllProducts();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
