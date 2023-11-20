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

        //These are for drone movement
        private Point targetPosition;
        private const int DroneSpeed = 5;
        private bool returningToStart = false;

        private static MainForm instance = null;

        // Public static method to get the instance
        public static MainForm GetInstance()
        {
            if (instance == null)
            {
                instance = new MainForm();
            }
            return instance;
        }

        public MainForm()
        {
            InitializeComponent();

            //farmComponents.Text = "root";
            TreeNode rootNode = new TreeNode("root");
            treeView.Nodes.Add(rootNode);

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

        private void inspectButton_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null
                && treeView.SelectedNode.Tag is ElementalUnit selectedUnit
                && selectedUnit.Name != "Drone")
            {
                Point targetPosition = new Point(selectedUnit.LocationX, selectedUnit.LocationY);

                StartDroneAnimation(targetPosition);
            }

        }

        private void StartDroneAnimation(Point target)
        {
            targetPosition = target;
            animationTimer.Start();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            Point currentPosition = returningToStart ? farmPanel.DroneStartPosition : targetPosition;

            var direction = new Point(currentPosition.X - farmPanel.DroneRectangle.X,
                                      currentPosition.Y - farmPanel.DroneRectangle.Y);

            var distance = Math.Sqrt(direction.X * direction.X + direction.Y * direction.Y);
            if (distance < DroneSpeed)
            {
                if (!returningToStart)
                {
                    // Drone reached the target, now return to start
                    returningToStart = true;
                    return; // Exit this tick, next tick will move towards start
                }
                else
                {
                    // Drone returned to start, stop the animation
                    animationTimer.Stop();
                    returningToStart = false;
                    return;
                }
            }

            // Normalize the direction and move the drone
            var moveX = (int)(DroneSpeed * direction.X / distance);
            var moveY = (int)(DroneSpeed * direction.Y / distance);
            farmPanel.MoveDrone(farmPanel.DroneRectangle.X + moveX,
                                farmPanel.DroneRectangle.Y + moveY);
        }

    }
}
