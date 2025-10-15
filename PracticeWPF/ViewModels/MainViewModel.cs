using PracticeWPF.Models;
using PracticeWPF.ViewModels.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IList<Person> _people;

        public IList<Person> People
        {
            get { return _people; }
            set { _people = value; }
        }

        private Person _selectedPerson;

        public Person  SelectedPerson
        {
            get { return _selectedPerson; }
            set { _selectedPerson = value; }
        }

        public MainViewModel()
        {
            People = new List<Person>
            {
                new Person{ID = 119302, Name = "r", Gender = true},
                new Person{ID = 114502, Name = "s", Gender = false},
                new Person{ID = 187402, Name = "e", Gender = true},
                new Person{ID = 015302, Name = "z", Gender = true},
                new Person{ID = 596302, Name = "s", Gender = true},
                new Person{ID = 187502, Name = "b", Gender = true},
                new Person{ID = 111548, Name = "s", Gender = false},
                new Person{ID = 187122, Name = "d", Gender = true},
            };
        }
    }
}
