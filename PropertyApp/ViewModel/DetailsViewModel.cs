﻿using PropertyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PropertyApp.ViewModel
{
    public class DetailsViewModel : BaseViewModel
    {
        public Property SelectedProperty { get; set; }
        public List<string> PropertyImages { get; set; }
        public int MoreItems { get; set; }
        public ICommand CloseCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());
    }
}
