using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_2.Pages
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }



        public double Calculo_SFS(double Salario)
        {
            if (Salario <= 4098.53)
            {
                return Salario * 0.0304;
            }
            else return 4098.53;
                 
        }

        public double Calculo_AFP(double Salario)
        {
            if (Salario <= 7738.67)
            {
                return Salario * 0.0287;
            }
            else return 7738.67;

        }

        public double Calculo_ISR(double Salario)
        {
            if (Salario * 12 > 416220.01 && Salario * 12 <= 624329.00)
            {
                return Math.Round((((Salario * 12) - 416220.00) * 0.15) / 12);
            }
            else if (Salario * 12 > 624329.01 && Salario * 12 <= 867123.00)
            {
                return Math.Round(((((Salario * 12) - 624329.01) * 0.20) + 31216.00) / 12);
            }
            else if (Salario * 12 > 867123.01)
            {
                return Math.Round(((((Salario * 12) - 867123.01) * 0.25) + 79776.00) / 12);
            }
            else return 0.00;

        }
    }
}
