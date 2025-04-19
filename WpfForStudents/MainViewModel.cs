using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfForStudents
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        private int clicks;
        public int Clicks { 
            get { return clicks; } 
            set 
            { 
                clicks = value; 
                OnPropertyChanged();
                //OnPropertyChanged("Clicks");
                //OnPropertyChanged(nameof(Clicks));
            } 
        }

        public ICommand ClickAdd
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Clicks++;
                });
            }
        }

        public MainViewModel() 
        {
            //Task.Factory.StartNew(() =>
            //{
            //    while (true) 
            //    {
            //        Task.Delay(1000).Wait();
            //        Clicks++;
            //        //clicks++;
            //    }
            //});
        }
    }
}
