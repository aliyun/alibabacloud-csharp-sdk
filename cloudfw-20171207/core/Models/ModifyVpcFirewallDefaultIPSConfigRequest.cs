// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallDefaultIPSConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable basic protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes.</description></item>
        /// <item><description><b>0</b>: no.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BasicRules")]
        [Validation(Required=false)]
        public string BasicRules { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable virtual patching. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes.</description></item>
        /// <item><description><b>0</b>: no.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableAllPatch")]
        [Validation(Required=false)]
        public string EnableAllPatch { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
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
        /// <para>The UID of the member that is managed by your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The level of the rule group for the IPS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: loose</description></item>
        /// <item><description><b>2</b>: medium</description></item>
        /// <item><description><b>3</b>: strict</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleClass")]
        [Validation(Required=false)]
        public string RuleClass { get; set; }

        /// <summary>
        /// <para>The mode of the intrusion prevention system (IPS). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: block mode.</description></item>
        /// <item><description><b>0</b>: monitor mode.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

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
        /// <para>The instance ID of the VPC firewall.</para>
        /// <list type="bullet">
        /// <item><description>If the VPC firewall protects traffic between a VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance, the value of this parameter is the ID of the CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. You can call the <a href="https://help.aliyun.com/document_detail/345777.html">DescribeVpcFirewallCenList</a> operation to query the IDs of CEN instances.</description></item>
        /// <item><description>If the VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit, the value of this parameter is the instance ID of the VPC firewall. You can call the <a href="https://help.aliyun.com/document_detail/342932.html">DescribeVpcFirewallList</a> operation to query the instance IDs of VPC firewalls.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-m5e7dbc4y****</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
