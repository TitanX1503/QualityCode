using System;

namespace QualityCode
{
    /// <summary>
    /// su funcion consiste en obtener los datos relacionados con la materia y tenerlos a disposicion cuando sea necesario o cuando se solicite.
    /// </summary>
    class Materia
    {
       string nombre { get; set; }

       /// <summary>
       /// el valor dado al examen despues de que es revisado.
       /// </summary>
       public int Examen { get; set; }

       /// <summary>
       /// la cantidad de trabajos entregados por el alumno, las cuales se convierten en un porcentaje para la evaluacion.
       /// </summary>
       public int Trabajos { get; set; }

       /// <summary>
       /// el numero total de clases en las cuales el alumno estuvo presente desde el comienzo de esta.
       /// </summary>
       public int Asistencia { get; set; }

       public Materia(string nombre, int Examen, int Trabajos, int Asistencia)
       {
           this.nombre = nombre;
           this.Examen = Examen;
           this.Trabajos = Trabajos;
           this.Asistencia = Asistencia;
       }

       public string TomarNombre()
        {
            return nombre;
        }
    }
}