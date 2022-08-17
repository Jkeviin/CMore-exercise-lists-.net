using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Notas
{
    public class lib_notas
    {
        #region Atributos
        private float notas;
        private float nota;
        private float resultado;
        private string nombre;
        private string error;
        private int cantidad;
        #endregion

        #region Metodos Publicos
        public lib_notas()
        {
            notas = 0;
            nota = 0;
            resultado = 0;
            cantidad = 0;
            nombre = "";
            error = "";
        }

        public bool Calcular()
        {
            if (!ValidarCalcular() || !ValidarNombre()) return false;

            try
            {
                resultado = notas / cantidad;
                Console.WriteLine(notas);
                Console.WriteLine(resultado);
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public bool ValidacionAgregar()
        {
            if (!ValidarTamano() || !ValidarCantidad()) return false;

            return true;
        }
        #endregion


        #region Metodos Privados

        private bool ValidarTamano()
        {
            if (nota < 0 || nota > 5)
            {
                error = "La nota no puede ser menor a 0 ni mayor a 5";
                return false;
            }
            return true;
        }

        private bool ValidarCantidad()
        {
            if (cantidad >= 4)
            {
                error = "No se pueden agregar mas de 4";
                return false;
            }
            return true;
        }

        private bool ValidarNombre()
        {

            if(nombre.Length == 0)
            {
                error = "Ingresa el nombre del estudiante";
                return false;
            }
            return true;
        }

        private bool ValidarCalcular()
        {
            if(cantidad < 4)
            {
                Console.WriteLine(cantidad);
                error = "Debes agregar 4 notas";
                return false;
            }
            return true;
        }
        #endregion



        #region Propiedades
        public float SetNota
        {
            set { nota = value; }
        }
        public string SetNombre
        {
            set { nombre = value; }
        }
        public int SetCantidad
        {
            set { cantidad = value; }
        }
        public float SetNotas
        {
            set { notas = value; }
        }
        public float GetResultado
        {
            get { return resultado; }
        }
        public float GetNota
        {
            get { return nota; }
        }
        public string GetError
        {
            get { return error; }
        }
        #endregion
    }
}
