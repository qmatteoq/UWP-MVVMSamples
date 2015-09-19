using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace CaliburnMicro.Basic.ViewModels
{
    public class MainViewModel: Screen
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                NotifyOfPropertyChange();
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        private string _message;

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                NotifyOfPropertyChange();
            }
        }

        public void SayHello()
        {
            Message = $"Hello {Name}";
        }

        public bool CanSayHello
        {
            get { return !string.IsNullOrEmpty(Name); }
        }
    }
}
