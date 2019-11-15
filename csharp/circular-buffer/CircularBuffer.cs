using System;


public class CircularBuffer<T>
{
    public T[] Table;
    public int RIndex;
    public int WIndex;

    public CircularBuffer(int capacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentException("Capacity MUST be greater than 0");
        }
        Table = new T[capacity];
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
            RIndex++;
            RIndex = RIndex % Table.Length;
            T result = Table[RIndex];
            return result;
        }
    }

    public void Write(T value)
    {
        WIndex++;
        WIndex = WIndex % Table.Length;
        Table[WIndex] = value;
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