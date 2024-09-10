// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorDataRequest : TeaModel {
        /// <summary>
        /// The end of the time range for the query. Supported formats:
        /// 
        /// *   UNIX timestamp: The value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// *   Time format: The value is in the YYYY-MM-DDThh:mm:ssZ format.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The number of data points to return.
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// The name of the metric. Valid values:
        /// 
        /// *   Availability
        /// *   ResponseTime
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The pagination cursor.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The interval at which monitoring data is returned. The value is an integral multiple of 60. Unit: seconds.
        /// 
        /// >  The default value equals the minimum interval at which detection requests are sent to the monitored address.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The beginning of the time range for the query. Supported formats:
        /// 
        /// *   UNIX timestamp: The value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// *   Time format: The value is in the YYYY-MM-DDThh:mm:ssZ format.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The ID of the site monitoring task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The type of the monitored object whose monitoring data is to be queried. Valid values:
        /// 
        /// *   metric
        /// *   event
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
