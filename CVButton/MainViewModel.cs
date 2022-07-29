using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CVButton
{
     public class MainViewModel
     {
          public ObservableCollection<DataItem> Items { get; set; }

          public ICommand GetDataCommand =>
               new Command((x) =>
               {
                    var i = x as DataItem;
               });

          public MainViewModel()
          {
               Items = new ObservableCollection<DataItem>
               {
                    new DataItem
                    {
                         Name = "Héctor"
                    },
                    new DataItem
                    {
                         Name = "John"
                    },
                    new DataItem
                    {
                         Name = "Peter"
                    },
               };
          }
     }

     public class DataItem
     {
          public string Name { get; set; }
     }
}
