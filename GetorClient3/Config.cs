using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GetorClient3
{
    class Config
    {
        static public string local = "";

        static public void Obterlocal()
        {
            string l = Environment.CurrentDirectory + "\\";
            if (File.Exists(l + "config.ianez"))
            {
                StreamReader leitor = new StreamReader(l + "config.ianez");
                local = leitor.ReadLine();
                leitor.Close();
            }

        }
    }
}
