﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InterfazGraficaV1.utils
{
    public sealed class Utils
    {
        public static String obtenerWSKey ()
        {
            string projectPath = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
            string wsKeyFilePath = Path.Combine(projectPath, "resources", "wskey.txt");

            if (!System.IO.File.Exists(wsKeyFilePath))
            {
                MessageBox.Show("El archivo wskey.txt no se encontró en la carpeta resources.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "WSKey not Found";
            }

            string WSKey = System.IO.File.ReadAllText(wsKeyFilePath).Trim();

            return WSKey;
        }
    }
}
