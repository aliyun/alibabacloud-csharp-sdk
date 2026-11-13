// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class BatchCopyVpcFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The ID of the access control policy group for the source virtual private cloud (VPC) border firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the VPC border firewall protects traffic between network instances (including VPCs, VBRs, and CCNs) in a Cloud Enterprise Network (CEN) instance and a specified VPC, set the value to the ID of the CEN instance.</para>
        /// </description></item>
        /// <item><description><para>If the VPC border firewall protects traffic between two VPCs that are connected by using Express Connect, set the value to the ID of the VPC border firewall instance.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/159760.html">DescribeVpcFirewallAclGroupList</a> operation to query the ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-a42bbb7b887148c9****</para>
        /// </summary>
        [NameInMap("SourceVpcFirewallId")]
        [Validation(Required=false)]
        public string SourceVpcFirewallId { get; set; }

        /// <summary>
        /// <para>The ID of the access control policy group for the destination virtual private cloud (VPC) border firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the VPC border firewall protects traffic between network instances (including VPCs, VBRs, and CCNs) in a CEN instance and a specified VPC, set the value to the ID of the CEN instance.</para>
        /// </description></item>
        /// <item><description><para>If the VPC border firewall protects traffic between two VPCs that are connected by using Express Connect, set the value to the ID of the VPC border firewall instance.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/159760.html">DescribeVpcFirewallAclGroupList</a> operation to query the ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-e37d3a04cf79446a****</para>
        /// </summary>
        [NameInMap("TargetVpcFirewallId")]
        [Validation(Required=false)]
        public string TargetVpcFirewallId { get; set; }

    }

}
