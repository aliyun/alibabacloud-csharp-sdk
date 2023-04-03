// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceAddressPoolResponseBody : TeaModel {
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
        /// The addresses in the address pool.
        /// </summary>
        [NameInMap("Addrs")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceAddressPoolResponseBodyAddrs Addrs { get; set; }
        public class DescribeDnsGtmInstanceAddressPoolResponseBodyAddrs : TeaModel {
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmInstanceAddressPoolResponseBodyAddrsAddr> Addr { get; set; }
            public class DescribeDnsGtmInstanceAddressPoolResponseBodyAddrsAddr : TeaModel {
                /// <summary>
                /// The address.
                /// </summary>
                [NameInMap("Addr")]
                [Validation(Required=false)]
                public string Addr { get; set; }

                /// <summary>
                /// The status of the last health check on the address. Valid values:
                /// 
                /// *   OK: No active alerts are triggered.
                /// *   ALERT: Alerts are triggered based on the alert rules.
                /// </summary>
                [NameInMap("AlertStatus")]
                [Validation(Required=false)]
                public string AlertStatus { get; set; }

                /// <summary>
                /// The source region of the address.
                /// 
                /// *   lineCode: the line code of the source region of the address. This parameter is deprecated, and lineCodes prevails.
                /// *   lineName: the line name of the source region of the address. This parameter is deprecated.
                /// *   lineCodes: the line codes of the source regions of the address.
                /// </summary>
                [NameInMap("AttributeInfo")]
                [Validation(Required=false)]
                public string AttributeInfo { get; set; }

                /// <summary>
                /// The time when the address was added into the address pool.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The timestamp that indicates the time when the address was added into the address pool.
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// The weight of the address.
                /// </summary>
                [NameInMap("LbaWeight")]
                [Validation(Required=false)]
                public int? LbaWeight { get; set; }

                /// <summary>
                /// The mode of the address. Valid values:
                /// 
                /// *   SMART: smart return
                /// *   ONLINE: always online
                /// *   OFFLINE: always offline
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// The description of the address.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The time when the address was last updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The timestamp that indicates the time when the address was last updated.
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// The time when the address pool was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The timestamp that indicates the time when the address pool was created.
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// The load balancing policy for the address pool. Valid values:
        /// 
        /// *   ALL_RR: returns all addresses.
        /// *   RATIO: returns addresses by weight.
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// The ID of the health check configuration.
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        /// <summary>
        /// Indicates the status of the health check. Valid values:
        /// 
        /// *   OPEN: The health check is enabled.
        /// *   CLOSE: The health check is disabled.
        /// *   UNCONFIGURED: The health check is not configured.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// The time when the address pool was last updated.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// The timestamp that indicates the time when the address pool was last updated.
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
