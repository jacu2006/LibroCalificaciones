// Fig. 5.6: LibroCalificaciones.cs
// Clase LibroCalificaciones que resuelve el problema del promedio de la clase utilizando la repetición controlada por un centinela.
using System;

public class LibroCalificaciones
{
    private string nombreCurso;

    public LibroCalificaciones(string nombre)
    {
        NombreCurso = nombre;
    }

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
        double promedio;

        total = 0;
        contadorCalif = 0;

        Console.WriteLine("Escriba califiacion o -1 para salir: ");
        calificacion = Convert.ToInt32(Console.ReadLine());
        while(calificacion != -1)
        {
            total = total + calificacion;
            contadorCalif = contadorCalif + 1;

            Console.Write("Escriba califiacion o -1 para salir: ");
            calificacion = Convert.ToInt32(Console.ReadLine());
        }

        if (contadorCalif != 0)
        {
            promedio = (double) total / contadorCalif;

            Console.WriteLine("\nEl total de las {0} calificaciones introducidas es {1}", contadorCalif, total);
            Console.WriteLine("El promedio de la clase es {0:F2}", promedio);
        }
        else
            Console.WriteLine("No se introdujeron calificaciones.");
    }
}