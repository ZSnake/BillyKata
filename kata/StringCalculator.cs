using System.Collections;

namespace kata
{
    public class StringCalculator
    {
        public int Add(string number)
        {
            var sum = 0;

            foreach (var item in number.Split(',','\n'))
            {
                int n;
                int.TryParse(item, out n);
                sum += n;
            }

            return sum;
        }
    }
}