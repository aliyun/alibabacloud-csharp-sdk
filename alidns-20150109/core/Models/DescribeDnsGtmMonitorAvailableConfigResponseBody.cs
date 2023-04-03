// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmMonitorAvailableConfigResponseBody : TeaModel {
        /// <summary>
        /// The monitored nodes that can be used to perform health checks on address pools that contain public domain names that are resolved to IPv4 addresses.
        /// </summary>
        [NameInMap("DomainIpv4IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodes DomainIpv4IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodes : TeaModel {
            [NameInMap("DomainIpv4IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodesDomainIpv4IspCityNode> DomainIpv4IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodesDomainIpv4IspCityNode : TeaModel {
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
                /// Indicates whether the monitored node is selected for the health check by default.
                /// </summary>
                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                /// <summary>
                /// The name of the group to which the monitored node belongs.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The type of the group to which the monitored node belongs. Valid values:
                /// 
                /// *   BGP: BGP nodes
                /// *   OVERSEAS: nodes outside the Chinese mainland
                /// *   ISP: ISP nodes
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("Ips")]
                [Validation(Required=false)]
                public DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodesDomainIpv4IspCityNodeIps Ips { get; set; }
                public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodesDomainIpv4IspCityNodeIps : TeaModel {
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                /// <summary>
                /// The code of the ISP to which the monitored node belongs.
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
        /// The monitored nodes that can be used to perform health checks on address pools that contain public domain names that are resolved to IPv6 addresses.
        /// </summary>
        [NameInMap("DomainIpv6IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodes DomainIpv6IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodes : TeaModel {
            [NameInMap("DomainIpv6IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodesDomainIpv6IspCityNode> DomainIpv6IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodesDomainIpv6IspCityNode : TeaModel {
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
                /// Indicates whether the monitored node is selected for the health check by default.
                /// </summary>
                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                /// <summary>
                /// The name of the group to which the monitored node belongs.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The type of the group to which the monitored node belongs. Valid values:
                /// 
                /// *   BGP: BGP nodes
                /// *   OVERSEAS: nodes outside the Chinese mainland
                /// *   ISP: ISP nodes
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("Ips")]
                [Validation(Required=false)]
                public DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodesDomainIpv6IspCityNodeIps Ips { get; set; }
                public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodesDomainIpv6IspCityNodeIps : TeaModel {
                    [NameInMap("ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                /// <summary>
                /// The code of the ISP to which the monitored node belongs.
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
        /// The monitored nodes that can be used to perform health checks on address pools that contain public IPv4 addresses.
        /// </summary>
        [NameInMap("Ipv4IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodes Ipv4IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodes : TeaModel {
            [NameInMap("Ipv4IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodesIpv4IspCityNode> Ipv4IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodesIpv4IspCityNode : TeaModel {
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
                /// Indicates whether the monitored node is selected for the health check by default.
                /// </summary>
                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                /// <summary>
                /// The name of the group to which the monitored node belongs.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The type of the group to which the monitored node belongs. Valid values:
                /// 
                /// *   BGP: Border Gateway Protocol (BGP) nodes
                /// *   OVERSEAS: nodes outside the Chinese mainland
                /// *   ISP: ISP nodes
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("Ips")]
                [Validation(Required=false)]
                public DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodesIpv4IspCityNodeIps Ips { get; set; }
                public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodesIpv4IspCityNodeIps : TeaModel {
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

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
        /// The monitored nodes that can be used to perform health checks on address pools that contain public IPv6 addresses.
        /// </summary>
        [NameInMap("Ipv6IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodes Ipv6IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodes : TeaModel {
            [NameInMap("Ipv6IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodesIpv6IspCityNode> Ipv6IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodesIpv6IspCityNode : TeaModel {
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
                /// Indicates whether the monitored node is selected for the health check by default.
                /// </summary>
                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                /// <summary>
                /// The name of the group to which the monitored node belongs.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The type of the group to which the monitored node belongs. Valid values:
                /// 
                /// *   BGP: BGP nodes
                /// *   OVERSEAS: nodes outside the Chinese mainland
                /// *   ISP: ISP nodes
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("Ips")]
                [Validation(Required=false)]
                public DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodesIpv6IspCityNodeIps Ips { get; set; }
                public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodesIpv6IspCityNodeIps : TeaModel {
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                /// <summary>
                /// The code of the ISP to which the monitored node belongs.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
