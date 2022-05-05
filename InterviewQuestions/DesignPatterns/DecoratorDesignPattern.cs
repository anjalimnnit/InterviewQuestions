using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    
        /// <summary>   
        /// Car Base component   
        /// </summary>   
        public interface ICar
        {
            string GetDescription();
            double GetCost();
        }

        /// <summary>   
        /// Concrete Car   
        /// </summary>   
        public class EconomyCar : ICar
        {
            public string GetDescription()
            {
                return "Economy Car";
            }

            public double GetCost()
            {
                return 450000.0;
            }
        }

        /// <summary>   
        /// Concrete Car   
        /// </summary>   
        public class DeluxCar : ICar
        {
            public string GetDescription()
            {
                return "Delux Car";
            }

            public double GetCost()
            {
                return 750000.0;
            }
        }

        /// <summary>   
        /// Concrete Car   
        /// </summary>   
        public class LuxuryCar : ICar
        {
            public string GetDescription()
            {
                return "Luxury Car";
            }

            public double GetCost()
            {
                return 1000000.0;
            }
        }
    }
