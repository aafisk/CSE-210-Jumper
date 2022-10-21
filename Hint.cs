class Hint {

    private List<string> hint = new List<string>();

    public Hint(string word) {
        for(int i = 0; i < word.Length; i++) {
            hint.Add("_ ");
        }
    }

    // Prints the current hint to the console.
    public void DisplayHint() {
        Console.WriteLine();
        for(int i = 0; i < hint.Count; i++) {
            Console.Write(hint[i]);
        }
    }

    // Updates the hint based on the letter and index provided
    public void UpdateHint(string letter, int i) {
        hint[i] = letter.ToLower() + " ";
    }

    public bool WordComplete() {
        for (int i = 0; i < hint.Count; i++) {
            if (hint[i] == "_ ") {
                return false;
            }
        }
        return true;
    }
}