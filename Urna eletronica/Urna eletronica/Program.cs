using BLL;
using Models;


internal class Program
{
    public static void Main(string[] args)
    {
        Eleitor eleitor = new Eleitor("Felipe", "122345667");
        EleitorBLL eleitorBLL = new EleitorBLL();
        eleitorBLL.Inserir(eleitor);

        Eleicao eleicao = new Eleicao(2012, 2,null,null);
        EleicaoBLL eleicaoBLL = new EleicaoBLL();
        eleicaoBLL.Inserir(eleicao);
    }
}