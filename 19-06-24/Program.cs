namespace _19_06_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente conto = new ContoCorrente();
            conto.ApriConto(500);
            conto.ApriConto(1000);
            conto.Versamento(500);
            conto.Prelievo(200);
            conto.ApriConto(1000);
            NameList nameList = new NameList();
            nameList.CercaUtente();
        }
    }
}
