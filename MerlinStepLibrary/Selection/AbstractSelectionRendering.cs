using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MerlinStepLibrary.Selection
{
    public partial class AbstractSelectionRendering : UserControl
    {
        public int MinimumDistanceBetweenOptions { get; set; }

        public AbstractSelectionRendering()
        {
            this.MinimumDistanceBetweenOptions = 0;
            InitializeComponent();
        }

        private int getLowestOptionBottom()
        {
            int height = 0;
            foreach (Control control in this.Controls)
            {
                height += control.Height;
            }
            if (this.Controls.Count >= 1)
            {
                height += (this.Controls.Count - 1) * this.MinimumDistanceBetweenOptions;
            }
            return height;
        }

        private void AbstractSelectionRendering_Resize(object sender, EventArgs e)
        {
            int lowestOptionBottom = getLowestOptionBottom();
            int downShift = (this.ClientRectangle.Height - lowestOptionBottom) > this.MinimumDistanceBetweenOptions ?
                (this.ClientRectangle.Height - lowestOptionBottom) / 10 : this.MinimumDistanceBetweenOptions;
            int nextTop = 0;
            foreach (Control child in Controls)
            {
                child.Left = 0;
                child.Width = this.ClientRectangle.Width;
                child.Top = nextTop;
                nextTop += child.Height + downShift;
            }
        }
    }
}
