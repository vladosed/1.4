using System;

namespace lab_work_1._4
{
    class Program
    {
        enum ComputerType { Desktop, Laptop, Server };

        // 2) declare struct Computer
        struct Computer
        {
            public byte CPU_cores;
            public float CPU_frequency;
            public int memory;
            public int HDD;
        }

        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)
            Computer[,][] computers = new Computer[4, 3][];

            // 4) set the size of every array in jagged array (number of computers)
            computers[0, 0] = new Computer[2];
            computers[0, 1] = new Computer[2];
            computers[0, 2] = new Computer[1];
            computers[1, 0] = new Computer[0];
            computers[1, 1] = new Computer[3];
            computers[1, 2] = new Computer[0];
            computers[2, 0] = new Computer[3];
            computers[2, 1] = new Computer[2];
            computers[2, 2] = new Computer[0];
            computers[3, 0] = new Computer[1];
            computers[3, 1] = new Computer[1];
            computers[3, 2] = new Computer[2];

        }

    }
}
