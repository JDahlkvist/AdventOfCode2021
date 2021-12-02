namespace TextHelper
{
    public static class InputReader
    {
        public static IEnumerable<string> GetInputLines()
        {
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            return System.IO.File.ReadLines(Path.Combine(projectFolder, @"Input.txt"));
        }
    }
}