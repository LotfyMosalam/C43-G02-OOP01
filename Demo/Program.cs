using Common;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            TypeA typeA = new TypeA();
            // typeA.x = 10;   // InValid
            // typeA.y = 20;   // InValid
            typeA.z = 30;      // Valid
        }
    }
}
