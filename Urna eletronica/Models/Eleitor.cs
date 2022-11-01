

namespace Models

{
    public class Eleitor
    {
		private string nome;
		private string rg;
		private string tituloEleitor;
		private bool seuVoto;

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
