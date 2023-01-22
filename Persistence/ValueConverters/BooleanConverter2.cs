using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Persistence.ValueConverters
{
    /// <summary>
    /// To convert a boolean property value in model to different string values in database when reading from or writing to the database
    /// </summary>
    public static class BooleanConverter2
    {
        public static ValueConverter<bool, string> Convert(string trueStr, string falseStr)
        {
            return new ValueConverter<bool, string>(b => b == true ? trueStr : falseStr, s => s == trueStr ? true : false);
        }
    }
}
