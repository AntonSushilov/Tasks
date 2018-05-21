using System.IO;

namespace ClassLibrary_Tasks_CSharp
{
    public class BinaryFile
    {
        public double[] Arr1 { set; get; }
        public double[] Arr2 { set; get; }

        string path = @"C:\Users\Public\Documents\BinaryFile.dat";
        public void EditBinaryFile()
        {
            ReadBinaryFile(path, out long n);

            EditArr1(Arr1);

        }

        public void ReadBinaryFile(string path, out long n)
        {
            BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));
            n = reader.BaseStream.Length / sizeof(double);
            Arr1 = new double[n];
            for (int i = 0; i < n; i++)
            {
                Arr1[i] = reader.ReadDouble();
            }
            reader.Close();

        }

        public void EditArr1(double[] Arr1)
        {
            Arr2 = new double[Arr1.Length];
            Arr2[0] = Arr1[0];
            Arr2[Arr2.Length - 1] = Arr1[Arr1.Length - 1];
            for (int i = 1; i < Arr1.Length - 1; i++)
            {
                Arr2[i] = (Arr1[i - 1] + Arr1[i + 1]) / 2;
            }
        }
    }
}
