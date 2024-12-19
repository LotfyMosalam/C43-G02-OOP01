using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    namespace Models
    {
        class Employee
        {
            
        }
    }

    public class TypeA
    {
        private int x;
        internal int y;
        public int z;
    }


    public struct TypeZ
    {

    }


    public interface IBehaviour
    {
        public void Accelerate();
    }


    public enum Gender : byte
    {
        Male = 100, Female = 200
    }


    public delegate string Func(int Number);


    public record Person(int Id, string Name);


}
    
