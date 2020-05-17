using Xunit;

namespace GameEngine.Tests
{
    public class NonPlayerCharacterShould
    {
        [Theory]
        // MemberData: Provides a data source for a data theory, with the data coming from one of the
        // following sources: 1. A static property 2. A static field 3. A static method
        [MemberData(nameof(InternalHealthDamageTestData.TestData), 
            MemberType= typeof(InternalHealthDamageTestData))]
        public void TakeDamage(int damage, int expectedHealth)
        {
            NonPlayerCharacter sut = new NonPlayerCharacter();

            sut.TakeDamage(damage);

            Assert.Equal(expectedHealth, sut.Health);
        }

        [Theory]
        // ExternalHealthDamageTestData: Fetching data from external source e.g. csv file 
        // & sharing in Static Property with MemberData
        [MemberData(nameof(ExternalHealthDamageTestData.TestData),
            MemberType = typeof(ExternalHealthDamageTestData))]
        public void TakeDamageExternalValue(int damage, int expectedHealth)
        {
            NonPlayerCharacter sut = new NonPlayerCharacter();

            sut.TakeDamage(damage);

            Assert.Equal(expectedHealth, sut.Health);
        }
    }
}
