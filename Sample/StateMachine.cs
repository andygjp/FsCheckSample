using System.Collections.Generic;

namespace Sample
{
    public class StateMachine
    {
        public State State { get; private set; }

        public List<string> History { get; } = new List<string>();

        public void Initialize()
        {
            State = State.Initialised;
            History.Clear();
        }
    }
}