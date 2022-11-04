using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class EleitorDAL
    {
        public void Inserir(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();

            try
            {

                cmd.CommandText = "INSERT INTO Eleitor (Nome, Titulo) " +
                "VALUES(@Nome, @Titulo) ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Titulo", _eleitor.TituloEleitor);
                cmd.Parameters.AddWithValue("@Nome", _eleitor.Nome);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally { 
                cmd.Connection.Close();
            }
        }

        public void Excluir(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "Delete from Eleitor Where ID_ELEITOR =  @ID_ELEITOR";
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID_ELEITOR", _eleitor.ID_ELEITOR);
                cmd.ExecuteNonQuery();
            } 
            finally
            {
                cmd.Connection.Close();
            }
        }

        public void Alterar(Eleitor _eleitor)
        {

        }

        public List<Eleitor> Buscar(string _titulo)
        {
            return new List<Eleitor>();
        }

    }
}