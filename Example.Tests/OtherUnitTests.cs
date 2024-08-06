namespace Example.Tests
{
	public class OtherUnitTests
	{
		[Fact]
		public void FailingFact()
		{
			Assert.True(false);
		}

		[Theory]
		[InlineData(1)]
		[InlineData(2)]
		public void SucceedingTheory(int value)
		{
			Assert.True(value > 0);
		}
	}
}