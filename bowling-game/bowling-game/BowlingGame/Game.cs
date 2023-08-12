namespace BowlingGame;

using System.Linq;

public class Roll {

    public Roll (int pinsKnocked, bool isStrike, bool isSpare) {
        PinsKnocked = pinsKnocked;
        IsStrike = isStrike;
        IsSpare = isSpare;
    }

    public int PinsKnocked { get; set; }
    public bool IsStrike { get; set; }
    public bool IsSpare { get; set; }
}

public class Frame {

    const int PinsPerFrame = 10;

    public List<Roll> rolls = new List<Roll>();
    private int attempt = 0;
    private int pinsInGame = PinsPerFrame;

    public bool canPlay() {
        return (attempt <= 2 && pinsInGame > 0);
    }

    public void roll(int pinsKnocked) {

        if (!canPlay()) throw new Exception("You can't play in this frame anymore!");
        
        pinsInGame -= pinsKnocked;

        rolls.Add(new Roll(pinsKnocked, (attempt == 0 && pinsKnocked == PinsPerFrame), (attempt > 0 && pinsInGame == 0)));

        attempt++;
    }
}

public class Game {

    const int BonusSpare = 10;
    const int BonusStrike = 20;
    const int FramesLength = 10;

    public List<Frame> frames = new List<Frame>();
    

    public void frameAttempt(Frame _frame) {
        if(frames.Count() >= FramesLength) throw new Exception("You can't play this game anymore!");
        frames.Add(_frame);
    }

    public int showScore() {
        var score = 0;

        foreach (Frame frame in frames) {
            var rollsInFrame = frame.rolls;
            
            for(int i = 0; i < rollsInFrame.Count(); i++) {
                score += rollsInFrame[i].PinsKnocked;
                score += (rollsInFrame[i].IsStrike) ? BonusStrike : 0;
                score += (rollsInFrame[i].IsSpare) ? BonusSpare : 0;
            }
        }

        return score;
    }
}
