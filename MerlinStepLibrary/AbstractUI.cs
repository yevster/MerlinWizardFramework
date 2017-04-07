using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MerlinStepLibrary
{
    /// <summary>
    /// A control containing a prompt and a child control
    /// </summary>
    internal class AbstractUI : Control
    {

        private Label lblPrompt;
        public int SpaceBetweenPromptAndChild { get; set; }
        public Padding Margin { get; set; }

        public AbstractUI(string promptText, Control childControl)
        {

            if (childControl == null)
                throw new ArgumentException("Unable to instantiate " + this.GetType().FullName + " with null child control");
            this.PromptText = promptText;
            this.ChildControl = childControl;

            //Default spacing
            this.SpaceBetweenPromptAndChild = 20;
            this.Margin = new Padding(15);
            InitializeComponent();
        }

        public string PromptText { get; private set; }
        public Control ChildControl { get; private set; }

        private void InitializeComponent()
        {
            this.lblPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.Controls.Add(lblPrompt);
            this.Controls.Add(this.ChildControl);
            
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(100, 23);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = this.PromptText;
            this.Resize += new EventHandler(AbstractUI_Resize);
            
            this.ResumeLayout(false);
            AbstractUI_Resize(this, EventArgs.Empty);

            
        }

        void AbstractUI_Resize(object sender, EventArgs e)
        {
            lblPrompt.Top = this.Margin.Top;
            lblPrompt.Left = this.Margin.Left;
            lblPrompt.Width = this.ClientRectangle.Width - this.Margin.Left - this.Margin.Right; ;
            this.ChildControl.Top = lblPrompt.Bottom + this.SpaceBetweenPromptAndChild;
            this.ChildControl.Left = this.Margin.Left;
            this.ChildControl.Width = this.ClientRectangle.Width - this.Margin.Right - this.Margin.Left; ;
            this.ChildControl.Height = this.ClientRectangle.Height - this.ChildControl.Top - this.Margin.Bottom;
        }


    }
}
