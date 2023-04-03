// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceAddressPoolsResponseBody : TeaModel {
        /// <summary>
        /// The returned address pools.
        /// </summary>
        [NameInMap("AddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceAddressPoolsResponseBodyAddrPools AddrPools { get; set; }
        public class DescribeDnsGtmInstanceAddressPoolsResponseBodyAddrPools : TeaModel {
            [NameInMap("AddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmInstanceAddressPoolsResponseBodyAddrPoolsAddrPool> AddrPool { get; set; }
            public class DescribeDnsGtmInstanceAddressPoolsResponseBodyAddrPoolsAddrPool : TeaModel {
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
                /// The time when the address pool was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The timestamp that indicates when the address pool was created.
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// The load balancing policy of the address pool. Valid values:
                /// 
                /// *   ALL_RR: returns all addresses.
                /// *   RATIO: returns addresses by weight.
                /// </summary>
                [NameInMap("LbaStrategy")]
                [Validation(Required=false)]
                public string LbaStrategy { get; set; }

                /// <summary>
                /// The ID of the health check task.
                /// </summary>
                [NameInMap("MonitorConfigId")]
                [Validation(Required=false)]
                public string MonitorConfigId { get; set; }

                /// <summary>
                /// Indicates whether health checks are configured. Valid values:
                /// 
                /// *   OPEN: enabled
                /// *   CLOSE: disabled
                /// *   UNCONFIGURED: not configured
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
                /// The type of the address pool. Valid values:
                /// 
                /// *   IPV4: IPv4 address
                /// *   IPV6: IPv6 address
                /// *   DOMAIN: domain name
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The time when the address pool was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The timestamp that indicates when the address pool was updated.
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
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
