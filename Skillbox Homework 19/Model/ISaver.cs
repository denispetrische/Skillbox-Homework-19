using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox_Homework_19.Model
{
    public interface ISaver
    {
        public void Save(string name, string age, string colour);
    }
}
