using BLL;
using DAL;
using Models;


internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            //Eleitor eleitor = new Eleitor("Marcos", "3214521",false);
            //eleitor.ID_ELEITOR = 19;

            //EleitorBLL eleitorBLL = new EleitorBLL();
            //eleitorBLL.Inserir(eleitor);

            //Eleitor eleitor = new Eleitor(2);
            //EleitorBLL eleitorBLL = new EleitorBLL();
            ///eleitorBLL.Inserir(eleitor);

            //eleitorBLL.Excluir(eleitor);

            //eleitorBLL.Alterar(eleitor);

            //Eleicao eleicao = new Eleicao(2012, 2, null, null);
            //EleicaoBLL eleicaoBLL = new EleicaoBLL();
            //eleicaoBLL.Inserir(eleicao);


            //Eleicao eleicao = new Eleicao(2012,1,null,null);
            //EleicaoBLL eleicaoBll = new EleicaoBLL();
            //eleicao.ID_ELEICAO = 3;
            //eleicaoBll.Alterar(eleicao);

            //eleicaoBll.Excluir(eleicao);

            Candidatos candidatos = new Candidatos("Bolsonaro", 22);
            CandidatoBLL candidatoBLL = new CandidatoBLL();
            candidatos.ID_CANDIDATO = 3;
            //candidatoBLL.Inserir(candidatos);
            //candidatoBLL.Excluir(candidatos);
            candidatoBLL.Alterar(candidatos);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}