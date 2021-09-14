using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace dataBiding
{
    public class Main : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string _number;


        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }


        private int _result;

        private int _result2;
        public int Result
        {
            get { return _result; }
            set { _result = value; OnPropertyChanged(); }
        }

        public int Result2
        {
            get { return _result2; }
            set { _result2 = value; OnPropertyChanged(); }
        }


        public Main()
        {
        }
        public void Show()
        {
            Random random = new Random();


            Result = random.Next(1, 7);
            Result2 = random.Next(1, 7);
            // MessageBox.Show(Number, MessageBoxButton.OK, MessageBoxImage.Information);
            //Result = random;
        }

        private string _tex1;
        public string Message1
        {
            get { return _tex1; }
            set { _tex1 = value; OnPropertyChanged(); }
        }


        private string _tex2;

        public string Message2
        {
            get { return _tex2; }
            set { _tex2 = value; OnPropertyChanged(); }
        }

        private string _tex3;

        public string Message3
        {
            get { return _tex3; }
            set { _tex3 = value; OnPropertyChanged(); }
        }

        private string _tex4;

        public string Message4
        {
            get { return _tex4; }
            set { _tex4 = value; OnPropertyChanged(); }
        }
        public void show()
        {
            string text = Message4;
            Message4 = Message3;
            Message3 = Message2;
            Message2 = Message1;
            Message1 = text;

        }
        /// <summary>
        /// 
        /// </summary>
        private string _style = "red";

        public string colors
        {
            get { return _style; }
            set { _style = value; OnPropertyChanged(); }
        }

        public void Styles1()
        {

            switch (colors)
            {
                case "red":
                    colors = "white";
                    break;
                case "white":
                    colors = "blue";
                    break;
                case "blue":
                    colors = "red";
                    break;
                default:
                    colors = "orange";
                    break;
            }
        }

        private string _X;


        public string MessageR
        {
            get { return _X; }
            set { _X = value; OnPropertyChanged(); }
        }

        private string _text;

        public string Message5
        {
            get { return _text; }
            set { _text = value; }
        }

        public void Shows()
        {
            MessageR = "Welkom" + ':' +  Message5;
        }
    }
}
