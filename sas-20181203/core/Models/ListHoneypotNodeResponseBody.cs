// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotNodeResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// An array that consists of the information about the management nodes.
        /// </summary>
        [NameInMap("HoneypotNodeList")]
        [Validation(Required=false)]
        public List<ListHoneypotNodeResponseBodyHoneypotNodeList> HoneypotNodeList { get; set; }
        public class ListHoneypotNodeResponseBodyHoneypotNodeList : TeaModel {
            /// <summary>
            /// Indicates whether a honeypot is allowed to access the Internet. Valid values:
            /// 
            /// *   **true**: The honeypot is allowed to access the Internet.
            /// *   **false**: The honeypot is not allowed to access the Internet.
            /// </summary>
            [NameInMap("AllowHoneypotAccessInternet")]
            [Validation(Required=false)]
            public bool? AllowHoneypotAccessInternet { get; set; }

            /// <summary>
            /// The time when the management node was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The type of the management node. Default value: **false**. Valid values:
            /// 
            /// *   **false**: non-default type
            /// *   **true**: default type
            /// </summary>
            [NameInMap("DefaultNode")]
            [Validation(Required=false)]
            public bool? DefaultNode { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("EcsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            /// <summary>
            /// The maximum number of honeypots that can be deployed to the management node.
            /// </summary>
            [NameInMap("HoneypotTotalCount")]
            [Validation(Required=false)]
            public int? HoneypotTotalCount { get; set; }

            /// <summary>
            /// The number of honeypots that are deployed to the management node.
            /// </summary>
            [NameInMap("HoneypotUsedCount")]
            [Validation(Required=false)]
            public int? HoneypotUsedCount { get; set; }

            /// <summary>
            /// The ID of the management node.
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// The IP address of the management node.
            /// </summary>
            [NameInMap("NodeIp")]
            [Validation(Required=false)]
            public string NodeIp { get; set; }

            /// <summary>
            /// The name of the management node.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The maximum number of probes that can be deployed for the management node.
            /// </summary>
            [NameInMap("ProbeTotalCount")]
            [Validation(Required=false)]
            public int? ProbeTotalCount { get; set; }

            /// <summary>
            /// The number of probes that are deployed for the management node.
            /// </summary>
            [NameInMap("ProbeUsedCount")]
            [Validation(Required=false)]
            public int? ProbeUsedCount { get; set; }

            /// <summary>
            /// An array consisting of the CIDR blocks that are allowed to access the management node.
            /// </summary>
            [NameInMap("SecurityGroupProbeIpList")]
            [Validation(Required=false)]
            public List<string> SecurityGroupProbeIpList { get; set; }

            /// <summary>
            /// The status of the management node. Valid values:
            /// 
            /// *   **1**: normal
            /// *   **2**: abnormal
            /// </summary>
            [NameInMap("TotalStatus")]
            [Validation(Required=false)]
            public int? TotalStatus { get; set; }

            /// <summary>
            /// Indicates whether the management node can be upgraded. Valid values:
            /// 
            /// *   **false**: no
            /// *   **true**: yes
            /// </summary>
            [NameInMap("UpgradeAvailable")]
            [Validation(Required=false)]
            public bool? UpgradeAvailable { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotNodeResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotNodeResponseBodyPageInfo : TeaModel {
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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
