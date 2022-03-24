using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_firstclass
{
    class Torneira
    {
        public String Cor { get; set; }
        public String Matérial { get; set; }
        public int Tamanho { get; set; }
        public int Altura { get; set; }
        public bool Estado { get; set; }

        public bool Abrir(int opcao)
        { 
            if(opcao == 1)
            {
                Estado = true;
            }
            return Estado;
        }

        public void Fechar()
        {
            Estado = false;

        }

        public void Jorrar()
        {

        }

    }
}
