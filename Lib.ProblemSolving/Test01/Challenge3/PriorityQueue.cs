namespace Lib.ProblemSolving.Test01.Challenge3;

public class PriorityQueue<T> where T : IComparable<T>
{
    private List<T> heap = new List<T>();

    public int Count => heap.Count;

    public void Enqueue(T item)
    {
        heap.Add(item);
        int i = heap.Count - 1;

        while (i > 0)
        {
            int parent = (i - 1) / 2;
            if (heap[parent].CompareTo(heap[i]) <= 0)
                break;

            Swap(parent, i);
            i = parent;
        }
    }

    public T Dequeue()
    {
        T result = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);

        int i = 0;
        while (true)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left >= heap.Count)
                break;

            int smallestChild = left;
            if (right < heap.Count && heap[right].CompareTo(heap[left]) < 0)
                smallestChild = right;

            if (heap[i].CompareTo(heap[smallestChild]) <= 0)
                break;

            Swap(i, smallestChild);
            i = smallestChild;
        }

        return result;
    }

    private void Swap(int i, int j)
    {
        T temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }
}