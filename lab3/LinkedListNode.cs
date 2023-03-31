namespace lab3;

public class LinkedListNode
{
    public KeyValuePair Pair { get; set; }
        
    public LinkedListNode Next { get; set; }

    public LinkedListNode(KeyValuePair pair, LinkedListNode next = null)
    {
        Pair = pair;
        Next = next;
    }
}