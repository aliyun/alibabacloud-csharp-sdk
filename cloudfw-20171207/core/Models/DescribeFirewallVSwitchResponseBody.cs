// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeFirewallVSwitchResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>A1562A68-99FA-5D6B-BD5B-2F959F25****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VswitchList")]
        [Validation(Required=false)]
        public List<DescribeFirewallVSwitchResponseBodyVswitchList> VswitchList { get; set; }
        public class DescribeFirewallVSwitchResponseBodyVswitchList : TeaModel {
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
            /// <para>10</para>
            /// </summary>
            [NameInMap("FirewallCount")]
            [Validation(Required=false)]
            public string FirewallCount { get; set; }

            [NameInMap("FirewallList")]
            [Validation(Required=false)]
            public List<DescribeFirewallVSwitchResponseBodyVswitchListFirewallList> FirewallList { get; set; }
            public class DescribeFirewallVSwitchResponseBodyVswitchListFirewallList : TeaModel {
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

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>184480249330****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-2zeez7gymz5r4pi****am</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

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
