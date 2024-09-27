// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmMonitorNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>Public IPv4 monitoring node list.</para>
        /// </summary>
        [NameInMap("Ipv4IspCityNodes")]
        [Validation(Required=false)]
        public ListCloudGtmMonitorNodesResponseBodyIpv4IspCityNodes Ipv4IspCityNodes { get; set; }
        public class ListCloudGtmMonitorNodesResponseBodyIpv4IspCityNodes : TeaModel {
            [NameInMap("Ipv4IspCityNode")]
            [Validation(Required=false)]
            public List<ListCloudGtmMonitorNodesResponseBodyIpv4IspCityNodesIpv4IspCityNode> Ipv4IspCityNode { get; set; }
            public class ListCloudGtmMonitorNodesResponseBodyIpv4IspCityNodesIpv4IspCityNode : TeaModel {
                /// <summary>
                /// <para>City code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>503</para>
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>City name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beijing</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>Country code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>629</para>
                /// </summary>
                [NameInMap("CountryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// <para>Country name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China</para>
                /// </summary>
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                /// <summary>
                /// <para>Monitor node default selection:</para>
                /// <list type="bullet">
                /// <item><description>true: Selected by default</description></item>
                /// <item><description>false: Not selected by default</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                /// <summary>
                /// <para>Monitor probe group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BGP Nodes</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>Monitoring node group type, currently supported:</para>
                /// <list type="bullet">
                /// <item><description>BGP: BGP node</description></item>
                /// <item><description>OVERSEAS: International node</description></item>
                /// <item><description>ISP: Carrier node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BGP</para>
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                /// <summary>
                /// <para>List of node IP addresses.</para>
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public ListCloudGtmMonitorNodesResponseBodyIpv4IspCityNodesIpv4IspCityNodeIps Ips { get; set; }
                public class ListCloudGtmMonitorNodesResponseBodyIpv4IspCityNodesIpv4IspCityNodeIps : TeaModel {
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                /// <summary>
                /// <para>Operator code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>465</para>
                /// </summary>
                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                /// <summary>
                /// <para>Operator name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

                /// <summary>
                /// <para>Unique identifier ID of the probe node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node-ewze1bysndy4gf**j8</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

            }

        }

        /// <summary>
        /// <para>List of public IPv6 monitoring nodes.</para>
        /// </summary>
        [NameInMap("Ipv6IspCityNodes")]
        [Validation(Required=false)]
        public ListCloudGtmMonitorNodesResponseBodyIpv6IspCityNodes Ipv6IspCityNodes { get; set; }
        public class ListCloudGtmMonitorNodesResponseBodyIpv6IspCityNodes : TeaModel {
            [NameInMap("Ipv6IspCityNode")]
            [Validation(Required=false)]
            public List<ListCloudGtmMonitorNodesResponseBodyIpv6IspCityNodesIpv6IspCityNode> Ipv6IspCityNode { get; set; }
            public class ListCloudGtmMonitorNodesResponseBodyIpv6IspCityNodesIpv6IspCityNode : TeaModel {
                /// <summary>
                /// <para>City code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>357</para>
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>City name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Shanghai</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>Country code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>629</para>
                /// </summary>
                [NameInMap("CountryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// <para>Country name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China</para>
                /// </summary>
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                /// <summary>
                /// <para>Monitor node default selection:</para>
                /// <list type="bullet">
                /// <item><description>true: Selected by default</description></item>
                /// <item><description>false: Not selected by default</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                /// <summary>
                /// <para>Monitoring probe group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BGP</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>Monitoring node group type, currently supported:</para>
                /// <list type="bullet">
                /// <item><description>BGP: BGP node</description></item>
                /// <item><description>OVERSEAS: International node</description></item>
                /// <item><description>ISP: Carrier node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BGP</para>
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                /// <summary>
                /// <para>List of node IP addresses.</para>
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public ListCloudGtmMonitorNodesResponseBodyIpv6IspCityNodesIpv6IspCityNodeIps Ips { get; set; }
                public class ListCloudGtmMonitorNodesResponseBodyIpv6IspCityNodesIpv6IspCityNodeIps : TeaModel {
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                /// <summary>
                /// <para>Operator code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>465</para>
                /// </summary>
                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                /// <summary>
                /// <para>Operator name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

                /// <summary>
                /// <para>Unique identifier ID of the probe node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node-ewze1bysndy4gf**j8</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

            }

        }

        /// <summary>
        /// <para>Unique request identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
