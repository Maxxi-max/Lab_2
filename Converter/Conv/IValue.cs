using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsValuesLib
{
    internal interface IValue
    {
        string GetValueName();
        List<string> GetMeasureList();
        decimal GetConvertedValue(double value, string from, string to);
    }
}
