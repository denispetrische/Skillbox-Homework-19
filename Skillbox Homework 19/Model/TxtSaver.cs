using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox_Homework_19.Model
{
    class TxtSaver : ISaver
    {
        public void Save(string name, string age, string colour)
        {
            using (StreamWriter sw = new StreamWriter($"{name}{age}{colour}.txt"))
            {
                
            }
        }
    }
}
