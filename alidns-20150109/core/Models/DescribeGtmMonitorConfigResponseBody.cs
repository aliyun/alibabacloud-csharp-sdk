// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmMonitorConfigResponseBody : TeaModel {
        /// <summary>
        /// The time when the health check configuration was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The timestamp that indicates the time when the health check configuration was created.
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// The maximum number of consecutive exceptions detected. If the number of consecutive exceptions detected reaches the maximum number, the application service is deemed abnormal.
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// The health check interval. Unit: seconds. The value is 60.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// The monitored nodes.
        /// </summary>
        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public DescribeGtmMonitorConfigResponseBodyIspCityNodes IspCityNodes { get; set; }
        public class DescribeGtmMonitorConfigResponseBodyIspCityNodes : TeaModel {
            [NameInMap("IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeGtmMonitorConfigResponseBodyIspCityNodesIspCityNode> IspCityNode { get; set; }
            public class DescribeGtmMonitorConfigResponseBodyIspCityNodesIspCityNode : TeaModel {
                /// <summary>
                /// The code of the city where the monitored node is deployed.
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// The display name of the city where the monitored node is deployed.
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// The code of the country where the monitored node is deployed.
                /// </summary>
                [NameInMap("CountryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// The display name of the country where the monitored node is deployed.
                /// </summary>
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                /// <summary>
                /// The code of the Internet service provider (ISP) to which the monitored node belongs.
                /// </summary>
                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                /// <summary>
                /// The display name of the ISP to which the monitored node belongs.
                /// </summary>
                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the health check configuration.
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
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        /// <summary>
        /// The protocol used for the health check.
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
        /// The health check timeout period. Unit: milliseconds. Valid values: 2000, 3000, 5000, and 10000.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// The time when the health check configuration was last updated.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// The timestamp that indicates the time when the health check configuration was last updated.
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
