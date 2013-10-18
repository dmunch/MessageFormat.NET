using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageFormat.NET
{
	class Message
	{
		public List<Segment> Segments;
		public Message Parent { get; protected set; }
		public List<Message> Children { get; protected set; }

		public Message(Message parent)
		{
			this.Segments = new List<Segment>();
			this.Parent = parent;
			this.Children = new List<Message>();

			if(parent != null)
				parent.Children.Add(this);
		}
	}

    class Segment
    {
    }

    class TextSegment : Segment
    {
        public string Text { get; set; }

        public TextSegment(string text) 
        {
            this.Text = text;
        }
    }

    class Argument
    {
        public Type Type { get; protected set; }

        public Argument()
        {
			Type = typeof(object);
        }

		public void SetType(string typeAsString)
		{
			switch (typeAsString)
			{
				case "number":
					Type = typeof(decimal);
					break;
				case "date":
					Type = typeof(DateTime);
					break;
				case "time":
					Type = typeof(DateTime);
					break;
				case "spellout":
					//301 three-hundred-one
					Type = typeof(decimal);
					break;
				case "ordinal":
					//"one", "two", "three", "four", ... 
					Type = typeof(int);
					break;
				case "duration":
					Type = typeof(TimeSpan);
					break;
			}
		}
    }

	class NamedArgument : Argument
	{
		public string Name { get; protected set; }

		public NamedArgument(string name)
		{
			this.Name = name;
		}
	}

	class NumberedArgument : Argument
	{
		public int Number { get; protected set; }

		public NumberedArgument(int number)
		{
			this.Number = number;
		}
	}

	class ArgSegment : Segment
	{
		public Argument Argument { get; set; }

		public ArgSegment()
		{
		}

		public ArgSegment(Argument arg)
		{
			this.Argument = arg;
		}
	}

    class PluralSegment : ArgSegment
    {
		public List<PluralAlternative> Alternatives { get; protected set; }
		public int Offset { get; set; }

		public int ExplicitValue { get; set; }
		public string Keyword { get; set; }

		public PluralSegment(Argument arg) 
			:base(arg)
        {
			this.Alternatives = new List<PluralAlternative>();
        }

		public PluralSegment()
		{
			this.Alternatives = new List<PluralAlternative>();
		}
    }

	class PluralAlternative
	{
		public Message Message { get; set; }
	}

	class PluralExplicitAlternative : PluralAlternative
	{
		public int ExplicitValue { get; set; }
	}

	class PluralKeywordAlternative : PluralAlternative
	{
		public string Keyword { get; set; }
	}
}
