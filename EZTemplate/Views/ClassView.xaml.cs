using EZAppMaker.Support;
using EZAppMaker.Components;

namespace EZTemplate.Views
{
    public partial class ClassView : EZContentView
    {
        public ClassView()
        {
            InitializeComponent();
        }

        public override bool OnBeforeLeaving()
        {
            return EZApp.ValidateRequired(this, out VisualElement failed);
        }
    }
}

