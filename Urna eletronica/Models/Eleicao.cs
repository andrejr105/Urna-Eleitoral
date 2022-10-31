
namespace Models
{
    public class Eleicao
    {
		private int ano;
		private int turno;
		private List<Candidatos> candidatos;
		private List<Eleitor>  eleitores;

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
		public Eleicao(int _ano, int _turno, List<Candidatos> _candidatos, List<Eleitor> _eleitores)
		{
			Ano = _ano;
			Turno = _turno;
			Candidatos = _candidatos;
			Eleitores = _eleitores;
		
		}

	}
}
