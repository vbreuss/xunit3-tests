namespace Example.Tests
{
	public class ExplicitUnitTests
	{
		[Fact(Explicit = true)]
		public void ExplicitFact()
		{
			Assert.True(false);
		}

		[Theory(Explicit = true)]
		[InlineData(1)]
		[InlineData(2)]
		public void ExplicitTheory(int value)
		{
			Assert.True(false);
		}
	}
}