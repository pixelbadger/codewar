
using System;
using System.IO;

namespace codewar
{
    /*
        Your flight departs in a few days from the Luton airport; the easiest way down from here is via bike.
        The shopkeeper at Banburyshire Bike Rentals is having a bad day. "Something's wrong with our computers; we can't log in!" 
        
        You ask if you can take a look. Their password database seems to be a little corrupted. 
        Some of the passwords wouldn't have been allowed by the Official Banburyshire Policy that was in effect when they were chosen.
    */
    public class Task2
    {
        private const int _part1Expected = int.MaxValue;
        private const int _part2Expected = int.MaxValue;

        private readonly string _puzzleInput;

        public Task2()
        {
            _puzzleInput = File.ReadAllText("password_list.txt");
        }

        /*
            To try to debug the problem, they have created a list (your puzzle input) of passwords (according to the corrupted database)
            and the policy when that password was set.

            For example, suppose you have the following list:

            1-3 a: abcde
            1-3 b: cdefg
            2-9 c: ccccccccc

            Each line gives the password policy and then the password. The password policy indicates the lowest and highest number of times a given
            letter must appear for the password to be valid. For example, 1-3 a means that the password must contain a at least 1 time and at most 3 times.

            In the above example, 2 passwords are valid. The middle password, cdefg, is not; it contains no instances of b, but needs at least 1. The first
            and third passwords are valid: they contain one a or nine c, both within the limits of their respective policies.

            How many passwords are valid according to their policies?
        */
        private int Part1()
        {
            return 0;
        }

        /*
            While it appears you validated the passwords correctly, they don't seem to be what the Official Banburyshire Authentication System is expecting.

            The shopkeeper suddenly realizes that he just accidentally explained the password policy rules from his old job at the sled rental place down the street! 
            The Official Banburyshire Policy actually works a little differently.

            Each policy actually describes two positions in the password, where 1 means the first character, 2 means the second character, and so on. 
            (Be careful; Banburyshire Policies have no concept of "index zero"!) Exactly one of these positions must contain the given letter. 
            Other occurrences of the letter are irrelevant for the purposes of policy enforcement.

            Given the same example list from above:

            1-3 a: abcde is valid: position 1 contains a and position 3 does not.
            1-3 b: cdefg is invalid: neither position 1 nor position 3 contains b.
            2-9 c: ccccccccc is invalid: both position 2 and position 9 contain c.

            How many passwords are valid according to the new interpretation of the policies?
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