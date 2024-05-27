namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\romyvdhx\Documents\ma\bewijzenmap\p1.4\prog\2023P4ProgCs2");

            System.IO.FileInfo[] files = dir.GetFiles();
            System.IO.DirectoryInfo[] directories = dir.GetDirectories();
            for (int i = 0; i < directories.Length; i++) 
            {
                Console.WriteLine(directories[i]);
            }
        }
    }
}
