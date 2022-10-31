

namespace Models

{
    public class Eleitor
    {
		private string nome;
		private string rg;
		private bool tituloElitor;
		private bool seuVoto;

		public bool SeuVoto
        {
			get { return seuVoto; }
			set { seuVoto = value; }
		}


		public bool TituloElitor
        {
			get { return tituloElitor; }
			set { tituloElitor = value; }
		}

		public string Rg
		{
			get { return rg; }
			set { rg = value; }
		}

		public string Nome

		{
			get { return nome; }
			set { nome = value; }
		}

		public Eleitor(string _nome, string _rg, bool _tituloElitor)
		{
			Nome = _nome;
			Rg = _rg;
			TituloElitor = _tituloElitor;
			SeuVoto = false;
			
		}



	}
}
