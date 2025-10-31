using ES.API.Library.Attributes;
using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Date with time range. Used e.g., for Pickup Date and Time.
    /// </summary>
    [Description("Date with time range. Used e.g., for Pickup Date and Time.")]
    public class DateTimeRange
    {
        /// <summary>
        /// The requested pickup/delivery date using the format YYYY-MM-DD
        /// </summary>
        [Description("The requested pickup/delivery date using the format YYYY-MM-DD")]
        [Example("2020-08-30")]
        public string? Date { get; set; }
        /// <summary>
        /// Start
        /// </summary>
        [Example("10:00:00")]
        public string? Start { get; set; }
        /// <summary>
        /// End
        /// </summary>
        [Example("11:00:00")]
        public string? End { get; set; }
    }
}
