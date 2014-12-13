using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Kret
{
    public class SaveReadFile
    {
        public string Uri
        {
            set;
            get;
        }

        private List<Player> _players;

        public SaveReadFile(string FileName)
        {
            _players = new List<Player>();
            Uri = FileName;
            _readFile();
        }

        public List<Player> Players
        {
            get
            {
                return _players;
            }
        }

        private async Task _readFile()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///"+Uri));
            var stream = await file.OpenStreamForReadAsync();
            using (StreamReader sr = new StreamReader(stream))
            {
                while (sr.Peek() >= 0)
                {
                    var a = sr.ReadLine();
                    try
                    {
                        string[] ret = a.Split('|');
                        _players.Add(new Player(ret[0], int.Parse(ret[1])));
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.ToString());
                    }
                }
            }
        }
        
    }
}
