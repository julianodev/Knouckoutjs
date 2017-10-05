using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knouckoutjs.Models
{
    public interface IPessoa
    {
        string Nome { get; set; }
        string Sobrenome { get; set; }

        DateTime Idade { get; set;}

        string Email { get; set; }

        IEnumerable<Pessoa> Get();

        Pessoa GetById(long id);

        bool Create (Pessoa pessoa);

        bool Update(Pessoa pessoa);

        bool Delete (Pessoa pessoa);

    }
}
