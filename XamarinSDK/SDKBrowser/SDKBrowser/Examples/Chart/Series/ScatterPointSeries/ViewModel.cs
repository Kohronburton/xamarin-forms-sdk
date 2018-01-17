﻿using System;
using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.Chart.Series.ScatterPointSeries
{
    public class ViewModel
    {
        public ObservableCollection<NumericalData> Data1 { get; private set; }
        public ObservableCollection<NumericalData> Data2 { get; private set; }

        public ViewModel()
        {
            this.Data1 = new ObservableCollection<NumericalData>(DataProvider.GetNumericData());
            this.Data2 = new ObservableCollection<NumericalData>(DataProvider.GetNumericData2());
        }
    }
}
