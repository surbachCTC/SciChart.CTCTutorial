using System;
using SciChart.Charting.Model.ChartSeries;

namespace SciChart.CTCTutorial
{
    public class InfoAnnotationViewModel : CustomAnnotationViewModel
    {
        public override Type ViewType
        {
            get { return typeof(InfoAnnotation); }
        }
    }
}

