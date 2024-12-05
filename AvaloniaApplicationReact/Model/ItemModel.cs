using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplicationReact.Models
{
    public class ItemModel: ReactiveObject
    {
        //Simple
        //public string Name { get; set; }

        //Changable
        private string _name;

        public string Name
        {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }
    }
}
