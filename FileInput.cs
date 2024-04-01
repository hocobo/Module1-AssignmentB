using System;
using System.Diagnostics;
using System.IO;

namespace Module1_AssignmentB
{
    public class FileInput
    {
        private StreamReader _in = null;
        private string _fileName;

        public FileInput(string fileName)
        {
            _fileName = fileName;
            try
            {
                _in = new StreamReader(_fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.Write("File Open Error: " + _fileName + ' ' + e);
            }
        }

        public void FileRead()
        {
            string line;
            try
            {
                while ((line = _in.ReadLine()) != null)
                {
                    Console.Write(line);
                }
            } catch (Exception e) {
                Console.Write("File Write Error: " + _fileName + " " + e);
            }
        }

        public string FileReadLine()
        {
            try
            {
                string line = _in.ReadLine(); 
                return line;
            }catch (Exception e) {
                Console.Write("File Write Error: " + _fileName + " " + e);
                return null;
            }
        }

        public void FileClose()
        {
            if (_in != null)
            {
                try
                {
                    _in.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}