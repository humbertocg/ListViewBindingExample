using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListviewBinding.ViewModels;
using Xamarin.Forms;

namespace ListviewBinding
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MainVM _viewModel;
        public MainPage()
        {
            InitializeComponent();
            _viewModel = new MainVM();
            BindingContext = _viewModel;
        }
    }
}
