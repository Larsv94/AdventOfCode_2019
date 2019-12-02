namespace Intcode
{
    public class InstructionFactory
    {
        public static Instruction Create(int type)=>
            type switch{
                1 => new Instruction(2,(args)=>args[0]+args[1]),
                2 => new Instruction(2,(args)=>args[0]*args[1]),
                _ => null,
            };
    }
}