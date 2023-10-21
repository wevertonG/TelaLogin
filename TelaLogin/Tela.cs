using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TelaLogin
{
    public partial class Tela_Login : Form
    {
     string connetionString = @"Data Source=DESKTOP-BQ55262\MSSQLSERVER07;Initial Catalog=master;User ID=sa; Password=123";
        public Tela_Login()
        {
            InitializeComponent();

            // Carregando a imagem para o PictureBox (substitua o caminho pela localização da sua imagem)
            pictureBoxolho.Image = Image.FromFile("C:\\Users\\wever\\source\\repos\\TelaLoginSL\\TelaLogin\\olho.png");

            // Defina o tamanho do PictureBox
            pictureBoxolho.Size = new System.Drawing.Size(16, 16);

            boxsenha.PasswordChar = '*';
        }
        private void buttonlogin_Click_1(object sender, EventArgs e)
        {

            string nome = boxlogin.Text;
            string senha = boxsenha.Text;
            
            

            try
            {
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                  cnn.Open();

                    string query = "SELECT nome, senha, salt FROM Usuarios WHERE nome = @nome";
                    using (SqlCommand command = new SqlCommand(query, cnn))  // Usamos parâmetros SQL para evitar ataques de injeção de SQL.
                    {

                        command.Parameters.AddWithValue("@nome", nome);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Encontrou um usuário com o nome especificado
                                string hashedPasswordFromDB = reader["senha"].ToString();
                                string saltFromDB = reader["salt"].ToString();

                                if (VerifyPassword(senha, hashedPasswordFromDB, saltFromDB) && termos.Checked == true)
                                {
                                    // Senha válida - Login bem-sucedido
                                    MessageBox.Show("Login bem-sucedido!");
                                }
                                else if(termos.Checked == false)
                                {
                                    MessageBox.Show("Aceite os termos para realizar o login!");
                                }
                                else
                                {
                                    // Senha inválida
                                    MessageBox.Show("Nome de usuário ou senha incorretos.");
                                }
                            }
                            else
                            {
                                // Nome de usuário não encontrado
                                MessageBox.Show("Nome de usuário não encontrado.");
                            }

                        }
                    }
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados.\n" +
                "Verifique os dados informados. Erro: " + erro.Message);
            }
        }

        private void buttonregistro_Click_1(object sender, EventArgs e)
        {
            TelaRegistro registro = new TelaRegistro();

            registro.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void Tela_Login_Load(object sender, EventArgs e)
        {
            bg.Image = Image.FromFile("C:\\Users\\wever\\source\\repos\\TelaLoginSL\\TelaLogin\\bg.png");
        }

        public static bool VerifyPassword(string senha, string hashedPassword, string salt)
        {
            // Combine a senha fornecida com o sal armazenado
            string saltedPassword = senha + salt;

            // Hash a senha combinada
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(saltedPassword));
                string inputHashedPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                return inputHashedPassword == hashedPassword;
            }
        }

        private bool pictureBoxClickedlogin = false;

        private void pictureBoxolho_Click(object sender, EventArgs e)
        {
            if (pictureBoxClickedlogin)
            {

                // Carregando a imagem para o PictureBox (substitua o caminho pela localização da sua imagem)
                pictureBoxolho.Image = Image.FromFile("C:\\Users\\wever\\source\\repos\\TelaLoginSL\\TelaLogin\\visualizar.png");

                // Defina o tamanho do PictureBox
                pictureBoxolho.Size = new System.Drawing.Size(16, 16);
                boxsenha.PasswordChar = '\0';
                pictureBoxClickedlogin = false;

            }

            else
            {
                // Carregando a imagem para o PictureBox (substitua o caminho pela localização da sua imagem)
                pictureBoxolho.Image = Image.FromFile("C:\\Users\\wever\\source\\repos\\TelaLoginSL\\TelaLogin\\olho.png");

                // Defina o tamanho do PictureBox
                pictureBoxolho.Size = new System.Drawing.Size(16, 16);
                boxsenha.PasswordChar = '*';
                pictureBoxClickedlogin = true;
            }
        }
    }
}

