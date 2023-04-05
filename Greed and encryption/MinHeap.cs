using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed_and_encryption
{
	internal class MinHeap<T> where T : IComparable<T>
	{
		private List<T> heap = new List<T>();

		public int Count => heap.Count;

		public void Add(T item)
		{
			heap.Add(item);
			int currentIndex = heap.Count - 1;

			while (currentIndex > 0)
			{
				int parentIndex = (currentIndex - 1) / 2;

				if (heap[currentIndex].CompareTo(heap[parentIndex]) >= 0)
				{
					break;
				}

				T temp = heap[currentIndex];
				heap[currentIndex] = heap[parentIndex];
				heap[parentIndex] = temp;

				currentIndex = parentIndex;
			}
		}

		public T Remove()
		{
			if (heap.Count == 0)
			{
				throw new InvalidOperationException("Heap is empty.");
			}

			T result = heap[0];
			heap[0] = heap[heap.Count - 1];
			heap.RemoveAt(heap.Count - 1);

			int currentIndex = 0;

			while (true)
			{
				int leftChildIndex = 2 * currentIndex + 1;
				int rightChildIndex = 2 * currentIndex + 2;

				if (leftChildIndex >= heap.Count)
				{
					break;
				}

				int smallerChildIndex = leftChildIndex;

				if (rightChildIndex < heap.Count && heap[rightChildIndex].CompareTo(heap[leftChildIndex]) < 0)
				{
					smallerChildIndex = rightChildIndex;
				}

				if (heap[currentIndex].CompareTo(heap[smallerChildIndex]) <= 0)
				{
					break;
				}

				T temp = heap[currentIndex];
				heap[currentIndex] = heap[smallerChildIndex];
				heap[smallerChildIndex] = temp;

				currentIndex = smallerChildIndex;
			}

			return result;
		}
	}
}
