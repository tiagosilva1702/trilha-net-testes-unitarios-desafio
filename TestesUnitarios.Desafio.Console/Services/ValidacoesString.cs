namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        /// <summary>
        /// Recebe um texto qualquer e retorna a quantidade de caracteres presentes no texto
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public int RetornarQuantidadeCaracteres(string texto)
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }

        /// <summary>
        /// Recebe um texto qualquer e um texto a ser procurado, retorna verdadeiro ou falso se um determinado trecho procurado está presente no texto
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="textoProcurado"></param>
        /// <returns></returns>
        public bool ContemCaractere(string texto, string textoProcurado)
        {
            var contem = texto.Contains(textoProcurado);
            return contem;
        }

        /// <summary>
        /// Recebe um texto qualquer e um trecho a ser procurado, retorna verdadeiro ou falso se um determinado trecho procurado está presente no final do texto apenas
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="textoProcurado"></param>
        /// <returns></returns>
        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }
    }
}