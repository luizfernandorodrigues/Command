using System;

namespace Command
{
    public class ConcretCommand : Command
    {
        public ConcretCommand(Receiver receiver) : base(receiver) { }
        public override void Execute()
        {
            receiver.Action();
        }
    }
}
