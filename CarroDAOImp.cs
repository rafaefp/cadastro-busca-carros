using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tarefa42
{
    public class CarroDAOImp: CarroDAO
    {
        public void cadastrar(Carro carro)
        {
            System.Data.SqlClient.SqlConnection connection;
            connection = new System.Data.SqlClient.SqlConnection();
            connection = DBConnectionFactory.GetInstance();
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO CARRO (MARCA, MODELO, ANO, COR) VALUES (@marca, @modelo, @ano, @cor)";
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@marca", carro.marca);
            command.Parameters.AddWithValue("@modelo", carro.modelo);
            command.Parameters.AddWithValue("@ano", carro.ano);
            command.Parameters.AddWithValue("@cor", carro.cor);

            command.ExecuteNonQuery();
            connection.Close();
        }
        public List<Carro> buscarPorModelo(string modelo)
        {
            System.Data.SqlClient.SqlConnection connection;
            connection = new System.Data.SqlClient.SqlConnection();
            connection = DBConnectionFactory.GetInstance();
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM CARRO WHERE MODELO = @modelo";
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@modelo", modelo);

            SqlDataReader reader = command.ExecuteReader();

            List<Carro> lista = new List<Carro>();
            while(reader.Read())
            {
                Carro carro = new Carro()
                {
                    marca = Convert.ToString(reader["marca"]),
                    modelo = Convert.ToString(reader["modelo"]),
                    ano = Convert.ToInt32(reader["ano"]),
                    cor = Convert.ToString(reader["cor"])
                };
                lista.Add(carro);
            }
            reader.Close();
            connection.Close();

            return lista;
        }
    }
}
