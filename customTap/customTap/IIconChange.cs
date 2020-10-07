using System;
using System.Collections.Generic;
using System.Text;

namespace customTap
{
    public interface IIconChange
    {
        bool IsSelected { get; set; }
        string CurrentIcon { get; }
    }
}
