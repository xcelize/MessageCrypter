using System;
using System.Collections.Generic;
using System.Text;

namespace MessageCrypter
{
	public class Key
	{
		private char c_letter;
		private int c_origineIndex;
		private int c_ActualIndex;

		public Key(char letter, int origineIndex)
		{
			c_letter = letter;
			c_origineIndex = origineIndex;
		}

		public Key(char letter, int origineIndex, int textPosition) : this(letter, origineIndex)
		{
			c_origineIndex = textPosition;
		}

		public char Letter
		{
			get { return c_letter; }
			set { c_letter = value; }
		}
		public int OrigineIndex
		{
			get { return c_origineIndex; }
			set { c_origineIndex = value; }
		}
		public int TextPosition
		{
			get { return c_ActualIndex; }
			set { c_ActualIndex = value; }
		}
	}
}
