// See https://aka.ms/new-console-template for more information
public class card {
    public static card call_function = new card();

    public static string card_template_1 = ".-----------.\n|     _     |\n|    /|     |\n|   / |     |\n|     |     |\n|     |     |\n|  ___|___  |\n|           |\n'-----------'";
    public static string card_template_2 = ".-----------.\n|    ___    |\n|  .'   '.  |\n|        |  |\n|     __.'  |\n|   .'      |\n|  |______  |\n|           |\n'-----------'";
    public static string card_template_3 = ".-----------.\n|    ___    |\n|  .'   '.  |\n|        |  |\n|    ----   |\n|        |  |\n|  '.___.'  |\n|           |\n'-----------'";
    public static string card_template_4 = ".-----------.\n|           |\n|    /  |   |\n|   /   |   |\n|  /____|_  |\n|       |   |\n|       |   |\n|           |\n'-----------'";
    public static string card_template_5 = ".-----------.\n|   _____   |\n|  |        |\n|  |____    |\n|       '.  |\n|        |  |\n|  '.___.'  |\n|           |\n'-----------'";
    public static string card_template_6 = ".-----------.\n|    ____   |\n|  .'       |\n|  | ___    |\n|  |'   '.  |\n|  |     |  |\n|  '.___.'  |\n|           |\n'-----------'";
    public static string card_template_7 = ".-----------.\n|  _______  |\n|        /  |\n|       /   |\n|      /    |\n|     /     |\n|    /      |\n|           |\n'-----------'";
    public static string card_template_8 = ".-----------.\n|    ___    |\n|  .'   '.  |\n|  '.___.'  |\n|  .'   '.  |\n|  |     |  |\n|  '.___.'  |\n|           |\n'-----------'";
    public static string card_template_9 = ".-----------.\n|    ___    |\n|  .'   '.  |\n|  |     |  |\n|  '.___.|  |\n|        |  |\n|  '.___.'  |\n|           |\n'-----------'";
    public static string card_template_10 = ".-----------.\n|  _   __   |\n| /| .'  '. |\n|  | |    | |\n|  | |    | |\n|  | |    | |\n| _|_'.__.' |\n|           |\n'-----------'";
    public static string card_template_11 = ".-----------.\n|   _   _   |\n|  /|  /|   |\n|   |   |   |\n|   |   |   |\n|   |   |   |\n|  _|_ _|_  |\n|           |\n'-----------'";
    public static string card_template_12 = ".-----------.\n|  _   __   |\n| /| .'  '. |\n|  |      | |\n|  |    .'  |\n|  |  .'    |\n| _|_'.____ |\n|           |\n'-----------'";
    public static string card_template_13 = ".-----------.\n|  _   __   |\n| /| .'  '. |\n|  |      | |\n|  |   ---  |\n|  |      | |\n| _|_'.__.' |\n|           |\n'-----------'";
    public static string[] all_card_templates = {card_template_1,card_template_2,card_template_3,card_template_4,card_template_5,card_template_6,card_template_7,card_template_8,card_template_9,card_template_10,card_template_11,card_template_12,card_template_13};
    
    public int get_new_card() {
        Random rnd = new Random();
        int card_number = rnd.Next(1,14);
        int index = card_number - 1;
        call_function.print_card(index);
        return card_number;
    }
    public string print_card(int index) {
        Console.WriteLine(all_card_templates[index]);

        return "";
    }
    static void Main(string[] args) {
        card call_function = new card();
        call_function.get_new_card();
    }
}