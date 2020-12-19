using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
      class Explorer
    {
        protected DriveInfo[] Drives { set; get; }
      //protected string CurrentPath { set; get; }
        public Explorer()
        {
            Drives = DriveInfo.GetDrives();
            //CurrentPath = "";
        }
        public string[] GetDrivesList()
        {
            string[] DriveList = new string[Drives.Length];
            for(int i = 0; i < Drives.Length; i++)
            {
                DriveList[i] = Drives[i].ToString();
            }
            return DriveList;
        }
        public string GetDriveCapacity(string temp)
        {
            DriveInfo drive = new DriveInfo(temp);
            double GB = Double.Parse(drive.TotalSize.ToString());
            GB /= 1000000000;
            temp = GB.ToString("0.#");
            temp += " GB";
            return temp;
        }
        public string GetFreeDriveCapacity(string temp)
        {
            DriveInfo drive = new DriveInfo(temp);
            double GB = Double.Parse(drive.TotalFreeSpace.ToString());
            GB /= 1000000000;
            temp = GB.ToString("0.#");
            temp += " GB";
            return temp;
        }
        public string GetDriveType(string temp)
        {
            DriveInfo drive = new DriveInfo(temp);
            return drive.DriveFormat.ToString();
        }
        public string[] GetDirectoriesList(string temp)
        {
            DirectoryInfo driveinfo = new DirectoryInfo(temp);
            DirectoryInfo[] directorylist = driveinfo.GetDirectories();
            string[] res = new string[driveinfo.GetDirectories().Length];
            for(int i = 0; i < res.Length; i++)
            {
                res[i] = directorylist[i].ToString();
            }
            return res;
        }
        public string[] GetFilesList(string temp)
        {
            DirectoryInfo driveinfo = new DirectoryInfo(temp);
            FileInfo[] directorylist = driveinfo.GetFiles();
            string[] res = new string[driveinfo.GetFiles().Length];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = directorylist[i].ToString();
            }
            return res;
        }
        public string GetDirectorySize(string temp)
        {
            DirectoryInfo driveinfo = new DirectoryInfo(temp);
            double res = 0;
            foreach(FileInfo i in driveinfo.GetFiles("*",SearchOption.AllDirectories))
            {
                res += i.Length;
            }
            res /= 1000000;
            temp = res.ToString("0.##");
            temp += " MB";
            return temp;
        }
        public string GetFileSize(string temp)
        {
            FileInfo fileinfo = new FileInfo(temp);
            double res = fileinfo.Length;
            res /= 1000000;
            temp = res.ToString("0.##");
            temp += " MB";
            return temp;
        }
        public string GetFileDateOfCreation(string temp)
        {
            DateTime res = File.GetCreationTime(temp);
            temp = res.ToString();
            return temp;
        }
        public string GetDirectoryDateOfCreation(string temp)
        {
            DateTime res = Directory.GetCreationTime(temp);
            temp = res.ToString();
            return temp;
        }
        public string GetFileLastAccessDate(string temp)
        {
            DateTime res = File.GetLastAccessTime(temp);
            temp = res.ToString();
            return temp;
        }
        public string GetDirectoryLastAccessDate(string temp)
        {
            DateTime res = Directory.GetLastAccessTime(temp);
            temp = res.ToString();
            return temp;
        }
        public string GetFileLastWriteDate(string temp)
        {
            DateTime res = File.GetLastWriteTime(temp);
            temp = res.ToString();
            return temp;
        }
        public string GetDirectoryLastWriteDate(string temp)
        {
            DateTime res = Directory.GetLastWriteTime(temp);
            temp = res.ToString();
            return temp;
        }

    }
}
