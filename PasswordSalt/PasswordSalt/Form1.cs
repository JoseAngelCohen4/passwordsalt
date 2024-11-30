using System.Security.Cryptography;
using System.Text;

namespace PasswordSalt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            TxtUsuarioGuardado.Text = TxtUsuario.Text;

            GenerarSalt();
            TxtContrasenaGuardado.Text = HashPassword(TxtContrasena.Text, TxtSaltGuardado.Text);
        }


        private void GenerarSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var random = RandomNumberGenerator.Create())
            {
                random.GetBytes(saltBytes);
            }

            TxtSaltGuardado.Text = Convert.ToBase64String(saltBytes);
        }

        private string HashPassword(string contrasena, string salt)
        {
            string contrasenaSalt = $"{contrasena}{salt}";
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contrasenaSalt));
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            bool esValido = ValidarPassword(TxtContrasenaValidar.Text, TxtSaltGuardado.Text, TxtContrasenaGuardado.Text);
            if (esValido)
            {
                MessageBox.Show("Contraseña Correcta");
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
        }

        private bool ValidarPassword(string passwordAValidar, string salt, string passwordAlmacenado)
        {
            string passwordActual = HashPassword(passwordAValidar, salt);
            if (passwordActual == passwordAlmacenado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
