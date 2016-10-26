using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFileWatcher
{
    public interface IFileWatcher
    {
        void StartWatchingFile(string path);
        void StopWatchingFile(string path);
    }
}
