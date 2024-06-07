// See https://aka.ms/new-console-template for more information
using espacioTareas;

namespace generarTareas
{
    public class creadorTareas
    {
        public List<Tarea> crearTareas(int n , string [] descripciones)
        {
            Random aleatorio = new Random();
            List<Tarea> listaTareas = new List<Tarea>();
            for (int i = 0; i < n; i++)
            {
                int duracion = aleatorio.Next(1, 60);
                int descripcion = aleatorio.Next(0, descripciones.Length);
                Tarea miTarea = new Tarea(i+1,descripciones[descripcion],duracion);
                listaTareas.Add(miTarea);
            }
            return listaTareas;
        }
    }
}



