// See https://aka.ms/new-console-template for more information
using tpmodul4_1302210059.TPMOD4;

class Program
{
    static void Main(string[] args)
    {
        KodePos kodepos = new KodePos();
        Console.WriteLine(kodepos.getKodePos("Margasari"));

        DoorMachine doorMachine = new DoorMachine();
        doorMachine.close();
        doorMachine.locks();
        doorMachine.unlock();
        doorMachine.open();
        doorMachine.close();
    }
}