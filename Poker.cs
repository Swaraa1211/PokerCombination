namespace PokerCombination
{
    internal class Poker
    {
        public static char[] pokerArr = { 'A', '2', '3', '4', '5', '6', '7', '8', '9', '1', 'J', 'Q', 'K' };
        public static string[] userInput = { "", "", "", "", "" };
        static void Main(string[] args)
        {
            //string[] inputPoker = { };
            string[] inputRoyalFlush = { "10h", "Jh", "Qh", "Ah", "Kh" };
            string[] inputStraightFlush = { "2h", "3h", "4h", "5h", "6h" };
            string[] inputFourOfAKind = { "8s", "10c", "10d", "10d", "10h" };
            string[] inputFullHouse = { };
            string[] inputFlush = {};
            string[] inputStraight = { "2h", "3h", "4h", "5c", "6d" };
            string[] inputThreeOfAKind = { "8s", "9c", "8d", "10d", "8h" };
            string[] inputTwoPair = { };
            string[] inputPair = {};


            if (isRoyalFlush(inputRoyalFlush))
            {
                Console.WriteLine("ROYAL FLUSH");
            }
            else if (isStraightFlush(inputStraightFlush))
            {
                Console.WriteLine("STRAIGHT FLUSH");
            }
            else if (isFourOfAKind(inputFourOfAKind))
            {
                Console.WriteLine("FOUR OF A KIND");
            }
            else if (isFullHouse(inputFullHouse))
            {
                Console.WriteLine("FULL HOUSE");
            }
            else if (isFlush(inputFlush))
            {
                Console.WriteLine("FLUSH");
            }
            else if (isStraight(inputStraight))
            {
                Console.WriteLine("STRAIGHT");
            }
            else if (isThreeOfAKind(inputThreeOfAKind))
            {
                Console.WriteLine("THREE OF A KIND");
            }
            else if (isTwoPair(inputTwoPair))
            {
                Console.WriteLine("TWO PAIR");
            }
            else if (isPair(inputPair))
            {
                Console.WriteLine("PAIR");
            }
            else
            {
                Console.WriteLine("HIGH CARD");
            }
            
        }
        public static bool isRoyalFlush(string[] input)
        {
            if (input[0][0]=='1' && input[1][0]== 'J' && input[2][0] == 'Q' && input[3][0] == 'A' && input[4][0] == 'K')
            {
                if (input[0][2] == 'h' && input[1][1] == 'h' && input[2][1] == 'h' && input[3][1] == 'h' && input[4][1] == 'h')
                {
                    return true;
                }
            }
            return false;
        }
        public static bool isStraightFlush(string[] input)
        {
            for (int i = 0; i < 9; i++)
            {
                if (input[0][0] == pokerArr[i])
                {
                    if (input[1][0] == pokerArr[i + 1] && input[2][0] == pokerArr[i + 2] && input[3][0] == pokerArr[i + 3] && input[4][0] == pokerArr[i + 4])
                    {
                        if (input[0][1] == 'h' && input[1][1] == 'h' && input[2][1] == 'h' && input[3][1] == 'h' && input[4][1] == 'h')
                        {
                            return true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return false;
        }
        public static bool isFourOfAKind(string[] input)
        {
            char check = ' ';
            int count = 1;
            for(int i = 0; i< 2; i++)
            {
                count = 1;
                check = input[i][0];
                for(int j=i+1; j<input.Length; j++)
                {
                    if(check == input[j][0])
                    {
                        count++; 
                        if (count == 4)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        public static bool isFullHouse(string[] input)
        {
            return false;
        }
        public static bool isFlush(string[] input)
        {
            return false;
        }
        public static bool isStraight(string[] input)
        {
            for (int i = 0; i < 9; i++)
            {
                if (input[0][0] == pokerArr[i])
                {
                    if (input[1][0] == pokerArr[i + 1] && input[2][0] == pokerArr[i + 2] && input[3][0] == pokerArr[i + 3] && input[4][0] == pokerArr[i + 4])
                    {
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return false;
        }
        public static bool isThreeOfAKind(string[] input)
        {
            char check = ' ';
            int count = 1;
            for (int i = 0; i < 3; i++)
            {
                count = 1;
                check = input[i][0];
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (check == input[j][0])
                    {
                        count++;
                        if (count == 3)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        public static bool isTwoPair(string[] input)
        {
            return false;
        }
        public static bool isPair(string[] input)
        {
            return false;
        }
    }
}


//string[] inputRoyalFlush = { "10h", "Jh", "Qh", "Ah", "Kh" };
//Console.WriteLine(isRoyalFlush(inputRoyalFlush));

//string[] inputStraightFlush = { "2h", "3h", "4h", "5h", "6h" };
//Console.WriteLine(isStraightFlush(inputStraightFlush));

//string[] inputFourOfAKind = { "8s", "10c", "10d", "10d", "10h" };
//Console.WriteLine(isFourOfAKind(inputFourOfAKind));

//string[] inputFullHouse = {};

//string[] inputFlush = {};

//string[] inputStraight = {"2h", "3h", "4h", "5c", "6d"};
//Console.WriteLine(isStraight(inputStraight));

//string[] inputThreeOfAKind = { "8s", "9c", "8d", "10d", "8h" };
//Console.WriteLine(isThreeOfAKind(inputThreeOfAKind));

//string[] inputTwoPair = {};

//string[] inputPair = {};

//High Card { "3h", "5h", "Qs", "9h", "Ad" }