// See https://aka.ms/new-console-template for more information
using System;

namespace espacioTareas
{
    public class Tarea
    {
        int tareaID;
        string descripcion;
        int duracion;
        public int TareaID { get => tareaID; set => tareaID = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public Tarea (int tareaID, string descripcion, int duracion)
        {
            this.TareaID = tareaID;
            this.Descripcion = descripcion;
            this.Duracion = duracion;
        }

        public void mostrarTarea(Tarea tarea)
        {
                Console.WriteLine("---Tarea numero: " + tarea.TareaID + "---");
                Console.WriteLine("Descripcion: " + tarea.Descripcion);
                Console.WriteLine("Duracion: " + tarea.Duracion + " min\n");
        }
        //Hacer BuscarTarea dentro de la clase tarea
    }
}

