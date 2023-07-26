using pitStopDuLeuo.model;
using pitStopDuLeuo.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pitStopDuLeuo.controller
{
    internal class manipulaProdutos
    {
        public void cadProd()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pcadastroProduto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("Produto", classeMercado.Produto);
                cmd.Parameters.AddWithValue("Marca", classeMercado.Marca);
                cmd.Parameters.AddWithValue("Validade", classeMercado.Validade);

                SqlParameter nv = cmd.Parameters.AddWithValue("IdProduto", SqlDbType.Int);
                nv.Direction= ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Produto cadastrado com sucesso, deseja cadastrar outro?",
                    "Novo Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    TelaCadastrar telacadastrar = new TelaCadastrar();
                    telacadastrar.abrirCadastro();


                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void buscProd()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pbuscarProdutoCodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@IdProduto", classeMercado.Codigo);
                cn.Open();
                var registros = cmd.ExecuteReader();

                if (registros.Read())
                {
                    classeMercado.Codigo = Convert.ToInt32(registros["IdProduto"]);
                    classeMercado.Produto = (string)registros["Produto"];
                    classeMercado.Marca = (string)registros["Marca"];
                    classeMercado.Validade = (string)registros["Validade"];
                }
                else
                {
                    classeMercado.Codigo = 0;
                    classeMercado.Produto = "";
                    classeMercado.Marca = "";
                    classeMercado.Validade = "";
                    MessageBox.Show("Peça não encontrada");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void deletProd()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pdeletarProduto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("idProduto", classeMercado.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Peça deletada com sucesso, deseja deletar outra ?",
                    "Deletar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    TelaDeletar telaDeletar = new TelaDeletar();
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void alterProd()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("palterarProduto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("IdProduto", classeMercado.Codigo);
                cmd.Parameters.AddWithValue("Produto", classeMercado.Produto);
                cmd.Parameters.AddWithValue("Marca", classeMercado.Marca);
                cmd.Parameters.AddWithValue("Validade", classeMercado.Validade);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterada com sucesso");

                classeMercado.Codigo = 0;
                classeMercado.Produto = "";
                classeMercado.Marca = "";
                classeMercado.Validade = "";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
