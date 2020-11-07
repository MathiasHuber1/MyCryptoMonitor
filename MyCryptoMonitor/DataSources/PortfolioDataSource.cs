﻿using System.ComponentModel;

namespace MyCryptoMonitor.DataSources
{
    public class PortfolioDataSource
    {
        public string FileName { get; set; }
        public string Name { get; set; }
        public bool Startup { get; set; }
    }

    public class PortfolioDataSourceList : BindingList<PortfolioDataSource> { }
}