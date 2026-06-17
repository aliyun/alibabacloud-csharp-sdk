// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeFirewallVswitchResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A81E99DF-07CF-5EE4-966A-9FF9F2F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of vSwitches.</para>
        /// </summary>
        [NameInMap("VswitchList")]
        [Validation(Required=false)]
        public List<DescribeFirewallVswitchResourcesResponseBodyVswitchList> VswitchList { get; set; }
        public class DescribeFirewallVswitchResourcesResponseBodyVswitchList : TeaModel {
            /// <summary>
            /// <para>The number of available IP addresses in the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AvailableIpCount")]
            [Validation(Required=false)]
            public string AvailableIpCount { get; set; }

            /// <summary>
            /// <para>The IPv4 CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.XX/16</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>The details of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The list of firewalls.</para>
            /// </summary>
            [NameInMap("FirewallList")]
            [Validation(Required=false)]
            public List<DescribeFirewallVswitchResourcesResponseBodyVswitchListFirewallList> FirewallList { get; set; }
            public class DescribeFirewallVswitchResourcesResponseBodyVswitchListFirewallList : TeaModel {
                /// <summary>
                /// <para>The ID of the firewall instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vfw-tr-37145c8f5ede45e9****</para>
                /// </summary>
                [NameInMap("FirewallId")]
                [Validation(Required=false)]
                public string FirewallId { get; set; }

                /// <summary>
                /// <para>The name of the Cloud Firewall.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-Firewall</para>
                /// </summary>
                [NameInMap("FirewallName")]
                [Validation(Required=false)]
                public string FirewallName { get; set; }

                /// <summary>
                /// <para>The type of the Cloud Firewall.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NatFirewall</para>
                /// </summary>
                [NameInMap("FirewallType")]
                [Validation(Required=false)]
                public string FirewallType { get; set; }

            }

            /// <summary>
            /// <para>The ID of the route table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-uf6ml7rgw5gzzdr****</para>
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

            /// <summary>
            /// <para>The type of the route table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Custom</b>: a custom route table.</para>
            /// </description></item>
            /// <item><description><para><b>System</b>: a system route table.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("RouteTableType")]
            [Validation(Required=false)]
            public string RouteTableType { get; set; }

            /// <summary>
            /// <para>The configuration status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>open</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp10qla9mgi42eo****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <para>The name of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-test</para>
            /// </summary>
            [NameInMap("VswitchName")]
            [Validation(Required=false)]
            public string VswitchName { get; set; }

            /// <summary>
            /// <para>The ID of the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
