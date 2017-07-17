namespace myLib
{
    public class ApplicationCodeClass
    {
        public string combineArrayStringWithSpace(string[] stringArray)
        {
            string str = default(string);

            foreach (string item in stringArray)
            {
                str += item + " ";
            }

            return str.Trim();
        }
    }
}