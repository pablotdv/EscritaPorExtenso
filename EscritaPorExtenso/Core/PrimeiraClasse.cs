namespace EscritaPorExtenso.Core
{
    public class PrimeiraClasse : Classe
    {
        public override string Sufixo { get { return string.Empty; }}

        public PrimeiraClasse(Ordem ordem, Classe classeAnterior = null)
        {
            Ordem = ordem;
        }

        public override string ToString()
        {
            return Ordem.ToString();
        }
    }
}