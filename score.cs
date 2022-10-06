namespace HiLo
{
    public class score{
        public static card call_function = new card();
        public int points;
        public bool correct;
        public bool no_win_or_lose;

    /// <summary>
    /// Construst a new game with 300 points 
    /// </summary> 
        public score(){
            points = 300;
            correct = false;
            no_win_or_lose = true;
        }

    /// <summary>
    /// Add points when the players guess corrctly and minus ponits when they guess wrong
    /// </summary> 
        public void display_win_or_lose() {
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
            
        }

    /// <summary>
    /// Generates points
    /// </summary> 
        public int get_score(){
            return points;
        }

    /// <summary>
    /// gameover when points = 0
    /// </summary> 
        public void gameover(){
            if (points == 0){
                Console.WriteLine("Gameover");
            }
        }
   }    

}

