using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace TelaLogin
{
    public partial class TelaRegistro : Form
    {
        string connetionString = @"Data Source=DESKTOP-BQ55262\MSSQLSERVER07;Initial Catalog=master;User ID=sa; Password=123";
        public TelaRegistro()
        {
            InitializeComponent();

            this.Location = new Point(
            (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            // Carregando a imagem para o PictureBox
            pictureBox1.Image = Image.FromFile("C:\\Users\\wever\\source\\repos\\TelaLoginSL\\TelaLogin\\olho.png");

            // Defina o tamanho do PictureBox
            pictureBox1.Size = new System.Drawing.Size(16, 16);

            senhartext.PasswordChar = '*';



        }

        public System.ComponentModel.CancelEventArgs ef;

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void realizarregistro_Click(object sender, EventArgs e)
        {
            string usuario = usuariorbox.Text;
            string senha = senhartext.Text;
            string email = emailtext.Text;

            if (!TelaRegistro.ValidarSenha(senha))
            {
                MessageBox.Show("A senha deve conter no mínimo 8 caracteres, sendo eles letras maiusculas, minusculas e caracteres especiais");
                return;
            }

            //Criptografia Hash

            byte[] saltbytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltbytes);
            }

            string salt = Convert.ToBase64String(saltbytes);

            //combinar a senha com o sal

            string saltedpassword = senha + salt;

            // usando hash para senha combinada

            string hashedpassword;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedbytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(saltedpassword));
                hashedpassword = BitConverter.ToString(hashedbytes).Replace("-", "").ToLower();
            }

            try
             {
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();

                    string checkUserQuery = "SELECT COUNT(*) FROM Usuarios WHERE nome = @nome";

                    using (SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, cnn))
                    {
                        checkUserCommand.Parameters.AddWithValue("@nome", usuario);

                        int userCount = (int)checkUserCommand.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Este usuário já existe. Escolha outro nome de usuário.");
                            return; // Não insira o usuário se ele já existir
                        }
                    }

                    string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                    if (!Regex.IsMatch(email, emailPattern))
                    {
                        MessageBox.Show("E-mail inválido. Digite um e-mail válido no formato exemplo@dominio.com.");
                        emailtext.Focus();
                        ef.Cancel = true; // Impede a mudança de foco
                    }

                        string checkUserQueryemail = "SELECT COUNT(*) FROM Usuarios WHERE email = @email";

                    using (SqlCommand checkUserCommand = new SqlCommand(checkUserQueryemail, cnn))
                    {
                        checkUserCommand.Parameters.AddWithValue("@email", email);

                        int emailCount = (int)checkUserCommand.ExecuteScalar();

                        if (emailCount > 0)
                        {
                            MessageBox.Show("Este email já existe. Escolha outro email.");
                            return; // Não insira o usuário se ele já existir
                        }
                    }

                    if (!termos.Checked)
                    {
                        MessageBox.Show("Aceite os termos para continuar");
                        return;
                    }

                    if (TelaRegistro.ValidarSenha(senha))
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine("Senha inválida. A senha não atende aos critérios especificados.");
                    }

                    string query = "INSERT INTO Usuarios (nome, email, senha, salt, DataCadastro) VALUES (@usuario, @email, @senha, @salt, GETDATE())";

                    using (SqlCommand command = new SqlCommand(query, cnn))
                    {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", hashedpassword);
                    command.Parameters.AddWithValue("@salt", salt);
                    command.Parameters.AddWithValue("@email", email);

                    int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuário cadastrado com sucesso!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar o usuário.");
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Cadastrar o usuário.\n" +
                "Verifique os dados informados. Erro: " + erro.Message);

            }
        }

        public static bool ValidarSenha(string senha)
        {
            // Padrão da senha: pelo menos 8 caracteres, incluindo uma letra maiúscula, uma letra minúscula, caracter especial e um número.
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$";
            if (!Regex.IsMatch(senha, pattern))
            {
                return false; // Retorna falso se a senha não atender aos critérios
            }

            // O código continua aqui se a senha atender aos critérios
            return true;
        }

        private bool pictureBoxClicked = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBoxClicked)
            {

                // Carregando a imagem para o PictureBox (substitua o caminho pela localização da sua imagem)
                pictureBox1.Image = Image.FromFile("C:\\Users\\wever\\source\\repos\\TelaLoginSL\\TelaLogin\\visualizar.png");

                // Defina o tamanho do PictureBox
                pictureBox1.Size = new System.Drawing.Size(16, 16);
                senhartext.PasswordChar = '\0';
                pictureBoxClicked = false;

            }

            else
            {
                // Carregando a imagem para o PictureBox (substitua o caminho pela localização da sua imagem)
                pictureBox1.Image = Image.FromFile("C:\\Users\\wever\\source\\repos\\TelaLoginSL\\TelaLogin\\olho.png");

                // Defina o tamanho do PictureBox
                pictureBox1.Size = new System.Drawing.Size(16, 16);
                senhartext.PasswordChar = '*';
                pictureBoxClicked = true;
            }
        }
    }
}
