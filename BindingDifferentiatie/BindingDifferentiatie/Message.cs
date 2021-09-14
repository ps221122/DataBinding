using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BindingDifferentiatie
{
    public class Message : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _result;

        public string Result
        {
            get { return _result; }
            set { _result = value; OnPropertyChanged(); }
        }


        public Message()
        {          
        }

        public void Show()
        {
            MessageBox.Show(Description, Title, MessageBoxButton.OK, MessageBoxImage.Information);
            Result = "Ok";
        }

    }
}
