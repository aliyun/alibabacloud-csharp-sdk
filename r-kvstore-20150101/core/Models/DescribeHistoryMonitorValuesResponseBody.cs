// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeHistoryMonitorValuesResponseBody : TeaModel {
        /// <summary>
        /// The monitoring information returned in the JSON format. For more information, see [View performance monitoring data](~~122091~~).
        /// 
        /// *   Only metrics whose values are not 0 are returned. This improves data transmission efficiency. Metrics that are not displayed are represented by the **0** default value.
        /// 
        /// *   The query result is aligned with the data aggregation frequency. If the specified time range to query is less than or equal to 10 minutes and the data is aggregated once every 5 seconds, query results are returned at an interval of 5 seconds. If the specified StartTime value does not coincide with a point in time for data aggregation, the system returns the latest point in time for data aggregation as the first point in time. For example, if you set the StartTime parameter to 2022-01-20T12:01:48Z, the first point in time returned is 2022-01-20T12:01:45Z.
        /// </summary>
        [NameInMap("MonitorHistory")]
        [Validation(Required=false)]
        public string MonitorHistory { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
