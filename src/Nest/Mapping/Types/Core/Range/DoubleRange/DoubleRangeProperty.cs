using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	/// <summary>
	/// A range of double-precision 64-bit IEEE 754 floating point values.
	/// </summary>
	[InterfaceDataContract]
	public interface IDoubleRangeProperty : IRangeProperty { }

	/// <inheritdoc cref="IDoubleRangeProperty"/>
	public class DoubleRangeProperty : RangePropertyBase, IDoubleRangeProperty
	{
		public DoubleRangeProperty() : base(RangeType.DoubleRange) { }
	}

	/// <inheritdoc cref="IDoubleRangeProperty"/>
	public class DoubleRangePropertyDescriptor<T>
		: RangePropertyDescriptorBase<DoubleRangePropertyDescriptor<T>, IDoubleRangeProperty, T>, IDoubleRangeProperty
		where T : class
	{
		public DoubleRangePropertyDescriptor() : base(RangeType.DoubleRange) { }
	}
}
