

using Models;
using DAL;

namespace BLL
{
    public class EleitorBLL
    {
        public void Inserir(Eleitor _eleitor)
        {
            if(_eleitor.Nome.Length <=2)
            throw new Exception("O neme do eleitor dever ter mais de 2 caractre ")
            

            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Inserir(_eleitor);
        }
        
        public void Excluir()
        {


        }

        public void Alterar()
        {

        }
         
        public void Buscar()
        {

        }

    }
}
