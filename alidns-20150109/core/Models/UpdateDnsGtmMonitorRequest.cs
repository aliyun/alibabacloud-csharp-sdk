// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDnsGtmMonitorRequest : TeaModel {
        /// <summary>
        /// The maximum number of consecutive exceptions detected. If the number of consecutive exceptions detected reaches the maximum number, the application service is deemed abnormal.
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

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
        public List<UpdateDnsGtmMonitorRequestIspCityNode> IspCityNode { get; set; }
        public class UpdateDnsGtmMonitorRequestIspCityNode : TeaModel {
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
        /// The ID of the health check configuration.
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        /// <summary>
        /// The extended information. The required parameters vary based on the health check protocol.
        /// 
        /// *   HTTP or HTTPS
        /// 
        ///     *   port: the port that you want to check
        /// 
        ///     *   host: the host settings
        /// 
        ///     *   path: the URL path
        /// 
        ///     *   code: the return code. If the return value of code is greater than the specified value, the health check result is deemed abnormal. For example, if code is set to 400 and the code 404 is returned, the health check result is deemed abnormal.
        /// 
        ///     *   failureRate: the failure rate
        /// 
        ///     *   sni: specifies whether to enable server name indication (SNI). This parameter is available only when ProtocolType is set to HTTPS. Valid values:
        /// 
        ///         *   true: enables SNI.
        ///         *   false: disables SNI.
        /// 
        ///     *   nodeType: the type of the monitoring node when the address pool type is domain name. Valid values:
        /// 
        ///         *   IPV4
        ///         *   IPV6
        /// 
        /// *   PING
        /// 
        ///     *   failureRate: the failure rate
        /// 
        ///     *   packetNum: the number of ping packets
        /// 
        ///     *   packetLossRate: the loss rate of ping packets
        /// 
        ///     *   nodeType: the type of the monitoring node when the address pool type is domain name. Valid values:
        /// 
        ///         *   IPV4
        ///         *   IPV6
        /// 
        /// *   TCP
        /// 
        ///     *   port: the port that you want to check
        /// 
        ///     *   failureRate: the failure rate
        /// 
        ///     *   nodeType: the type of the monitoring node when the address pool type is domain name. Valid values:
        /// 
        ///         *   IPV4
        ///         *   IPV6
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

    }

}
