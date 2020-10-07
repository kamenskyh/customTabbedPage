using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace customTap
{
    public class Tab2ViewModel : BaseViewModel, IIconChange
    {

        public Tab2ViewModel()
        {
          //  Title = "Tab2";
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
            get => IsSelected ? "favorite_icon.png" : "assis_icon.png";
        }
    }
}
