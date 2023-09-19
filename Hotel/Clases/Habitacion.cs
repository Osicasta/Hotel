using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Clases
{
    public class Habitacion
    {
       //Atributos
       private int ID;
       private String Tipo_habitacion;
       private int Numero_camas;
       private int Numero_bannos;
       private int Precio_noche;
       private Boolean Disponible;


       //Metodos
       public string Verificar_disponibilidad() 
        {
            return "";
        }

       public Boolean Reservar_habitacion() 
        {
            return true;
        }

       public Boolean Librar_habitacion() 
        {
            return true;
        }
    }
}
