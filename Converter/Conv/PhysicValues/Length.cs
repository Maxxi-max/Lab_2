using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsValuesLib.PhysicValues
{
    internal class Length : BaseValue
    {
        public Length()
        {
            Name = "Длина";
            Coeff = new Dictionary<string, double>
            {
                { "Метры",        1             },
                { "Километры",    1000          },
                { "Сантиметры",   0.01       },
                { "Дециметры",    0.1        },
                { "Миллиметры",   0.001      },
                { "Микрометры",   0.000001   },
            };
        }
    }
}
