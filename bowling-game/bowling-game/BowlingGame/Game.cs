namespace BowlingGame;

public class Game
{
    private int scorePoints = 0;

    public void roll(int pins) {
        scorePoints += pins;
    }

    public int score() {
        return scorePoints;
    }

}
