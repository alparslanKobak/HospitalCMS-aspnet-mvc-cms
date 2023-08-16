﻿using Microsoft.AspNetCore.Components.Web;

namespace App.API.Utils
{
    public class FileHelper
    {
        //public static async Task<string> FileLoaderAsync(IFormFile formFile)
        //{
        //    string fileName = "";

        //    fileName = formFile.FileName;

        //    string directory = Directory.GetCurrentDirectory() + "/wwwroot/Images/" + fileName;

        //    using var stream = new FileStream(directory, FileMode.Create);
        //    await formFile.CopyToAsync(stream);
        //    return fileName;
        //}

        public static bool FileRemover(string fileName, string filePath = "/wwwroot/Images/")
        {
            string directory = Directory.GetCurrentDirectory() + filePath + fileName;
            if (File.Exists(directory))
            {
                File.Delete(directory);
                return true;
            }
            return false;
        }

        public static async Task<string> FileLoaderAsync(IFormFile Image, string filePath = "/wwwroot/Images/")
        {
            if (Image == null || Image.Length <= 0)
                return null;

            string extension = Path.GetExtension(Image.FileName);
            string fileName = Guid.NewGuid().ToString() + extension;
            string directory = Directory.GetCurrentDirectory() + filePath;
            string fullPath = Path.Combine(directory, fileName);

            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await Image.CopyToAsync(stream);
            }
            return $"/Images/{fileName}";
        }

        public static async Task<string> FileLoaderAPI(IFormFile Image, string targetFolderPath, string imageTitle)
        {
            if (Image == null || Image.Length <= 0)
                return null;

            string extension = Path.GetExtension(Image.FileName);
            string fileName = imageTitle;
            string fullPath = Path.Combine(targetFolderPath, fileName);

            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await Image.CopyToAsync(stream);
            }

            return $"/Images/{fileName}";
        }


    }

}
