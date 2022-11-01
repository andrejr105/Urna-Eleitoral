using BLL;
using Models;


internal class Program
{
    public static void Main(string[] args)
    {
        Eleitor eleitor = new Eleitor("Felipe", "122345667");
        EleitorBLL eleitorBLL = new EleitorBLL();
        eleitorBLL.Inserir(eleitor);
    }
}