// EXCEEDING REQUIREMENTS DESCRIPTION:
// I added a Leveling system to enhance the gamification aspects of the program.
// As the player earns total points, their Level automatically updates based on 
// the formula Level = (Score / 500) + 1. The level displays next to their total score.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}