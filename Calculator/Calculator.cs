using System;

namespace CalculatorLib
{


    /// <summary>
    /// A calculator library
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Addition function; returns the sum of the arguments
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public float Add(float arg1, float arg2) => arg1 + arg2;

        /// <summary>
        /// Subtraction function; returns the difference of the arguments
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public float Subtract(float arg1, float arg2) => arg1 - arg2;
    }
}
