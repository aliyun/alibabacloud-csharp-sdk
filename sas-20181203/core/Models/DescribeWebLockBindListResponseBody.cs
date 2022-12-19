// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockBindListResponseBody : TeaModel {
        /// <summary>
        /// The information about the servers that have web tamper proofing enabled.
        /// </summary>
        [NameInMap("BindList")]
        [Validation(Required=false)]
        public List<DescribeWebLockBindListResponseBodyBindList> BindList { get; set; }
        public class DescribeWebLockBindListResponseBodyBindList : TeaModel {
            /// <summary>
            /// The number of alerts.
            /// </summary>
            [NameInMap("AuditCount")]
            [Validation(Required=false)]
            public string AuditCount { get; set; }

            /// <summary>
            /// The number of blocked tampering events.
            /// </summary>
            [NameInMap("BlockCount")]
            [Validation(Required=false)]
            public string BlockCount { get; set; }

            /// <summary>
            /// The number of protected directories.
            /// </summary>
            [NameInMap("DirCount")]
            [Validation(Required=false)]
            public string DirCount { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the server.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The operating system that the server runs.
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// The starting progress percentage of web tamper proofing. Valid values: 0 to 100.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            /// <summary>
            /// The error code for web tamper proofing. Valid values:
            /// 
            /// *   **2001**: The Security Center agent is offline.
            /// *   **9999**: The connection timed out.
            /// </summary>
            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            /// <summary>
            /// The error message for web tamper proofing. Valid values:
            /// 
            /// *   **client offline**: The Security Center agent is offline.
            /// *   **timeout**: The connection timed out.
            /// </summary>
            [NameInMap("ServiceDetail")]
            [Validation(Required=false)]
            public string ServiceDetail { get; set; }

            /// <summary>
            /// The status of web tamper proofing on the server. Valid values:
            /// 
            /// *   **stop**: Web tamper proofing is disabled.
            /// *   **initializing**: Web tamper proofing is being enabled.
            /// *   **exception**: Web tamper proofing is not running as expected.
            /// *   **running**: Web tamper proofing is running.
            /// *   **closing**: Web tamper proofing is being disabled.
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

            /// <summary>
            /// The protection status of the server. Valid values:
            /// 
            /// *   **on**: protected
            /// *   **off**: unprotected
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The page number of the returned page. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries returned per page. Default value: 20.
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
        /// The total number of servers that have web tamper proofing enabled.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
