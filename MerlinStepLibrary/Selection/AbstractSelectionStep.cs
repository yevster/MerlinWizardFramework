using System;
using System.Collections.Generic;
using System.Text;

using Merlin;

using System.Windows.Forms;

namespace MerlinStepLibrary.Selection
{
    /// <summary>
    /// A selection step adaptable to work for options of any data type
    /// </summary>
    /// <typeparam name="ResultType"></typeparam>
    public class AbstractSelectionStep<ResultType> : TemplateStep
    {
        /// <summary>
        /// A delegate that will generate a control representing the available options.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public delegate Control RendererDelegate(IEnumerable<ResultType> options);
        public delegate IList<ResultType> SelectionResultDelgate();
        private Control _ui = null;

        /// <summary>
        /// Creates a new AbstractSelectionStep.
        /// </summary>
        /// <param name="renderer"></param>
        /// <param name="resultDelegate"></param>
        /// <param name="options"></param>
        protected AbstractSelectionStep(IEnumerable<ResultType> options, string prompt)
        {
            var allOptions = new List<ResultType>();
            allOptions.AddRange(options);
            this.Options = allOptions;
            this.PromptText = prompt;
        }

        /// <summary>
        /// Creates a new AbstractSelectionStep.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="prompt"></param>
        /// <param name="renderer">A function to generate a UI control representing the available options.</param>
        /// <param name="resultDelegate">A function that returns the options that were selected</param>
        /// <param name="preselected">A list of options selected at initialization</param>
        public AbstractSelectionStep(RendererDelegate renderer, SelectionResultDelgate resultDelegate,
            IEnumerable<ResultType> options, string prompt)
            : this(options, prompt)
        {
            this.Renderer = renderer;
            this.ResultDelegate = resultDelegate;
        }

        /// <summary>
        /// Gets the renderer delgate.
        /// </summary>
        public RendererDelegate Renderer { get; protected set; }

        protected SelectionResultDelgate ResultDelegate { private get; set; }

        protected IList<ResultType> Options { get; private set; }

        /// <summary>
        /// Gets or sets the text of the question presented to the user at the 
        /// top of the step display, such as "Please select one of the following options:".
        /// Note: Changing this setting when the step is already displayed will
        /// not update the displayed prompt.
        /// </summary>
        public string PromptText { get; set; }

        /// <summary>
        /// Gets or sets the selected result. Changing this value
        /// while the step is displayed will not update the selected 
        /// value in the step's UI. Changes to the selection in the UI
        /// will not be reflected in the property until the user clicks
        /// Next or Finish in the wizard.
        /// </summary>
        public IList<ResultType> Selected
        {
            get
            {
                if (this.ResultDelegate == null)
                {
                    throw new NotImplementedException("Selection result delegate not specified. "
                        + "This step was not implemented properly.");
                }
                return this.ResultDelegate();
            }
        }

        public override Control UI
        {
            get
            {
                if (null == _ui) _ui = new AbstractUI(this.PromptText, Renderer(this.Options));
                return _ui;
            }
        }

    }
}
