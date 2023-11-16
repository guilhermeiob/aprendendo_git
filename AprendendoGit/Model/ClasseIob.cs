using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoGit.Model
{
    internal class ClasseIob
    {

        public string str = "String de teste";

        public int num = 10;

        public void funcao()
        {
            Console.WriteLine(str);
        }

        public void dobro()
        {
            num = num * 2;
        }

    }
}
