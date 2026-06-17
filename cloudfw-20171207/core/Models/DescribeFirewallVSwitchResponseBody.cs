// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeFirewallVSwitchResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1562A68-99FA-5D6B-BD5B-2F959F25****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of vSwitches.</para>
        /// </summary>
        [NameInMap("VswitchList")]
        [Validation(Required=false)]
        public List<DescribeFirewallVSwitchResponseBodyVswitchList> VswitchList { get; set; }
        public class DescribeFirewallVSwitchResponseBodyVswitchList : TeaModel {
            /// <summary>
            /// <para>The number of available IP addresses.</para>
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
            /// <para>The number of intrusion prevention events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("FirewallCount")]
            [Validation(Required=false)]
            public string FirewallCount { get; set; }

            /// <summary>
            /// <para>The list of firewalls.</para>
            /// </summary>
            [NameInMap("FirewallList")]
            [Validation(Required=false)]
            public List<DescribeFirewallVSwitchResponseBodyVswitchListFirewallList> FirewallList { get; set; }
            public class DescribeFirewallVSwitchResponseBodyVswitchListFirewallList : TeaModel {
                /// <summary>
                /// <para>The instance ID of the firewall.</para>
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

            }

            /// <summary>
            /// <para>The UID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>184480249330****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The ID of the VPC instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zeez7gymz5r4pi****am</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

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
            /// <para>The zone ID.</para>
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
