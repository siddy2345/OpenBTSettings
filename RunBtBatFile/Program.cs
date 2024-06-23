using System.Diagnostics;

namespace RunBtBatFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecuteFile(@"%windir%\explorer.exe ms-settings:bluetooth");
        }

        public static void ExecuteFile(string command)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo(@"cmd.exe", "/c" + command);
            Process process;

            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;

            process = Process.Start(processInfo);

            process.Close();
        }
    }
}
