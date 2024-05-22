// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateGtmMonitorRequest : TeaModel {
        /// <summary>
        /// The maximum number of consecutive exceptions detected. If the number of consecutive exceptions detected reaches the maximum number, the application service is deemed abnormal.
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// The health check interval. Unit: seconds. Set the value to 60.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// The monitored nodes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<UpdateGtmMonitorRequestIspCityNode> IspCityNode { get; set; }
        public class UpdateGtmMonitorRequestIspCityNode : TeaModel {
            /// <summary>
            /// The code of the city where the monitored node is deployed.
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
        /// The ID of the health check configuration.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        /// <summary>
        /// The protocol used for the health check.
        /// 
        /// This parameter is required.
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

    }

}
