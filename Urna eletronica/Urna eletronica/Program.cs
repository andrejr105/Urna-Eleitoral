using BLL;
using Models;


internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Eleitor eleitor = new Eleitor("Felipe", "122345667");
            eleitor.ID_ELEITOR = 14;

            EleitorBLL eleitorBLL = new EleitorBLL();
            //eleitorBLL.Inserir(eleitor);

            //Eleitor eleitor = new Eleitor(2);
            //EleitorBLL eleitorBLL = new EleitorBLL();
            ///eleitorBLL.Inserir(eleitor);

            eleitorBLL.Excluir(eleitor);

            //Eleicao eleicao = new Eleicao(2012, 2, null, null);
            //EleicaoBLL eleicaoBLL = new EleicaoBLL();
            //eleicaoBLL.Inserir(eleicao);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}