// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// The access nodes of the queried cluster.
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
            /// The number of risky nodes.
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// The health state of access nodes. Valid values:
            /// 
            /// *   **RISK**
            /// *   **NORMAL**
            /// *   **UNAVAILABLE**
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
        /// The compute node groups of the queried cluster.
        /// </summary>
        [NameInMap("Executor")]
        [Validation(Required=false)]
        public DescribeDBClusterHealthStatusResponseBodyExecutor Executor { get; set; }
        public class DescribeDBClusterHealthStatusResponseBodyExecutor : TeaModel {
            /// <summary>
            /// The number of healthy access nodes.
            /// </summary>
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            /// <summary>
            /// The total number of compute nodes.
            /// </summary>
            [NameInMap("ExpectedCount")]
            [Validation(Required=false)]
            public long? ExpectedCount { get; set; }

            /// <summary>
            /// The number of risky nodes.
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// The health state of compute node groups. Valid values:
            /// 
            /// *   **RISK**
            /// *   **NORMAL**
            /// *   **UNAVAILABLE**
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
        /// The health state of the cluster. Valid values:
        /// 
        /// *   **RISK**
        /// *   **NORMAL**
        /// *   **UNAVAILABLE**
        /// 
        /// >  When the states of the access nodes, compute node groups, and storage node groups of a cluster are all **NORMAL** and a connection to the cluster is established, the state of the cluster is **NORMAL**. When the state of the access nodes, compute node groups, or storage node groups of the cluster is **RISK**, the state of the cluster is **RISK**. When the state of the access nodes, compute node groups, or storage node groups of the cluster is **UNAVAILABLE**, the state of the cluster is **UNAVAILABLE**.
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The storage node groups of the queried cluster.
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
            /// *   **RISK**
            /// *   **NORMAL**
            /// *   **UNAVAILABLE**
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
