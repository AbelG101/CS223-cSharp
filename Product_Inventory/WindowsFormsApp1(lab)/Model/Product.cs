using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_lab_.Model
{
    internal class Product
    {
        public int Number
        {
            get;
            set;
        }

        public string Date
        {
            get;
            set;
        }
        public int InventoryNum
        {
            get;
            set;
        }
        public string ObjName
        {
            get;
            set;
        }
        public int Count
        {
            set;
            get;
        }
        public float Price
        {
            set;
            get;
        }

        public void save()
        {
            Console.WriteLine("Succesfully saved");
        }
    }
}
