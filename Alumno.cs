using System;

namespace QualityCode

{
    /// <summary>
    /// La informacion relacionada o relevante con los datos del alumno 
    /// </summary>
    class Student
    {

        string Estudiante { get; set; }

        /// <summary>
        /// la calificacion obtenida en el primer tema de la primera unidad
        /// </summary>
        double Tema1Unidad1 { get; set; }

        /// <summary>
        /// la calificacion obtenida en el segundo tema de la primera unidad
        /// </summary>
        double Tema2Unidad1 { get; set; }

        /// <summary>
        /// la calificacion obtenida en el tercer tema de la primera unidad
        /// </summary>
        double Tema3Unidad1 { get; set; }


        public Student(string Estudiante, double Tema1Unidad1, double Tema2Unidad1, double Tema3Unidad1)
        {
            this.Estudiante = Estudiante;

            this.Tema1Unidad1 = Tema1Unidad1;
            this.Tema2Unidad1 = Tema2Unidad1;
            this.Tema3Unidad1 = Tema3Unidad1;

        }

        public string TomarEstudiante()
            {
                return Estudiante;
            }
            public decimal TomarTema1Unidad1()
            {
                return Tema1Unidad1;
            }
            public decimal TomarTema2Unidad1()
            {
                return Tema2Unidad1;
            }
            public decimal TomarTema3Unidad1()
            {
                return Tema3Unidad1;
            }
    }
}        
