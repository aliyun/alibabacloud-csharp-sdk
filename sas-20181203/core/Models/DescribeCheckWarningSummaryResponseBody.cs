// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningSummaryResponseBody : TeaModel {
        /// <summary>
        /// The level-1 type of the check item. Examples: database, system, weak password, and middleware.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Indicates whether the risk item can be exploited. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The ID of the container cluster.
        /// 
        /// >  You can call the [DescribeGroupedContainerInstances](~~182997~~) operation to query the IDs of container clusters.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the risk item.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The number of medium-risk items.
        /// </summary>
        [NameInMap("WarningSummarys")]
        [Validation(Required=false)]
        public List<DescribeCheckWarningSummaryResponseBodyWarningSummarys> WarningSummarys { get; set; }
        public class DescribeCheckWarningSummaryResponseBodyWarningSummarys : TeaModel {
            /// <summary>
            /// The statistics of check items.
            /// </summary>
            [NameInMap("CheckCount")]
            [Validation(Required=false)]
            public int? CheckCount { get; set; }

            [NameInMap("CheckExploit")]
            [Validation(Required=false)]
            public bool? CheckExploit { get; set; }

            [NameInMap("ContainerRisk")]
            [Validation(Required=false)]
            public bool? ContainerRisk { get; set; }

            [NameInMap("DatabaseRisk")]
            [Validation(Required=false)]
            public bool? DatabaseRisk { get; set; }

            [NameInMap("HighWarningCount")]
            [Validation(Required=false)]
            public int? HighWarningCount { get; set; }

            /// <summary>
            /// The number of low-risk items.
            /// </summary>
            [NameInMap("LastFoundTime")]
            [Validation(Required=false)]
            public string LastFoundTime { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The number of entries to return on each page.
            /// </summary>
            [NameInMap("LowWarningCount")]
            [Validation(Required=false)]
            public int? LowWarningCount { get; set; }

            /// <summary>
            /// The ID of the request, which is used to locate and troubleshoot issues.
            /// </summary>
            [NameInMap("MediumWarningCount")]
            [Validation(Required=false)]
            public int? MediumWarningCount { get; set; }

            /// <summary>
            /// The number of check items returned on the current page.
            /// </summary>
            [NameInMap("RiskId")]
            [Validation(Required=false)]
            public long? RiskId { get; set; }

            [NameInMap("RiskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            /// <summary>
            /// Queries the statistical information about baseline check results. The information includes the number of servers on which a baseline check is performed, the number of baseline check items, and the pass rate of check items in the last baseline check.
            /// </summary>
            [NameInMap("SubTypeAlias")]
            [Validation(Required=false)]
            public string SubTypeAlias { get; set; }

            [NameInMap("TypeAlias")]
            [Validation(Required=false)]
            public string TypeAlias { get; set; }

            /// <summary>
            /// DescribeCheckWarningSummary
            /// </summary>
            [NameInMap("WarningMachineCount")]
            [Validation(Required=false)]
            public int? WarningMachineCount { get; set; }

        }

    }

}
