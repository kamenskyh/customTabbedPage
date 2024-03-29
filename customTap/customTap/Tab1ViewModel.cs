﻿using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace customTap
{
    public class Tab1ViewModel : BaseViewModel, IIconChange
    {

        public Tab1ViewModel()
        {
           // Title = "Tab1";
        }

        bool isSelected;
        public bool IsSelected
        {
            get => isSelected;
            set
            {
                if (SetProperty(ref isSelected, value))
                    OnPropertyChanged(nameof(CurrentIcon));
            }
        }
        public string CurrentIcon
        {
            get => IsSelected ? "favorite_icon.png" : "driver_icon.png";
        }
    }
}
