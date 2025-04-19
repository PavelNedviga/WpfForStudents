using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfForStudents
{
    class MainViewModel : ViewModelBase
    {
        public ObservableCollection<Record> Records { get; set; } = new ObservableCollection<Record>() 
        { 
            new Record(1,"video", "video description", "mp4"),
            new Record(2,"audio", "audio description", "mp3"),
            new Record(3,"book", "book description", "epub"),
        };
        public Record SelectedRecord {get;set;}

        public int Clicks { get; set; }

        public ICommand ClickAdd
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Clicks++;
                }, obj => Clicks <= 10);
            }
        }

        public MainViewModel() 
        {

        }
    }
}
