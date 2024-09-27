// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmMonitorAvailableConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The nodes that perform health checks on domain names that use public IPv4 addresses.</para>
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
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>503</para>
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The display name of the city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhangjiakou</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>Indicates whether the health check node is selected by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                /// <summary>
                /// <para>The name of the node group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BGP Nodes</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The type of the node group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BGP: BGP node</description></item>
                /// <item><description>OVERSEAS: node outside the Chinese mainland</description></item>
                /// <item><description>ISP: ISP node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BGP</para>
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                /// <summary>
                /// <para>The IP addresses of the health check nodes.</para>
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodesDomainIpv4IspCityNodeIps Ips { get; set; }
                public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodesDomainIpv4IspCityNodeIps : TeaModel {
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                /// <summary>
                /// <para>The ISP code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>465</para>
                /// </summary>
                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                /// <summary>
                /// <para>The display name of the ISP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

            }

        }

        /// <summary>
        /// <para>The nodes that perform health checks on domain names that use public IPv6 addresses.</para>
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
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>503</para>
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The display name of the city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhangjiakou</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>Indicates whether the health check node is selected by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                /// <summary>
                /// <para>The name of the node group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BGP Nodes</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The type of the node group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BGP: BGP node</description></item>
                /// <item><description>OVERSEAS: node outside the Chinese mainland</description></item>
                /// <item><description>ISP: ISP node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BGP</para>
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                /// <summary>
                /// <para>This parameter is not returned.</para>
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodesDomainIpv6IspCityNodeIps Ips { get; set; }
                public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodesDomainIpv6IspCityNodeIps : TeaModel {
                    [NameInMap("ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                /// <summary>
                /// <para>The ISP code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>465</para>
                /// </summary>
                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                /// <summary>
                /// <para>The display name of the ISP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

            }

        }

        /// <summary>
        /// <para>The nodes that perform health checks on public IPv4 addresses.</para>
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
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>503</para>
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The display name of the city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhangjiakou</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>Indicates whether the health check node is selected by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                /// <summary>
                /// <para>The name of the node group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BGP Nodes</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The type of the node group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BGP: Border Gateway Protocol (BGP) node</description></item>
                /// <item><description>OVERSEAS: node outside the Chinese mainland</description></item>
                /// <item><description>ISP: ISP node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BGP</para>
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                /// <summary>
                /// <para>The IP addresses of the health check nodes.</para>
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodesIpv4IspCityNodeIps Ips { get; set; }
                public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodesIpv4IspCityNodeIps : TeaModel {
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                /// <summary>
                /// <para>The Internet service provider (ISP) code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>465</para>
                /// </summary>
                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                /// <summary>
                /// <para>The display name of the ISP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

            }

        }

        /// <summary>
        /// <para>The nodes that perform health checks on public IPv6 addresses.</para>
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
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>503</para>
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The display name of the city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhangjiakou</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>Indicates whether the health check node is selected by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                /// <summary>
                /// <para>The name of the node group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BGP Nodes</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The type of the node group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BGP: BGP node</description></item>
                /// <item><description>OVERSEAS: node outside the Chinese mainland</description></item>
                /// <item><description>ISP: ISP node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BGP</para>
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                /// <summary>
                /// <para>This parameter is not returned.</para>
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodesIpv6IspCityNodeIps Ips { get; set; }
                public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodesIpv6IspCityNodeIps : TeaModel {
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                /// <summary>
                /// <para>The ISP code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>465</para>
                /// </summary>
                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                /// <summary>
                /// <para>The display name of the ISP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
