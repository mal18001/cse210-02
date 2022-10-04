public class score{
    public int points = 300;
    public bool correct;
    public bool no_win_or_lose = true;

    public void display_win_or_lose(bool correct, bool no_win_or_lose, int[] card_numbers_used) {
        if (correct == true) {
            points += 100 ;
            Console.WriteLine("\n       You win! Good guess!");
        }
        else if (correct == false) {
            if (no_win_or_lose == true) {
                Console.WriteLine("\n Same number! Who would've thought?");
            }
            else {
                points -= 75;
                Console.WriteLine("\n     Sorry, that wasn't right.");
            }
        }
        call_function.loop_until_done(card_numbers_used);
    }

    public void gameover(){
        if (points == 0){
            Console.WriteLine("Gameover");
        }
    }
}

