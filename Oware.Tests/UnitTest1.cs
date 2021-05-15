//SDP, Prac 2, Question 2, g19f7919
using NUnit.Framework;

namespace Oware.Tests
{
    
    public class MockScoreHouse : IScoreHouse {
        
        public int GetCount() {
            throw new System.NotImplementedException();
        }

        public bool AddSeed(Seed seed) {
            return true;
        }

        public void Reset() {
            throw new System.NotImplementedException();
        }
    }


    public class Tests
    {
        [SetUp]
        public void Setup()
        {   }

        [Test]
        public void WhenCallingResetHouseTheHouseIsReset()
        {
            //arrange
            House x = new House(0, 0);      //create a new house, seeds = 4
            x.AddSeedInPot(new Seed());     //add one seed to the house
                                            //no. of seeds is therefore 5

            //act
            x.ResetHouse();                 //reset the house (Method we are testing!)
                                            ////no. of seeds should be 4

            //assert
            Assert.AreEqual(x.GetCount(), new House(0, 0).GetCount());  //check against new initialised house
        }

        [Test]
        public void WhenAddSeedToScoreHouseAddSeedIsCalled()
        {
            //arrange
                //IScoreHouse mock = Substitute.For<IScoreHouse>();
                //mock.AddSeed(Seed seed).Returns(true);
            IScoreHouse mock = new MockScoreHouse();
            Player p1 = new Player("p1", mock);
            
            //act
            bool test = p1.AddSeedToScoreHouse(new Seed());

            //assert
            Assert.AreEqual(true, test);
        }
    }
}