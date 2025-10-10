using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab_2
{
    internal class Connection
    {
        public Connection(Size otv, Size val) 
        {
            _shaft = val;
            _hole = otv;
        }
        private Size? _shaft = null;
        private Size? _hole = null;
        private string type = "default";
        private double? smax = null;
        private double? smin = null;
        private double? nmax = null;
        private double? nmin = null;
        public string GetInfo()
        {
            switch (type)
            {
                case "Посадка с зазором":
                    {
                        return $"Посадка с зазором: Smax = {smax} Smin = {smin}";
                    }
                case "Посадка с натягом":
                    {
                        return $"Посадка с натягом: Smax = {nmax} Smin = {nmin}";
                    }
                case "Переходная посадка":
                    {
                        return $"Переходная посадка: Smax = {smax} Smin = {nmax}";
                    }
                default: { return "0"; }
            }
        }
        private void SetType()
        {
            if (_hole.Es - _shaft.Ei > 0 && _hole.Ei - _shaft.Ei > 0)
            {
                type = "Посадка с зазором";
                smax = _hole.Es - _shaft.Ei;
                smin = _hole.Ei - _shaft.Es;
            }
            else if (_shaft.Ei - _hole.Es > 0 && _shaft.Es - _hole.Ei > 0)
            {
                type = "Посадка с натягом";
                nmax = _shaft.Es - _hole.Ei;
                nmin = _shaft.Ei - _hole.Es;
            }
            else if (_hole.Es - _shaft.Ei > 0 && _shaft.Es - _hole.Ei > 0)
            {
                type = "Переходная посадка";
                smax = _hole.Es - _shaft.Ei;
                nmax = _shaft.Es - _hole.Ei;
            }
        }
        private double? Smax
        {
            get { return smax; }
        }
        private double? Smin
        {
            get { return smin; }
        }
        private double? Nmax
        {
            get { return nmax; }
        }
        private double? Nmin
        {
            get { return nmin; }
        }
        private double? Probability()
        {
            double? Mx = (_shaft.Es + _shaft.Ei) / 2 - (_hole.Es + _hole.Ei) / 2;
            double? Sigma = 1.0 / 6 * Math.Sqrt(Math.Pow(((double)_shaft.Es + (double)_shaft.Ei), 2) + Math.Pow(((double)_hole.Es + (double)_hole.Ei), 2));
            double? z = Mx / Sigma;
            int? h = 1000;
            double? Fx = 0;
            double? xp, y, s, result = 0, g = (z - 0) / h;
            for (int i = 0; i < h; i++)
            {
                xp = 0 + g;
                y = Math.Pow(2.71, (-Math.Pow((double)z, 2) / 2));
                s = g * y;
                Fx += s;
            }
            double? Fz = 1.0 / Math.Sqrt((2 * 3.14)) * Fx;
            return Fz;
        }
        public double? ProbabilitySmax() 
        {
            return 0.4986 + Probability();
        }
        public double? ProbabilityNmax()
        {
            return 1 - ProbabilitySmax();
        }
    }
}
