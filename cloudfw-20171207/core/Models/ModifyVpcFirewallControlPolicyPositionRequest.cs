// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallControlPolicyPositionRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the access control policy.</para>
        /// <para>To modify an access control policy, provide the unique ID of the policy. Call the <a href="https://help.aliyun.com/document_detail/159758.html">DescribeVpcFirewallControlPolicy</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2746d9ff-5d7c-449d-a2a9-ccaa15fe****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The language of the request and response.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (Default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
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
        /// <para>For more information about the valid range of priorities, see <a href="https://help.aliyun.com/document_detail/474145.html">DescribePolicyPriorities</a>.</para>
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
        /// <para>This parameter is deprecated. Use the AclUuid parameter to specify the policy to modify.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("OldOrder")]
        [Validation(Required=false)]
        public string OldOrder { get; set; }

        /// <summary>
        /// <para>The ID of the policy group for the VPC firewall. You can call the <a href="https://help.aliyun.com/document_detail/159760.html">DescribeVpcFirewallAclGroupList</a> operation to obtain the ID.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the VPC firewall protects a Cloud Enterprise Network (CEN) instance, the ID of the policy group is the ID of the CEN instance.</para>
        /// <para>Example: cen-ervw0g12b5jbw\<em>\</em>\<em>\</em></para>
        /// </description></item>
        /// <item><description><para>If the VPC firewall protects an Express Connect circuit, the ID of the policy group is the ID of the VPC firewall instance.</para>
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
