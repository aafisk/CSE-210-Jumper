class Parachute {

  private List<string> parachute = new List<string>();
  private bool guessesLeft = true;

  public Parachute() {
    parachute.Add(@" _____ ");
    parachute.Add(@"/_____\");
    parachute.Add(@"\     /");
    parachute.Add(@" \   / ");
    parachute.Add(@"   O   ");

  }

  public bool CutParachute() {
    if (parachute[0] == "   O   ") {
      parachute[0] = "   X   ";
      guessesLeft = false;
      return false;
    }
    else {
      parachute.RemoveAt(0);
      return true;
    }
  }

  public void DisplayParachute() {
    Console.WriteLine("");
    for(int i = 0; i < parachute.Count; i++) {
      Console.WriteLine(parachute[i]);
    }

    Console.WriteLine(@"  /|\  ");
    Console.WriteLine(@"  / \  ");
    Console.WriteLine(@"       ");
    Console.WriteLine(@"^^^^^^^");
  }

  public bool GetGuessesLeft() {
    return guessesLeft;
  }

}