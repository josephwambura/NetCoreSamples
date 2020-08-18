using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfAppMVVM.Models;
using WpfAppMVVM.ViewModels;
using WpfAppMVVM.Views;

namespace WpfAppMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    //public partial class App : Application
    //{

    //}

    internal sealed partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var history = new ObservableCollection<string>();
            var model = new ConverterModel(s => s.ToUpper(), history);
            var converterPresenter = new ConverterPresenter(model, history);
            var mainWindow = new MainWindow { DataContext = converterPresenter };

            mainWindow.Show();
        }
    }
}
