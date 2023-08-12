namespace BowlingGame.Tests;

public class BowlingGameTest
{

    [Fact]
    public void TestFrameWithSpare() {
        var frame = new Frame();

        frame.roll(5);
        frame.roll(5);

        var _rolls = frame.rolls;

        Assert.False(_rolls[0].IsStrike);
        Assert.False(_rolls[0].IsSpare);

        Assert.False(_rolls[1].IsStrike);
        Assert.True(_rolls[1].IsSpare);
    }

    [Fact]
    public void TestFrameWithStrike() {
        var frame = new Frame();

        frame.roll(10);

        var _rolls = frame.rolls;

        Assert.True(_rolls[0].IsStrike);
        Assert.False(_rolls[0].IsSpare);
    }

    [Fact]
    public void TestNewRollsWithStrike() {
        var frame = new Frame();

        frame.roll(10);

        var ex = Record.Exception(() => {
            frame.roll(3);
        });

        Assert.NotNull(ex);
        Assert.Equal("You can't play in this frame anymore!", ex.Message);
    }

    [Fact]
    public void TestScoreWithStrike() {
        var game = new Game();
        var frame = new Frame();

        frame.roll(10);
        game.frameAttempt(frame);

        Assert.Equal(30, game.showScore());
    }

    [Fact]
    public void TestScoreWithSpare() {
        var game = new Game();
        var frame = new Frame();

        frame.roll(5);
        frame.roll(5);
        game.frameAttempt(frame);

        Assert.Equal(20, game.showScore());
    }

    [Fact]
    public void TestScore() {
        var game = new Game();
        var frame1 = new Frame();

        frame1.roll(5);
        frame1.roll(5);
        game.frameAttempt(frame1);

        var frame2 = new Frame();

        frame2.roll(5);
        frame2.roll(3);
        game.frameAttempt(frame2);

        Assert.Equal(28, game.showScore());
    }

    [Fact]
    public void TestGameLimit() {
        var game = new Game();

        var frame1 = new Frame();
        frame1.roll(5);
        frame1.roll(5);
        game.frameAttempt(frame1);

        var frame2 = new Frame();
        frame2.roll(3);
        frame2.roll(0);
        game.frameAttempt(frame2);

        var frame3 = new Frame();
        frame3.roll(1);
        frame3.roll(6);
        game.frameAttempt(frame3);

        var frame4 = new Frame();
        frame4.roll(8);
        frame4.roll(1);
        game.frameAttempt(frame4);
        
        var frame5 = new Frame();
        frame5.roll(6);
        frame5.roll(2);
        game.frameAttempt(frame5);

        var frame6 = new Frame();
        frame6.roll(1);
        frame6.roll(3);
        game.frameAttempt(frame6);

        var frame7 = new Frame();
        frame7.roll(3);
        frame7.roll(3);
        game.frameAttempt(frame7);

        var frame8 = new Frame();
        frame8.roll(1);
        frame8.roll(2);
        game.frameAttempt(frame8);

        var frame9 = new Frame();
        frame9.roll(2);
        frame9.roll(3);
        game.frameAttempt(frame9);

        var frame10 = new Frame();
        frame10.roll(7);
        frame10.roll(0);
        game.frameAttempt(frame10);

        var frame11 = new Frame();
        frame11.roll(6);
        frame11.roll(1);

        var ex = Record.Exception(() => {
            game.frameAttempt(frame11);
        });

        Assert.NotNull(ex);
        Assert.Equal("You can't play this game anymore!", ex.Message);



    }
}
