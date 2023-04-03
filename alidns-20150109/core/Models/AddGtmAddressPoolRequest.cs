// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// The addresses in the address pool.
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public List<AddGtmAddressPoolRequestAddr> Addr { get; set; }
        public class AddGtmAddressPoolRequestAddr : TeaModel {
            /// <summary>
            /// The weight of the address.
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

            /// <summary>
            /// The mode of the address. Valid values:
            /// 
            /// *   **SMART**: smart return
            /// *   **ONLINE**: always online
            /// *   **OFFLINE**: always offline
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// The address.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

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
        /// </summary>
        [NameInMap("MinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? MinAvailableAddrNum { get; set; }

        /// <summary>
        /// The extended information, that is, the parameters required for the protocol. Different protocols require different parameters:
        /// 
        /// HTTP or HTTPS:
        /// 
        /// *   port: the port to check.
        /// *   failureRate: the failure rate.
        /// *   code: the status code threshold. If the returned status code is greater than the specified threshold, the application service is deemed abnormal. Valid values: 400 and 500.
        /// *   host: the host configuration.
        /// *   path: the health check URL.
        /// 
        /// PING:
        /// 
        /// *   packetNum: the number of ping packets.
        /// *   packetLossRate: the loss rate of ping packets.
        /// *   failureRate: the failure rate.
        /// 
        /// TCP:
        /// 
        /// *   port: the port to check.
        /// *   failureRate: the failure rate.
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
        /// The health check timeout period. Unit: milliseconds. Valid values: 2000, 3000, 5000, and 10000.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// The type of the address pool. Valid values:
        /// 
        /// *   **IP**: IPv4 address
        /// *   **DOMAIN**: domain name
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
