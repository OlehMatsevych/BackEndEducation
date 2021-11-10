using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestSameAssembly();
            TestDefferentAssembly();
        }

        static void TestSameAssembly()
        {
            Console.WriteLine("Reflection in same assembly:");
            Console.WriteLine("**********************************************************************");

            Type classType = Type.GetType("Reflection.TriangleHelper");
            foreach (var member in classType.GetMembers())
            {
                Console.WriteLine($"Type: {member.DeclaringType}, Member: {member.MemberType}, Name: {member.Name}");
            }
        }
        static void TestDefferentAssembly()
        {

            Console.WriteLine("**********************************************************************");

            Console.WriteLine("Reflection in different assembly:");

            Assembly asm = Assembly.LoadFrom("C://Learning/CodePractices/Reflection/ReflectionTest/bin/Debug/netcoreapp3.1/ReflectionTest.dll");
            Type type = asm.GetType("ReflectionTest.StringHandler");

            object obj = Activator.CreateInstance(type, new object[] {"TEST" });
            var method = type.GetMethod("GetLowerText", BindingFlags.Instance | BindingFlags.NonPublic);
            var result = method.Invoke(obj, null);
            Console.WriteLine($"Result: {result}");

        }
    }



    public class TriangleHelper
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public double FindArea() =>
            0.5 * a * b;
        public int FindPerimeter() =>
            a + b + c;
    }
}
