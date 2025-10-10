using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Size
    {
        public Size(string type, double nominal, double es, double ei) 
        {
            Nominal = nominal;
            Es = es;
            Ei = ei;
            Dtype = type;
        }
        double? _nominal = null;
        double? _es = null;
        double? _ei = null;
        string _type = "default";
        
        public string? Dtype { 
            get { return _type; }
            private set {
                if (value == "вал")
                    _type = value;
                else if (value == "отверстие")
                    _type = value;
             } 
        }
        public double? Nominal
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
        public double? Dmax() 
        {
            double? Dmax = _nominal + _es;
            return Dmax;
        }
        public double? Dmin()
        {
            double? Dmin = _nominal + _ei;
            return Dmin;
        }
        public double? TD()
        {
            double? TD = _es - _ei;
            return TD;
        }
    }
}

