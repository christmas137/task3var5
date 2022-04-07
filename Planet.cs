using System.Collections.Generic;

namespace task3var5
{
    public class Planet
    {
        private string name;
        
        private List<Mat> mats = new List<Mat>();
        private List<Ocean> oceans = new List<Ocean>();
        private List<Lend> lends = new List<Lend>();


        public Planet(string name)
        {
            this.name = name;
        }


        public void addMat(string name)
        {
            mats.Add(new Mat(name));
        }
        
        public void addOcean(string name)
        {
            oceans.Add(new Ocean(name));
        }
        
        public void addLend(string name)
        {
            lends.Add(new Lend(name));
        }

        public int numderOfMats()
        {
            return mats.Count;
        }
        
        public int numderOfOceans()
        {
            return oceans.Count;
        }
        
        public int numderOfLends()
        {
            return lends.Count;
        }

        public override string ToString()
        {
            string s = "Planet's name: " + this.name + "\n";
            s += "\tMats:\n";
            foreach (Mat m in mats)
            {
                s += "\t\t" + m+"\n";
            }
            s += "\tOceans:\n";
            foreach (Ocean o in oceans)
            {
                s += "\t\t" + o+"\n";
            }
            s += "\tLends:\n";
            foreach (Lend l in lends)
            {
                s += "\t\t" + l+"\n";
            }

            return s;
        }

        public Mat getMat(int mat)
        {
            return mats[mat-1];
        }
        
        public Ocean getOcean(int ocean)
        {
            return oceans[ocean-1];
        }
        
        public Lend getLend(int lend)
        {
            return lends[lend-1];
        }
    }
}