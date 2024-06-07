// See https://aka.ms/new-console-template for more information
namespace espacioOperaciones
{
    public class Operacion
    {
        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion operacionRealizada;
        public double Resultado{
            get { return ResultadoAnterior; }
        }
        public double NuevoValor{
            get { return NuevoValor1; } // = get => nuevoValor
            
        }
        public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
        public double NuevoValor1 { get => nuevoValor; set => nuevoValor = value; }
        public TipoOperacion OperacionRealizada { get => operacionRealizada; set => operacionRealizada = value; }

        public enum TipoOperacion{
            Suma,
            Resta,
            Multiplicacion,
            Division,
            limpiar
        }
    }
}
