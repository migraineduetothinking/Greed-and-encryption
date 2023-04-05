using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Greed_and_encryption
{
	internal class HuffmanNode : IComparable<HuffmanNode>
	{
		public int Frequency { get; set; }
		public char Symbol { get; set; }
		public HuffmanNode LeftChild { get; set; }
		public HuffmanNode RightChild { get; set; }


		public HuffmanNode(char symbol, int frequency)
		{
			Symbol = symbol;
			Frequency = frequency;
		}

		public HuffmanNode(HuffmanNode left, HuffmanNode right)
		{
			Frequency = left.Frequency + right.Frequency;
			LeftChild = left;
			RightChild = right;
		}


		public int CompareTo(HuffmanNode other)
		{
			return this.Frequency - other.Frequency;
		}

		public bool IsLeaf()
		{
			return (LeftChild == null && RightChild == null);
		}
	}
}
