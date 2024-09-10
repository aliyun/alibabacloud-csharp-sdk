// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorLogRequest : TeaModel {
        /// <summary>
        /// 浏览器类型。
        /// </summary>
        [NameInMap("Browser")]
        [Validation(Required=false)]
        public string Browser { get; set; }

        /// <summary>
        /// 该参数已废弃，无需关注。
        /// </summary>
        [NameInMap("BrowserInfo")]
        [Validation(Required=false)]
        public string BrowserInfo { get; set; }

        /// <summary>
        /// The city identification code.
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// 设备类型（模拟屏幕大小类型）。
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public string Device { get; set; }

        /// <summary>
        /// The end of the time range to query. Valid values:
        /// 
        /// *   UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 Thursday, January 1, 1970
        /// *   UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format
        /// 
        /// >  We recommend that you use UNIX timestamps to prevent time zone-related issues.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The filter condition.
        /// 
        /// You can specify a simple expression, for example, `TotalTime>100`. In this case, the operation returns only the data for instant test tasks whose total response time exceeds 100 milliseconds.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// The carrier identification code.
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 1440.
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// The name of the metric.
        /// 
        /// Only the `ProbeLog` metric is supported.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The token that is used to initiate the next request if the response of the current request is truncated. You can use the token to initiate another request and obtain the remaining records.``
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The start of the time range to query. The following formats are supported:
        /// 
        /// *   UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 Thursday, January 1, 1970
        /// *   UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format
        /// 
        /// > 
        /// 
        /// *   The specified time range includes the end time and excludes the start time. The start time must be earlier than the end time.\\
        ///     We recommend that you use UNIX timestamps to prevent time zone-related issues.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The IDs of the instant test tasks. Separate multiple task IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public string TaskIds { get; set; }

    }

}
