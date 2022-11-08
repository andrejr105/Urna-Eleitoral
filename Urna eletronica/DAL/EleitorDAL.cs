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
                cmd.Parameters.AddWithValue("@Titulo", _eleitor.Titulo);
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
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "UPDATE ELeitor SET Nome = @Nome, Titulo = @Titulo, votou = @votou Where ID_ELEITOR = @ID_ELEITOR";
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID_ELEITOR", _eleitor.ID_ELEITOR);
                cmd.Parameters.AddWithValue("@Nome", _eleitor.Nome);
                cmd.Parameters.AddWithValue("@votou", _eleitor.Votou);
                cmd.Parameters.AddWithValue("@Titulo", _eleitor.Titulo);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cmd.Connection.Close();
            }

        }

        public List<Eleitor> Buscar(string _titulo)
        {
            return new List<Eleitor>();
        }

    }
}