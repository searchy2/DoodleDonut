namespace Vatio.Filters
{
    /*
     * This class handles the filtering when the value type is float
     */
    internal class InnerLowPassFilterFloat : AInnerLowPassFilter<float>
    {
        internal InnerLowPassFilterFloat(float a, float initialValue)
            : base(a, initialValue)
        {
        }

        /*
         * This function calculates filtered value, when filtered type is float.
         * This is a special case, as built-in types do not support arithmetic operations through
reflections, so here we use specific data type.
         * Parameters are:
         *      input - the new, unfiltered value
         */
        override protected float CalculateAvgWithInput(float input)
        {
            return (float)(avg + a * (input - avg));
        }
    }
}
