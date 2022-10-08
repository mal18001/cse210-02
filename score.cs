namespace HiLo
{
    public class score{
        public static card call_function = new card();
        public static score call_score_function = new score();
        public int points = 300;
        public bool correct;
        public bool no_win_or_lose;
        public bool game_over;

    /// <summary>
    /// Constructs a new game with 300 points 
    /// </summary> 
        public score(){
            correct = false;
            no_win_or_lose = true;
        }

    /// <summary>
    /// Adds points when the player guessed corrctly and subtracts points when they guess wrong
    /// </summary> 
        public void display_win_or_lose() {
            if (correct == true) {
                points += 100 ;
                Console.WriteLine("\n       Correct! Good guess!");
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
            call_score_function.gameover(points);

            
        }

    /// <summary>
    /// Generates points
    /// </summary> 
        public int get_score(){
            return points;
        }

    /// <summary>
    /// gameover when points <= 0
    /// </summary> 
        public void gameover(int points){
            if (points <= 0){
                game_over = true;
                Console.WriteLine("\n             Game Over");
            }
        }
   }    

}

