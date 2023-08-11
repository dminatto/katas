namespace BowlingGame.Tests;

public class BowlingGameTest
{

    private int Roll(int n, int pins) {
        Game g = new Game();
        
        for(int i = 0; i < n; i++){
            g.roll(pins);
        }

        return g.score();
    }

    [Fact]
    public void TestGutterGame()
    {
        int score = Roll(0, 0);
        Assert.Equal(0, score);
    }

    [Fact]
    public void TestAllOnes() {
        int score = Roll(20, 1);
        Assert.Equal(20, score);
    }
}