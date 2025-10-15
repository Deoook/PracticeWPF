using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PracticeWPF.ViewModels.Bases
{
    public class ViewModelBase : ObservableObject
    {
        private BitmapSource myVar;

        public BitmapSource MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
    }
}
