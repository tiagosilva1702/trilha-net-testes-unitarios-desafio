namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        /// <summary>
        /// Recebe uma lista de números inteiros e retorna uma nova lista, apenas com os números positivos
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        /// <summary>
        /// Recebe uma lista de números inteiros e verifica se um determinado número está presente dentro dessa lista
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            return contem;
        }

        /// <summary>
        /// Recebe uma lista de números inteiros e retorna uma nova lista, com seus valores múltiplicados por um determinado número
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada;
        }

        /// <summary>
        /// Recebe uma lista de números inteiros e retorna o maior número entre eles
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        /// <summary>
        /// Recebe uma lista de números inteiros e retorna o menor número entre eles
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }
    }
}
