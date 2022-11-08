using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class EleicaoDAL
    {

        public void Inseir(Eleicao _eleicao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "INSERT INTO Eleicao (Ano, Turno) " +
            "VALUES(@Ano, @Turno) ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Ano", _eleicao.Ano);
            cmd.Parameters.AddWithValue("@Turno", _eleicao.Turno);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void Excluir(Eleicao _eleicao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "Delete from Eleicao Where ID_ELEICAO =  @ID_ELEICAO";
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID_ELEICAO", _eleicao.ID_ELEICAO);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public void Alterar(Eleicao _eleicao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "UPDATE Eleicao SET Ano = @Ano, Turno = @Turno Where ID_ELEICAO = @ID_ELEICAO";
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID_ELEICAO", _eleicao.ID_ELEICAO);
                cmd.Parameters.AddWithValue("@Ano", _eleicao.Ano);
                cmd.Parameters.AddWithValue("@Turno", _eleicao.Turno);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public List<Eleicao> Buscar(int _turno, int _ano)
        {
            return new List<Eleicao>();
        }
    }
}
