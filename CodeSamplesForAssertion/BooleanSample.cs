using System;

namespace CodeSamplesForAssertion
{
    public class BooleanSample
    {
        public bool IsWeekDay(string dayOfWeek)
        {
            bool result;
            try
            {
                result = (string.Equals(dayOfWeek, "monday", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(dayOfWeek, "tuesday", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(dayOfWeek, "wedensday", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(dayOfWeek, "thursday", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(dayOfWeek, "friday", StringComparison.OrdinalIgnoreCase)
                    ) ? true : false;
            }
            catch (Exception ex)
            {
                   throw ex;
            }

            return result;


        }
    }
}
