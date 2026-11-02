var queue = new Queue<string>();
queue.Enqueue("first");
queue.Enqueue("second");
queue.Enqueue("third");
while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}

var stack = new Stack<string>();
stack.Push("create");
stack.Push("edit");
stack.Push("delete");
Console.WriteLine(stack.Pop()); 
Console.WriteLine(stack.Peek()); 
Console.WriteLine(stack.Count); 