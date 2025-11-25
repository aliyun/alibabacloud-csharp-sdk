// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrafficLogRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-000000000000</para>
        /// </summary>
        [NameInMap("AclPreRuleId")]
        [Validation(Required=false)]
        public string AclPreRuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("AclPreState")]
        [Validation(Required=false)]
        public string AclPreState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("AppDpiState")]
        [Validation(Required=false)]
        public string AppDpiState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AssetRegion")]
        [Validation(Required=false)]
        public string AssetRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public string AttackType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>out</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainUrl")]
        [Validation(Required=false)]
        public string DomainUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>182.92.206.XXX</para>
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9876</para>
        /// </summary>
        [NameInMap("DstPort")]
        [Validation(Required=false)]
        public string DstPort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-wz95m1aq9b0h****vk1yb</para>
        /// </summary>
        [NameInMap("DstVpcId")]
        [Validation(Required=false)]
        public string DstVpcId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("DstVpcRegionNo")]
        [Validation(Required=false)]
        public string DstVpcRegionNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1742926322</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VpcFirewall</para>
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public string FirewallType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("FlowType")]
        [Validation(Required=false)]
        public string FlowType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>icmp</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>128599825273****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vfw-tr-7a9c8901ed394****</para>
        /// </summary>
        [NameInMap("NatFirewallId")]
        [Validation(Required=false)]
        public string NatFirewallId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ngw-2zew6yn017hhzbm****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8b115ae3-da64-4b80-81c1-1cd2dd42****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RuleResult")]
        [Validation(Required=false)]
        public string RuleResult { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleSource")]
        [Validation(Required=false)]
        public string RuleSource { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yundun</para>
        /// </summary>
        [NameInMap("SourceCode")]
        [Validation(Required=false)]
        public string SourceCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>139.217.234.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.68.60.XXX</para>
        /// </summary>
        [NameInMap("SrcIP")]
        [Validation(Required=false)]
        public string SrcIP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8082</para>
        /// </summary>
        [NameInMap("SrcPort")]
        [Validation(Required=false)]
        public string SrcPort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.100.134.XX</para>
        /// </summary>
        [NameInMap("SrcPrivateIP")]
        [Validation(Required=false)]
        public string SrcPrivateIP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-wz9309pkwe06lv****tk4</para>
        /// </summary>
        [NameInMap("SrcVpcId")]
        [Validation(Required=false)]
        public string SrcVpcId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("SrcVpcRegionNo")]
        [Validation(Required=false)]
        public string SrcVpcRegionNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1730946241</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tis-98fd64c5****</para>
        /// </summary>
        [NameInMap("TlsScopeId")]
        [Validation(Required=false)]
        public string TlsScopeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vfw-a42bbb7b887148c9****</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VulLevel")]
        [Validation(Required=false)]
        public string VulLevel { get; set; }

    }

}
