using System;
namespace Intcode
{
    public class Instruction
    {
        public int ArgumentLength { get; set; }
        public Func<int[],int> Operation { get; set; }
        public Instruction(int argLength, Func<int[],int> operation)=>(ArgumentLength,Operation)=(argLength,operation);
    }
}