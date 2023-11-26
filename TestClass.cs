using Xunit;

public class TestClass {
    
    // [Theory]
    // [InlineData(3)]
    // [InlineData(5)]
    // [InlineData(6)]
    // public void checkingIfOdd (int number) {
    //     Program program = new Program();
    //     Assert.True(program.isOdd(number));
    // }

    [Fact]
    public void FirstUniqueCharacterTest() {
        Utils utils = new Utils();
        Assert.Equal(0, utils.FirstUniqueCharacter("leetcode"));
        Assert.Equal(2, utils.FirstUniqueCharacter("loveleetcode"));
        Assert.Equal(-1, utils.FirstUniqueCharacter("aabb"));
    }

}