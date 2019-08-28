using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ListviewBinding.Models;
using MvvmHelpers;
using Xamarin.Forms;

namespace ListviewBinding.ViewModels
{
    public class MainVM : BaseViewModel
    {
        public ObservableRangeCollection<ItemVM> Items { get; set; }
        public MainVM()
        {
            var items = new List<Item>();
            items.Add(new Item { Title = "Test1" });
            items.Add(new Item { Title = "Test2" });
            items.Add(new Item { Title = "Test3" });
            Items = new ObservableRangeCollection<ItemVM>();
            foreach(var item in items)
            {
                var itemVM = new ItemVM(item);
                itemVM.ButtonCommand = new Command<ItemVM>(async (obj) => await ButtonAction(obj));
                Items.Add(itemVM);
            }
        }

        private async Task ButtonAction(ItemVM obj)
        {
            await Application.Current.MainPage.DisplayAlert("Button Click", "item " + obj.TitleItem+" was clicked","ok");
        }
    }
}
