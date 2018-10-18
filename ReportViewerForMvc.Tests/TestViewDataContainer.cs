using System.Web.Mvc;

namespace ReportViewerForMvc.Tests
{
    public class TestViewDataContainer : IViewDataContainer
    {
        private ViewDataDictionary viewData = new ViewDataDictionary();
        public ViewDataDictionary ViewData
        {
            get
            {
                return this.viewData;
            }
            set
            {
                this.viewData = value;
            }
        }
    }
}
