// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWhiteListStrategyStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The statistics of the policies.
        /// </summary>
        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public List<DescribeWhiteListStrategyStatisticsResponseBodyStrategies> Strategies { get; set; }
        public class DescribeWhiteListStrategyStatisticsResponseBodyStrategies : TeaModel {
            /// <summary>
            /// The number of the servers on which the policy takes effect.
            /// </summary>
            [NameInMap("AssetCount")]
            [Validation(Required=false)]
            public int? AssetCount { get; set; }

            /// <summary>
            /// The learning progress of the policy. Unit: percent (%).
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// The status of the policy. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: learning
            /// *   **2**: paused
            /// *   **3**: learning completed
            /// *   **4**: enabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The ID of the policy.
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public long? StrategyId { get; set; }

            /// <summary>
            /// The name of the policy.
            /// </summary>
            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            /// <summary>
            /// The intelligent learning duration. Unit: hour.
            /// </summary>
            [NameInMap("StudyTime")]
            [Validation(Required=false)]
            public int? StudyTime { get; set; }

            /// <summary>
            /// The number of suspicious processes.
            /// </summary>
            [NameInMap("SuspiciousProcCount")]
            [Validation(Required=false)]
            public int? SuspiciousProcCount { get; set; }

            /// <summary>
            /// The number of trusted processes.
            /// </summary>
            [NameInMap("TrustProcCount")]
            [Validation(Required=false)]
            public int? TrustProcCount { get; set; }

            /// <summary>
            /// The number of malicious processes.
            /// </summary>
            [NameInMap("VirusProcCount")]
            [Validation(Required=false)]
            public int? VirusProcCount { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
