// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// Health state details of access nodes.
        /// </summary>
        [NameInMap("CS")]
        [Validation(Required=false)]
        public DescribeDBClusterHealthStatusResponseBodyCS CS { get; set; }
        public class DescribeDBClusterHealthStatusResponseBodyCS : TeaModel {
            /// <summary>
            /// The number of healthy access nodes.
            /// </summary>
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            /// <summary>
            /// The total number of access nodes.
            /// </summary>
            [NameInMap("ExpectedCount")]
            [Validation(Required=false)]
            public long? ExpectedCount { get; set; }

            /// <summary>
            /// The number of risky access nodes.
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// The health state of access nodes. Valid values:
            /// 
            /// *   **RISK**: risky
            /// *   **NORMAL**: healthy
            /// *   **UNAVAILABLE**: unavailable
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The number of unavailable access nodes.
            /// </summary>
            [NameInMap("UnavailableCount")]
            [Validation(Required=false)]
            public long? UnavailableCount { get; set; }

        }

        /// <summary>
        /// Health state details of compute node groups.
        /// </summary>
        [NameInMap("Executor")]
        [Validation(Required=false)]
        public DescribeDBClusterHealthStatusResponseBodyExecutor Executor { get; set; }
        public class DescribeDBClusterHealthStatusResponseBodyExecutor : TeaModel {
            /// <summary>
            /// The number of healthy compute node groups.
            /// </summary>
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            /// <summary>
            /// The total number of compute node groups.
            /// </summary>
            [NameInMap("ExpectedCount")]
            [Validation(Required=false)]
            public long? ExpectedCount { get; set; }

            /// <summary>
            /// The number of risky compute node groups.
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// The health state of compute node groups. Valid values:
            /// 
            /// *   **RISK**: risky
            /// *   **NORMAL**: healthy
            /// *   **UNAVAILABLE**: unavailable
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The number of unavailable compute node groups.
            /// </summary>
            [NameInMap("UnavailableCount")]
            [Validation(Required=false)]
            public long? UnavailableCount { get; set; }

        }

        /// <summary>
        /// The health state of the cluster. Valid values:
        /// 
        /// *   **RISK**: risky
        /// 
        /// *   **NORMAL**: healthy
        /// 
        /// *   **UNAVAILABLE**: unavailable
        /// 
        /// > If the health states of access nodes, compute node groups, and storage node groups are all **healthy** and the cluster is detected to be alive, the health state of the cluster is **healthy**. If the preceding three health states include **risky**, the health state of the cluster is **risky**. If the preceding three health states include **unavailable**, the health state of the cluster is **unavailable**.
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Health state details of storage node groups.
        /// </summary>
        [NameInMap("Worker")]
        [Validation(Required=false)]
        public DescribeDBClusterHealthStatusResponseBodyWorker Worker { get; set; }
        public class DescribeDBClusterHealthStatusResponseBodyWorker : TeaModel {
            /// <summary>
            /// The number of healthy storage node groups.
            /// </summary>
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            /// <summary>
            /// The total number of storage node groups.
            /// </summary>
            [NameInMap("ExpectedCount")]
            [Validation(Required=false)]
            public long? ExpectedCount { get; set; }

            /// <summary>
            /// The number of risky storage node groups.
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// The health state of storage node groups. Valid values:
            /// 
            /// *   **RISK**: risky
            /// *   **NORMAL**: healthy
            /// *   **UNAVAILABLE**: unavailable
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The number of unavailable storage node groups.
            /// </summary>
            [NameInMap("UnavailableCount")]
            [Validation(Required=false)]
            public long? UnavailableCount { get; set; }

        }

    }

}
