//SDP, Prac 2, Question 2, g19f7919
using NUnit.Framework;

namespace Oware.Tests
{
    
    public class MockScoreHouse : IScoreHouse {     //mock object class.
        
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
                //IScoreHouse mock = Substitute.For<IScoreHouse>();    //tried using the Nsubstitute package but had errors.
                //mock.AddSeed(Seed seed).Returns(true);
            IScoreHouse mock = new MockScoreHouse();    //create the Mock object
            Player p1 = new Player("p1", mock);         //create a player object to use the mock object
            
            //act
            bool test = p1.AddSeedToScoreHouse(new Seed());     //test the player method AddSeedToScoreHouse
                                                                //which calles the mock object method AddSeed(returns true if called).

            //assert
            Assert.AreEqual(true, test);        //check result against mock object return value.
        }
    }
}