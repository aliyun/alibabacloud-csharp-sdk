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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public List<AddDnsGtmAddressPoolRequestAddr> Addr { get; set; }
        public class AddDnsGtmAddressPoolRequestAddr : TeaModel {
            /// <summary>
            /// The address in the address pool.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public string Addr { get; set; }

            /// <summary>
            /// The information about the source region of the address. The value of this parameter is a JSON string. Valid values:
            /// 
            /// *   LineCode: the line code of the source region for the address
            /// 
            /// *   lineCodeRectifyType: the rectification type of the line code. Default value: AUTO. Valid values:
            /// 
            ///     *   NO_NEED: no need for rectification
            ///     *   RECTIFIED: rectified
            ///     *   AUTO: automatic rectification
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("AttributeInfo")]
            [Validation(Required=false)]
            public string AttributeInfo { get; set; }

            /// <summary>
            /// The weight of the address pool.
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

            /// <summary>
            /// The return mode of the addresses: Valid values:
            /// 
            /// *   SMART: smart return
            /// *   ONLINE: always online
            /// *   OFFLINE: always offline
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// The remarks.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// The number of consecutive failures.
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
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
        /// The nodes for monitoring.
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<AddDnsGtmAddressPoolRequestIspCityNode> IspCityNode { get; set; }
        public class AddDnsGtmAddressPoolRequestIspCityNode : TeaModel {
            /// <summary>
            /// The city code.
            /// 
            /// Specify the parameter according to the value of CityCode returned by the DescribeGtmMonitorAvailableConfig operation.
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// *   The Internet service provider (ISP) node. Specify the parameter according to the value of IspCode returned by the DescribeGtmMonitorAvailableConfig operation.
            /// *   If the returned value of GroupType for the DescribeGtmMonitorAvailableConfig operation is BGP or Overseas, IspCode is not required and is set to 465 by default.
            /// *   If the returned value of GroupType for the DescribeGtmMonitorAvailableConfig operation is not BGP or Overseas, IspCode is required. When IspCode is specified, CityCode is required.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// The extended information. The required parameters vary based on the value of ProtocolType.
        /// 
        /// *   When ProtocolType is set to HTTP or HTTPS:
        /// 
        ///     *   port: the port that you want to check
        /// 
        ///     *   host: the host settings
        /// 
        ///     *   path: the URL path
        /// 
        ///     *   code: the return code. The health check result is deemed abnormal if the returned value is greater than the specified value.
        /// 
        ///     *   failureRate: the failure rate
        /// 
        ///     *   sni: specifies whether to enable server name indication (SNI). This parameter is available only when ProtocolType is set to HTTPS. Valid values:
        /// 
        ///         *   true: enables SNI.
        ///         *   other: disables SNI.
        /// 
        ///     *   nodeType: the type of the node for monitoring when Type is set to DOMAIN. Valid values:
        /// 
        ///         *   IPV4
        ///         *   IPV6
        /// 
        /// *   When ProtocolType is set to PING:
        /// 
        ///     *   failureRate: the failure rate
        /// 
        ///     *   packetNum: the number of ping packets
        /// 
        ///     *   packetLossRate: the loss rate of ping packets
        /// 
        ///     *   nodeType: the type of the node for monitoring when Type is set to DOMAIN. Valid values:
        /// 
        ///         *   IPV4
        ///         *   IPV6
        /// 
        /// *   When ProtocolType is set to TCP:
        /// 
        ///     *   port: the port that you want to check
        /// 
        ///     *   failureRate: the failure rate
        /// 
        ///     *   nodeType: the type of the node for monitoring when Type is set to DOMAIN. Valid values:
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
        /// 
        /// This parameter is required.
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
        /// The timeout period. Unit: milliseconds.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
