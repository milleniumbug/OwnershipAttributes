using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnershipAttributes
{
	/// <summary>
	/// The callee takes ownership of the object which is passed as an argument:
	/// If the method is static, the object will be disposed before the method returns, or passed to another API marked with this attribute.
	/// If the method is non-static, the above can happen, or the object will be disposed in it's Dispose() implementation
	/// </summary>
	[AttributeUsage(AttributeTargets.Field|AttributeTargets.Property|AttributeTargets.Parameter)]
	public class ConsumesAttribute : Attribute
	{
		/// <summary>
		/// The condition under which this code consumes the object.
		/// </summary>
		public string Conditionally { get; set; }
	}
}
