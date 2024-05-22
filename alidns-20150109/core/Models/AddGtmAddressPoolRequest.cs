// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// The address pools.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public List<AddGtmAddressPoolRequestAddr> Addr { get; set; }
        public class AddGtmAddressPoolRequestAddr : TeaModel {
            /// <summary>
            /// The weight of the address pool.
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

            /// <summary>
            /// The mode of the address pool. Valid values:
            /// 
            /// *   **SMART**: smart return
            /// *   **ONLINE**: always online
            /// *   **OFFLINE**: always offline
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// The address in the address pool.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The number of consecutive failures.
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// The ID of the GTM instance for which you want to create an address pool.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The health check interval. Unit: seconds. Set the value to 60.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// The monitored nodes.
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<AddGtmAddressPoolRequestIspCityNode> IspCityNode { get; set; }
        public class AddGtmAddressPoolRequestIspCityNode : TeaModel {
            /// <summary>
            /// The code of the city where the monitored node is deployed. For more information about specific values, see the response parameters of DescribeGtmMonitorAvailableConfig.
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// *   The code of the Internet service provider (ISP) to which the monitored node belongs. For more information about specific values, see the response parameters of DescribeGtmMonitorAvailableConfig.
            /// *   If the value of the GroupType parameter is BGP or OVERSEAS, IspCode is optional. The default value is 465.
            /// *   If the value of the GroupType parameter is not BGP or OVERSEAS, IspCode is required and is used together with CityCode.
            /// </summary>
            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

        }

        /// <summary>
        /// The language of the values of specific response parameters.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The minimum number of available addresses in the address pool.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? MinAvailableAddrNum { get; set; }

        /// <summary>
        /// The extended information. The required parameters vary based on the value of ProtocolType.
        /// 
        /// When ProtocolType is set to HTTP or HTTPS:
        /// 
        /// *   port: the port that you want to check
        /// *   failureRate: the failure rate
        /// *   code: the return code. The health check result is deemed abnormal if the returned value is greater than the specified value. Valid values: 400 and 500.
        /// *   host: the host settings
        /// *   path: the URL path
        /// 
        /// When ProtocolType is set to PING:
        /// 
        /// *   packetNum: the number of ping packets
        /// *   packetLossRate: the packet loss rate
        /// *   failureRate: the failure rate
        /// 
        /// When ProtocolType is set to TCP:
        /// 
        /// *   port: the port that you want to check
        /// *   failureRate: the failure rate
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        /// <summary>
        /// Specifies whether to enable the health check. Valid values:
        /// 
        /// *   **OPEN**: enables the health check.
        /// *   **CLOSE**: disables the health check. This is the default value.
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
        /// *   Ping
        /// *   TCP
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// The timeout period. Unit: milliseconds. Valid values: 2000, 3000, 5000, and 10000.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// The type of the address pool. Valid values:
        /// 
        /// *   **IP**: IPv4 address
        /// *   **DOMAIN**: domain name
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
