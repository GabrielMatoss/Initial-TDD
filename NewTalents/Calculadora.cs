
namespace NewTalents
{
    public class Calculadora
    {
        private List<string> _listaHistorico;
        private string _data;
        public Calculadora(string data)
        {
            _listaHistorico = new List<string>();
            _data = data;

        }

        public int Somar(int num1, int num2)
        {
            int result = num1 + num2;
            _listaHistorico.Insert(0, $"Res: {result} - Data: {_data}");
            return result;
        }

        public int Subtrair(int num1, int num2)
        {
            int result = num1 - num2;
            _listaHistorico.Insert(0, $"Res: {result} - Data: {_data}");
            return result;
        }

        public int Multiplicar(int num1, int num2)
        {
            int result = num1 * num2;
            _listaHistorico.Insert(0, $"Res: {result} - Data: {_data}");
            return result;
        }

        public int Dividir(int num1, int num2)
        {
            int result = num1 / num2;
            _listaHistorico.Insert(0, $"Res: {result} - Data: {_data}");
            return result;
        }

        public List<string> Historico()
        {
            _listaHistorico.RemoveRange(3, _listaHistorico.Count - 3);
            return _listaHistorico;
        }
    }
}
