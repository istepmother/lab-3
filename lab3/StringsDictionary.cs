namespace lab3;

public class StringsDictionary
{
    private const int InitialSize = 10000;
    
    private LinkedList[] _buckets = new LinkedList[InitialSize];
        
    public void Add(string key, string value)
        {
            int curHash = CalculateHash(key);
        
            int index = curHash % InitialSize;
            if (_buckets[index] == null)
            {
                _buckets[index] = new LinkedList();
            }
            _buckets[index].AddBack(new KeyValuePair(key, value));
        }

    public void Remove(string key)
        {
            int curHash = CalculateHash(key);
        
            int index = curHash % InitialSize;
            if (_buckets[index] == null)
            {
                throw new Exception("there is no such element (bucket is null)");
            }
            _buckets[index].RemoveByKey(key);
        }

    public string Get(string key)
        {
            int curHash = CalculateHash(key);
        
            int index = curHash % InitialSize;
            if (_buckets[index] == null)
            {
                throw new Exception("there is no such an element (bucket is null");
            }
            var pair = _buckets[index].GetItemWithKey(key);
            if (pair == null)
            {
                throw new Exception("there is no such an element(not on the list or list is empty");
            }
            return pair.Value;
        }
    
    private int CalculateHash(string key)
    {
        // function to convert string value to number
        int result = 0;
        foreach (var c in key) 
        {
            byte number = Convert.ToByte(c); 
            result += number * number;
        }
        return result;
    }
    
    public void PrintDictionary()
    {
        // to check what i've done
        for (int i = 0; i < InitialSize; i++)
        {
            Console.WriteLine($"THIS IS bucket number{i}");
            Console.WriteLine($"THIS IS bucket number{i}");
            Console.WriteLine($"THIS IS bucket number{i}");
            Console.WriteLine($"THIS IS bucket number{i}");
            Console.WriteLine($"THIS IS bucket number{i}");
            Console.WriteLine($"THIS IS bucket number{i}");
            Console.WriteLine($"THIS IS bucket number{i}");
            var variabBucket = _buckets[i];
            if (variabBucket != null)
            {
                variabBucket.PrintLinkedList();
            }
            else
            {
                Console.WriteLine("null");
            }
            
        }
    }
}