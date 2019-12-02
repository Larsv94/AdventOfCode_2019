using System.Linq;
using System;
using System.Collections.Generic;
namespace Intcode
{
    public class Computer
    {
        private int[] MemoryBackup {get; set; }
        private int[] Memory { get; set; }

        private int InstructionPointer = 0;
        public Computer(int[] input)
        {
           this.MemoryBackup = input;
           Reset();
        }
        public (int noun,int verb) Attempt(Range range,int expectedResult){
            return (0,0);
        }
        public void Reset(){
            this.Memory = (int[])MemoryBackup.Clone();
            InstructionPointer = 0;
        }
        public int Process()
        {
            Instruction currentInstruction;
            while((currentInstruction=InstructionFactory.Create(Next()))!=null){
                var instructionArgumentPosition = NextRange(currentInstruction.ArgumentLength);
                var instructionArguments = instructionArgumentPosition.Select(pos=>Memory[pos]).ToArray();
                var instructionResult = currentInstruction.Operation(instructionArguments);
                int storePostion = Next();
                Memory[storePostion] = instructionResult;
            }
            return Memory[0];
        }
        private int Next(){
            var nextPos = InstructionPointer++;
            return nextPos >= Memory.Length ? 99: Memory[nextPos];
        }
        private int[] NextRange(int steps){
            Range range = InstructionPointer..(InstructionPointer+=steps);
            return Memory[range];
        }
    }
}