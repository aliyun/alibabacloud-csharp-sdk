// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedVulResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The information about the vulnerability.
        /// </summary>
        [NameInMap("GroupedVulItems")]
        [Validation(Required=false)]
        public List<DescribeGroupedVulResponseBodyGroupedVulItems> GroupedVulItems { get; set; }
        public class DescribeGroupedVulResponseBodyGroupedVulItems : TeaModel {
            /// <summary>
            /// The alias of the vulnerability.
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// The number of vulnerabilities that have the **high** priority.
            /// </summary>
            [NameInMap("AsapCount")]
            [Validation(Required=false)]
            public int? AsapCount { get; set; }

            /// <summary>
            /// The timestamp when the vulnerability was last detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtLast")]
            [Validation(Required=false)]
            public long? GmtLast { get; set; }

            /// <summary>
            /// The number of handled vulnerabilities.
            /// </summary>
            [NameInMap("HandledCount")]
            [Validation(Required=false)]
            public int? HandledCount { get; set; }

            /// <summary>
            /// The number of vulnerabilities that have the **medium** priority.
            /// </summary>
            [NameInMap("LaterCount")]
            [Validation(Required=false)]
            public int? LaterCount { get; set; }

            /// <summary>
            /// The name of the vulnerability.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The number of vulnerabilities that have the **low** priority.
            /// </summary>
            [NameInMap("NntfCount")]
            [Validation(Required=false)]
            public int? NntfCount { get; set; }

            /// <summary>
            /// Indicates whether the application protection feature is supported.
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// 
            /// > If this parameter is not returned, the application protection feature is not supported.
            /// </summary>
            [NameInMap("RaspDefend")]
            [Validation(Required=false)]
            public int? RaspDefend { get; set; }

            /// <summary>
            /// The IDs of the common vulnerabilities and exposures (CVEs) that are related to the vulnerability.
            /// </summary>
            [NameInMap("Related")]
            [Validation(Required=false)]
            public string Related { get; set; }

            /// <summary>
            /// The tag that is added to the vulnerability. Valid values:
            /// 
            /// *   Restart required
            /// *   Remote utilization
            /// *   EXP exists
            /// *   Available
            /// *   Elevation of Privilege
            /// *   Code Execution
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// The total number of fixed vulnerabilities.
            /// </summary>
            [NameInMap("TotalFixCount")]
            [Validation(Required=false)]
            public long? TotalFixCount { get; set; }

            /// <summary>
            /// The type of the vulnerability. Valid values:
            /// 
            /// *   **cve**: Linux software vulnerability
            /// *   **sys**: Windows system vulnerability
            /// *   **cms**: Web-CMS vulnerability
            /// *   **app**: application vulnerability
            /// *   **emg**: urgent vulnerability
            /// *   **sca**: vulnerability that is detected based on software component analysis
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The number of entries per page. Default value: 10.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
