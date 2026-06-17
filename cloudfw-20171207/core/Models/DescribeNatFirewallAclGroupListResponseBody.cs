// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallAclGroupListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of NAT firewalls.</para>
        /// </summary>
        [NameInMap("NatFirewalls")]
        [Validation(Required=false)]
        public List<DescribeNatFirewallAclGroupListResponseBodyNatFirewalls> NatFirewalls { get; set; }
        public class DescribeNatFirewallAclGroupListResponseBodyNatFirewalls : TeaModel {
            /// <summary>
            /// <para>The number of policies in the access control policy group of the NAT firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("AclRuleCount")]
            [Validation(Required=false)]
            public int? AclRuleCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the NAT firewall is the default one.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The ID of the NAT Gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-2zed6z6qkd7ogc****</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <para>The name of the NAT Gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-test</para>
            /// </summary>
            [NameInMap("NatGatewayName")]
            [Validation(Required=false)]
            public string NatGatewayName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F06DE24D-6EB9-5F55-B588-7BB946DF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
