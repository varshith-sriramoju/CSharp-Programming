namespace Module1{
class Basic
{
    static void Main(String[] args)
    {
        Console.WriteLine("hello world");
        Console.Write("this is ");
        Console.Write("also in single line");
        Console.WriteLine();
        Console.WriteLine(123);
        Console.WriteLine("0.23F");
        Console.WriteLine(true);
 
        //DT and variables
        int num=12;
        String str="hello";
        string str1="hehe";
        char ch='a';
        bool isit=false;
        Console.WriteLine(str);
        Console.WriteLine(str1);
        Console.WriteLine(isit);

        //explicit typecasting 
        double someNum=1.234;
        int typeCast=(int)someNum;
        Console.WriteLine(typeCast);
        //built in mehtods
        Console.WriteLine(Convert.ToInt32(someNum));
        Console.WriteLine(Convert.ToString(someNum));
        
        
        


        
    }
}
}




