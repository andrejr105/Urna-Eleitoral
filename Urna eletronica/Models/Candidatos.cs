namespace Models
{
    public class Candidatos
    {
		private string nome;
		private int numero;
		private string pratido;
		private int id_candidato;

		public string Pratido

		{
			get { return pratido; }
			set { pratido = value; }
		}


		public int Numero
        {
			get { return numero; }
			set { numero = value; }
		}


		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
		public int ID_CANDIDATO
		{
			get { return id_candidato; }
			set { id_candidato = value; }
		}
        public Candidatos(string _nome , int _numero)
		{
			 Nome = _nome;	
			 Numero = _numero;

		 
		}

	}
}