// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class FindContainerNetworkConnectResponseBody : TeaModel {
        /// <summary>
        /// The information about the network connections.
        /// </summary>
        [NameInMap("Connects")]
        [Validation(Required=false)]
        public List<FindContainerNetworkConnectResponseBodyConnects> Connects { get; set; }
        public class FindContainerNetworkConnectResponseBodyConnects : TeaModel {
            /// <summary>
            /// The information about the destination container.
            /// 
            /// > This parameter is not supported.
            /// </summary>
            [NameInMap("DstContainer")]
            [Validation(Required=false)]
            public FindContainerNetworkConnectResponseBodyConnectsDstContainer DstContainer { get; set; }
            public class FindContainerNetworkConnectResponseBodyConnectsDstContainer : TeaModel {
                /// <summary>
                /// The ID of the destination container.
                /// </summary>
                [NameInMap("ContainerId")]
                [Validation(Required=false)]
                public string ContainerId { get; set; }

            }

            /// <summary>
            /// The destination IP address.
            /// </summary>
            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            /// <summary>
            /// The destination port.
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public string DstPort { get; set; }

            /// <summary>
            /// The timestamp when the connection was first established.
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// The ID of the network connection.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The timestamp when the connection was last established.
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// The information about the source container.
            /// 
            /// > This parameter is not supported.
            /// </summary>
            [NameInMap("SrcContainer")]
            [Validation(Required=false)]
            public FindContainerNetworkConnectResponseBodyConnectsSrcContainer SrcContainer { get; set; }
            public class FindContainerNetworkConnectResponseBodyConnectsSrcContainer : TeaModel {
                /// <summary>
                /// The ID of the source container.
                /// </summary>
                [NameInMap("ContainerId")]
                [Validation(Required=false)]
                public string ContainerId { get; set; }

            }

            /// <summary>
            /// The source IP address.
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            /// <summary>
            /// The source port.
            /// </summary>
            [NameInMap("SrcPort")]
            [Validation(Required=false)]
            public string SrcPort { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public FindContainerNetworkConnectResponseBodyPageInfo PageInfo { get; set; }
        public class FindContainerNetworkConnectResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **20**.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
