using MamentoSanAndreas;

CJ cj = new CJ(10,5,12);

cj.Shoot();
cj.Crime();

SaveGame game = new SaveGame();

game.Add(cj.Save());

cj.Shoot();
cj.Shoot();
cj.Shoot();
cj.Crime();

game.Add(cj.Save());

cj.RestoreState(game.GetSave());
cj.RestoreState(game.GetSave());

