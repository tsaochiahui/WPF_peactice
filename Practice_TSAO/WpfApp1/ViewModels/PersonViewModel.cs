using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;
using System.Collections.ObjectModel;
using WpfApp1.ViewModels;

namespace WpfApp1
{
    public class PersonViewModel: ViewModelBase
    {
        

        public PersonViewModel()
        {
            Persons = new ObservableCollection<Person>
            { new Person {Name= "Eric", Gender="man",Age=18,Tel=123},
            new Person { Name = "Josh", Gender = "man", Age = 19, Tel = 456 },
            new Person { Name = "Ady", Gender = "man", Age = 20, Tel = 789 }
            };

        }
        public ObservableCollection<Person> Persons { get; set; }


        //public ObservableCollection<Person> Persons
        //{
        //    get
        //    {
        //        return _people;
        //    }
        //    set
        //    {
        //        if (_people != value)
        //        {
        //            _people = value;
                    
        //        }
        //    }
        //}

        

        public Person SelectedPerson { get; set; }
    }

}
