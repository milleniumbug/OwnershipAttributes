using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OwnershipAttributes
{
	/// <summary>
	/// The function or property marked with this attribute produces an object which the caller has the responsibility of disposing.
	/// This object can be produced through a return value, or an `out` or `ref` parameter
	/// </summary>
	[AttributeUsage(AttributeTargets.Property|AttributeTargets.ReturnValue|AttributeTargets.Parameter)]
	public class ProducesAttribute : Attribute
	{
		/// <summary>
		/// The condition under which this code produces the object.
		/// </summary>
		public string Conditionally { get; set; }
	}
}
