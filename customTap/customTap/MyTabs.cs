﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace customTap
{
    public class MyTabs : TabbedPage
    {

        public event EventHandler UpdateIcons;

        Page currentPage;
        public MyTabs()
        {
            Children.Add(new TabIconsPage()
            {

            });

            Children.Add(new TabIconsPage2()
            {

            });

            currentPage = Children[0];

            this.CurrentPageChanged += Handle_CurrentPageChanged;

        }

        void Handle_CurrentPageChanged(object sender, EventArgs e)
        {
            var currentBinding = currentPage.BindingContext as IIconChange;
            if (currentBinding != null)
                currentBinding.IsSelected = false;

            currentPage = CurrentPage;
            currentBinding = currentPage.BindingContext as IIconChange;
            if (currentBinding != null)
                currentBinding.IsSelected = true;

            UpdateIcons?.Invoke(this, EventArgs.Empty);
        }
    }
}
