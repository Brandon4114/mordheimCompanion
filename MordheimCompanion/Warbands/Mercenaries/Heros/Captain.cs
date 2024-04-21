
namespace MordheimCompanion.Warbands.Mercenaries.Heros;

public class Captain(string type) : IHero
{
    public string Name { get; set; } = "Captain";
    public string Type { get; set; } = type;
    public string Description { get; set; } = "Mercenary Captain";
    public int Experiance { get; set; } = 20;

    public IHero.Skills GetSkills()
    {
        return this.
    }

    public void SetSkills(IHero.Skills value)
    {
        switch (type)
        {
            case "Reikland":
                SetReiklandSkills();
                break;
            case "Middenheim":
                SetMiddenheimSkills();
                break;
            case "Marienburg":
                setMarienburgSkills();
                break;
            default:
                throw new Exception("Type of Mercenary does not exist");
        }
    }

    private void setMarienburgSkills()
    {
        throw new NotImplementedException();
    }

    private void SetMiddenheimSkills()
    {
        throw new NotImplementedException();
    }

    private void SetReiklandSkills()
    {
        throw new NotImplementedException();
    }
}
