// See https://aka.ms/new-console-template for more information
using espacioTareas;
using generarTareas;
using EspacioCalculadora;
using espacioOperaciones;

List<Tarea> Tpendientes = new List<Tarea>(); 
List<Tarea> Trealizadas = new List<Tarea>(); 
string [] descripciones = {"Jugar Free Fire",
                            "Hacer Tp7 AyEDI",
                            "Leer Habitos atomicos",
                            "Comprar pan",
                            "Ir al gym",
                            "Pagar cuentas",
                            "Ir a la facultad",
                            "Ir a un cumple",
                            "Salir a correr",
                            "Bañarme",
                            "Cocinar",
                            "Lavar ropa",
                            "Ver Halo",
                            "Ir al cine",
                            "Dar clases de consulta",
                            "Estudiar javaScript",
                            "Lavar zapatillas"
                            };

Random aleatorio = new Random();
int min = 2;
int max = 16;
int n = aleatorio.Next(min, max);

Console.WriteLine($"El numero Pseudoaleatorio entre {min} y {max} = {n}");

int opcion=1;
int Tnum = n+1;
string descripcion;
int Ttiempo;

creadorTareas instacia = new creadorTareas(); // Esta clase la uso especificamente para crear "tareas" aleatorias
Tpendientes = instacia.crearTareas(n, descripciones); // crearTareas(n) devuelve una lista con n tareas;

do
{
    Console.WriteLine("-----MENU-----");
    Console.WriteLine("0 - Salir");
    Console.WriteLine("1 - Ingresar Tarea pendiente");
    Console.WriteLine("2- Mostrar lista de Pendientes");
    Console.WriteLine("3- Marcar tareas pendentes como realizadas");
    Console.WriteLine("4- Mostrar lista de Realizadas");
    Console.WriteLine("5- Buscar Tarea");
    do
    {
        int.TryParse(Console.ReadLine(), out opcion);
    } while (opcion<0 || opcion>5);

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingresar Descripcion de la tarea:");
            descripcion = Console.ReadLine();
            Console.WriteLine("Ingresar el tiempo que dura la tarea en minutos (numero entero):");
            int.TryParse(Console.ReadLine(), out Ttiempo);
            Tpendientes.Add(new Tarea(Tnum,descripcion,Ttiempo));
            Tnum++;
        break;
        case 2:
            foreach (var Tarea in Tpendientes)
            {
                Tarea.mostrarTarea(Tarea);
            }
        break;
        case 3:
            int id,cont=0,aux=0,ban=0;
            Console.WriteLine("Ingresar el id de la tarea que quiere marcar como Realizada:");
            int.TryParse(Console.ReadLine(), out id);
            foreach (var Tarea in Tpendientes)
            {
                if (Tarea.TareaID == id)
                {
                    ban=1;
                    aux = cont;
                    Trealizadas.Add(Tarea);
                }
                cont++;
            }
            if (ban == 1)
            {
                Tpendientes.Remove(Tpendientes[aux]);
            }else{
                Console.WriteLine("Tarea no encontrada");
            }
            
        break;
        case 4:
            foreach (var Tarea in Trealizadas)
                {
                    Console.WriteLine("---Tarea numero: " + Tarea.TareaID + "---");
                    Console.WriteLine("Descripcion: " + Tarea.Descripcion);
                    Console.WriteLine("Duracion: " + Tarea.Duracion + " min\n");
                }
        break;
        case 5:
        string des;
            Console.WriteLine("Ingrese la descripcion de la tarea a buscar (Debe ser exacta para que la encuentre): ");
            des = Console.ReadLine();
            int bandera=0;
            foreach (var Tarea in Tpendientes)
            {
                if(Tarea.Descripcion == des){
                    Tarea.mostrarTarea(Tarea);
                    bandera = 1;
                }
            }
            if (bandera == 0)
            {
                foreach (var Tarea in Trealizadas)
                {
                    if(Tarea.Descripcion == des){
                        Tarea.mostrarTarea(Tarea);
                        bandera = 1;
                    }
                }
            }
            if (bandera == 0)
            {
                Console.WriteLine("Tarea no encontrada");
            }
            
        break;
    }

} while (opcion!=0);

//---------EJERCICIO 2--------------------
double num=0;
Calculadora operacion = new Calculadora();
List<Operacion> LHistorial= new List<Operacion>();
Operacion miOperacion ;

do
{
    Console.WriteLine("######### Calculadora #########");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Limpiar");
    Console.WriteLine("6 - Historial");
    Console.WriteLine("0 - Salir");
    int.TryParse(Console.ReadLine(),out opcion);

    switch (opcion)
    {
        case 1:
            miOperacion = new Operacion();
            miOperacion.ResultadoAnterior = operacion.Resultado;
            Console.WriteLine("Sumar | Ingrese el numero: ");
            double.TryParse(Console.ReadLine(),out num);
            operacion.Sumar(num);
            miOperacion.NuevoValor1 = num;
            miOperacion.OperacionRealizada = Operacion.TipoOperacion.Suma;
            LHistorial.Add(miOperacion);
            //Tarea miTarea = new Tarea(i+1,descripciones[descripcion],duracion);
              //  listaTareas.Add(miTarea);
        break;
        case 2:
            miOperacion = new Operacion();
            miOperacion.ResultadoAnterior = operacion.Resultado;
            Console.WriteLine("Restar | Ingrese el numero: ");
            double.TryParse(Console.ReadLine(),out num);
            operacion.Restar(num);
            miOperacion.NuevoValor1 = num;
            miOperacion.OperacionRealizada = Operacion.TipoOperacion.Resta;
            LHistorial.Add(miOperacion);
        break;
        case 3:
            miOperacion = new Operacion();
            miOperacion.ResultadoAnterior = operacion.Resultado;
            Console.WriteLine("Multiplicar | Ingrese el numero: ");
            double.TryParse(Console.ReadLine(),out num);
            operacion.Multiplicar(num);
            miOperacion.NuevoValor1 = num;
            miOperacion.OperacionRealizada = Operacion.TipoOperacion.Multiplicacion;
            LHistorial.Add(miOperacion);
        break;
        case 4:
            miOperacion = new Operacion();
            miOperacion.ResultadoAnterior = operacion.Resultado;
            Console.WriteLine("Dividir | Ingrese el numero: ");
            do
            {
                double.TryParse(Console.ReadLine(),out num);
                if (num==0)
                {
                    Console.WriteLine("No puede ingresar 0");
                }
            } while (num==0);
            operacion.Dividir(num);
            miOperacion.NuevoValor1 = num;
            miOperacion.OperacionRealizada = Operacion.TipoOperacion.Division;
            LHistorial.Add(miOperacion);
        break;
        case 5:
            operacion.Limpiar();
        break;
        case 6:
            int cont=1;
            char signo=' ';
            double resul=0;
            Console.WriteLine("-------HISTORIAL-------");
            foreach (var historial in LHistorial)
            {
                switch (historial.OperacionRealizada)
                {
                    case Operacion.TipoOperacion.Suma:
                        Console.WriteLine("Operacion realizada: SUMA");
                        signo = '+';
                        resul = historial.Resultado+historial.NuevoValor;
                    break;
                    case Operacion.TipoOperacion.Resta:
                        Console.WriteLine("Operacion realizada: RESTA");
                        signo = '-';
                        resul = historial.Resultado-historial.NuevoValor;
                    break;
                    case Operacion.TipoOperacion.Multiplicacion:
                        Console.WriteLine("Operacion realizada: MULTIPLICACION");
                        signo = '*';
                        resul = historial.Resultado*historial.NuevoValor;
                    break;
                    case Operacion.TipoOperacion.Division:
                        Console.WriteLine("Operacion realizada: DIVISION");
                        signo = '/';
                        resul = historial.Resultado/historial.NuevoValor;
                    break;
                }
                Console.WriteLine($"{historial.Resultado} {signo} {historial.NuevoValor} = {resul}");
                cont++;
            }
        break;

    }
    Console.WriteLine("El numero resultante es: " + operacion.Resultado);
} while (opcion!=0);