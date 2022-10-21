class Game {

    private Dictionary words = new Dictionary();
    private Hint hint;
    private Parachute parachute;

    public Game() {

    }

    public void Play() {
        // Get the random word for the game
        string word = words.GetRandomWord();
        hint = new Hint(word);
        parachute = new Parachute();

        bool continueGame = true;

        while(continueGame) {

            // Display the hint and parachute for the user
            hint.DisplayHint();
            Console.WriteLine("");
            parachute.DisplayParachute();

            // Get the players guess
            Console.WriteLine("Guess a letter [a-z]: ");
            string playerGuess = Console.ReadLine() ?? "";
            
            // Check the players guess
            if (!CheckUserGuess(playerGuess, word)) {
                parachute.CutParachute();
            }

            if (!parachute.GetGuessesLeft()) {
                continueGame = false;
                parachute.DisplayParachute();
            }

            if (hint.WordComplete()) {
                continueGame = false;
                Console.WriteLine("Congratulations, you guessed the word!");
            }
        }
    }

    public bool CheckUserGuess(string guess, string word) {
        bool letterInWord = false;
        for(int i = 0; i < word.Length; i++) {
            if (word[i].ToString() == guess.ToLower()) {
                hint.UpdateHint(guess, i);
                letterInWord = true;
            }
        }
        return letterInWord;
    }
}