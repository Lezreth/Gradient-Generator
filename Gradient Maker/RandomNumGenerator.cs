using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradient_Maker
{
    public class RandomNumGenerator
    {
        /// <summary>
        /// Random key generator.
        /// </summary>
        private Random KeyGenerator { get; set; } = new Random();

        /// <summary>
        /// Keys that have been generated.
        /// </summary>
        private List<double> Keys { get; set; } = new List<double>();

        /// <summary>
        /// Generate a new unique key.
        /// </summary>
        /// <returns>Unique key.</returns>
        public double GetKey()
        {
            double NKey;
            do
            {
                NKey = KeyGenerator.NextDouble();
            } while (Keys.Contains(NKey));

            Keys.Add(NKey);
            return NKey;
        }


        public void RemoveKey(double Key)
        {
            if (Keys.Contains(Key))
            { _ = Keys.Remove(Key); }
        }
    }
}
