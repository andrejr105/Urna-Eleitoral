
using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CandidatosDAL
    {
        public void Inserir(Candidatos _Candidatos)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "INSERT INTO Candidato (Nome, Numero) " +
            "VALUES(@Nome, @Numero) ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Nome", _Candidatos.Nome);
            cmd.Parameters.AddWithValue("@Numero", _Candidatos.Numero);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void Excluir(Candidatos _Candidatos)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "Delete from Candidato Where ID_CANDIDATO =  @ID_CANDIDATO";
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID_CANDIDATO", _Candidatos.ID_CANDIDATO);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public void Alterar(Candidatos _Candidatos)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "UPDATE Candidato SET Nome = @Nome, Numero = @Numero Where ID_CANDIDATO = @ID_CANDIDATO";
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID_CANDIDATO", _Candidatos.ID_CANDIDATO);
                cmd.Parameters.AddWithValue("@Nome", _Candidatos.Nome);
                cmd.Parameters.AddWithValue("@Numero", _Candidatos.Numero);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cmd.Connection.Close();
            }

        }
        public List<Candidatos> Buscar(string _titulo)
        {
            return new List<Candidatos>();
        }
    }
}
