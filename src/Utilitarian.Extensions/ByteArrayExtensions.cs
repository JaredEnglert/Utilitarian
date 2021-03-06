﻿using System.IO;

namespace Utilitarian.Extensions
{
    public static class ByteArrayExtensions
    {
        public static void ToFile(this byte[] bytes, string filePath)
        {
            var fileInfo = new FileInfo(filePath);

            // ReSharper disable once PossibleNullReferenceException
            if (!fileInfo.Directory.Exists)
            {
                Directory.CreateDirectory(fileInfo.Directory.FullName);
            }

            var binaryWriter = new BinaryWriter(File.OpenWrite(filePath));

            try
            {
                binaryWriter.Write(bytes);
            }
            finally
            {
                binaryWriter.Close();
            }
        }
    }
}
