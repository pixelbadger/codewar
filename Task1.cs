
using System;
using System.IO;

namespace codewar
{
    /*
        Congratulations! As a hard working software developer you have you've decided to take a vacation at a nice resort on a tropical island.
        Before you leave, the trolls in accounting just need you to fix your expense report (expense_report.txt); apparently, something isn't quite adding up.
    */
    public class Task1 
    {
        private const int _part1Expected = int.MaxValue;
        private const int _part2Expected = int.MaxValue;

        private readonly string _puzzleInput;

        public Task1()
        {
            _puzzleInput = File.ReadAllText("expense_report.txt");
        }

        /*
            Specifically, they need you to find the two entries that sum to 2020 and then multiply those two numbers together.

            For example, suppose your expense report contained the following:

            1721
            979
            366
            299
            675
            1456
            
            In this list, the two entries that sum to 2020 are 1721 and 299. Multiplying them together produces 1721 * 299 = 514579, so the correct answer is 514579.

            Of course, your expense report is much larger. Find the two entries that sum to 2020; what do you get if you multiply them together?
        */
        private int Part1()
        {
            return 0;
        }

        /*
            The Elves in accounting are thankful for your help; one of them even offers you a starfish coin they had left over from a past vacation. 
            
            They offer you a second one if you can find three numbers in your expense report that meet the same criteria.

            Using the above example again, the three entries that sum to 2020 are 979, 366, and 675. Multiplying them together produces the answer, 241861950.

            In your expense report, what is the product of the three entries that sum to 2020?
        */
        private int Part2()
        {
            return 0;
        }

        public bool RunAssertions() 
        {
            var part1 = Part1();
            var part1Success = part1 == _part1Expected;
            Console.WriteLine($"{(part1Success ? "Pass" : "Fail")}: Expected part 1 answer {_part1Expected}, and got {part1}");

            var part2 = Part2();
            var part2Success = part2 == _part2Expected;
            Console.WriteLine($"{(part2Success ? "Pass" : "Fail")}: Expected part 2 answer {_part2Expected}, and got {part2}");

            return part1Success && part2Success;
        }
    }
}