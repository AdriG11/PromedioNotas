using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioNotas
{
    public class Promedio
    {
        // Atributos
        public string Nombre;
        public int Nota1;
        public int Nota2;
        public int Nota3;
        public int Nota4;
            
           //Metodos
           
        public double NotaBaja()
        {
            int menor =  int.MaxValue;
            if (Nota1 < Nota2) menor = Nota1; else menor = Nota2;
            if (Nota3 < menor) menor = Nota3;
            if (Nota4 < menor) menor = Nota4;
            return menor;

        }

        public double promedio()
        {
            return (Nota1 + Nota2 + Nota3 + Nota4 - NotaBaja()) / 3.0;
        }

        public string condicion ()
        {
            double prome = promedio();
            if (prome <= 5 )
            {
                return "DESAPROBADO";
            } else if (prome > 7 && prome <=7.5 )
            {
                return "RECUPERACION";
            }
            else
            {
                return "APROBADO";
            }

        }
    }
}
