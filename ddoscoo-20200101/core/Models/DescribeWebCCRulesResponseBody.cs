// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCCRulesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of custom frequency control rules.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The custom frequency control rule.
        /// </summary>
        [NameInMap("WebCCRules")]
        [Validation(Required=false)]
        public List<DescribeWebCCRulesResponseBodyWebCCRules> WebCCRules { get; set; }
        public class DescribeWebCCRulesResponseBodyWebCCRules : TeaModel {
            /// <summary>
            /// The action triggered if the rule is matched. Valid values:
            /// 
            /// *   **close**: The requests that match the rule are blocked.
            /// *   **captcha**: Completely Automated Public Turing test to tell Computers and Humans Apart (CAPTCHA) verification for the requests that match the rule is implemented.
            /// </summary>
            [NameInMap("Act")]
            [Validation(Required=false)]
            public string Act { get; set; }

            /// <summary>
            /// The number of requests that are allowed from a single IP address. Valid values: **2** to **2000**.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The check interval. Valid values: **5** to **10800**. Unit: seconds.
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// The match mode. Valid values:
            /// 
            /// *   **prefix**: prefix match.
            /// *   **match**: exact match.
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The validity period. Valid values: **1** to **1440**. Unit: minutes.
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// The check path.
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

    }

}
