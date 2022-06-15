// See https://aka.ms/new-console-template for more information

// Start the child process.

using System.Diagnostics;
using System.Text;

/*Process p = new Process();
// Redirect the output stream of the child process.
p.StartInfo.UseShellExecute = false;
p.StartInfo.RedirectStandardOutput = true;
p.StartInfo.FileName = "YOURBATCHFILE.bat";
p.Start();
// Do not wait for the child process to exit before
// reading to the end of its redirected stream.
// p.WaitForExit();
// Read the output stream first and then wait.
string output = p.StandardOutput.ReadToEnd();
p.WaitForExit();*/

Encoding defaultEnc = new UTF8Encoding();

try
{
    System.Diagnostics.ProcessStartInfo process = new System.Diagnostics.ProcessStartInfo();
    process.UseShellExecute = false;
    process.FileName = "lpstat";
    process.Arguments = "-e";
    process.RedirectStandardOutput = true;

    System.Diagnostics.Process cmd =  System.Diagnostics.Process.Start(process);

    string? line;

    while ((line = cmd.StandardOutput.ReadLine()) != null )
    {
        Console.WriteLine(line);
    }
    
    //string output = cmd.StandardOutput.ReadToEnd();
// waiting to complete 
    cmd.WaitForExit();

}
catch (Exception e)
{

}

