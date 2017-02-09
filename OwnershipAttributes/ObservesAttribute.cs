using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnershipAttributes
{
	/// <summary>
	/// This method promises it won't dispose the passed in object, it does however expect it will be not disposed before the function ends.
	/// </summary>
	[AttributeUsage(AttributeTargets.Parameter|AttributeTargets.Property|AttributeTargets.Field)]
	public class ObservesAttribute : Attribute
	{
		/// <summary>
		/// The condition under which this code observes the object.
		/// </summary>
		public string Conditionally { get; set; }

		public LifetimeExpectation With { get; set; }
	}

	public enum LifetimeExpectation
	{
		Method,
		Object
	}
}
