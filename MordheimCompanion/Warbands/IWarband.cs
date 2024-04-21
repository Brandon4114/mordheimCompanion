namespace MordheimCompanion.Warbands;

public interface IWarband
{
    string Name { get; }
    int Gold { get; }
    List<IHero>? Heros { get;}
    List<IHenchmen>? Henchmen { get;}
}
