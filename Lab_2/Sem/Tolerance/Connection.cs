using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sem;

namespace Sem.Tolerance
{
    internal class Connection
    {
        public Connection(Size otv, Size val) // Объявление в конструкторе перменных
        {
            _shaft = val;
            _hole = otv;
        }
        private Size? _shaft = null; // Объявление новых перменных
        private Size? _hole = null;
        private string type = "default";
        private decimal? smax = null;
        private decimal? smin = null;
        private decimal? nmax = null;
        private decimal? nmin = null;
        private decimal? snmax = null;
        private decimal? snmin = null;
        public string GetInfo() // Метод для вывода информации о виде посадки 
        {
            SetType();
            switch (type)
            {
                case "Посадка с зазором":
                    {
                        return "Посадка с зазором";
                    }
                case "Посадка с натягом":
                    {
                        return "Посадка с натягом";
                    }
                case "Переходная посадка":
                    {
                        return "Переходная посадка";
                    }
                default: { return "0"; }
            }
        }
        private void SetType() // Метод для определения вида посадки и расчета зазора-натяга
        {
            if (_hole.Es - _shaft.Ei > 0 && _hole.Ei - _shaft.Ei > 0)
            {
                type = "Посадка с зазором";
                smax = Convert.ToDecimal(_hole.Es - _shaft.Ei);
                smin = Convert.ToDecimal(_hole.Ei - _shaft.Es);
            }
            else if (_shaft.Ei - _hole.Es > 0 && _shaft.Es - _hole.Ei > 0)
            {
                type = "Посадка с натягом";
                nmax = Convert.ToDecimal(_shaft.Es - _hole.Ei);
                nmin = Convert.ToDecimal(_shaft.Ei - _hole.Es);
            }
            else if (_hole.Es - _shaft.Ei > 0 && _shaft.Es - _hole.Ei > 0)
            {
                type = "Переходная посадка";
                smax = Convert.ToDecimal(_hole.Es - _shaft.Ei);
                nmax = Convert.ToDecimal(_shaft.Es - _hole.Ei);
            }
        }
        private decimal? Smax
        {
            get { return smax; }
        }
        private decimal? Smin
        {
            get { return smin; }
        }
        private decimal? Nmax
        {
            get { return nmax; }
        }
        private decimal? Nmin
        {
            get { return nmin; }
        }
        public decimal? SNmax()
        {
            if (type == "Посадка с зазором")
            {
                snmax = smax; 
            }
            else if (type == "Посадка с натягом")
                snmax = nmax;
            else if (type == "Переходная посадка")
                snmax = smax;
            return snmax;
        }
        public decimal? SNmin()
        {
            if (type == "Посадка с зазором")
                snmin = smin;
            else if (type == "Посадка с натягом")
                snmin = nmin;
            else if (type == "Переходная посадка")
                snmin = nmax;
            return snmin;
        }
        private double? Probability() // Метод для расчета значения интеграла Ф(z)
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
        public double? ProbabilitySmax() // Метод для расчета вероятности зазора при переходной посадке
        {
            return 0.4986 + Probability();
        }
        public double? ProbabilityNmax() // Метод для расчета вероятности натяга при переходной посадке
        {
            return 1 - ProbabilitySmax();
        }
    }
}
