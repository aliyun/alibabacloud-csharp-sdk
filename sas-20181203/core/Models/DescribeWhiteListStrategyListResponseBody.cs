// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWhiteListStrategyListResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the policies.
        /// </summary>
        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public List<DescribeWhiteListStrategyListResponseBodyStrategies> Strategies { get; set; }
        public class DescribeWhiteListStrategyListResponseBodyStrategies : TeaModel {
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

        }

    }

}
