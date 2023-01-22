using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Persistence.ValueConverters
{
    /// <summary>
    /// To convert a boolean property value in model to a specific string value in database and viec versa.
    /// </summary>
    public class BooleanConverter1 : ValueConverter<bool, string>
    {
        public BooleanConverter1() : base(
            b => b == true ? "yes" : "no",
            s => s == "yes" ? true : false
        )
        {
        }
    }
}
