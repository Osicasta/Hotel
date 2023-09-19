using System;

namespace Hotel
{
    class Hotel
    {
        // Atributos
        private string nombre;
        private string direccion;
        private int categoria;

        // Métodos
        public string HabitacionesDisponibles()
        {
            // Implementación
            return "";
        }
    }

    class Habitacion
    {
        // Atributos
        private int id;
        private string tipoHabitacion;
        private int numeroCamas;
        private int numeroBannos;
        private int precioNoche;
        private bool disponible;

        // Métodos
        public string VerificarDisponibilidad()
        {
            // Implementación
            return "";
        }

        public bool ReservarHabitacion()
        {
            // Implementación
            return false;
        }

        public bool LiberarHabitacion()
        {
            // Implementación
            return false;
        }
    }

    class Recepcionista
    {
        // Atributos
        private string nombre;
        private string apellido;

        // Métodos
        public bool HacerCheckIn()
        {
            // Implementación
            return false;
        }

        public bool HacerCheckOut()
        {
            // Implementación
            return false;
        }
    }

    class Cliente
    {
        // Atributos
        private string nombre;
        private int contacto;

        // Métodos
        public bool HacerReserva()
        {
            // Implementación
            return false;
        }

        public bool CancelarReserva()
        {
            // Implementación
            return false;
        }
    }

    class Sistema
    {
        // Atributos
        private Cliente cliente;
        private Habitacion habitacion;
        private bool estadoReserva;

        // Métodos
        public int CalcularCosto()
        {
            // Implementación
            return 0;
        }

        public bool ConfirmarReserva()
        {
            // Implementación
            return false;
        }

        public bool CancelarReserva()
        {
            // Implementación
            return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hotel Armony Springs");
        }
    }
}
