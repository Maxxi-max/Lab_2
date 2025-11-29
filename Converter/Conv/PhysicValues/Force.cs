using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsValuesLib.PhysicValues
{
    internal class Force : BaseValue
    {
        public Force()
        {
            Name = "Сила";
            Coeff = new Dictionary<string, double>
            {
                { "Ньютон",        1             },
                { "КилоНьютон",    1000          },
                { "МегаНьютоны",   1000000  },
            };
        }
    }
}
