using System;
using System.IO;
using Xamarin.Forms;
using AgendaTrabalhoFinal.Droid.Database;
using AgendaTrabalhoFinal.Database;

[assembly: Dependency(typeof(FileHelper))]
namespace AgendaTrabalhoFinal.Droid.Database
{
    public class FileHelper: iFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}