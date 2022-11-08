
using DAL;
using Models;

namespace BLL
{
    public class EleicaoBLL
    {
        public void Inserir(Eleicao _eleicao)
        { 


            EleicaoDAL _eleicaoDal = new EleicaoDAL();
            _eleicaoDal.Inseir(_eleicao);
        }
        public void Excluir(Eleicao _eleicao)
        {
            EleicaoDAL _eleicaoDal = new EleicaoDAL();
            _eleicaoDal.Excluir(_eleicao);
        }
        public void Alterar(Eleicao _eleicao)
        {
            EleicaoDAL _eleicaoBLL = new EleicaoDAL();
            _eleicaoBLL.Alterar(_eleicao);
        }
        public List<Eleicao> Buscar(int _turno, int _ano)
        {
            EleicaoDAL _eleicaoDAL = new EleicaoDAL();
            return _eleicaoDAL.Buscar(_turno, _ano);
        }
    }
}
