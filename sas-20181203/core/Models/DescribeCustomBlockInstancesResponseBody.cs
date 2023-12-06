// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomBlockInstancesResponseBody : TeaModel {
        /// <summary>
        /// The server ID.
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<DescribeCustomBlockInstancesResponseBodyInstanceList> InstanceList { get; set; }
        public class DescribeCustomBlockInstancesResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// The status of the host network extension. Valid values:
            /// 
            /// *   **true**: online
            /// *   **false**: offline
            /// </summary>
            [NameInMap("AliNetOnline")]
            [Validation(Required=false)]
            public bool? AliNetOnline { get; set; }

            /// <summary>
            /// The blocking type. Valid values:
            /// 
            /// *   **group**: security group
            /// *   **alinet**: host network extension
            /// </summary>
            [NameInMap("BlockType")]
            [Validation(Required=false)]
            public string BlockType { get; set; }

            /// <summary>
            /// The error code returned.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The name of the asset.
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
            /// Indicates whether the rule is enabled for the server.
            /// 
            /// *   **2**: enabling failed
            /// *   **1**: enabled
            /// *   **0**: disabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The information that is returned after brute-force attacks are blocked.
            /// </summary>
            [NameInMap("SuccessInfo")]
            [Validation(Required=false)]
            public string SuccessInfo { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeCustomBlockInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeCustomBlockInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page. Default value: **20**.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of servers to which the defense rule is applied.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
