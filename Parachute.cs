class Parachute {

  private List<string> parachute = new List<string>();

  public Parachute() {
    parachute.Add(@" _____ ");
    parachute.Add(@"/_____\");
    parachute.Add(@"\     /");
    parachute.Add(@" \   / ");
    parachute.Add(@"   O   ");
    parachute.Add(@"  /|\  ");
    parachute.Add(@"  / \  ");
    parachute.Add(@"       ");
    parachute.Add(@"^^^^^^^");
  }

  public void CutParachute() {
    parachute.RemoveAt(0);
  }

}