// Fig. 5.5: LibroCalificaciones.cs
// Clase LibroCalificaciones que resuelve el problema del promedio de la clase utilizando la repetición controlada por un contador.
using System;

public class LibroCalificaciones
{
    private string nombreCurso; // nombre del curso que representa este LibroCalificaciones
    
    //el constructor inicializa nombreCurso
    public LibroCalificaciones(string nombre)
    {
        NombreCurso = nombre; // inicializa nombreCurso usando la propiedad
    } // fin del constructor

    // propiedad para obtener (get) y establecer (set) el nombre del curso
    public string NombreCurso
    {
        get
        {
            return nombreCurso;
        }
        set
        {
            nombreCurso = value;
        }
    }

    public void MostrarMensaje()
    {
        Console.WriteLine("Bienvenido al libro de calificaciones de\n{0}!\n", NombreCurso);
    }

    public void DeterminarPromedioClase()
    {
        int total;
        int contadorCalif;
        int calificacion;
        int promedio;

        total = 0;
        contadorCalif = 1;

        while (contadorCalif <= 10)
        {
            Console.Write("Escriba la calificación: ");
            calificacion = Convert.ToInt32(Console.ReadLine());
            total = total + calificacion;
            contadorCalif = contadorCalif + 1;
        }
        promedio = total / 10;
        Console.WriteLine("\nEl total de las 10 calificaciones es {0}", total);
        Console.WriteLine("El promedio de la clase es {0}", promedio);

    }
}
