

namespace Models

{
    public class Eleitor
    {
		private int id_eleitor;
		private string nome;
		private string tituloEleitor;
		private bool seuVoto;

		public int ID_ELEITOR
		{
			get { return id_eleitor; }
			set { id_eleitor = value; }
		}


		public bool SeuVoto
        {
			get { return seuVoto; }
			set { seuVoto = value; }
		}


		public string TituloEleitor
        {
			get { return tituloEleitor; }
			set { tituloEleitor = value; }
		}

	

		public string Nome

		{
			get { return nome; }
			set { nome = value; }
		}

		public Eleitor(string _nome, string _tituloEleitor)
		{

			Nome = _nome;
	
			TituloEleitor = _tituloEleitor;
			SeuVoto = false;
			
		}



	}
}
