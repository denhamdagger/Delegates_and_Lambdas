using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lambdas
{
	[TestClass]
	public class _09_Lambda
	{
		class Person
		{
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public int Age { get; set; }

			public override string ToString()
			{
				return string.Format("{0} {1}, aged {2}", FirstName, LastName, Age);
			}
		}

		[TestMethod]
		public void Lambda09()
		{
			List<Person> people = new List<Person>() {
				new Person{FirstName = "Steve", LastName = "Chowles", Age = 46},
				new Person{FirstName = "Holly", LastName = "Chowles", Age = 8},
				new Person{FirstName = "Chloe", LastName = "Chowles", Age = 6},
				new Person{FirstName = "Alan",  LastName = "Kennard", Age = 45}
			};

			Console.WriteLine("\nAll People");
			foreach (Person p in people)
				Console.WriteLine(p);

			#region Notes
			// For all our examples we have used the FUNC delegate type. 
			// A FUNC type is a delegate that:
			//    Takes Zero or more inputs (up to 16)
			//    Return 1 output

			// There is also a PREDICATE delegate type that:
			//    Takes one input
			//    Return 1 bool output of TRUE or FALSE

			// In this example we want to find entries based on some PREDICATE
			// List<T> has a FindAll method with the following signature
			// public List<T> FindAll(Predicate<T> match)
			// where
			//   Predicate<T> = public delegate bool Predicate<in T>(T obj)

			// If we return TRUE, the object is returned
			// If we return FALSE, the object is NOT returned
			#endregion

			IEnumerable<Person> peopleFound = people.FindAll( x => x.LastName == "Chowles" );

			Console.WriteLine("\nPeople Found");
			foreach (Person p in peopleFound)
				Console.WriteLine(p);

		}
	}
}
