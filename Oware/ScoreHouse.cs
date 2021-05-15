/* This is an almost-complete translation of https://github.com/haarismemon/oware/ from Java to C#
*/
using System.Collections.Generic;

namespace Oware {

    public interface IScoreHouse {
        int GetCount();
        bool AddSeed(Seed seed);
        void Reset();
    }

    public class ScoreHouse : IScoreHouse {
        private List<Seed> seedsInHouse;
        public ScoreHouse() {
            seedsInHouse = new List<Seed>();
        }
        
        public int GetCount() {
            return seedsInHouse.Count;
        }

        public bool AddSeed(Seed seed) {
            seedsInHouse.Add(seed);
            return true;
        }

        public void Reset() {
            seedsInHouse.Clear();
        }
    }
}