// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DeleteVpcFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The unique identity ID of the access control policy for virtual private cloud (VPC) firewalls at the border.</para>
        /// <para>When you delete an access control policy, you must provide the unique identity ID of the policy. You can invoke the <a href="https://help.aliyun.com/document_detail/159758.html">DescribeVpcFirewallControlPolicy</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00281255-d220-4db1-8f4f-c4df2214****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The language of the request and response.</para>
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
        /// <para>The ID of the access control policy group for virtual private cloud (VPC) firewalls at the border. You can invoke the <a href="https://help.aliyun.com/document_detail/159760.html">DescribeVpcFirewallAclGroupList</a> operation to query the ID.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the virtual private cloud (VPC) firewalls at the border protect a CEN instance, the policy group ID is the instance ID of the CEN instance.</para>
        /// <para> Example: cen-ervw0g12b5jbw****</para>
        /// </description></item>
        /// <item><description><para>If the virtual private cloud (VPC) firewalls at the border protect an Express Connect circuit, the policy group ID is the instance ID of the virtual private cloud (VPC) firewalls at the border.</para>
        /// <para>Example: vfw-a42bbb7b887148c9****</para>
        /// </description></item>
        /// </list>
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
