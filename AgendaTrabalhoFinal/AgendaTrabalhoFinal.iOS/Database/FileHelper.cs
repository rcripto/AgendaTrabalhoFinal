using System;
using System.IO;
using Xamarin.Forms;
using AgendaTrabalhoFinal.iOS.Database;
using AgendaTrabalhoFinal.Database;

[assembly: Dependency(typeof(FileHelper))]
namespace AgendaTrabalhoFinal.iOS.Database
{
    public class FileHelper: iFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, filename);
        }
    }
}