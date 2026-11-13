// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallAclGroupListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the access control policy groups of the VPC firewall.</para>
        /// </summary>
        [NameInMap("AclGroupList")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallAclGroupListResponseBodyAclGroupList> AclGroupList { get; set; }
        public class DescribeVpcFirewallAclGroupListResponseBodyAclGroupList : TeaModel {
            /// <summary>
            /// <para>The mode of the access control engine.</para>
            /// </summary>
            [NameInMap("AclConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallAclGroupListResponseBodyAclGroupListAclConfig AclConfig { get; set; }
            public class DescribeVpcFirewallAclGroupListResponseBodyAclGroupListAclConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether strict mode is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Strict mode is enabled.</description></item>
                /// <item><description>0: Strict mode is disabled.</description></item>
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
            /// <para>The access control policy group ID of the virtual private cloud (VPC) firewalls at the border. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If the virtual private cloud (VPC) firewalls at the border protect a Cloud Enterprise Network (CEN) instance, the policy group ID is the instance ID of the CEN instance.</para>
            /// <para>Example: cen-ervw0g12b5jbw*\<em>\</em>\*</para>
            /// </description></item>
            /// <item><description><para>If the virtual private cloud (VPC) firewalls at the border protect an Express Connect circuit, the policy group ID is the instance ID of the virtual private cloud (VPC) firewalls at the border.</para>
            /// <para>Example: vfw-a42bbb7b887148c9*\<em>\</em>\*</para>
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
            /// <para>The access control policy group name of the virtual private cloud (VPC) firewalls at the border.</para>
            /// <list type="bullet">
            /// <item><description>If the virtual private cloud (VPC) firewalls at the border protect a CEN instance, the policy group name is the name of the CEN instance.</description></item>
            /// <item><description>If the virtual private cloud (VPC) firewalls at the border protect an Express Connect circuit, the policy group name is the name of the virtual private cloud (VPC) firewalls at the border.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>group_test</para>
            /// </summary>
            [NameInMap("AclGroupName")]
            [Validation(Required=false)]
            public string AclGroupName { get; set; }

            /// <summary>
            /// <para>The number of policies in the access control policy group of the virtual private cloud (VPC) firewalls at the border.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("AclRuleCount")]
            [Validation(Required=false)]
            public int? AclRuleCount { get; set; }

            /// <summary>
            /// <para>Specifies whether the firewall is the default firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The firewall is the default firewall.</description></item>
            /// <item><description><b>false</b>: The firewall is not the default firewall.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The ID of the member accounts of the current Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>258039427902****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of access control policy groups of the VPC firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
