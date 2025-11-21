using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem.Tolerance
{
    internal class Size
    {
        public Size(string type, double nominal, double es, double ei) // Объявление в конструкторе переменных из ввода данных
        {
            Nominal = nominal;
            Es = es;
            Ei = ei;
            Dtype = type;
        }
        double? _nominal = null; // Объявление новых перменных
        double? _es = null;
        double? _ei = null;
        string _type = "default";

        public string? Dtype
        {  // Опеределение типа диаметра вал/отверстие
            get { return _type; }
            private set
            {
                if (value == "вал")
                    _type = value;
                else if (value == "отверстие")
                    _type = value;
            }
        }
        public double? Nominal // Объявление и проверка всех введенных значений
        {
            private set
            {
                if (value > 0)
                    _nominal = value;
            }
            get { return _nominal; }
        }
        public double? Es
        {
            private set
            {
                _es = value;
            }
            get { return _es; }
        }
        public double? Ei
        {
            private set { _ei = value; }
            get { return _ei; }
        }
        public double? Dmax() // Метод максимального диаметра
        {
            double? Dmax = _nominal + _es;
            return Dmax;
        }
        public double? Dmin() // Метод минимального диаметра
        {
            double? Dmin = _nominal + _ei;
            return Dmin;
        }
        public double? TD() // Метод допуска
        {
            double? TD = _es - _ei;
            return TD;
        }
    }
}
