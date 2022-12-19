// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningSummaryResponseBody : TeaModel {
        /// <summary>
        /// The number of check items returned on the current page.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The page number of the current page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of check items.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The statistics of check items.
        /// </summary>
        [NameInMap("WarningSummarys")]
        [Validation(Required=false)]
        public List<DescribeCheckWarningSummaryResponseBodyWarningSummarys> WarningSummarys { get; set; }
        public class DescribeCheckWarningSummaryResponseBodyWarningSummarys : TeaModel {
            /// <summary>
            /// The number of check items.
            /// </summary>
            [NameInMap("CheckCount")]
            [Validation(Required=false)]
            public int? CheckCount { get; set; }

            /// <summary>
            /// Indicates whether the risk item can be exploited. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("CheckExploit")]
            [Validation(Required=false)]
            public bool? CheckExploit { get; set; }

            /// <summary>
            /// Indicates whether the risk item is a database risk item. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("DatabaseRisk")]
            [Validation(Required=false)]
            public bool? DatabaseRisk { get; set; }

            /// <summary>
            /// The number of high-risk items.
            /// </summary>
            [NameInMap("HighWarningCount")]
            [Validation(Required=false)]
            public int? HighWarningCount { get; set; }

            /// <summary>
            /// The time when the last baseline check was performed.
            /// </summary>
            [NameInMap("LastFoundTime")]
            [Validation(Required=false)]
            public string LastFoundTime { get; set; }

            /// <summary>
            /// The risk level of the risk item. Valid values:
            /// 
            /// *   **high**
            /// *   **medium**
            /// *   **low**
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The number of low-risk items.
            /// </summary>
            [NameInMap("LowWarningCount")]
            [Validation(Required=false)]
            public int? LowWarningCount { get; set; }

            /// <summary>
            /// The number of medium-risk items.
            /// </summary>
            [NameInMap("MediumWarningCount")]
            [Validation(Required=false)]
            public int? MediumWarningCount { get; set; }

            /// <summary>
            /// The ID of the risk item.
            /// </summary>
            [NameInMap("RiskId")]
            [Validation(Required=false)]
            public long? RiskId { get; set; }

            /// <summary>
            /// The name of the risk item.
            /// </summary>
            [NameInMap("RiskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            /// <summary>
            /// The level-2 type of the risk item.
            /// </summary>
            [NameInMap("SubTypeAlias")]
            [Validation(Required=false)]
            public string SubTypeAlias { get; set; }

            /// <summary>
            /// The level-1 type of the check item. Examples: database, system, weak password, and middleware.
            /// </summary>
            [NameInMap("TypeAlias")]
            [Validation(Required=false)]
            public string TypeAlias { get; set; }

            /// <summary>
            /// The number of assets on which risk items are detected.
            /// </summary>
            [NameInMap("WarningMachineCount")]
            [Validation(Required=false)]
            public int? WarningMachineCount { get; set; }

        }

    }

}
