using DAL;
using Models;

namespace BLL
{
    public class CandidatoBLL
    {
        public void Inseir(Candidatos _Candidatos)
        {
            CandidatosDAL _candidatosDAL = new CandidatosDAL();
            _candidatosDAL.Inseir(_Candidatos);
        }
        public void Excluir(Candidatos _Candidatos)
        {
            CandidatosDAL _candidatosDAL = new CandidatosDAL();
            _candidatosDAL.Excluir(_Candidatos);
        }
        public void Alterar(Candidatos _Candidatos)
        {
            CandidatosDAL _candidatosDAL = new CandidatosDAL();
            _candidatosDAL.Alterar(_Candidatos);
        }
        public List<Candidatos> Buscar(string _titulo)
        {
            CandidatosDAL _candidatosDAL = new CandidatosDAL();
            return _candidatosDAL.Buscar(_titulo);
        }
    }
}