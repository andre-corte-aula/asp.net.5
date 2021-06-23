using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ASPNet.Core5.API.Models.Response
{
    public class ClienteModel
    {
        public string Nome { get; private set; }

        public void PreencherNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Informe o nome");
            }

            Nome = nome;
        }
    }
}
