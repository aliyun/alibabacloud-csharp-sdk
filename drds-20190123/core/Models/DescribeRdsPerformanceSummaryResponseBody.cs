// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRdsPerformanceSummaryResponseBody : TeaModel {
        /// <summary>
        /// A collection of objects.
        /// </summary>
        [NameInMap("RdsPerformanceInfos")]
        [Validation(Required=false)]
        public List<DescribeRdsPerformanceSummaryResponseBodyRdsPerformanceInfos> RdsPerformanceInfos { get; set; }
        public class DescribeRdsPerformanceSummaryResponseBodyRdsPerformanceInfos : TeaModel {
            /// <summary>
            /// The number of active sessions of the RDS instance.
            /// </summary>
            [NameInMap("ActiveSessions")]
            [Validation(Required=false)]
            public int? ActiveSessions { get; set; }

            /// <summary>
            /// The CPU utilization of an RDS instance.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// The IOPS of the RDS instance.
            /// </summary>
            [NameInMap("Iops")]
            [Validation(Required=false)]
            public float? Iops { get; set; }

            /// <summary>
            /// The ID of an RDS instance.
            /// </summary>
            [NameInMap("RdsId")]
            [Validation(Required=false)]
            public string RdsId { get; set; }

            /// <summary>
            /// The disk usage of apsaradb for RDS. Unit: MB.
            /// </summary>
            [NameInMap("SpaceUsage")]
            [Validation(Required=false)]
            public long? SpaceUsage { get; set; }

            /// <summary>
            /// The total number of current RDS sessions.
            /// </summary>
            [NameInMap("TotalSessions")]
            [Validation(Required=false)]
            public int? TotalSessions { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the API request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
