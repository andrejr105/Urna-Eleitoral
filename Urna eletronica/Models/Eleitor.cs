

namespace Models

{
    public class Eleitor
    {
		private int id_eleitor;
		private string nome;
		private string titulo;
		private bool votou;

		public int ID_ELEITOR
		{
			get { return id_eleitor; }
			set { id_eleitor = value; }
		}


		public bool Votou
        {
			get { return votou; }
			set { votou = value; }
		}


		public string Titulo
        {
			get { return titulo; }
			set { titulo = value; }
		}

	

		public string Nome

		{
			get { return nome; }
			set { nome = value; }
		}

		public Eleitor(string _nome, string _titulo, bool _votou)
		{

			Nome = _nome;

            titulo = _titulo;
            Votou = _votou;
			
		}



	}
}
