using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MerlinStepLibrary.Selection
{
    /// <summary>
    /// A step to select a string among a number of choices.
    /// </summary>
    public class TextSelectionStep : AbstractSelectionStep<string>
    {
        public enum SelectionCardinality { Single, Multiple }

        private List<string> _selectedAnswers;

        /// <summary>
        /// Creates a new text selection step
        /// </summary>
        /// <param name="prompt">The prompt to appear at the top of the UI</param>
        /// <param name="options">The possible selection options</param>
        public TextSelectionStep(string prompt, params string[] options)
            :this (prompt, (IEnumerable<string>)options)
        { }

        /// <summary>
        /// Creates a new text selection step
        /// </summary>
        /// <param name="prompt">The prompt to appear at the top of the UI</param>
        /// <param name="options">The possible selection options</param>
        public TextSelectionStep(string prompt, IEnumerable<string> options)
            : base(options, prompt)
        {
            _selectedAnswers = new List<string>();
            this.Cardinality = SelectionCardinality.Single;
            this.AllowSelectNone = true;
            this.Renderer = renderOptions;
            this.ResultDelegate = () => _selectedAnswers.ToArray();
        }
        


        private Control renderOptions(IEnumerable<string> options)
        {
            Console.WriteLine(this == null);
            Control result = new AbstractSelectionRendering();
            foreach (string s in options)
            {
                Control optionControl;
                if (this.Cardinality == SelectionCardinality.Multiple)
                {
                    var checkBox = new CheckBox();
                    checkBox.CheckedChanged += (sender, args) => checkUncheck(checkBox.Checked, checkBox.Text);
                    optionControl=checkBox;
                    
                }
                else
                {
                    var radioButton = new RadioButton();
                    radioButton.CheckedChanged += (sender, args) => checkUncheck(radioButton.Checked, radioButton.Text);
                    optionControl = radioButton;
                }
                optionControl.Text = s;
                result.Controls.Add(optionControl);
            }
            return result;
        }

        /// <summary>
        /// Determines whether more than one option can be selected.
        /// If set to Multiple, options will be represented by checkboxes.
        /// If set to Single (default), options will be represented by radio buttons.
        /// Default: Single.
        /// </summary>
        public SelectionCardinality Cardinality { get; set; }

        /// <summary>
        /// If set to false and the SelectionCardinality is set to Multiple, 
        /// the Next button will not activate until at least one
        /// item has been selected. A selection is always required when
        /// the cardinality is set to Single. Default: true.
        /// </summary>
        public bool AllowSelectNone { get; set; }

        //When an option is checked or unchecked, updates the result
        private void checkUncheck(bool selection, string answer)
        {
            if (selection && !_selectedAnswers.Contains(answer))
            {
                _selectedAnswers.Add(answer);
            }
            if (!selection && _selectedAnswers.Contains(answer))
            {
                _selectedAnswers.Remove(answer);
            }
            StateUpdated();
        }


        public override bool AllowNext()
        {
            return base.AllowNext()
                && !(this.Cardinality == SelectionCardinality.Single && _selectedAnswers.Count == 0)
                && !(this.Cardinality == SelectionCardinality.Multiple && !this.AllowSelectNone && _selectedAnswers.Count == 0);
        }
        
    }
}
