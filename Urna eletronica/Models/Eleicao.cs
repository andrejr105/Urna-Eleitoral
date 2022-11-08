
namespace Models
{
    public class Eleicao
    {
		private int ano;
		private int turno;
		private List<Candidatos> candidatos;
		private List<Eleitor>  eleitores;
		private int id_eleicao;

		public List<Eleitor> Eleitores
        {
			get { return  eleitores; }
			set {  eleitores = value; }
		}


		public List<Candidatos> Candidatos
        {
			get { return candidatos; }
			set { candidatos = value; }
		}


		public int Turno
		{
			get { return turno; }
			set { turno = value; }
		}

		public int Ano
		{
			get { return ano; }
			set { ano = value; }
		}
		public int ID_ELEICAO
        {
			get { return id_eleicao; }
			set { id_eleicao = value; }
		}
		public Eleicao(int _ano, int _turno, List<Candidatos> _candidatos, List<Eleitor> _eleitores)
		{
			Eleitores = _eleitores;
			Candidatos = _candidatos;
			Turno = _turno;
			Ano = _ano;
        }

	}
}
