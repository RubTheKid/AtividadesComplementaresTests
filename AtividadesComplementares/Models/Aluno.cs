using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesComplementares.Models
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        private List<Registro> AtivsAluno { get; set; }

        public Aluno(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
