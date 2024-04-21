using MordheimCompanion;
using MordheimCompanion.Warbands.Mercenaries;
using MordheimCompanion.Warbands.Mercenaries.Heros;

namespace MordheimCompanionTests
{
    public class Warband_Tests
    {
        [Fact]
        public void CanCreateNewMercenariesWarband()
        {
            //arrange
            var expectedType = typeof(Mercenaries);
            Mercenaries warband;
            //act
            warband = new Mercenaries();

            //assert
            Assert.IsType(expectedType, warband);
        }

        [Fact]
        public void CanAddHeroToMercenariesWarband()
        {
            var mercenaries = new Mercenaries();

            mercenaries.AddNewCaptain();

            Assert.All(mercenaries.Heros, Assert.NotNull);
        }

        [Fact]
        public void DoesNewMercenaryWarbandStartWith500Gold()
        {
            var mercenaries = new Mercenaries();

            Assert.Equal(500, mercenaries.Gold);
        }
    }
}