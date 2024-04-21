using MordheimCompanion.Warbands.Mercenaries.Heros;

namespace MordheimCompanion.Warbands.Mercenaries;

public class Mercenaries : IWarband
{
    public string Name { get; set; } = "Reiklanders";
    public int Gold { get; set; } = 500;

    public List<IHero>? Heros => [];
    public List<IHenchmen>? Henchmen => [];

    // Constructor to initialize the list
    public Mercenaries()
    {

    }

    public void AddNewCaptain() => Heros.Add(new Captain("Reikland"));
}
