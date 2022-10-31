namespace Models
{
    public class Candidatos
    {
		private string nome;
		private int numcandidatos;
		private string pratido;


		public string Pratido

		{
			get { return pratido; }
			set { pratido = value; }
		}


		public int Numcandidatos
        {
			get { return numcandidatos; }
			set { numcandidatos = value; }
		}


		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
		public Candidatos(string _nome , int _numcandidatos, string _pratido)
		{
			 Nome = _nome;	
			 Numcandidatos = _numcandidatos;
			Pratido = _pratido;
		 
		}

	}
}