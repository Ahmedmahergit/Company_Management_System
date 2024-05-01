using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis;
using System;
using System.IO;
using static System.Net.WebRequestMethods;

namespace Company.PL.Helpers
{
    public static  class DocumentSettings
    {
        public static string UploadFile(IFormFile file, string FolderName)
        {
            //1.Get Location Folder Name

            string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "F:\\New folder (2)\\Mvc Project\\Company.PL\\Company.PL\\wwwroot\\Files\\Images\\", FolderName);

            //2.Get file Name And Make It Unique

            string FileName = $"{Guid.NewGuid()}{file.FileName}";

            //3.Get File Path[Folder Path + File Name]
            string FilePath =Path.Combine(FolderPath, FileName);

            //4.Save file

            using var Fs = new FileStream(FilePath, FileMode.Create);
            file.CopyTo(Fs);

            //5.Return File Name

            return FileName;
        }
    }
}
