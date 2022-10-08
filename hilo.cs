// See https://aka.ms/new-console-template for more information
namespace HiLo {
    public class card {
        public static card call_card_function = new card();
        public static score call_score_function = new score();
        // all of the templates for the cards
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
        public Random rnd = new Random();

        public score points = new score();
        public int[] card_numbers_used = {};
        public int next_card_number;
        /// <summary>
        /// Prints the card, pulling it from the list of templates
        /// </summary>
        public void print_card(bool correct, bool no_win_or_lose) {
            Console.WriteLine(all_card_templates[card_numbers_used[card_numbers_used.Length - 1] - 1]);
            points.display_win_or_lose();
        }
        /// <summary>
        /// Determines if the user's guess is correct
        /// </summary>
        public bool higher_or_lower(string? guess) {
            int first_card = card_numbers_used[card_numbers_used.Length - 2];
            int next_card = card_numbers_used[card_numbers_used.Length - 1];
            // if the user guessed higher
            if (guess == "h") {
                if (first_card < next_card) {
                    points.correct = true;
                    points.no_win_or_lose = false;
                }
                else if (first_card > next_card) {
                    points.correct = false;
                    points.no_win_or_lose = false;
                }
                else if (first_card == next_card) {
                    points.correct = false;
                    points.no_win_or_lose = true;
                }
            }
            //if the user guessed lower
            else if (guess == "l") {
                if (first_card > next_card) {
                    points.correct = true;
                    points.no_win_or_lose = false;
                }
                else if (first_card < next_card) {
                    points.correct = false;
                    points.no_win_or_lose = false;
                }
                else if (first_card == next_card) {
                    points.correct = false;
                    points.no_win_or_lose = true;
                }
            }
            call_card_function.print_card(points.correct, points.no_win_or_lose);
            return points.correct;
        }
        /// <summary>
        /// Asks the user for their guess
        /// </summary>
        public void ask_for_guess() {
            Console.WriteLine("\nDo you think the next card will be:\n    Higher (h)  or  Lower (l)?\n");
            string? guess = Console.ReadLine();
            call_card_function.higher_or_lower(guess);
        }

        /// <summary>
        /// Asks the user if they would like to play again, or ends the game if game over
        /// </summary>
        public bool loop_until_done() {
            if (points.points <= 0) {
                return false;
            }
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
        /// <summary>
        /// Generate a new card
        /// </summary>
        public int [] get_new_card() {
            next_card_number = rnd.Next(1,14);
            card_numbers_used = card_numbers_used.Append(next_card_number).ToArray();
            int array_length = card_numbers_used.Length;
            Console.WriteLine($"\n         This is your card:\n\n{all_card_templates[card_numbers_used[array_length - 2] - 1]}");
            call_card_function.ask_for_guess();
            return card_numbers_used;
        }
        /// <summary>
        /// Gets the first card of the game
        /// </summary>
        public int [] get_first_card() {
            int first_card_number = rnd.Next(1,14);
            card_numbers_used = card_numbers_used.Append(first_card_number).ToArray();
            do{
                call_card_function.get_new_card();
            }while(call_card_function.loop_until_done());
            return card_numbers_used;

        }

        public static void Main(string[] args) {
            Console.WriteLine("\n Welcome to Hilo! your starting score\n           is 300 points.");
            call_card_function.get_first_card();
        }
    }
}