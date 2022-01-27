namespace FizzBuzzLibrary;
public class FizzBuzz
{
    //logic will fail, give  number and return nothing 
    public string GetResult(int nmbr)
    {
        string result = "";

        if (nmbr >1000){
            throw new Exception("Number exceed 1000");
        }

        if (nmbr <0){
            throw new Exception("Negative numbers are not allowed");
        }

        for (int ndx = 1; ndx < nmbr + 1; ndx++)
        {
            if (ndx % 3 == 0 && ndx % 5 == 0)
            {
                 result += "FizzBuzz ";

            }
            else if (ndx % 5 == 0)
            {
                result += "Buzz ";
            }
            else if (ndx % 3 == 0){
                result += "Fizz ";
            }
            else
            {
                result += ndx.ToString() + " ";
            }

        }
        return result;
    }

}
