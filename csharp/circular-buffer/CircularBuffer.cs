using System;


public class CircularBuffer<T>
{
    public T[] Table;
    public int RIndex; // Read Index
    public int LRIndex; // Last Read Index
    public int WIndex; // Write Index

    public CircularBuffer(int capacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentException("Capacity MUST be greater than 0");
        }
        Table = new T[capacity];
        LRIndex = -1;
        RIndex = 0;
        WIndex = 0;
    }

    public T Read()
    {

        if (Table[RIndex].Equals(default(T)))
        {
            throw new InvalidOperationException();
        }
        else
        {
            if (LRIndex == RIndex)
            {
                throw new InvalidOperationException();
            }
            RIndex++;
            RIndex = RIndex % Table.Length;
            LRIndex = RIndex;
            T result = Table[RIndex];
            return result;
        }
    }

    public void Write(T value)
    {
        Table[WIndex] = value;
        WIndex++;
        WIndex = WIndex % Table.Length;
    }

    public void Overwrite(T value)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public void Clear()
    {
        Read();
    }
}