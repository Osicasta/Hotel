using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Clases
{
    public class Sistema
    {
        //Atributos
        private Cliente cliente =  new Cliente();
        private Habitacion habitacion = new Habitacion();
        private Boolean Estado_reserva;

        //Metodos
        public int Calcular_costo() 
        {
            return 0;
        }
        public Boolean Confirmar_reserva() 
        {
            return true;        
        }
        public Boolean Cancelar_reserva() 
        {
            return true;
        }
    }
}
