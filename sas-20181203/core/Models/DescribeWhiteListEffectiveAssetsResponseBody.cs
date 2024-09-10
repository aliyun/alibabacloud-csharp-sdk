// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWhiteListEffectiveAssetsResponseBody : TeaModel {
        /// <summary>
        /// The servers on which the policy takes effect.
        /// </summary>
        [NameInMap("Assets")]
        [Validation(Required=false)]
        public List<DescribeWhiteListEffectiveAssetsResponseBodyAssets> Assets { get; set; }
        public class DescribeWhiteListEffectiveAssetsResponseBodyAssets : TeaModel {
            /// <summary>
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("MachineName")]
            [Validation(Required=false)]
            public string MachineName { get; set; }

            /// <summary>
            /// The exception handling mode. Valid values:
            /// 
            /// *   **0**: unhandled
            /// *   **1**: alerted
            /// *   **2**: blocked
            /// </summary>
            [NameInMap("ProcessMethod")]
            [Validation(Required=false)]
            public int? ProcessMethod { get; set; }

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
            /// The number of **untrusted programs** on the server.
            /// </summary>
            [NameInMap("SuspiciousEventCount")]
            [Validation(Required=false)]
            public int? SuspiciousEventCount { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

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
        /// The total number of the servers on which the policy takes effect.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
