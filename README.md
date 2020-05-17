# xUnitTutorial
I took a reference from the Pluralsight course "Testing .NET Code with xUnit.net: Getting Started" by Jason Roberts

You can find the code for the below topics.

## [Boolean Asserts](https://github.com/copaliwal/xUnitTutorial/commit/c8b9e0ebec03567310b24719f85c8119b49c1cb5)
     - Assert.False(actualValue)
     - Assert.False(bool condition)
     - Assert.True(actualValue)
     - Assert.True(bool condition)

## [String Asserts](https://github.com/copaliwal/xUnitTutorial/commit/81bbf7410c67dff03ecbfbff388e49aa71f913ca)
     - Assert.Contains(string expectedSubstring, string actualString)
     - Assert.DoesNotContain(string expectedSubstring, string actualString)
	 - Assert.Matches(string expectedRegexPattern, string actualString);
     - Assert.DoesNotMatch(string expectedRegexPattern, string actualString)
	 - Assert.Equal(string expected, string actual)
	 - Assert.Equal(string expected, string actual, bool ignoreCase = false, bool ignoreLineEndingDifferences = false, bool ignoreWhiteSpaceDifferences = false)
	 - Assert.StartsWith(string expectedStartString, string actualString)
     - Assert.EndsWith(string expectedEndString, string actualString)
	 
## [Numeric Asserts](https://github.com/copaliwal/xUnitTutorial/commit/eae658dc864273db0b29753f5d4600d71913ece2)
     - Assert.InRange<T>(T actual, T low, T high)
	 - Assert.Equal<T>(T expected, T actual)
	 - Assert.NotEqual<T>(T expected, T actual)

## [Floating Point Asserts](https://github.com/copaliwal/xUnitTutorial/commit/d8b2178bc4ab8c9decae851e6481d282b272b879)
     - Assert.Equal(double expected, double actual, int precision)
	 - Assert.NotEqual(double expected, double actual, int precision)
	 
## [Null Asserts](https://github.com/copaliwal/xUnitTutorial/commit/bd7606f089336452877cc4161a53dc3163f09655)
	 - Assert.NotNull(object @object)
	 - Assert.Null(object @object)

## [Collection Asserts](https://github.com/copaliwal/xUnitTutorial/commit/a4571d71f727500b867fd7e7da1563d100e89806)
	 - Assert.All<T>(IEnumerable<T> collection, Action<T> action)
	 - Assert.Collection<T>(IEnumerable<T> collection, params Action<T>[] elementInspectors)
	 - Assert.Contains<T>(IEnumerable<T> collection, Predicate<T> filter)
	 - Assert.Empty(IEnumerable collection)
	 - Assert.NotEmpty(IEnumerable collection)
	 - Assert.Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual)
	 - Assert.NotEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual)
	 - Assert.Single<T>(IEnumerable<T> collection, Predicate<T> predicate)
	 
## [Object Type Asserts](https://github.com/copaliwal/xUnitTutorial/commit/1b715006910d4c41d28d9ff7d6a5b46dd960d65b)
	 - Assert.IsAssignableFrom(Type expectedType, object @object)
	 - Assert.IsType<T>(object @object)
	 - Assert.IsNotType<T>(object @object)

## [Object Instance Asserts](https://github.com/copaliwal/xUnitTutorial/commit/57254bfdab0520bbed395614b6b504960bf2226b)
	 - Assert.Equal<T>(T expected, T actual)
	 - Assert.NotEqual<T>(T expected, T actual)
	 - Assert.Contains<T>(T expected, IEnumerable<T> collection)
	 - Assert.Contains<TKey, TValue>(TKey expected, IReadOnlyDictionary<TKey, TValue> collection)
	 - Assert.DoesNotContain<TKey, TValue>(TKey expected, IDictionary<TKey, TValue> collection)
	 
## [Exception Asserts](https://github.com/copaliwal/xUnitTutorial/commit/f557223f6c83f5dc45548a4685746df1fc0a8e7f)
	 - Assert.Throws<T>(Func<Task> testCode)
	 - Assert.Throws(Type exceptionType, Func<object> testCode)
	 - Assert.Exception RecordException(Func<Task> testCode)
	 - Assert.Exception RecordException(Action testCode)
	 
## [Event Asserts](https://github.com/copaliwal/xUnitTutorial/commit/0cb710d950a8f6b09457b159921cbb75ae1513c8)
	 - RaisedEvent<T> Raises<T>(Action<EventHandler<T>> attach, Action<EventHandler<T>> detach, Action testCode) where T : EventArgs
	 
## [Categorizing Tests](https://github.com/copaliwal/xUnitTutorial/commit/017268d71ed86567c51da31eea44328e5f486430)
	 - [Trait(string name, string value)]
	 - Attribute used to decorate a test method with arbitrary name/value pairs ("traits").
	 
## [Skipping Tests](https://github.com/copaliwal/xUnitTutorial/commit/eccfbbdf4e9707021f5f0ea81b5eec4250dd9dbc)
	 - [Fact(Skip = "Skip this step in Run")]
	 - Marks the test so that it will not be run, and gets or sets the skip reason
	 
## [Test Output Messages](https://github.com/copaliwal/xUnitTutorial/commit/e13f5acab9297753be18a8c6ed0ae30139c5145f)
	 - ITestOutputHelper
	 - Represents a class which can be used to provide test output.
	 
## [Reducing Duplicated Code](https://github.com/copaliwal/xUnitTutorial/commit/24b6b694b372d4349574e3e33d7bf83309f5eee9)
	 - use DI or initialise sut (system under test) object in the class constroctor
	 
## [Sharing Context Between Tests](https://github.com/copaliwal/xUnitTutorial/commit/699c913a7539871d29b11ea64a61bfeee3a06934)
	 - IClassFixture
	 - Used to decorate xUnit.net test classes and collections to indicate a test which has per-test-class fixture data.An instance of the fixture data is initialized just before the first test in the class is run, and if it implements IDisposable, is disposed after the last test in the class is run.To gain access to the fixture data from inside the test, a constructor argument should be added to the test class which exactly matches the TFixture.Class fixtures must have a single parameterless constructor, and may take collection fixture types as constructor arguments.
	 
## [Sharing Context Across Test Classes](https://github.com/copaliwal/xUnitTutorial/commit/7ef2831e74d4bf23192f9c9c245aeef96661b71a)
	 - CollectionDefinitionAttribute
	 - Used to declare a test collection container class. The container class gives developers a place to attach interfaces like Xunit.IClassFixture and Xunit.ICollectionFixture that will be applied to all tests classes that are members of the test collection.
	 
## [Inline Data-Theory](https://github.com/copaliwal/xUnitTutorial/commit/f32fa1e626f3868d6d38b60686faf97116feedca)
	 - Adds the [Theory] & [InlineData] attributes to the test and can send data to test
	 - Provides a data source for a data theory, with the data coming from inline values.
	 
## [Member Data](https://github.com/copaliwal/xUnitTutorial/commit/6dabcbc64c87a728bbbf13480cb9b7fa65672f99)
	 - Add [MemberData] attribute to test
	 - MemberData: Provides a data source for a data theory, with the data coming from one of the following sources: 1. A static property 2. A static field 3. A static method
	 
## [External Data](https://github.com/copaliwal/xUnitTutorial/commit/1a4d69366fbf2953b59e70400fb0be65e18a5eb1)
	 - Same as MemberData just we read data from external sources
	 
## [Custom Attribute](https://github.com/copaliwal/xUnitTutorial/commit/f5c3966dd5ce1d3e18ee07a4ae4c21930d297a1e)
	 - Create Custome attribute deriving from DataAttribute class
	 - Abstract attribute which represents a data source for a data theory.Data source providers derive from this attribute and implement GetData to return the data for the theory. Caution: the property is completely enumerated by.ToList() before any test is run.Hence it should return independent object sets.
