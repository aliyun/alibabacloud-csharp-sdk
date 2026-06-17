// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallAclGroupListResponseBody : TeaModel {
        /// <summary>
        /// <para>The access control policy groups.</para>
        /// </summary>
        [NameInMap("AclGroupList")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallAclGroupListResponseBodyAclGroupList> AclGroupList { get; set; }
        public class DescribeVpcFirewallAclGroupListResponseBodyAclGroupList : TeaModel {
            /// <summary>
            /// <para>The ACL engine mode.</para>
            /// </summary>
            [NameInMap("AclConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallAclGroupListResponseBodyAclGroupListAclConfig AclConfig { get; set; }
            public class DescribeVpcFirewallAclGroupListResponseBodyAclGroupListAclConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether strict mode is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>1: Strict mode is enabled.</para>
                /// </description></item>
                /// <item><description><para>0: Strict mode is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StrictMode")]
                [Validation(Required=false)]
                public int? StrictMode { get; set; }

            }

            /// <summary>
            /// <para>The ID of the access control policy group for the VPC boundary firewall.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If the VPC boundary firewall protects a Cloud Enterprise Network (CEN) instance, the policy group ID is the ID of the CEN instance.</para>
            /// <para>Example: cen-ervw0g12b5jbw\<em>\</em>\<em>\</em></para>
            /// </description></item>
            /// <item><description><para>If the VPC boundary firewall protects an Express Connect circuit, the policy group ID is the ID of the VPC boundary firewall instance.</para>
            /// <para>Example: vfw-a42bbb7b887148c9\<em>\</em>\<em>\</em></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vfw-a42bbb7b887148c9****</para>
            /// </summary>
            [NameInMap("AclGroupId")]
            [Validation(Required=false)]
            public string AclGroupId { get; set; }

            /// <summary>
            /// <para>The name of the access control policy group for the VPC boundary firewall.</para>
            /// <list type="bullet">
            /// <item><description><para>If the VPC boundary firewall protects a Cloud Enterprise Network instance, the group name is the name of the CEN instance.</para>
            /// </description></item>
            /// <item><description><para>If the VPC boundary firewall protects an Express Connect circuit, the group name is the name of the VPC boundary firewall instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>group_test</para>
            /// </summary>
            [NameInMap("AclGroupName")]
            [Validation(Required=false)]
            public string AclGroupName { get; set; }

            /// <summary>
            /// <para>The number of policies in the access control policy group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("AclRuleCount")]
            [Validation(Required=false)]
            public int? AclRuleCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the policy group is a default group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The policy group is a default group.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The policy group is not a default group.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The ID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>258039427902****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of access control policy groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
