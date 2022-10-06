// See https://aka.ms/new-console-template for more information
namespace HiLo {
    public class card {
        public static card call_card_function = new card();
        public static score call_score_function = new score();

        public static string card_template_1 = "           .-----------.\n           |     _     |\n           |    /|     |\n           |   / |     |\n           |     |     |\n           |     |     |\n           |  ___|___  |\n           |           |\n           '-----------'";
        public static string card_template_2 = "           .-----------.\n           |    ___    |\n           |  .'   '.  |\n           |        |  |\n           |     __.'  |\n           |   .'      |\n           |  |______  |\n           |           |\n           '-----------'";
        public static string card_template_3 = "           .-----------.\n           |    ___    |\n           |  .'   '.  |\n           |        |  |\n           |    ----   |\n           |        |  |\n           |  '.___.'  |\n           |           |\n           '-----------'";
        public static string card_template_4 = "           .-----------.\n           |           |\n           |    /  |   |\n           |   /   |   |\n           |  /____|_  |\n           |       |   |\n           |       |   |\n           |           |\n           '-----------'";
        public static string card_template_5 = "           .-----------.\n           |   _____   |\n           |  |        |\n           |  |____    |\n           |       '.  |\n           |        |  |\n           |  '.___.'  |\n           |           |\n           '-----------'";
        public static string card_template_6 = "           .-----------.\n           |    ____   |\n           |  .'       |\n           |  | ___    |\n           |  |'   '.  |\n           |  |     |  |\n           |  '.___.'  |\n           |           |\n           '-----------'";
        public static string card_template_7 = "           .-----------.\n           |  _______  |\n           |        /  |\n           |       /   |\n           |      /    |\n           |     /     |\n           |    /      |\n           |           |\n           '-----------'";
        public static string card_template_8 = "           .-----------.\n           |    ___    |\n           |  .'   '.  |\n           |  '.___.'  |\n           |  .'   '.  |\n           |  |     |  |\n           |  '.___.'  |\n           |           |\n           '-----------'";
        public static string card_template_9 = "           .-----------.\n           |    ___    |\n           |  .'   '.  |\n           |  |     |  |\n           |  '.___.|  |\n           |        |  |\n           |  '.___.'  |\n           |           |\n           '-----------'";
        public static string card_template_10 = "           .-----------.\n           |  _   __   |\n           | /| .'  '. |\n           |  | |    | |\n           |  | |    | |\n           |  | |    | |\n           | _|_'.__.' |\n           |           |\n           '-----------'";           
        public static string card_template_11 = "           .-----------.\n           |   _   _   |\n           |  /|  /|   |\n           |   |   |   |\n           |   |   |   |\n           |   |   |   |\n           |  _|_ _|_  |\n           |           |\n           '-----------'";
        public static string card_template_12 = "           .-----------.\n           |  _   __   |\n           | /| .'  '. |\n           |  |      | |\n           |  |    .'  |\n           |  |  .'    |\n           | _|_'.____ |\n           |           |\n           '-----------'";
        public static string card_template_13 = "           .-----------.\n           |  _   __   |\n           | /| .'  '. |\n           |  |      | |\n           |  |   ---  |\n           |  |      | |\n           | _|_'.__.' |\n           |           |\n           '-----------'";
        public static string[] all_card_templates = {card_template_1,card_template_2,card_template_3,card_template_4,card_template_5,card_template_6,card_template_7,card_template_8,card_template_9,card_template_10,card_template_11,card_template_12,card_template_13};
        public bool correct;
        public bool no_win_or_lose = true;

        public score points = new score();


        public void print_card(bool correct, bool no_win_or_lose, int[] card_numbers_used) {
            Console.WriteLine(all_card_templates[card_numbers_used[card_numbers_used.Length - 1] - 1]);
            points.display_win_or_lose();

        }

        public bool higher_or_lower(string? guess, int[] card_numbers_used) {
            int first_card = card_numbers_used[card_numbers_used.Length - 2];
            int next_card = card_numbers_used[card_numbers_used.Length - 1];
            bool correct = false;
            no_win_or_lose = false;
            if (guess == "h") {
                if (first_card < next_card) {
                    correct = true;
                    call_card_function.print_card(correct, no_win_or_lose, card_numbers_used);
                    return correct;
                }
                else if (first_card > next_card) {
                    correct = false;
                    call_card_function.print_card(correct, no_win_or_lose, card_numbers_used);
                    return correct;
                }
                else if (first_card == next_card) {
                    no_win_or_lose = true;
                    call_card_function.print_card(correct, no_win_or_lose, card_numbers_used);
                    return no_win_or_lose;
                }
            }

            else if (guess == "l") {
                if (first_card > next_card) {
                    correct = true;
                    call_card_function.print_card(correct, no_win_or_lose, card_numbers_used);
                    return correct;
                }
                else if (first_card < next_card) {
                    correct = false;
                    call_card_function.print_card(correct, no_win_or_lose, card_numbers_used);
                    return correct;
                }
                else if (first_card == next_card) {
                    no_win_or_lose = true;
                    call_card_function.print_card(correct, no_win_or_lose, card_numbers_used);
                    return no_win_or_lose;
                }
            }
            call_card_function.print_card(correct, no_win_or_lose, card_numbers_used);
            return correct;
        }

        public void ask_for_guess(int[] card_numbers_used) {
            Console.WriteLine("\nDo you think the next card will be:\n    Higher (h)  or  Lower (l)?\n");
            string? guess = Console.ReadLine();
            call_card_function.higher_or_lower(guess, card_numbers_used);
        }

        public bool loop_until_done(int[] card_numbers_used) {
            Console.WriteLine($"\n    Your score is: {points.get_score()} points.");
            Console.WriteLine("\n   Would you like to play again?\n       Yes (y)  or  No (n)?");
            string? answer = Console.ReadLine();
            if (answer == "y") {
                return true;
            }
            else if (answer == "n") {
                Console.WriteLine("        Thanks for Playing!\n");
                return false;
            }
            return false;
        }

        public void get_new_card(int[] card_numbers_used) {
            Random rnd = new Random();
            int card_number = rnd.Next(1,14);
            card_numbers_used = card_numbers_used.Append(card_number).ToArray();
            int array_length = card_numbers_used.Length;
            if (array_length == 1) {
                int second_card_number = rnd.Next(1,14);
                card_numbers_used = card_numbers_used.Append(second_card_number).ToArray();

            }
            Console.WriteLine($"\n         This is your card:\n\n{all_card_templates[card_numbers_used[card_numbers_used.Length - 2] - 1]}");
            call_card_function.ask_for_guess(card_numbers_used);
        }
        public static void Main(string[] args) {
            int[] card_numbers_used = {};
            Console.WriteLine("\n Welcome to Hilo! your starting score\n           is 300 points.");
            do{
                call_card_function.get_new_card(card_numbers_used);
            }while(call_card_function.loop_until_done(card_numbers_used));
        }
    }
}