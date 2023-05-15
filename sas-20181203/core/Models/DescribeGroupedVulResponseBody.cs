// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedVulResponseBody : TeaModel {
        /// <summary>
        /// The number of entries to return on each page. Default value: 10.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("GroupedVulItems")]
        [Validation(Required=false)]
        public List<DescribeGroupedVulResponseBodyGroupedVulItems> GroupedVulItems { get; set; }
        public class DescribeGroupedVulResponseBodyGroupedVulItems : TeaModel {
            /// <summary>
            /// The number of handled vulnerabilities.
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// The tag that is added to the vulnerability. Valid values:
            /// 
            /// *   Restart required
            /// *   Remote exploitation
            /// *   Exploit exists
            /// *   Exploitable
            /// *   Privilege escalation
            /// *   Code execution
            /// </summary>
            [NameInMap("AsapCount")]
            [Validation(Required=false)]
            public int? AsapCount { get; set; }

            /// <summary>
            /// An array that consists of the details about the vulnerability.
            /// </summary>
            [NameInMap("GmtLast")]
            [Validation(Required=false)]
            public long? GmtLast { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("HandledCount")]
            [Validation(Required=false)]
            public int? HandledCount { get; set; }

            /// <summary>
            /// The number of vulnerabilities that have the **low** priority.
            /// </summary>
            [NameInMap("LaterCount")]
            [Validation(Required=false)]
            public int? LaterCount { get; set; }

            /// <summary>
            /// The timestamp when the vulnerability was last detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the request, which is used to locate and troubleshoot issues.
            /// </summary>
            [NameInMap("NntfCount")]
            [Validation(Required=false)]
            public int? NntfCount { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: 10.
            /// </summary>
            [NameInMap("RaspDefend")]
            [Validation(Required=false)]
            public int? RaspDefend { get; set; }

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
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// gmtLast
            /// </summary>
            [NameInMap("TotalFixCount")]
            [Validation(Required=false)]
            public long? TotalFixCount { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The tag that is used to search for the vulnerabilities. Valid values:
        /// 
        /// *   Restart required
        /// *   Remote exploitation
        /// *   Exploit exists
        /// *   Exploitable
        /// *   Privilege escalation
        /// *   Code execution
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the asset group.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The types of the vulnerabilities.
        /// 
        /// > This parameter is valid only for application vulnerabilities and vulnerabilities that are detected based on software component analysis.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
