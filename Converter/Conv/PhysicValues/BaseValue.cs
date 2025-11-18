using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsValuesLib.PhysicValues
{
    internal class BaseValue : IValue
    {
        private string _name = "Default";
        public string GetValueName()
        {
            return _name;
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }
        // словарь переводных коэффициентов
        private Dictionary<string, double> _coeff = new Dictionary<string, double>()
        {
            { "default",   0   },
        };
        // свойство для переопределения словаря коэффициентов
        // в классах-наследниках
        protected Dictionary<string, double> Coeff
        {
            get => _coeff;
            set
            {
                _coeff = value;
            }
        }
        // список единиц измерения из словаря коэффициентов
        public List<string> GetMeasureList()
        {
            List<string> list = new List<string>();
            foreach (var str in _coeff)
            {
                list.Add(str.Key);
            }
            return list;
        }
        // функция конвертации
        public decimal GetConvertedValue
            (double value, string from, string to)
        {
            decimal inSi = (decimal)value * (decimal)_coeff[from];     // переводим в СИ
            decimal required = (decimal)inSi / (decimal)_coeff[to];    // переводим в нужные единицы
            return required;
        }
    }
}
