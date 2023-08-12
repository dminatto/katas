# Bowling Game

The Bowling Game Kata is a classic coding exercise used to practice test-driven development (TDD) and learn about the principles of writing clean, maintainable code. In this kata, a simple scoring system is implemented for a game of bowling.

![](https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExdjZsMGRpZnJkMmg4ZTJ4MjRyaXM1eGNlN2R2cTZvajQzcjlmOXhiMyZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/lzuOELD76TlmV2Dess/giphy.gif)

## Objective

The objective of this kata is to create a program that can calculate the score of a game of bowling based on the rolls of the player. The game consists of ten frames, and each frame can have up to two rolls. The score is calculated by adding up the pins knocked down in each frame, with bonuses for strikes and spares.

## Rules

1. Each game consists of ten frames.
2. In each frame, the player has two rolls to knock down ten pins.
3. If the player knocks down all ten pins with their first roll (a strike), they receive a bonus of the next two rolls.
4. If the player knocks down all ten pins with their two rolls (a spare), they receive a bonus of the next roll.
5. The maximum score for a frame is 30 (10 pins knocked down + bonus for a strike + bonus for a spare).
6. The final frame may have up to three rolls if a strike or spare is rolled.
7. The game ends after ten frames.

## Resources

- [Uncle Bob's Bowling Game Kata](http://butunclebob.com/ArticleS.UncleBob.TheBowlingGameKata)
- [Bowling Scoring](https://en.wikipedia.org/wiki/Ten-pin_bowling#Scoring)

Have fun coding and practicing your TDD skills! Remember, the goal is not only to make the tests pass but also to write clean and maintainable code.
