namespace FizzBuzz
{
    internal class FizzBuzzGenerator
    {
        // Option 1
        //public string Convert(int number)
        //{
        //    if ( number % 5 == 0 && number % 3 == 0) return "FizzBuzz";
        //    if ( number % 5 == 0 ) return "Buzz";
        //    if ( number % 3 == 0 ) return "Fizz";
        //    return number.ToString();
        //}

        // Option 2
        public string Convert(int number)
        {
            string result = "";

            if (number % 3 == 0) 
                result += "Fizz";

            if (number % 5 == 0) 
                result += "Buzz";

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }
    }
}