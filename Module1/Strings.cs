using System;
namespace Module1{
    class Strings
    {
        static void Main(String[] args)
        {
            string fname="Sriramoju";
            string lname="Varshith";
            string name=string.Concat(fname+" "+lname);
            Console.WriteLine(name);

            //string interpolation
            string name1= $"my name is {fname} {lname}";
            Console.WriteLine(name1);

            //access strings
            Console.WriteLine(fname[0]);
            Console.WriteLine(fname.IndexOf("S"));
            Console.WriteLine(name.Substring(10));
            
            
            
            
            
        }
    }
}