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
using WpfForStudents.Models;
using WpfForStudents.Business;

namespace WpfForStudents
{
    class MainViewModel : ViewModelBase
    {
        public ObservableCollection<Record> Records { get 
            {
                return new ObservableCollection<Record>(DataExtractor.GetRecords()
                    .Where(t=>t.Id <=1).ToList());
            }
            set
            {
                DataExtractor.WriteRecords(value);
            }
        } 
        public Record SelectedRecord {get;set;}

        public int Clicks { get; set; }

        public ICommand ClickAdd
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    Clicks++;
                    var rec = Records.ToList();
                    rec.Append(new Record(4, "series", "series description", "mp4"));
                    Records = new ObservableCollection<Record>(rec);
                }, obj => Clicks <= 10);
            }
        }

        public MainViewModel() 
        {
        }
    }
}
