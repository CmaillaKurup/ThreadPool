using System;
using System.Threading;
class ThreadPoolDemo 
{
    public void task1(object obj)
    {
        //for each time i ar smaller or equal to 2 
        //the consol will write the string
        for (int i = 0; i <= 2; i++)
        { 
            Console.WriteLine("Task 1 is being executed");
        }
    }
    public void task2(object obj)
    {
        //same as above
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine("Task 2 is being executed");
        }
    }

    static void Main()
    {
        ThreadPoolDemo tpd = new ThreadPoolDemo();
        for (int i = 0; i < 2; i++)
        {
            //tje waitCallback make sure that the command awaits til a new thread becomes availerble in the pool
            //ThreadPool.QueueUserWorkItem(tpd.task1);
            //ThreadPool.QueueUserWorkItem(tpd.task2);
            ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task1));
            ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task2));
        }
    
        Console.Read();
    }
}