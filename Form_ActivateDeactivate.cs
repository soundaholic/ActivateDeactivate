using INFITF;
using ProductStructureTypeLib;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ActivateDeactivate
{
    public partial class Form_ActivateDeactivate : Form
    {
        private INFITF.Application myCATIA;

        public Form_ActivateDeactivate()
        {
            InitializeComponent();
            myCATIA = (INFITF.Application)Marshal.GetActiveObject("CATIA.Application");
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            Selection mySelection;
            mySelection = myCATIA.ActiveDocument.Selection;

            if (RadioButton_Deactivate.Checked)
            {
                DeactivateInTree(mySelection);
            }
            if (RadioButton_Activate.Checked)
            {
                ActivateInTree(mySelection);
            }
        }
        public void DeactivateInTree(Selection selection)
        {
            List<AnyObject> list = new List<AnyObject>();

            //ProductDocument productDocument = myCATIA.ActiveDocument as ProductDocument;
            //Product product = productDocument.Product;

            //selection = productDocument.Selection;
            //selection.Add(product.Products.Item(2));
            //myCATIA.StartCommand("Activate / Deactivate Component");

            AnyObject selectedItem;

            for (int i = 1; i <= selection.Count; i++)
            {
                //selectedItem = selection.Item(i).Value;
                selectedItem = selection.Item2(i).Value as AnyObject;
                if (selectedItem == null) throw new NullReferenceException();
                list.Add(selectedItem);
            }
            selection.Clear();

            foreach (AnyObject item in list)
            {
                selection.Add(item);
                myCATIA.StartCommand("Activate / Deactivate Component");
                selection.Clear();
            }
        }

        public void ActivateInTree(Selection selection)
        {
            List<AnyObject> list = new List<AnyObject>();
            AnyObject selectedItem;

            for (int i = 1; i <= selection.Count; i++)
            {
                selectedItem = selection.Item2(i).Value as AnyObject;
                if (selectedItem == null) throw new NullReferenceException();
                list.Add(selectedItem);
            }

            selection.Clear();

            foreach (AnyObject item in list)
            {
                selection.Add(item);

                if (!IsProductActivated((Product)item))
                {
                    myCATIA.StartCommand("Activate / Deactivate Component");
                }
                selection.Clear();
            }
        }

        private bool IsProductActivated(Product instance)
        {
            //crashed wenn instance is root product
            return instance.Parameters.Item(((Product)instance.Parent).get_PartNumber() + "\\" + instance.get_Name() + "\\Component Activation State").ValueAsString() == "true";
        }

        private void button_Select_Click(object sender, EventArgs e)
        {

        }

        private void Form_ActivateDeactivate_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please select the CATIA tree members to activate or deactivate,\nchose the option and press \"Start\" button");
        }
    }
}