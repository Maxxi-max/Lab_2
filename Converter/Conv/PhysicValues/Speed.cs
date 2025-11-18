using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhysicsValuesLib.PhysicValues
{
    internal class Speed : BaseValue
    {
        public Speed()
        {
            Name = "Скорость";
            Coeff = new Dictionary<string, double>
            {
                { "Метры в секунду",        1          },
                { "Километры в час",    1.0/3.6       },
                { "Километры в",   1000       },
                { "Мили в час",        1.0/2.24        },
                { "Узлы",        1.0/1.94        },
                { "Скорость света",   1.0/3.34*0.000000001   },
            };
        }
    }
}
