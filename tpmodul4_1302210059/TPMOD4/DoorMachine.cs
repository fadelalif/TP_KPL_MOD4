using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302210059.TPMOD4
{
    class DoorMachine
    {
        private State state;

        public DoorMachine()
        {
            state = new LockedState(this);
        }

        public void SetState(State state)
        {
            this.state = state;
        }

        public void unlock()
        {
            state.unlock();
        }

        public void locks()
        {
            state.lockDoor();
        }

        public void open()
        {
            state.open();
        }

        public void close()
        {
            state.close();
        }

        abstract class State
        {
            protected DoorMachine doorMachine;

            public State(DoorMachine doorMachine)
            {
                this.doorMachine = doorMachine;
            }

            public abstract void unlock();

            public abstract void lockDoor();

            public abstract void open();

            public abstract void close();
        }
        class LockedState : State
        {
            public LockedState(DoorMachine doorMachine) : base(doorMachine) { }

            public override void unlock()
            {
                Console.WriteLine("Membuka pintu...");
                doorMachine.SetState(new UnlockedState(doorMachine));
            }

            public override void lockDoor()
            {
                Console.WriteLine("Pintu sudah terkunci");
            }

            public override void open()
            {
                Console.WriteLine("Pintu terkunci");
            }

            public override void close()
            {
                Console.WriteLine("Pintu terkunci");
            }
        }
        class UnlockedState : State
        {
            public UnlockedState(DoorMachine doorMachine) : base(doorMachine) { }

            public override void unlock()
            {
                Console.WriteLine("Pintu sudah terbuka");
            }

            public override void lockDoor()
            {
                Console.WriteLine("Mengunci pintu...");
                doorMachine.SetState(new LockedState(doorMachine));
            }

            public override void open()
            {
                Console.WriteLine("Membuka pintu...");
                doorMachine.SetState(new OpenState(doorMachine));
            }

            public override void close()
            {
                Console.WriteLine("Pintu sudah tertutup");
            }
        }
        class OpenState : State
        {
            public OpenState(DoorMachine doorMachine) : base(doorMachine) { }

            public override void unlock()
            {
                Console.WriteLine("Pintu masih terbuka");
            }

            public override void lockDoor()
            {
                Console.WriteLine("Pintu masih terbuka");
            }

            public override void open()
            {
                Console.WriteLine("Pintu sudah terbuka");
            }

            public override void close()
            {
                Console.WriteLine("Menutup pintu...");
                doorMachine.SetState(new UnlockedState(doorMachine));
            }
        }
    }
}
