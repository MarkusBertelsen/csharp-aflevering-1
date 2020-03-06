using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Aflevering
{
    class User : INotifyPropertyChanged
    {
        public int id;
        public int Id { 
            set {
                id = value;
                NotifyPropertyChanged(nameof(ListBoxToString));
            }
            get { return id; }
        }
        public string name;
        public string Name {
            set {
                name = value;
                NotifyPropertyChanged(nameof(ListBoxToString));
            }
            get { return name; }
        }
        public int age { get; set; }
        public int score { get; set; }

        public User(int id, string name, int age, int score)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.score = score;
        }

        public string ListBoxToString { get { return name + ", id: " + id; } }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
