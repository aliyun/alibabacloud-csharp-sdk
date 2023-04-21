// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFlowMetricRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query data. The following formats are supported:
        /// 
        /// *   UNIX timestamp: the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// *   UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the instance. The value can be the ID of the cloud desktop or the ID of the Internet access package.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The type of the instance. You can select a cloud desktop or a network package as an instance. If you select a cloud desktop as an instance, you need to configure the `InstanceId` and `MetricType` parameters. If you select a network package as an instance, you also need to must configure the parameters.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The type of the monitoring data. The monitoring data includes the inbound bandwidth and the outbound bandwidth of the cloud desktop, or the workspace bandwidth that is originated from or destined for the Internet.
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// The interval at which monitoring data is collected. Unit: seconds.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The following formats are supported:
        /// 
        /// *   UNIX timestamp: the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// *   UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
