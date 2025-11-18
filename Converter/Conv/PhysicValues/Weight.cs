using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhysicsValuesLib.PhysicValues
{
    internal class Weight : BaseValue
    {
        public Weight()
        {
            Name = "Масса";
            Coeff = new Dictionary<string, double>
            {
                { "Граммы",        1             },
                { "Килограммы",    1000          },
                { "Центнеры",        100000             },
                { "Тонны",        1000000             },
                { "Милиграммы",   0.001      },
                { "Микрограммы",   0.000001   },
            };
        }
    }
}
