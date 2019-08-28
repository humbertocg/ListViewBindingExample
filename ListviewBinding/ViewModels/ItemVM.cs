using System;
using System.Windows.Input;
using ListviewBinding.Models;
using MvvmHelpers;

namespace ListviewBinding.ViewModels
{
    public class ItemVM : BaseViewModel
    {
        private Item _item;

        public string TextEntry { get; set; }

        public ICommand ButtonCommand { get; set; }

        public string TitleItem => _item?.Title;

        public ItemVM(Item item)
        {
            _item = item;
        }
    }
}
