using Microsoft.Extensions.DependencyInjection;
using OrchidCavalry.Services;
using OrchidCavalry.ViewModels;
using System;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace OrchidCavalry
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var serviceProvier = this.RegisterServices();

            this.DataContext = serviceProvier.GetService<MainViewModel>();
        }


        private IServiceProvider RegisterServices()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IFileWriter, FileWriter>();
            serviceCollection.AddTransient<Newtonsoft.Json.JsonSerializer>();


            serviceCollection.AddTransient<MainViewModel>();

            return serviceCollection.BuildServiceProvider();
        }

    }
}
