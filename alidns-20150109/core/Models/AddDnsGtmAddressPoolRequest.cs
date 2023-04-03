// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDnsGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// The addresses in the address pool.
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public List<AddDnsGtmAddressPoolRequestAddr> Addr { get; set; }
        public class AddDnsGtmAddressPoolRequestAddr : TeaModel {
            /// <summary>
            /// The address.
            /// </summary>
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public string Addr { get; set; }

            /// <summary>
            /// The source region of the address. The value is a JSON string.
            /// 
            /// *   lineCode: the line code of the source region of the address.
            /// 
            /// *   lineCodeRectifyType: the rectification type of the line code. Default value: AUTO. Valid values:
            /// 
            ///     *   NO_NEED: no need for rectification
            ///     *   RECTIFIED: rectified
            ///     *   AUTO: automatic rectification
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

        }

        /// <summary>
        /// The maximum number of consecutive exceptions detected. If the number of consecutive exceptions detected reaches the maximum number, the application service is deemed abnormal.
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// The ID of the GTM instance for which you want to create an address pool.
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
        /// The monitored nodes.
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<AddDnsGtmAddressPoolRequestIspCityNode> IspCityNode { get; set; }
        public class AddDnsGtmAddressPoolRequestIspCityNode : TeaModel {
            /// <summary>
            /// The code of the city where the monitored node is deployed.
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// The code of the Internet service provider (ISP) to which the monitored node belongs.
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
        /// The load balancing policy for the address pool. Valid values:
        /// 
        /// *   ALL_RR: returns all addresses.
        /// *   RATIO: returns addresses by weight.
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// The extended information, that is, the parameters required for the protocol. Different protocols require different parameters:
        /// 
        /// *   HTTP or HTTPS:
        /// 
        ///     *   port: the port to check.
        /// 
        ///     *   host: the host configuration.
        /// 
        ///     *   path: the health check URL.
        /// 
        ///     *   code: the status code threshold. If the returned status code is greater than the specified threshold, the application service is deemed abnormal.
        /// 
        ///     *   failureRate: the failure rate.
        /// 
        ///     *   sni: specifies whether to enable Server Name Indication (SNI). This parameter is only required for the HTTPS protocol. Valid values:
        /// 
        ///         *   true: enables SNI.
        ///         *   Other value: disables SNI.
        /// 
        ///     *   nodeType: the type of the monitored node when the address pool type is DOMAIN. Valid values:
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
        ///     *   nodeType: the type of the monitored node when the address pool type is DOMAIN. Valid values:
        /// 
        ///         *   IPV4
        ///         *   IPV6
        /// 
        /// *   TCP:
        /// 
        ///     *   port: the port to check.
        /// 
        ///     *   failureRate: the failure rate.
        /// 
        ///     *   nodeType: the type of the monitored node when the address pool type is DOMAIN. Valid values:
        /// 
        ///         *   IPV4
        ///         *   IPV6
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        /// <summary>
        /// Specifies whether to enable the health check. If this parameter is set to OPEN, the system validates the health check configuration. If this parameter is set to CLOSE, the health check configuration is discarded. Default value: CLOSE. Valid values:
        /// 
        /// *   OPEN: enables the health check.
        /// *   CLOSE: disables the health check.
        /// </summary>
        [NameInMap("MonitorStatus")]
        [Validation(Required=false)]
        public string MonitorStatus { get; set; }

        /// <summary>
        /// The name of the address pool that you want to create.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The protocol used for the health check. Valid values:
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
        /// The health check timeout period. Unit: milliseconds.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

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

    }

}
