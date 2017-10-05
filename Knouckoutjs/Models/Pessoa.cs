using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Knouckoutjs.Models
{
    public class Pessoa : IPessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Idade { get; set; }
        public string Email { get; set; }


        public IEnumerable<Pessoa> Get()
        {
            throw new NotImplementedException();
        }

        public Pessoa GetById(long id)
        {
            throw new NotImplementedException();
        }

        public bool Create(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public bool Update(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}