// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetCloudMetricLogsRequest : TeaModel {
        /// <summary>
        /// The data aggregation interval. Unit: seconds.
        /// 
        /// Valid values: 1, 10, 60, 600, and 3600.
        /// 
        /// Default value: 1
        /// </summary>
        [NameInMap("AggregationInterval")]
        [Validation(Required=false)]
        public int? AggregationInterval { get; set; }

        /// <summary>
        /// The data aggregation type. Valid values:
        /// 
        /// *   sum: the sum of the data
        /// *   avg: the average value
        /// *   max: the maximum value
        /// *   min: the minimum value
        /// 
        /// Aggregation is disabled by default.
        /// </summary>
        [NameInMap("AggregationType")]
        [Validation(Required=false)]
        public string AggregationType { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The filter conditions. A JSON string consisting of one or more key:value pairs. Value range of key:
        /// 
        /// *   InstanceId: the ID of the node
        /// *   Hostname: the hostname of the node
        /// *   NetworkInterface: the name of the network interface
        /// *   DiskDevice: the name of the disk
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// The beginning of the time range to query. This value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// The category of the output performance metrics. Separate multiple metrics with commas (,). Valid values:
        /// 
        /// *   cpu
        /// *   memory
        /// </summary>
        [NameInMap("MetricCategories")]
        [Validation(Required=false)]
        public string MetricCategories { get; set; }

        /// <summary>
        /// The dimensions of the performance metric. Valid values:
        /// 
        /// *   machine
        /// *   process
        /// *   network
        /// *   disk
        /// </summary>
        [NameInMap("MetricScope")]
        [Validation(Required=false)]
        public string MetricScope { get; set; }

        /// <summary>
        /// Logs are returned in reverse order of timestamps.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// The end of the time range to query. This value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public int? To { get; set; }

    }

}
