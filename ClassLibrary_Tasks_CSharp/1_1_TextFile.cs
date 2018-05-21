using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibrary_Tasks_CSharp
{
    public class TextFile
    {
        public List<string> Text { get; set; }

        public string[] ReadFile(string path)
        {
            StreamReader reader = new StreamReader(path, Encoding.Default);
            Text = new List<string>();
            string line = reader.ReadLine();
            while (line != null)
            {
                Text.Add(line);
                line = reader.ReadLine();
            }
            reader.Close();
            return Text.ToArray();
        }



        public string[] DeleteParagraph(int k)
        {
            int pos = 0, count = 0, index = 0;
            bool ch = false;
            for (int i = 0; i < Text.Count; i++)
            {
                if (Text[i] != string.Empty && !ch)
                {
                    pos++;
                    ch = true;
                }

                if (Text[i] == string.Empty && ch)
                {
                    ch = false;
                }

                if (pos == k)
                {
                    if (count++ == 0)
                        index = i;
                }


            }
            Text.RemoveRange(index, count);


            return Text.ToArray();
        }
        public void WriteFile(string outpath)
        {
            StreamWriter writer = new StreamWriter(outpath);
            foreach (string s in Text)
            {
                writer.WriteLine(s);
            }
            writer.Close();
        }
    }
}
