using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadCleanerV2.assets
{
    public class Cleaner : Config
    {
        //TODO: Implement the Cleaner Class
        // LOGIC to move the Files to the respective folders
        public Cleaner()
        {
            DownloadFolderPath = SetDownloadFolderPath();
            CreateFolders(DownloadFolderPath);

            Files = GetFiles(DownloadFolderPath);
            Folders = GetFolders(DownloadFolderPath);

            _FolderNames = new string[] {
                "Images", "Video",
                "Audio",  "Zips",
                "Office","Installations",
                "Sys-Image", "Code",
                "Ohter"
            };
            _FolderNames = FolderNames;
        }

        public void StartCleaning()
        {
            foreach (string File in Files)
            {
           
                DecideFolder(File);
            }
        }
    }

}
