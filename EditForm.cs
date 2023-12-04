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

            if (unit is Item item)
            {
                // Item-specific UI adjustments
                currentPriceLabel.Visible = true;
                currentPriceText.Visible = true;
                currentPriceText.Text = item.CurrentPrice.ToString();
            }
            else if (unit is ItemContainer)
            {
                // Hide Item-specific fields for ItemContainer
                currentPriceLabel.Visible = false;
                currentPriceText.Visible = false;
            }

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
            // Set initial visibility based on the selected radio button
            currentPriceLabel.Visible = itemRadio.Checked;
            currentPriceText.Visible = itemRadio.Checked;

            itemRadio.Visible = true;
            itemContainerRadio.Visible = true;
        }

        private void LoadUnitData()
        {

            if (unitToEdit != null) { 
                nameText.Text = unitToEdit.Name;
                purchasePriceText.Text = unitToEdit.PurchasePrice.ToString();

                xLocText.Text = unitToEdit.LocationX.ToString();
                yLocText.Text = unitToEdit.LocationY.ToString();
                lengthText.Text = unitToEdit.Length.ToString();
                widthText.Text = unitToEdit.Width.ToString();
                heightText.Text = unitToEdit.Height.ToString();

                if (unitToEdit is Item item)
                {
                    // Item-specific UI adjustments
                    currentPriceText.Text = item.CurrentPrice.ToString();
                }


            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(isEditMode)
            {
                unitToEdit.Name = nameText.Text;
                unitToEdit.PurchasePrice = Decimal.Parse(purchasePriceText.Text);
                unitToEdit.LocationX = Int32.Parse(xLocText.Text);
                unitToEdit.LocationY = Int32.Parse(yLocText.Text);
                unitToEdit.Length = Double.Parse(lengthText.Text);
                unitToEdit.Width= Double.Parse(widthText.Text);
                unitToEdit.Height = Double.Parse(heightText.Text);

                if (unitToEdit is Item item)
                {
                    // Item-specific UI adjustments
                    currentPriceText.Text = item.CurrentPrice.ToString();
                }
            }
            else
            {
                ElementalUnit newElement;

                if (itemContainerRadio.Checked)
                {
                    newElement = new ItemContainer(
                        nameText.Text,
                        Decimal.Parse(purchasePriceText.Text),
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
                    Decimal.Parse(purchasePriceText.Text),
                    Decimal.Parse(currentPriceText.Text),
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

        private void itemRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (itemRadio.Checked)
            {
                // If Item is selected, show Current Price field
                currentPriceLabel.Visible = true;
                currentPriceText.Visible = true;
            }
        }

        private void itemContainerRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (itemContainerRadio.Checked)
            {
                // If Item Container is selected, hide Current Price field
                currentPriceLabel.Visible = false;
                currentPriceText.Visible = false;
            }
        }
    }
}
