using System;
using System.Collections.Generic;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Greed_and_encryption
{


	internal class Program
	{

		static void Main(string[] args)
		{
			string InputFilePath = @"D:\projects\Greed and encryption\Greed and encryption\SherLocked.txt";


			string EncodedFilePath = @"D:\projects\Greed and encryption\Greed and encryption\encoded.txt";

			string EncodedBytesFilePath = @"D:\projects\Greed and encryption\Greed and encryption\encodedBytes.txt";


			string DecodedFilePath = @"D:\projects\Greed and encryption\Greed and encryption\decoded.txt";

			string DecodedBytesFilePath = @"D:\projects\Greed and encryption\Greed and encryption\decodedBytes.txt";



			string fileContent = File.ReadAllText(InputFilePath);


			HuffmanTree huffmanTree = new HuffmanTree(fileContent);

			
			huffmanTree.PrintEncodingTable();

			Console.WriteLine("\n");

			//Char encoding and decoding from string to string
			string encodedText = huffmanTree.Encode(fileContent);
			Console.WriteLine("Encoded text: " + encodedText + "\n");

			string decodedText = huffmanTree.Decode(encodedText);
			Console.WriteLine("Decoded text using Decode: " + decodedText );


			//Char encoding to file, decoding from file to string and from file to file
			huffmanTree.EncodeToFile(InputFilePath, EncodedFilePath);

			string decodedFromFile = huffmanTree.DecodeFromFile(EncodedFilePath);
			Console.WriteLine("Decoded text using DecodeFromFile: " + decodedFromFile + "\n");

			huffmanTree.DecodeFromFileToFile(EncodedFilePath, DecodedFilePath);


			//Byte encoding to file, decoding from file to string and from file to file
			huffmanTree.EncodeBytesToFile(InputFilePath, EncodedBytesFilePath);

			string decodedBytesFromFile = huffmanTree.DecodeBytesFromFile(EncodedBytesFilePath);
			Console.WriteLine("Decoded text using DecodeBytesFromFile: " + decodedBytesFromFile + "\n");

			huffmanTree.DecodeBytesFromFileToFile(EncodedBytesFilePath, DecodedBytesFilePath);



		}


	}

}