using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{

    class iEstudiantes
    {
        private int id;
        private String nombre;
        private int edad;
        private int nota1;
        private int nota2;
        private int parcial;
        private int notafinal;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public int Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        public int Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public int Parcial
        {
           get { return parcial; }
            set { parcial = value; }
        }


        public int NotaFinal
        {
            get { return notafinal; }
            set { notafinal = value; }
        }



        public iEstudiantes(int id,  string nombre, int edad, int nota1, int nota2, int parcial, int notafinal)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.parcial = parcial;
            this.notafinal = notafinal;


        }

        public string Mostrar()
        {
            return "ESTUDIANTE: " + nombre + " " + " EDAD: " + edad + " NOTA FINAL: " + notafinal + " ESTADO: ";
        }
    }

}