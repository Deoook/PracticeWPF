using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_App.Models
{
    public class Note : ObservableObject
    {
        private string _strFilePath = string.Empty;
        public string strFilePath
        {
            get => _strFilePath;
            set => SetProperty(ref _strFilePath, value);
        }

        private string _strContent = string.Empty;
        public string strContent
        {
            get => _strContent;
            set => SetProperty(ref _strContent, value);
        }
    }
}
