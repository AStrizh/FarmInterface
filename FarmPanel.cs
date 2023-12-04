using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmInterface
{
    public class FarmPanel : Panel
    {
        public Rectangle DroneRectangle { get; set; }
        public Point DroneStartPosition { get; set; }
        public ElementalUnit RootContainer { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawElement(RootContainer, e.Graphics);
        }

        private void DrawElement(ElementalUnit element, Graphics graphics)
        {
            if (element == null) return;

            if (element.Name == "Drone")
            {
                // If DroneRectangle is not set, initialize it
                if (DroneRectangle == default(Rectangle))
                {
                    DroneRectangle = new Rectangle(element.LocationX, element.LocationY,
                                                   (int)element.Width, (int)element.Length);

                    DroneStartPosition = new Point(element.LocationX, element.LocationY);
                }

                graphics.DrawRectangle(Pens.Black, DroneRectangle);
            }
            else
            {
                // Draw other elements as rectangles
                Rectangle rect = new Rectangle(element.LocationX, element.LocationY,
                                               (int)element.Width, (int)element.Length);
                graphics.DrawRectangle(Pens.Black, rect);

                // Recursive call for ItemContainers
                if (element is ItemContainer container)
                {
                    foreach (var child in container.Children)
                    {
                        DrawElement(child, graphics);
                    }
                }
            }
        }


        public void DisplayLabels()
        {
            // Clear existing labels
            ClearLabels();

            // Display updated labels
            DisplayElementLabel(RootContainer);
        }

        private void DisplayElementLabel(ElementalUnit element)
        {
            if (element == null) return;

            Label nameLabel = new Label
            {
                Text = element.Name,
                AutoSize = true, // Automatically size the label to fit the text
                Font = new Font("Arial", 8, FontStyle.Regular),
                Location = new Point(element.LocationX, element.LocationY)
            };

            this.Controls.Add(nameLabel); // Add the label to the FarmPanel

            if (element is ItemContainer container)
            {
                foreach (var child in container.Children)
                {
                    DisplayElementLabel(child);
                }
            }
        }

        public void MoveDrone(int x, int y)
        {
            DroneRectangle = new Rectangle(x, y, DroneRectangle.Width, DroneRectangle.Height);
            this.Invalidate();
        }

        private void ClearLabels()
        {
            // Create a list of labels to remove
            var labelsToRemove = this.Controls.OfType<Label>().ToList();

            // Remove each label from the controls
            foreach (var label in labelsToRemove)
            {
                this.Controls.Remove(label);
                label.Dispose(); // Properly dispose the label
            }
        }
    }
}
