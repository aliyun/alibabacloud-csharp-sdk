// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetCloudMetricLogsResponseBody : TeaModel {
        /// <summary>
        /// The list of the performance data.
        /// </summary>
        [NameInMap("MetricLogs")]
        [Validation(Required=false)]
        public GetCloudMetricLogsResponseBodyMetricLogs MetricLogs { get; set; }
        public class GetCloudMetricLogsResponseBodyMetricLogs : TeaModel {
            [NameInMap("MetricLog")]
            [Validation(Required=false)]
            public List<GetCloudMetricLogsResponseBodyMetricLogsMetricLog> MetricLog { get; set; }
            public class GetCloudMetricLogsResponseBodyMetricLogsMetricLog : TeaModel {
                /// <summary>
                /// The name of the disk.
                /// </summary>
                [NameInMap("DiskDevice")]
                [Validation(Required=false)]
                public string DiskDevice { get; set; }

                /// <summary>
                /// The hostname of the node.
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// A JSON-serialized string that contains values for multiple performance metrics.
                /// </summary>
                [NameInMap("MetricData")]
                [Validation(Required=false)]
                public string MetricData { get; set; }

                /// <summary>
                /// The name of the network interface.
                /// </summary>
                [NameInMap("NetworkInterface")]
                [Validation(Required=false)]
                public string NetworkInterface { get; set; }

                /// <summary>
                /// The timestamp of the log. This value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public int? Time { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
