// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallPolicyPriorUsedRequest : TeaModel {
        /// <summary>
        /// <para>The language of the content within the request and response.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default)</description></item>
        /// <item><description><b>en</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the access control policy group. You can call the <a href="https://help.aliyun.com/document_detail/159760.html">DescribeVpcFirewallAclGroupList</a> operation to query the ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If the VPC firewall is used to protect a Cloud Enterprise Network (CEN) instance, the value of this parameter is the ID of the CEN instance.</para>
        /// <para>Example: cen-ervw0g12b5jbw\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>If the VPC firewall is used to protect an Express Connect circuit, the value of this parameter is the ID of the VPC firewall.</para>
        /// <para>Example: vfw-a42bbb7b887148c9\<em>\</em>\<em>\</em>.</para>
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
