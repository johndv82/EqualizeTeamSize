using EqualizeTeamSize;

int[] teamSize = { 1, 4, 4, 5, 6, 7 };
int k = 3;
var rpta = Solver.equalizeTeamSize(teamSize, k);
foreach (var rpt in rpta) {
    Console.WriteLine(rpt);
}
Console.WriteLine();