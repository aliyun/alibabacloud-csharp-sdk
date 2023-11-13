// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCCRulesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned custom frequency control rules.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// An array that consists of the details of the custom frequency control rule.
        /// </summary>
        [NameInMap("WebCCRules")]
        [Validation(Required=false)]
        public List<DescribeWebCCRulesResponseBodyWebCCRules> WebCCRules { get; set; }
        public class DescribeWebCCRulesResponseBodyWebCCRules : TeaModel {
            /// <summary>
            /// The blocking type. Valid values:
            /// 
            /// *   **close**: blocks requests.
            /// *   **captcha**: enables Completely Automated Public Turing test to tell Computers and Humans Apart (CAPTCHA) verification.
            /// </summary>
            [NameInMap("Act")]
            [Validation(Required=false)]
            public string Act { get; set; }

            /// <summary>
            /// The number of requests that are allowed from an individual IP address. Valid values: **2** to **2000**.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The check intervals. Valid values: **5** to **10800**. Unit: seconds.
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// The match mode. Valid values:
            /// 
            /// *   **prefix**: prefix match
            /// *   **match**: exact match
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
            /// The blocking duration. Valid values: **1** to **1440**. Unit: minutes.
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
