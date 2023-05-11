// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDnsGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// The address pools.
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public List<AddDnsGtmAddressPoolRequestAddr> Addr { get; set; }
        public class AddDnsGtmAddressPoolRequestAddr : TeaModel {
            /// <summary>
            /// The address in the address pool.
            /// </summary>
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public string Addr { get; set; }

            /// <summary>
            /// The source region of the address, in JSON-formatted string.
            /// 
            /// *   LineCode: the line code of the source region of the address.
            /// 
            /// *   lineCodeRectifyType: the rectification type of the line code. Default value: AUTO. Valid values:
            /// 
            ///     *   NO_NEED: no need for rectification.
            ///     *   RECTIFIED: rectified.
            ///     *   AUTO: automatic rectification.
            /// </summary>
            [NameInMap("AttributeInfo")]
            [Validation(Required=false)]
            public string AttributeInfo { get; set; }

            /// <summary>
            /// The weight of the address.
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

            /// <summary>
            /// The response mode of address resolution. Valid values:
            /// 
            /// *   SMART: smart return.
            /// *   ONLINE: always online.
            /// *   OFFLINE: always offline.
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// The additional information about the address.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// The number of consecutive health check failures.
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The health check interval. Unit: seconds.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// The city nodes to monitor.
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<AddDnsGtmAddressPoolRequestIspCityNode> IspCityNode { get; set; }
        public class AddDnsGtmAddressPoolRequestIspCityNode : TeaModel {
            /// <summary>
            /// The code of the city node to monitor.
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// The code of the Internet service provider (ISP) node to monitor.
            /// </summary>
            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

        }

        /// <summary>
        /// The language of the values of specific response parameters. Default value: en. Valid values: en, zh, and ja.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

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
        /// The extended information. The required parameters vary based on the health check protocol.
        /// 
        /// *   HTTP or HTTPS:
        /// 
        ///     *   port: the check port.
        /// 
        ///     *   host: the host settings.
        /// 
        ///     *   path: the URL path.
        /// 
        ///     *   code: the return code greater than the specified value.
        /// 
        ///     *   failureRate: the failure rate.
        /// 
        ///     *   sni: specifies whether to enable server name indication (SNI). This parameter is available only when Health Check Protocol is set to HTTPS. Valid values:
        /// 
        ///         *   true: enables SNI.
        ///         *   other: disables SNI.
        /// 
        ///     *   nodeType: The type of the node to monitor when the address pool type is DOMAIN. Valid values:
        /// 
        ///         *   IPV4
        ///         *   IPV6
        /// 
        /// *   PING:
        /// 
        ///     *   failureRate: the failure rate.
        /// 
        ///     *   packetNum: the number of ping packets.
        /// 
        ///     *   packetLossRate: the loss rate of ping packets.
        /// 
        ///     *   nodeType: the type of the node to monitor when the address pool type is DOMAIN. Valid values:
        /// 
        ///         *   IPV4
        ///         *   IPV6
        /// 
        /// *   TCP:
        /// 
        ///     *   port: the check port.
        /// 
        ///     *   failureRate: the failure rate.
        /// 
        ///     *   nodeType: the type of the node to monitor when the address pool type is DOMAIN. Valid values:
        /// 
        ///         *   IPV4
        ///         *   IPV6
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        /// <summary>
        /// Specifies whether to enable the health check feature. If you set this parameter to OPEN, the system verifies the health check configurations. If you set this parameter to CLOSE, the system discards the health check configurations. Default value: CLOSE. Valid values:
        /// 
        /// *   OPEN: enables the health check feature.
        /// *   CLOSE: disables the health check feature.
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
        /// The health check protocol. Valid values:
        /// 
        /// *   HTTP
        /// *   HTTPS
        /// *   PING
        /// *   TCP
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// The period of health check timeout. Unit: milliseconds.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// The type of the address pool. Valid values:
        /// 
        /// *   IPV4: IPv4 address.
        /// *   IPV6: IPv6 address.
        /// *   DOMAIN: domain name.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
