// See https://aka.ms/new-console-template for more information
public class card {

    static void Main(string[] args) {
        card call_function = new card();
        call_function.print_card();
    }

    public string card_template_1 = ".-----------.\n|     _     |\n|    /|     |\n|   / |     |\n|     |     |\n|     |     |\n|  ___|___  |\n|           |\n'-----------'";
    public string card_template_2 = ".-----------.\n|    ___    |\n|  .'   '.  |\n|        |  |\n|     __.'  |\n|   .'      |\n|  |______  |\n|           |\n'-----------'";
    public string card_template_3 = ".-----------.\n|    ___    |\n|  .'   '.  |\n|        |  |\n|    ----   |\n|        |  |\n|  '.___.'  |\n|           |\n'-----------'";
    public string card_template_4 = ".-----------.\n|           |\n|    /  |   |\n|   /   |   |\n|  /____|_  |\n|       |   |\n|       |   |\n|           |\n'-----------'";
    public string card_template_5 = ".-----------.\n|   _____   |\n|  |        |\n|  |____    |\n|       '.  |\n|        |  |\n|  '.___.'  |\n|           |\n'-----------'";
    public string card_template_6 = ".-----------.\n|    ____   |\n|   /       |\n|  | ___    |\n|  |'   '|  |\n|  |     |  |\n|  '.___.'  |\n|           |\n'-----------'";
    public string card_template_7 = ".-----------.\n|  _______  |\n|        /  |\n|       /   |\n|      /    |\n|     /     |\n|    /      |\n|           |\n'-----------'";
    public string card_template_8 = ".-----------.\n|    ___    |\n|  .'   '.  |\n|  '.___.'  |\n|  .'   '.  |\n|  |     |  |\n|  '.___.'  |\n|           |\n'-----------'";
    public string card_template_9 = ".-----------.\n|    ___    |\n|  .'   '.  |\n|  |     |  |\n|  '.___.|  |\n|        |  |\n|  '.___.'  |\n|           |\n'-----------'";
    public string card_template_10 = ".-----------.\n|  _   __   |\n| /| .'  '. |\n|  | |    | |\n|  | |    | |\n|  | |    | |\n| _|_'.__.' |\n|           |\n'-----------'";
    public string card_template_11 = ".-----------.\n|   _   _   |\n|  /|  /|   |\n|   |   |   |\n|   |   |   |\n|   |   |   |\n|  _|_ _|_  |\n|           |\n'-----------'";
    public string card_template_12 = ".-----------.\n|  _   __   |\n| /| .'  '. |\n|  |      | |\n|  |    .'  |\n|  |  .'    |\n| _|_'.____ |\n|           |\n'-----------'";
    public string card_template_13 = ".-----------.\n|  _   __   |\n| /| .'  '. |\n|  |      | |\n|  |   ---  |\n|  |      | |\n| _|_'.__.' |\n|           |\n'-----------'";
    public static void get_new_card() {
        Random rnd = new Random();
        int card_number = rnd.Next(1,14);
        
    }
    public string print_card() {

        Console.WriteLine(card_template_1);
        Console.WriteLine(card_template_2);
        Console.WriteLine(card_template_3);
        Console.WriteLine(card_template_4);
        Console.WriteLine(card_template_5);
        Console.WriteLine(card_template_6);
        Console.WriteLine(card_template_7);
        Console.WriteLine(card_template_8);
        Console.WriteLine(card_template_9);
        Console.WriteLine(card_template_10);
        Console.WriteLine(card_template_11);
        Console.WriteLine(card_template_12);
        Console.WriteLine(card_template_13);
        return "";
    }

}