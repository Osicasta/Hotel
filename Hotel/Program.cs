using System;

namespace Hotel // Note: actual namespace depends on the project name.
{

    class Hotel {

        //Atributos
        private String nombre;
        private String Direccion;
        private int Categoria;

        //Metodos
        public string Habitaciones_disponibles() { };

    }


    class Habitacion {

        //Atributos
        private int ID;
        private String Tipo_habitacion;
        private int Numero_camas;
        private int Numero_bannos;
        private int Precio_noche;
        private Boolean Disponible;


        //Metodos
        public string Verificar_disponibilidad() { }

        public Boolean Reservar_habitacion() { }

        public Boolean Librar_habitacion() { }



    }

    class Recepcionista {

        //Atributos
        private String Nombre;
        private String Apellido;

        //Metodos
        public Boolean Hacer_checkIn() { }
        public Boolean Hacer_checkOut() { }


    }


    class Cliente{

        //Atributos
        private String Nombre;
        private int Contacto;

        //Metodos
        public Boolean Hacer_reserva() { }
        public Boolean Cancelar_reserva() { }


    }

    class Sistema{

        //Atributos
        private Cliente = new Cliente();
        private Habitacion = new Habitacion();
        private Boolean Estado_reserva;

        //Metodos
        public int Calcular_costo() { }
        public Boolean Confirmar_reserva() { }
        public Boolean Cancelar_reserva() { }
    }   




    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hotel Armony Springs");
        }
    }
}