// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAntiBruteForceRulesResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeAntiBruteForceRulesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeAntiBruteForceRulesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the defense rules.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeAntiBruteForceRulesResponseBodyRules> Rules { get; set; }
        public class DescribeAntiBruteForceRulesResponseBodyRules : TeaModel {
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// Indicates whether the defense rule is the default rule. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// 
            /// > The default rule takes effect on all servers that are not protected by defense rules against brute-force attacks.
            /// </summary>
            [NameInMap("DefaultRule")]
            [Validation(Required=false)]
            public bool? DefaultRule { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("EnableSmartRule")]
            [Validation(Required=false)]
            public bool? EnableSmartRule { get; set; }

            /// <summary>
            /// The threshold of logon failures that you specify.
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// The period of time during which logons from an account are not allowed. Unit: minutes.
            /// </summary>
            [NameInMap("ForbiddenTime")]
            [Validation(Required=false)]
            public int? ForbiddenTime { get; set; }

            /// <summary>
            /// The ID of the defense rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The number of servers to which the defense rule is applied.
            /// </summary>
            [NameInMap("MachineCount")]
            [Validation(Required=false)]
            public int? MachineCount { get; set; }

            /// <summary>
            /// The name of the defense rule.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The period of time during which logon failures from an account are measured. Unit: minutes. If **Span** is set to 10, the defense rule takes effect when the logon failures measured within 10 minutes reaches the specified threshold. The IP addresses of attackers cannot be used to log on to the server within the specified period of time.
            /// </summary>
            [NameInMap("Span")]
            [Validation(Required=false)]
            public int? Span { get; set; }

            /// <summary>
            /// An array consisting of the UUIDs of servers to which the defense rule is applied.
            /// </summary>
            [NameInMap("UuidList")]
            [Validation(Required=false)]
            public List<string> UuidList { get; set; }

        }

    }

}
