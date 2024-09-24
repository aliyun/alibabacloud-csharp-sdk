// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DeleteVpcFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access control policy. </para>
        /// <para>To delete an access control policy, you must provide the ID of the policy. You can call the <b>DescribeVpcFirewallControlPolicy</b> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00281255-d220-4db1-8f4f-c4df2214****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The natural language of the request and response. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the group to which the access control policy belongs. You can call the <b>DescribeVpcFirewallAclGroupList</b> operation to query the ID.  </para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the VPC firewall is used to protect a CEN instance, the value of this parameter is the ID of the CEN instance.</description></item>
        /// </list>
        /// <para>Example: cen-ervw0g12b5jbw****</para>
        /// <list type="bullet">
        /// <item><description>If the VPC firewall is used to protect an Express Connect circuit, the value of this parameter is the ID of the VPC firewall.</description></item>
        /// </list>
        /// <para>Example: vfw-a42bbb7b887148c9****</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-a42bbb7b887148c91****</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
