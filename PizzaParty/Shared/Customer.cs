using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices; 
namespace PizzaParty.Shared
{
   public class Customer : INotifyDataErrorInfo, INotifyPropertyChanged
    {
        private string name;
        public event PropertyChangedEventHandler PropertyChanged; 

        public string Name
        {
            get { return name;
               
            }
            set { name = value; OnPropertyChanged(); }
        }


        private void OnPropertyChanged(
            [CallerMemberName] string propertyName = "")
        {
           
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public bool HasErrors => GetErrors(string.Empty).Any();
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
     

        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName) || propertyName == nameof(Name))
            {
                if (string.IsNullOrEmpty(Name))
                {
                    yield return $"A customers name is mandatory";
                }
                else if (Name.Contains("Pizza"))
                {
                    yield return $"Name should not contain \"Pizza\"";
                }
            }
            if (string.IsNullOrEmpty(propertyName) || propertyName == nameof(Street))
            {
                if (string.IsNullOrEmpty(Street))
                {
                    yield return $"{propertyName} is mandatory";
                }
            }
            if (string.IsNullOrEmpty(propertyName) || propertyName == nameof(City))
            {
                if (string.IsNullOrEmpty(City))
                {
                    yield return $"{propertyName} is mandatory";
                }
            }
        }

        public int Id { get; set; }
   
        public string Street { get; set; }
        public string City { get; set; }
        
    }
}
