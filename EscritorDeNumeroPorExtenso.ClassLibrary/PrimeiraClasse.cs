namespace EscritorDeNumeroPorExtenso.ClassLibrary
{
    public class PrimeiraClasse: IClasse
    {
        public IOrdem Ordem { get; set; }
        public string Sulfixo { get; private set; }

        public int[] Algarismos
        {
            get { return Ordem.Algarismos; }
        }

        public PrimeiraClasse(IOrdem ordem)
        {
            Ordem = ordem;
        }
    }
}