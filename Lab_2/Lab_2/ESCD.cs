using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Lab_2;

namespace Lab_2
{
    public class ESCD
    {
        private float? D = null;
        private float? d = null;
        private float? ESS = null;
        private float? EII = null;
        private float? ess = null;
        private float? eii = null;
        public float? Diam 
        {
            set
            {
                if (value > 0)
                    D = value;
            }
            get { return D;  }
        }
        public float? ES
        {
            set
            {
                    ESS = value;
            }
            get { return ESS; }
        }
        public float? EI
        {
            set { EII = value;}
            get { return EII; }
        }
        public float? es
        {
            set
            {
                
                    ess = value;
            }
            get { return ess; }
        }
        public float? ei
        {
            set
            {
               
                    eii = value;
            }
            get { return eii; }
        }
        public float? diam
        {
            set
            {
                if (value > 0)
                    d = value;
            }
            get { return d; }
        }

        public void PrintDmax() => Console.WriteLine($"\nhМаксимальный диаметр отверстия: {D + ESS}");
        public void PrintDmin() => Console.WriteLine($"Минимальный диаметр отверстия: {D + EII}");
        public void Printdmax() => Console.WriteLine($"Максимальный диаметр вала: {d + ess}");
        public void Printdmin() => Console.WriteLine($"Максимальный диаметр вала: {d + eii}");
        public void PrintTD() => Console.WriteLine($"Допуск отверстия: {ESS - EII}");
        public void Printtd() => Console.WriteLine($"Допуск вала: {ess - eii}");
        public void PrintPosad() {
            if (ESS - eii > 0 && EII - ess > 0)
            {
                Console.WriteLine("Посадка с зазором");
                Console.WriteLine($"Максимальный зазор: {ESS - eii}");
                Console.WriteLine($"Минимальный зазор: {EII - ess}");
            }
            else if (eii - ESS > 0 && ess - EII > 0)
            {
                Console.WriteLine("Посадка с натягом");
                Console.WriteLine($"Максимальный натяг: {ess - EII}");
                Console.WriteLine($"Минимальный натяг: {eii - ESS}");
            }
            else if (ESS-eii>0 && ess - EII>0) {
                Console.WriteLine("Переходная посадка");
                Console.WriteLine($"Максимальный зазор: {ESS - eii}");
                Console.WriteLine($"Максимальный натяг: {ess - EII}");
            }
        }
    }
}
