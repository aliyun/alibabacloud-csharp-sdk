// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotNodeMetricListRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Valid values:
        /// 
        /// *   UNIX timestamp: the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC
        /// *   Date format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The expression that is used to compute the query results in real time.
        /// 
        /// >  Only the groupby expression is supported. This expression is similar to the GROUP BY statement that applies to databases.
        /// </summary>
        [NameInMap("Express")]
        [Validation(Required=false)]
        public string Express { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// >  The maximum value of the Length parameter in a request is 1440.
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// The metric that is used to monitor the cloud service.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The namespace of the cloud service. Format: acs_cloud service name.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The management node ID.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The time interval. Unit: seconds. Valid values: 60, 300, and 900.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The following formats are supported:
        /// 
        /// *   UNIX timestamp: the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC
        /// *   Date format: YYYY-MM-DDThh:mm:ssZ
        /// *   The interval between the start time and the end time is less than or equal to 31 days.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
