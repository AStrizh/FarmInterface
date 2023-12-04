using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace FarmInterface
{
    public partial class EditForm : Form
    {
        private ElementalUnit unitToEdit;
        private bool isEditMode;

        public ElementalUnit CreatedElement { get; private set; }


        public EditForm(ElementalUnit unit) : this()
        {
            unitToEdit = unit;
            isEditMode = true;
            LoadUnitData();

            // Hide radio buttons in edit mode
            itemRadio.Visible = false;
            itemContainerRadio.Visible = false;
        }

        // Overloaded constructor for adding a new element
        public EditForm()
        {
            InitializeComponent();
            isEditMode = false;
            // Make radio buttons visible
            itemRadio.Visible = true;
            itemContainerRadio.Visible = true;
        }

        private void LoadUnitData()
        {

            if (unitToEdit != null) { 
                nameText.Text = unitToEdit.Name;
                purchasepText.Text = unitToEdit.PurchasePrice.ToString();
                currentpText.Text = unitToEdit.CurrentPrice.ToString();
                xLocText.Text = unitToEdit.LocationX.ToString();
                yLocText.Text = unitToEdit.LocationY.ToString();
                lengthText.Text = unitToEdit.Length.ToString();
                widthText.Text = unitToEdit.Width.ToString();
                heightText.Text = unitToEdit.Height.ToString();            
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(isEditMode)
            {
                unitToEdit.Name = nameText.Text;
                unitToEdit.PurchasePrice = Decimal.Parse(purchasepText.Text);
                unitToEdit.CurrentPrice = Decimal.Parse(currentpText.Text);
                unitToEdit.LocationX = Int32.Parse(xLocText.Text);
                unitToEdit.LocationY = Int32.Parse(yLocText.Text);
                unitToEdit.Length = Double.Parse(lengthText.Text);
                unitToEdit.Width= Double.Parse(widthText.Text);
                unitToEdit.Height = Double.Parse(heightText.Text);
            }
            else
            {
                ElementalUnit newElement;

                if (itemContainerRadio.Checked)
                {
                    newElement = new ItemContainer(
                        nameText.Text,
                        Decimal.Parse(purchasepText.Text),
                        Decimal.Parse(currentpText.Text),
                        Int32.Parse(xLocText.Text), 
                        Int32.Parse(yLocText.Text), 
                        Double.Parse(lengthText.Text), 
                        Double.Parse(widthText.Text), 
                        Double.Parse(heightText.Text));
                }
                else
                {

                    newElement = new Item(
                    nameText.Text,
                    Decimal.Parse(purchasepText.Text),
                    Decimal.Parse(currentpText.Text),
                    Int32.Parse(xLocText.Text),
                    Int32.Parse(yLocText.Text),
                    Double.Parse(lengthText.Text),
                    Double.Parse(widthText.Text),
                    Double.Parse(heightText.Text));
                }
                CreatedElement = newElement;

            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
