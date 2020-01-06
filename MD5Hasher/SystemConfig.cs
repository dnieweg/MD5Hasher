using System;
using System.Collections.Generic;
using System.Text;

namespace MD5Hasher
{
    class SystemConfig
    {
        private string directoryPath;
        private string currentWorkingDir;

        public String getDirectoryPath()
        {
            return directoryPath;
        }
        public void setDirectoryPath(string path)
        {
            directoryPath = path;
        }

        public String getCWDPath()
        {
            return currentWorkingDir;
        }
        public void setCWDPath(string path)
        {
            currentWorkingDir = path;
        }
    }
}
