using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FarmInterface
{
    public partial class MainForm : Form
    {
        private ItemContainer rootContainer = new ItemContainer("Farm", 0.00m, 0, 0, 0, 0, 0);
        private FarmPanel farmPanel;

        private Timer animationTimer = new Timer();
        private int buttonSpeed = 5;

        public MainForm()
        {
            InitializeComponent();

            //farmComponents.Text = "root";
            TreeNode rootNode = new TreeNode("root");
            treeView.Nodes.Add(rootNode);

            // Initialize the Timer
            animationTimer.Interval = 16; // 60 frames per second
            animationTimer.Tick += AnimationTimer_Tick;

            // Start the animation
            animationTimer.Start();

            //Replaces the placeholder panel displayed in design with the custom farmPanel
            farmPanel = new FarmPanel
            {

                Size = placeholderPanel.Size, 
                Location = placeholderPanel.Location, 
                BorderStyle = BorderStyle.Fixed3D 
            };
            this.Controls.Remove(placeholderPanel);
            this.Controls.Add(farmPanel);

            farmPanel.RootContainer = rootContainer;
        }

        private void MoveButton(int deltaX)
        {
            // Move the button horizontally
            button1.Location = new System.Drawing.Point(button1.Location.X + deltaX, button1.Location.Y);
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Move the button to the right
            MoveButton(buttonSpeed);

            // Check if the button is out of the panel's bounds
            if (button1.Location.X + button1.Width > farmPanel.Width)
            {
                // Change the direction of movement
                buttonSpeed = -buttonSpeed;
            }
            else if (button1.Location.X < farmPanel.Location.X)
            {
                // Change the direction of movement
                buttonSpeed = Math.Abs(buttonSpeed);
            }
        }



        private void populate_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            Testing.PopulateBarnTest(rootContainer);
            PopulateTreeView(rootContainer, treeView.Nodes);

            farmPanel.DisplayLabels();
            farmPanel.Invalidate();
        }


        private void PopulateTreeView(ElementalUnit unit, TreeNodeCollection nodes)
        {
            TreeNode newNode = nodes.Add(unit.Name);
            newNode.Tag = unit; // Storing the ElementalUnit object in the Tag property

            if (unit is ItemContainer container)
            {
                foreach (var child in container.Children)
                {
                    PopulateTreeView(child, newNode.Nodes);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //what treeView
            if (treeView.SelectedNode != null)
            {
                ElementalUnit selectedUnit = treeView.SelectedNode.Tag as ElementalUnit;
                // Implement the logic to delete the selectedUnit from its parent
                // Update the TreeView

                if(selectedUnit == rootContainer)
                {
                    // Special case for root container: clear its children
                    if (selectedUnit is ItemContainer container)
                    {
                        container.Children.Clear();
                    }
                }
                else
                {
                    selectedUnit.Delete(selectedUnit);
                }

                treeView.Nodes.Remove(treeView.SelectedNode);
                treeView.Nodes.Clear();
                PopulateTreeView(rootContainer, treeView.Nodes);

                farmPanel.DisplayLabels();
                farmPanel.Invalidate();
            }


        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                ElementalUnit selectedUnit = treeView.SelectedNode.Tag as ElementalUnit;
                EditForm editForm = new EditForm(selectedUnit);
                editForm.ShowDialog();

                // After editing, update the TreeView if necessary
                treeView.SelectedNode.Text = selectedUnit.Name;
            }
            farmPanel.DisplayLabels();
            farmPanel.Invalidate();
        }

        private void treeExpand_CheckedChanged(object sender, EventArgs e)
        {
            // If the check box is checked, expand all the tree nodes.
            if (treeExpand.Checked == true)
            {
                treeView.ExpandAll();
            }
            else
            {
                // If the check box is not checked, collapse the first tree node.
                treeView.CollapseAll();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null && treeView.SelectedNode.Tag is ItemContainer selectedContainer)
            {
                // Open the form to add a new Item or ItemContainer
                EditForm addForm = new EditForm();
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Create new element based on user input
                    ElementalUnit newElement = addForm.CreatedElement;
                    if (newElement != null)
                    {
                        selectedContainer.AddItem(newElement);

                        // Update TreeView and FarmPanel
                        treeView.Nodes.Clear();
                        PopulateTreeView(rootContainer, treeView.Nodes);
                        farmPanel.DisplayLabels();
                        farmPanel.Invalidate();
                    }
                }
            }
        }
    }
}
