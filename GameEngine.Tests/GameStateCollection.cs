using Xunit;

namespace GameEngine.Tests
{
    //     ICollectionFixture: Used to decorate xUnit.net test classes and collections to indicate a test which
    //     has per-test-collection fixture data. An instance of the fixture data is initialized
    //     just before the first test in the collection is run, and if it implements IDisposable,
    //     is disposed after the last test in the collection is run. To gain access to the
    //     fixture data from inside the test, a constructor argument should be added to
    //     the test class which exactly matches the TFixture.

    [CollectionDefinition("GameState collection")]
    public class GameStateCollection : ICollectionFixture<GameStateFixture> {}

}
