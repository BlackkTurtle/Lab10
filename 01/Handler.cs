using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class Handler
    {
        public void DispatcherChangeName(object sender, NameChangeEventArgs result)
        {
            Console.WriteLine("Dispatcher's name changed to "+result.Name+".");
        }
    }
}
