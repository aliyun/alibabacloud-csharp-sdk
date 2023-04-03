// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmMonitorConfigResponseBody : TeaModel {
        /// <summary>
        /// The time when the health check task was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The timestamp that indicates when the health check task was created.
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// The number of consecutive times of failed health check attempts.
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// The interval at which the health check task is executed. Unit: seconds.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// The monitored node.
        /// </summary>
        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorConfigResponseBodyIspCityNodes IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorConfigResponseBodyIspCityNodes : TeaModel {
            [NameInMap("IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorConfigResponseBodyIspCityNodesIspCityNode> IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorConfigResponseBodyIspCityNodesIspCityNode : TeaModel {
                /// <summary>
                /// The code of the monitored city node.
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// The display name of the monitored city node.
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// The code of the country or region.
                /// </summary>
                [NameInMap("CountryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// The display name of the country or region.
                /// </summary>
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                /// <summary>
                /// The code of the monitored Internet service provider (ISP) node.
                /// </summary>
                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                /// <summary>
                /// The name of the ISP.
                /// </summary>
                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the health check task.
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        /// <summary>
        /// The extended information. The following parameters are required for different health check protocols:
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
        ///     *   sni: specifies whether to enable server name indication (SNI). This parameter is used only for the HTTPS protocol. Valid values:
        /// 
        ///         *   true: enable SNI.
        ///         *   false: disable SNI.
        /// 
        ///     *   nodeType: the type of the node to monitor when the address pool type is DOMAIN. Valid values:
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The timeout period. Unit: milliseconds.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// The time when the information about the health check task was updated.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// The timestamp that indicates when the information about the health check task was updated.
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
