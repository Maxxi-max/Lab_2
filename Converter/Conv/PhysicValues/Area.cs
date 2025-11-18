using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhysicsValuesLib.PhysicValues
{
    internal class Area : BaseValue
    {
        public Area()
        {
            Name = "Площадь";
            Coeff = new Dictionary<string, double>
            {
                { "Метры квадратные",        1             },
                { "Километры квадратные",    1000          },
                { "Сантиметры квадратные",   0.01       },
                { "Дециметры квадратные",    0.1        },
                { "Миллиметры квадратные",   0.001      },
                { "Микрометры квадратные",   0.000001   },
            };
        }
    }
}
