using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MIT_App.Views
{
    class ViewModels
    {
        public Int32Rect SourceRect { set; get; }
        public ViewModels()
        {
            this.SourceRect = new Int32Rect(0, 0, 1000, 1000);
        }
    }
}
