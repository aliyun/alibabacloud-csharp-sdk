// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddGtmMonitorRequest : TeaModel {
        /// <summary>
        /// The ID of the address pool.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        /// <summary>
        /// The number of consecutive failures.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// The health check interval. Unit: seconds. Set the value to 60.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// The nodes for monitoring.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<AddGtmMonitorRequestIspCityNode> IspCityNode { get; set; }
        public class AddGtmMonitorRequestIspCityNode : TeaModel {
            /// <summary>
            /// The city code.
            /// 
            /// Specify the parameter according to the value of CityCode returned by the DescribeGtmMonitorAvailableConfig operation.
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// The Internet service provider (ISP) node. Specify the parameter according to the value of IspCode returned by the DescribeGtmMonitorAvailableConfig operation.
            /// 
            /// *   If the return value of GroupType for the DescribeGtmMonitorAvailableConfig operation is BGP or Overseas, IspCode is not required and is set to 465 by default.
            /// *   If the return value of GroupType for the DescribeGtmMonitorAvailableConfig operation is not BGP or Overseas, IspCode is required. When IspCode is specified, CityCode is required.
            /// </summary>
            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

        }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The extended information. The required parameters vary based on the health check protocol.
        /// 
        /// HTTP or HTTPS
        /// 
        /// *   port: the port that you want to check
        /// *   failureRate: the failure rate
        /// *   code: the return code. The health check result is deemed abnormal if the returned value is greater than the specified value. Valid values: 400 and 500.
        /// *   host: the host settings
        /// *   path: the URL path
        /// 
        /// PING
        /// 
        /// *   packetNum: the number of ping packets
        /// *   packetLossRate: the packet loss rate
        /// *   failureRate: the failure rate
        /// 
        /// TCP
        /// 
        /// *   port: the port that you want to check
        /// *   failureRate: the failure rate
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        /// <summary>
        /// The protocol used for the health check. Valid values:
        /// 
        /// *   HTTP
        /// *   HTTPS
        /// *   PING
        /// *   TCP
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// The health check timeout period. Unit: milliseconds. Valid values: 2000, 3000, 5000, and 10000.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
