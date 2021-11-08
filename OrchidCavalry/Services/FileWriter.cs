using System;
using System.Threading.Tasks;
using Windows.Storage;

namespace OrchidCavalry.Services
{
    public class FileWriter : IFileWriter
    {
        private readonly Windows.Storage.StorageFolder storageFolder =
Windows.Storage.ApplicationData.Current.LocalFolder;

        public async Task WriteFileAsync(string fileName, string contents)
        {

            var storageFolder =
                ApplicationData.Current.LocalFolder;
            var ticketsFile =
                await storageFolder.GetFileAsync(fileName);


            await FileIO.WriteTextAsync(ticketsFile, contents);

        }

        public async Task<string> ReadFileAsync(string fileName)
        {

            var storageFolder =
                Windows.Storage.ApplicationData.Current.LocalFolder;
            var ticketsFile =
                await storageFolder.GetFileAsync(fileName);

            return await Windows.Storage.FileIO.ReadTextAsync(ticketsFile);

        }
    }
}
