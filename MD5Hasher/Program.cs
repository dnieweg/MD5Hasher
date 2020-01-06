using System;

namespace MD5Hasher
{
    class Program
    {
        
        static void Main(string[] args)

        {
            SystemConfig conf = new SystemConfig();

            string scanPath = "C:\\Users\\dn00g\\Documents\\test_scan_directory";
            conf.setDirectoryPath(scanPath);
            Console.WriteLine(String.Format("The Current Scanning Directory is : {0}",conf.getDirectoryPath() ) );
        }
    }
}
