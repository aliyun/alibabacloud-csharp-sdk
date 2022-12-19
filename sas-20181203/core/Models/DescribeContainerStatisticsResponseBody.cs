// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The alert statistics of container assets.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeContainerStatisticsResponseBodyData Data { get; set; }
        public class DescribeContainerStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// The number of alerts whose risk level is **Reminder**.
            /// </summary>
            [NameInMap("RemindAlarmCount")]
            [Validation(Required=false)]
            public int? RemindAlarmCount { get; set; }

            /// <summary>
            /// The number of alerts whose risk level is **Urgent**.
            /// </summary>
            [NameInMap("SeriousAlarmCount")]
            [Validation(Required=false)]
            public int? SeriousAlarmCount { get; set; }

            /// <summary>
            /// The number of alerts whose risk level is **Suspicious**.
            /// </summary>
            [NameInMap("SuspiciousAlarmCount")]
            [Validation(Required=false)]
            public int? SuspiciousAlarmCount { get; set; }

            /// <summary>
            /// The total number of alerts that are generated in the current container cluster.
            /// </summary>
            [NameInMap("TotalAlarmCount")]
            [Validation(Required=false)]
            public int? TotalAlarmCount { get; set; }

            /// <summary>
            /// The total number of nodes in the current container cluster.
            /// </summary>
            [NameInMap("TotalNode")]
            [Validation(Required=false)]
            public int? TotalNode { get; set; }

            /// <summary>
            /// The number of nodes on which alerts are generated in the current container cluster.
            /// </summary>
            [NameInMap("hasRiskNode")]
            [Validation(Required=false)]
            public int? HasRiskNode { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
