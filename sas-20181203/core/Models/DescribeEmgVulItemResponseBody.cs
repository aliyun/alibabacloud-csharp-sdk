// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEmgVulItemResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// An array that consists of the urgent vulnerabilities returned.
        /// </summary>
        [NameInMap("GroupedVulItems")]
        [Validation(Required=false)]
        public List<DescribeEmgVulItemResponseBodyGroupedVulItems> GroupedVulItems { get; set; }
        public class DescribeEmgVulItemResponseBodyGroupedVulItems : TeaModel {
            /// <summary>
            /// The name of the urgent vulnerability.
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// The check method.
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// The timestamp when the urgent vulnerability was last detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtLastCheck")]
            [Validation(Required=false)]
            public long? GmtLastCheck { get; set; }

            /// <summary>
            /// The timestamp when the vulnerability was disclosed. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtPublish")]
            [Validation(Required=false)]
            public long? GmtPublish { get; set; }

            /// <summary>
            /// The name of the detection rule.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The number of unhandled urgent vulnerabilities.
            /// </summary>
            [NameInMap("PendingCount")]
            [Validation(Required=false)]
            public int? PendingCount { get; set; }

            /// <summary>
            /// The progress of the urgent vulnerability detection task. Valid values: 0 to 100.
            /// 
            /// > This parameter is returned only when an urgent vulnerability is being detected.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// The detection status of the urgent vulnerability. Valid values:
            /// 
            /// *   **10**: The urgent vulnerability is not detected.
            /// *   **20**: The urgent vulnerability is being detected.
            /// *   **30**: The urgent vulnerability detection is complete.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The method that is used to detect the urgent vulnerability. Valid values:
            /// 
            /// *   **python**: The Version method is used. Security Center checks the software versions of your server to check whether disclosed vulnerabilities exist on your server.
            /// *   **scan**: The Network Scan method is used. Security Center analyzes the access traffic to your server over the Internet to check whether vulnerabilities exist on your server.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page. Default value: **10**.
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
        /// The total number of the urgent vulnerabilities returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
