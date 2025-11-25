// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeFirewallVswitchResourcesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>A81E99DF-07CF-5EE4-966A-9FF9F2F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VswitchList")]
        [Validation(Required=false)]
        public List<DescribeFirewallVswitchResourcesResponseBodyVswitchList> VswitchList { get; set; }
        public class DescribeFirewallVswitchResourcesResponseBodyVswitchList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AvailableIpCount")]
            [Validation(Required=false)]
            public string AvailableIpCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.0.XX/16</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("FirewallList")]
            [Validation(Required=false)]
            public List<DescribeFirewallVswitchResourcesResponseBodyVswitchListFirewallList> FirewallList { get; set; }
            public class DescribeFirewallVswitchResourcesResponseBodyVswitchListFirewallList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>vfw-tr-37145c8f5ede45e9****</para>
                /// </summary>
                [NameInMap("FirewallId")]
                [Validation(Required=false)]
                public string FirewallId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-Firewall</para>
                /// </summary>
                [NameInMap("FirewallName")]
                [Validation(Required=false)]
                public string FirewallName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NatFirewall</para>
                /// </summary>
                [NameInMap("FirewallType")]
                [Validation(Required=false)]
                public string FirewallType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vtb-uf6ml7rgw5gzzdr****</para>
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("RouteTableType")]
            [Validation(Required=false)]
            public string RouteTableType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>open</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-bp10qla9mgi42eo****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-test</para>
            /// </summary>
            [NameInMap("VswitchName")]
            [Validation(Required=false)]
            public string VswitchName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
