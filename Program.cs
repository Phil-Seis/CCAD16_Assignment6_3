//use a queue class
//include time date stamp in message
//maybe location

using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Queue<Call> callQueue = new Queue<Call>();

        // Using Enqueue to add callers to the queue
        Console.WriteLine("***Callers in queue***");
        callQueue.Enqueue(new Call(1, "Alice", "New York"));
        callQueue.Enqueue(new Call(2, "Bob", "Los Angeles"));
        callQueue.Enqueue(new Call(3, "Charlie", "Chicago"));
        callQueue.Enqueue(new Call(4, "Diana", "Houston"));
        callQueue.Enqueue(new Call(5, "Eve", "Miami"));

        // Enumerate the queue
        foreach (Call call in callQueue)
        {
            Console.WriteLine(call);
        }

        // Using dequeue to remove callers
        Console.WriteLine("");
        Console.WriteLine("***Removing the following callers from the queue***");
        Console.WriteLine("{0}", callQueue.Dequeue());
        Console.WriteLine("{0}", callQueue.Dequeue());
        Console.WriteLine("{0}", callQueue.Dequeue());

        // Enumerate the new queue
        Console.WriteLine("");
        Console.WriteLine("***Updated queue of callers***");
        foreach (Call call in callQueue)
        {
            Console.WriteLine(call);
        }
    }
}
public class Call
{
    public int CallId { get; set; }
    public string CallerName { get; set; }
    public DateTime Timestamp { get; set; }
    public string Location { get; set; }

    public Call(int callId, string callerName, string location = "Unknown")
    {
        CallId = callId;
        CallerName = callerName;
        Timestamp = DateTime.Now;
        Location = location;
    }
    public override string ToString()
    {
        return $"Call ID: {CallId}, Caller Name: {CallerName}, Timestamp: {Timestamp}, Location: {Location}";
    }
}


