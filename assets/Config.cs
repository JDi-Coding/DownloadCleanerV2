using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadCleanerV2.assets
{
    /// <summary>
    /// Class <c> Config </c> is a class that contains the configuration of the application.
    /// 
    /// Here we have the "DownloadFolderPath", Files and Folders Location.
    /// </summary>
    public class Config
    {

        public static string DownloadFolderPath = @"E:\Downloads\";

        private string[] Files;

        private string[] Folders;

        public Config()
        {
            DownloadFolderPath = SetDownloadFolderPath(); 
            Files = GetFiles(DownloadFolderPath);
            Folders = GetFolders(DownloadFolderPath);
        }

        public static string SetDownloadFolderPath()
        {
            // TODO: here later set the download folder path
            // based on the User Input or Default Path
            return @"E:\Downloads\";
        }

        public static string[] GetFiles(string path)
        {
            return System.IO.Directory.GetFiles(path);
        }

        public static string[] GetFolders(string path)
        {
            return System.IO.Directory.GetDirectories(path);
        }


    }
}
