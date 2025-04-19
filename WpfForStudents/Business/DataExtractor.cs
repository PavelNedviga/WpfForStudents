using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfForStudents.Models;

namespace WpfForStudents.Business
{
    static class DataExtractor
    {
        static List<Record> initialCollection = new List<Record>()
            {
                new Record(1,"video", "video description", "mp4"),
                new Record(2,"audio", "audio description", "mp3"),
                new Record(3,"book", "book description", "epub"),
            };

        public static List<Record> GetRecords()
        {
            return initialCollection;
        }

        internal static void WriteRecords(ObservableCollection<Record> value)
        {
            initialCollection = value.ToList();
        }
    }
}
