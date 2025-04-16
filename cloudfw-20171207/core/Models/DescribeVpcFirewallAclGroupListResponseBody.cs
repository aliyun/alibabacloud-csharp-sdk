// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallAclGroupListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the policy groups.</para>
        /// </summary>
        [NameInMap("AclGroupList")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallAclGroupListResponseBodyAclGroupList> AclGroupList { get; set; }
        public class DescribeVpcFirewallAclGroupListResponseBodyAclGroupList : TeaModel {
            [NameInMap("AclConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallAclGroupListResponseBodyAclGroupListAclConfig AclConfig { get; set; }
            public class DescribeVpcFirewallAclGroupListResponseBodyAclGroupListAclConfig : TeaModel {
                [NameInMap("StrictMode")]
                [Validation(Required=false)]
                public int? StrictMode { get; set; }

            }

            /// <summary>
            /// <para>The ID of the policy group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If the VPC firewall is used to protect a Cloud Enterprise Network (CEN) instance, the value of this parameter is the ID of the CEN instance.</para>
            /// <para>Example: cen-ervw0g12b5jbw\<em>\</em>\<em>\</em></para>
            /// </description></item>
            /// <item><description><para>If the VPC firewall is used to protect an Express Connect circuit, the value of this parameter is the instance ID of the VPC firewall.</para>
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
            /// <para>The name of the policy group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If the VPC firewall is used to protect a CEN instance, the value of this parameter is the name of the CEN instance.</description></item>
            /// <item><description>If the VPC firewall is used to protect an Express Connect circuit, the value of this parameter is the instance name of the VPC firewall.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>group_test</para>
            /// </summary>
            [NameInMap("AclGroupName")]
            [Validation(Required=false)]
            public string AclGroupName { get; set; }

            /// <summary>
            /// <para>The number of access control policies in the policy group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("AclRuleCount")]
            [Validation(Required=false)]
            public int? AclRuleCount { get; set; }

            /// <summary>
            /// <para>是否是默认防火墙。取值：</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>：是默认防火墙。</description></item>
            /// <item><description><b>false</b>：不是默认防火墙。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The UID of the member that is managed by your Alibaba Cloud account.</para>
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
        /// <para>The total number of the policy groups that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
