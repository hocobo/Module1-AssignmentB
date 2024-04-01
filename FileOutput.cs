using System;
using System.IO;

namespace Module1_AssignmentB
{
    public class FileOutput
    {
        private StreamWriter _out = null;
        private string _fileName;

        public FileOutput(string fileName)
        {
            _fileName = fileName;
            try
            {
                _out = new StreamWriter(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.Write("File Open Error: " + fileName + " " + e);
            }
        }

        public void FileWrite(string line)
        {
            try
            {
                _out.Write(line + "\n");
            }
            catch (Exception e)
            {
                Console.Write(("File Write Error: " + _fileName + " " + e));
            }
        }

        public void FileClose()
        {
            if (_out != null)
            {
                try
                {
                    _out.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}