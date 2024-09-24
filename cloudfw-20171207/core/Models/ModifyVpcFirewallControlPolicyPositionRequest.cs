// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallControlPolicyPositionRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the access control policy.</para>
        /// <para>If you want to modify the configurations of an access control policy, you must provide the UUID of the policy. You can call the <a href="https://help.aliyun.com/document_detail/159758.html">DescribeVpcFirewallControlPolicy</a> operation to query the UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2746d9ff-5d7c-449d-a2a9-ccaa15fe****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and the response.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
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
        /// <para>The new priority of the access control policy.</para>
        /// <remarks>
        /// <para> For more information about the valid values of the new priority, see <a href="https://help.aliyun.com/document_detail/474145.html">DescribeVpcFirewallPolicyPriorUsed</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NewOrder")]
        [Validation(Required=false)]
        public string NewOrder { get; set; }

        /// <summary>
        /// <para>The original priority of the access control policy.</para>
        /// <remarks>
        /// <para>This parameter is not recommended. We recommend that you use the AclUuid parameter to specify the policy that you want to modify.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("OldOrder")]
        [Validation(Required=false)]
        public string OldOrder { get; set; }

        /// <summary>
        /// <para>The ID of the group to which the access control policy belongs. You can call the <a href="https://help.aliyun.com/document_detail/159760.html">DescribeVpcFirewallAclGroupList</a> operation to query the ID.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the VPC firewall is used to protect a CEN instance, the value of this parameter must be the ID of the CEN instance.</para>
        /// <para>Example: cen-ervw0g12b5jbw\<em>\</em>\<em>\</em></para>
        /// </description></item>
        /// <item><description><para>If the VPC firewall is used to protect an Express Connect circuit, the value of this parameter must be the instance ID of the VPC firewall.</para>
        /// <para>Example: vfw-a42bbb7b887148c9\<em>\</em>\<em>\</em></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-a42bbb7b887148c9****</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
