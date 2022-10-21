using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLoginVini
{
    public class LoginUser
    {
        private string user;
        private string senha;

        public const string MensagemSobreLoginUsuario = "Preencha todos os campos!";
        public const string MensagemQuandoSenhaForIncorreta = "Senha incorreta!";


        public LoginUser() { }

        public LoginUser(string usuario, string password)
        {
            user = usuario;
            senha = password;
        }
        public string usuario { get { return user; } }
        public string password { get { return senha; } }

        public bool Login(string user, string senha)
        {
            if (user == "" || senha == "")
            {
                
                throw new ArgumentOutOfRangeException(MensagemSobreLoginUsuario);
            }
            else if (password != senha)
            {
                throw new ArgumentOutOfRangeException(MensagemQuandoSenhaForIncorreta);
            }

            return true;


        }
        static void Main(string[] args)
        {
            LoginUser log = new LoginUser();

            log.user = "vini";
            log.senha = "123";

            string usuarioInserido = "vini";
            string senhaInserida = "123";

            bool result = log.Login(usuarioInserido, senhaInserida);

            string respostalogin;
            if (result == true)
            {
                respostalogin = "Seja Bem Vindo Amigo";
            }
            else
            {
                respostalogin = "Sai fora Garoto!!";
            }
            Console.WriteLine(respostalogin);

            Console.ReadKey();
        }
    }
}
