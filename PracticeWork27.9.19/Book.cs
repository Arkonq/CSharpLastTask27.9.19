using System;

namespace PracticeWork27._9._19
{
	[Serializable]
	public class Book
	{
		//[NonSerialized]
		public string Name { get; set; }
		public double Price { get; set; }
		public string Author { get; set; }
		public int Year { get; set; }
	}
}