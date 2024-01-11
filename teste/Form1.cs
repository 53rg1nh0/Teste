using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using DataTable = System.Data.DataTable;
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace teste
{
    
    
    public partial class frmTeste : Form
    {
       
        public frmTeste()
        {
            InitializeComponent();
        }

        private void btnIncerir_Click(object sender, EventArgs e)
        {
            using (OleDbConnection Conexao = new OleDbConnection(ConexaoXlsx()))
            {              
                string Sql = "INSERT INTO [Folha1$] (id, nome, contato, documento) VALUES (@id, @nome, @contato, @documento)";

                OleDbCommand Comandos = new OleDbCommand(Sql, Conexao);

                Comandos.Parameters.AddWithValue("@id", txbID.Text);
                Comandos.Parameters.AddWithValue("@nome", txbNome.Text);
                Comandos.Parameters.AddWithValue("@contato", txbContato.Text);
                Comandos.Parameters.AddWithValue("@documento", txbDocumento.Text);
                Conexao.Open();
                try
                {
                    MessageBox.Show("Dados Inseridos com Sucesso!");
                    LimparDados();
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao Inserir os Dados!");
                }
                Conexao.Close();

                //Excel.Application app = new Excel.Application();
                //Workbook pasta;
                //Worksheet plan;
                //string path = @"C:\Users\sergi\OneDrive\Área de Trabalho\Teste.xlsx";
                //pasta = app.Workbooks.Open(path);

                //if(pasta!= null)
                //{
                //    pasta.Close(true);
                //    app.Quit();
                //}
            }
        }

        protected void Tabela()
        {
            using (OleDbConnection Conexao = new OleDbConnection(ConexaoXlsx()))
            {
                string Sql = "SELECT * FROM [Folha1$]";

                OleDbCommand Comandos = new OleDbCommand(Sql, Conexao);


                Conexao.Open();
                try
                {
                    OleDbDataAdapter adp = new OleDbDataAdapter(Comandos);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dtgTabela.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao Inserir os Dados!");

                }
                Conexao.Close();
            }
        }



        private string ConexaoXlsx()
        {
            string ArquivoXlsx = @"C:\Users\sergi\OneDrive\Área de Trabalho\Teste.xlsX";
            return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + ArquivoXlsx + "';Extended Properties=Excel 12.0;";
        }

        private void LimparDados()
        {
            txbID.Clear();
            txbNome.Clear();
            txbDocumento.Clear();
            txbContato.Clear();
        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTeste_Load(object sender, EventArgs e)
        {
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
          

            Tabela();

           
            

            string nomeProcesso = Process.GetCurrentProcess().ProcessName;

            // Obtém todos os processos com o nome do atual
            Process[] processes = Process.GetProcessesByName("OneDrive");

            // Maior do que 1, porque a instância atual também conta
            if (processes.Length >= 1)
            {
                //MessageBox.Show(nomeProcesso);
            }
            else
            {
                //MessageBox.Show("Onedrive não está em execução");
            }
            //stopwatch.Stop();

            //MessageBox.Show("O processo levou " + stopwatch.ElapsedMilliseconds + " milissegundos para executar.");


            //InicializarAplicacao();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            //using (OleDbConnection Conexao = new OleDbConnection(ConexaoXlsx()))
            //{
            //    string Sql = /*"DELETE FROM [Folha1$] WHERE id = 'teste'";*/"UPDATE [Folha1$] SET nome= 'Joao' WHERE id = 'teste2'";
            //    Conexao.Open();
            //    OleDbCommand Comandos = new OleDbCommand(Sql, Conexao);

            //    try
            //    {
            //        Comandos.ExecuteNonQuery();
            //        MessageBox.Show("Dados Inseridos com Sucesso!");
            //        LimparDados();
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Ocorreu um erro ao Inserir os Dados!");
            //    }
            //    Conexao.Close();
            //}

        }
    }
}