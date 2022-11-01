

using Models;
using DAL;

namespace BLL
{
    public class EleitorBLL
    {
        public void Inserir(Eleitor _eleitor)
        {
            if (_eleitor.Nome.Length <= 2)
                throw new Exception("O neme do eleitor dever ter mais de 2 caractre ");
            

            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Inserir(_eleitor);
        }
        
        public void Excluir(Eleitor _eleitor)
        {
            EleitorDAL _eleitorDAL = new EleitorDAL();
            _eleitorDAL.Excluir(_eleitor);

        }

        public void Alterar(Eleitor _eleitor)
        {
            if (_eleitor.Nome.Length <= 2)
                throw new Exception("O neme do eleitor dever ter mais de 2 caractre ");

            EleitorDAL _eleitorDAL = new EleitorDAL();
            _eleitorDAL.Alterar(_eleitor);
        }
         
        public List<Eleitor> Buscar(string _titulo)
        {

            EleitorDAL _eleitorDAL = new EleitorDAL();
          return  _eleitorDAL.Buscar(_titulo);
        }

    }
}
