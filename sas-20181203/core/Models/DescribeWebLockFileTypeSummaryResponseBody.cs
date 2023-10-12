// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockFileTypeSummaryResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of events on web tamper proofing returned.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeWebLockFileTypeSummaryResponseBodyList> List { get; set; }
        public class DescribeWebLockFileTypeSummaryResponseBodyList : TeaModel {
            /// <summary>
            /// The number of attempts.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The type of the protected file. Valid values:
            /// 
            /// *   **php**: PHP file
            /// *   **jsp**: JSP file
            /// *   **asp**: ASP file
            /// *   **aspx**: ASPX file
            /// *   **js**: JS file
            /// *   **cgi**: CGI file
            /// *   **html**: HTML file
            /// *   **htm**: HTM file
            /// *   **xml**: XML file
            /// *   **shtml**: SHTML file
            /// *   **shtm**: SHTM file
            /// *   **jpg**: JPG file
            /// *   **gif**: GIF file
            /// *   **png**: PNG file
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of events on web tamper proofing.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
