// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeNamespacesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the request was successful.
        /// *   **3xx**: indicates that the request was redirected.
        /// *   **4xx**: indicates that the request failed.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information of namespaces.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeNamespacesResponseBodyData Data { get; set; }
        public class DescribeNamespacesResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The list of namespaces.
            /// </summary>
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<DescribeNamespacesResponseBodyDataNamespaces> Namespaces { get; set; }
            public class DescribeNamespacesResponseBodyDataNamespaces : TeaModel {
                /// <summary>
                /// The ACM-specific AccessKey ID. It can be used to manage data in an Application Configuration Management (ACM) namespace. For more information, see [Differences between Alibaba Cloud AccessKey and ACM-specific AccessKey](~~~~).
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                [NameInMap("AddressServerHost")]
                [Validation(Required=false)]
                public string AddressServerHost { get; set; }

                [NameInMap("NameSpaceShortId")]
                [Validation(Required=false)]
                public string NameSpaceShortId { get; set; }

                /// <summary>
                /// The description of the namespace.
                /// </summary>
                [NameInMap("NamespaceDescription")]
                [Validation(Required=false)]
                public string NamespaceDescription { get; set; }

                /// <summary>
                /// The ID of the namespace. The information of the default namespace cannot be queried or modified. The default namespace cannot be deleted.
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// The name of the namespace.
                /// </summary>
                [NameInMap("NamespaceName")]
                [Validation(Required=false)]
                public string NamespaceName { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ACM-specific AccessKey secret. It can be used to manage data in an ACM namespace. For more information, see [Differences between Alibaba Cloud AccessKey and ACM-specific AccessKey](~~~~).
                /// </summary>
                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                /// <summary>
                /// The ID of the tenant.
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

            /// <summary>
            /// The number of entries returned on each page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of namespaces.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// The error code. 
        /// 
        /// - The **ErrorCode** parameter is not returned when the request succeeds.
        /// - The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned message.
        /// 
        /// *   **success** is returned when the request succeeds.
        /// *   An error message is returned when the request fails.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the details of namespaces were queried successfully. Valid values:
        /// 
        /// *   **true**: indicates that the query was successful.
        /// *   **false**: indicates that the query failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the trace. It can be used to query the details of a request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
