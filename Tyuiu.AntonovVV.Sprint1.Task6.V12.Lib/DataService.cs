using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AntonovVV.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }
            string[] words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 0)
            {
                return false;
            }
            string lastWord = words[words.Length - 1];
            string originalWithoutLastWord = value.Substring(0, value.LastIndexOf(lastWord));
            return originalWithoutLastWord.Contains(lastWord);
        }
    }
}