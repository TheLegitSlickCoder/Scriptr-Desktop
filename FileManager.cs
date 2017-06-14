using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Scriptr
{
  internal class FileManager
  {
    private string getDesktopPath()
    {
      return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    }

    public void saveJSFile(string code)
    {
      string str1 = "<script>" + code + "</script>";
      string str2 = this.getDesktopPath() + "\\script.html";
      try
      {
        File.Create(str2).Dispose();
        StreamWriter streamWriter = new StreamWriter(str2);
        streamWriter.WriteLine(str1);
        streamWriter.Dispose();
        Process.Start(str2);
      }
      catch
      {
        int num = (int) MessageBox.Show("[ERROR]: Could not run script.");
      }
    }
  }
}
