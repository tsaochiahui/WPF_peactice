using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    internal class PersonViewModel
    {

        public PersonViewModel()
        {
            Persons = new ObservableCollection<Person>
            { new Person {Name= "Eric", gender="man",age=18,tel=123},
            new Person { Name = "Josh", gender = "man", age = 19, tel = 456 },
            new Person { Name = "Ady", gender = "man", age = 20, tel = 789 }
            };

        }
        public ObservableCollection<Person> Persons { get; set; }

        public Person SelectedPerson { get; set; }
    }

}
