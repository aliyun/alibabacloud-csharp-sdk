// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstanceAddressPoolsResponseBody : TeaModel {
        /// <summary>
        /// The returned list of address pools of the GTM instance.
        /// </summary>
        [NameInMap("AddrPools")]
        [Validation(Required=false)]
        public DescribeGtmInstanceAddressPoolsResponseBodyAddrPools AddrPools { get; set; }
        public class DescribeGtmInstanceAddressPoolsResponseBodyAddrPools : TeaModel {
            [NameInMap("AddrPool")]
            [Validation(Required=false)]
            public List<DescribeGtmInstanceAddressPoolsResponseBodyAddrPoolsAddrPool> AddrPool { get; set; }
            public class DescribeGtmInstanceAddressPoolsResponseBodyAddrPoolsAddrPool : TeaModel {
                /// <summary>
                /// The number of addresses in the address pool.
                /// </summary>
                [NameInMap("AddrCount")]
                [Validation(Required=false)]
                public int? AddrCount { get; set; }

                /// <summary>
                /// The ID of the address pool.
                /// </summary>
                [NameInMap("AddrPoolId")]
                [Validation(Required=false)]
                public string AddrPoolId { get; set; }

                /// <summary>
                /// The time when this address pool was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// The minimum number of available addresses in the address pool.
                /// </summary>
                [NameInMap("MinAvailableAddrNum")]
                [Validation(Required=false)]
                public int? MinAvailableAddrNum { get; set; }

                /// <summary>
                /// The health check ID of the address pool.
                /// </summary>
                [NameInMap("MonitorConfigId")]
                [Validation(Required=false)]
                public string MonitorConfigId { get; set; }

                /// <summary>
                /// Indicates whether health check was enabled for the address pool. Valid values:
                /// 
                /// *   **OPEN**: Enabled
                /// *   **CLOSE**: Disabled
                /// *   **UNCONFIGURED**: Not configured
                /// </summary>
                [NameInMap("MonitorStatus")]
                [Validation(Required=false)]
                public string MonitorStatus { get; set; }

                /// <summary>
                /// The name of the address pool.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The availability status of the address pool. Valid values:
                /// 
                /// *   **AVAILABLE**: Available
                /// *   **NOT_AVAILABLE**: Unavailable
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the address pool. Valid values:
                /// 
                /// *   **IP**: IP address
                /// *   **DOMAIN**: Domain name
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The last time when the address pool was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// A timestamp that indicates the last time the address pool was updated.
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// The number of the page returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned on all pages.
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
