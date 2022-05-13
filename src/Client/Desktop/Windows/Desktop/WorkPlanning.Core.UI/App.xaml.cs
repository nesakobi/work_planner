using MugenMvvmToolkit.WPF.Binding;
using Prism.Ioc;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WorkPlanning.Core.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        public App()
        {
            WpfDataBindingExtensions.InitializeFromDesignContext();
        }

        protected override Window CreateShell()
        {
            MainWindow window = new MainWindow();
            window.Show();
            return window;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

        }
    }
}
