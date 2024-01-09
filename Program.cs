using System;


namespace DYNAMIC 
{
    internal class Program
    {
        static void Main(string[] args)
        {
           object obj = "Bravo";
            //obj.GetHashCode()

          var methodInfo = obj.GetType().GetMethod("get has code");
            methodInfo.Invoke(null, null);

            dynamic excelObject = "Bravo";
            excelObject.Optimize();
        }
    }
}