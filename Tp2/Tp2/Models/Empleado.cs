using System;

namespace Tp2.Models
{
    public class Empleado
    {
        private const float SUELDO_BASE = 15000;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int edad;
        private string telefono;
        private string domicilio;
        private string rol;
        private DateTime fechaIngreso;
        private int antiguedad;
        private double salario;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Rol { get => rol; set => rol = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public int Edad { get => edad;}
        public int Antiguedad { get => antiguedad;}
        public double Salario { get => salario;}

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, string tel, string domicilio, string rol, DateTime fechaIngreso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            telefono = tel;
            this.domicilio = domicilio;
            this.rol = rol;
            this.fechaIngreso = fechaIngreso;

            edad = calcularEdadOAntiguedad(fechaNacimiento);
            antiguedad = calcularEdadOAntiguedad(fechaIngreso);
            salario = calcularSalario(antiguedad);
        }

        public int calcularEdadOAntiguedad(DateTime fecha)
        {
            int difFechas = (DateTime.Today - fecha).Days;
            return (int)(difFechas/365.25);
        }

        public double calcularSalario(int antiguedad)
        {
            if(antiguedad < 20)
            {
                return SUELDO_BASE * 0.85 + SUELDO_BASE * ((double)antiguedad / 100);
            }
            else
            {
                return SUELDO_BASE * 0.85 + SUELDO_BASE * 0.25;
            }
            
        }

    }
}
