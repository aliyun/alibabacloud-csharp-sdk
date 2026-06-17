// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrafficLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeTrafficLogResponseBodyDataList> DataList { get; set; }
        public class DescribeTrafficLogResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The ID of the pre-matched ACL policy. If you leave this parameter empty, all policies are matched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AclPreRuleId")]
            [Validation(Required=false)]
            public string AclPreRuleId { get; set; }

            /// <summary>
            /// <para>The name of the pre-matched ACL policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AclPreRuleName")]
            [Validation(Required=false)]
            public string AclPreRuleName { get; set; }

            /// <summary>
            /// <para>The pre-matching status of the ACL. Valid values:</para>
            /// <para><b>app_unknown</b>: The application is not detected.</para>
            /// <para><b>domain_unknown</b>: The domain name is not detected.</para>
            /// <para><b>normal</b>: Normal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("AclPreState")]
            [Validation(Required=false)]
            public string AclPreState { get; set; }

            /// <summary>
            /// <para>The API status. Valid values:</para>
            /// <para><b>none</b>: Initial state.</para>
            /// <para><b>policy_discard</b>: The connection failed to be established and was blocked by a user-defined ACL or threat intelligence.</para>
            /// <para><b>tcp_not_establish</b>: TCP connection failed.</para>
            /// <para><b>no_payload</b>: The connection is established, but deep packet inspection has analyzed zero payloads.</para>
            /// <para><b>analysing</b>: Detecting.</para>
            /// <para><b>unknown_loose</b>: Loose mode. Detection failed. The system continues to detect.</para>
            /// <para><b>unknown_strict</b>: Strict mode. Detection failed.</para>
            /// <para><b>success</b>: Detection successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("AppDpiState")]
            [Validation(Required=false)]
            public string AppDpiState { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The name of the attacked application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WebLogic</para>
            /// </summary>
            [NameInMap("AttackApp")]
            [Validation(Required=false)]
            public string AttackApp { get; set; }

            /// <summary>
            /// <para>The attack type of the intrusion prevention event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public int? AttackType { get; set; }

            /// <summary>
            /// <para>The city ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FI</para>
            /// </summary>
            [NameInMap("CityId")]
            [Validation(Required=false)]
            public string CityId { get; set; }

            /// <summary>
            /// <para>The reason for closing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp_fin</para>
            /// </summary>
            [NameInMap("CloseReason")]
            [Validation(Required=false)]
            public string CloseReason { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-*</para>
            /// </summary>
            [NameInMap("CloudInstanceId")]
            [Validation(Required=false)]
            public string CloudInstanceId { get; set; }

            /// <summary>
            /// <para>The country ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>US</para>
            /// </summary>
            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

            /// <summary>
            /// <para>The traffic direction. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>in</b>: inbound traffic.</para>
            /// </description></item>
            /// <item><description><para><b>out</b>: outbound traffic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The URL in the flow log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx.com</para>
            /// </summary>
            [NameInMap("DomainUrl")]
            [Validation(Required=false)]
            public string DomainUrl { get; set; }

            /// <summary>
            /// <para>The destination IP address found. This indicates that the intrusion prevention event includes this destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.2.2</para>
            /// </summary>
            [NameInMap("DstIP")]
            [Validation(Required=false)]
            public string DstIP { get; set; }

            /// <summary>
            /// <para>The destination port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public int? DstPort { get; set; }

            /// <summary>
            /// <para>The list of destination VPC information.</para>
            /// </summary>
            [NameInMap("DstVpc")]
            [Validation(Required=false)]
            public DescribeTrafficLogResponseBodyDataListDstVpc DstVpc { get; set; }
            public class DescribeTrafficLogResponseBodyDataListDstVpc : TeaModel {
                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <para>The VPC instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vba1c1em97h0ji71b****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The instance name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yi-vpc</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

            /// <summary>
            /// <para>The end time of the data. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1751423363</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Other extension data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public string Ext { get; set; }

            /// <summary>
            /// <para>The inbound traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>125</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public string InBytes { get; set; }

            /// <summary>
            /// <para>The number of inbound messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("InPackets")]
            [Validation(Required=false)]
            public string InPackets { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The ISP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FOP Dmytro Nedilskyi</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The ISP ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50075069</para>
            /// </summary>
            [NameInMap("IspId")]
            [Validation(Required=false)]
            public string IspId { get; set; }

            /// <summary>
            /// <para>The region of the source or destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The UID of the Cloud Firewall member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14151892****7022</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The outbound traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>230</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public string OutBytes { get; set; }

            /// <summary>
            /// <para>The number of outbound messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("OutPackets")]
            [Validation(Required=false)]
            public string OutPackets { get; set; }

            /// <summary>
            /// <para>The number of bytes in the packet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>355</para>
            /// </summary>
            [NameInMap("PacketBytes")]
            [Validation(Required=false)]
            public long? PacketBytes { get; set; }

            /// <summary>
            /// <para>The number of traffic packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("PacketCount")]
            [Validation(Required=false)]
            public long? PacketCount { get; set; }

            /// <summary>
            /// <para>The private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.21.234.XXX</para>
            /// </summary>
            [NameInMap("PrivateIp")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            /// <summary>
            /// <para>The private port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("PrivatePort")]
            [Validation(Required=false)]
            public int? PrivatePort { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the matched rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00000000-0000-0000-0000-000000000000</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The final result of the traffic. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>pass</b>: The traffic is allowed.</para>
            /// </description></item>
            /// <item><description><para><b>alert</b>: An alert is generated.</para>
            /// </description></item>
            /// <item><description><para><b>drop</b>: The traffic is dropped.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("RuleResult")]
            [Validation(Required=false)]
            public int? RuleResult { get; set; }

            /// <summary>
            /// <para>The source of the detection rule that is matched. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: None.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Basic protection.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Virtual patching.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Access control.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Threat intelligence.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RuleSource")]
            [Validation(Required=false)]
            public string RuleSource { get; set; }

            /// <summary>
            /// <para>The list of rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeTrafficLogResponseBodyDataListRules> Rules { get; set; }
            public class DescribeTrafficLogResponseBodyDataListRules : TeaModel {
                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sharepoint</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The source of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RuleSource")]
                [Validation(Required=false)]
                public string RuleSource { get; set; }

            }

            /// <summary>
            /// <para>The source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("SrcIP")]
            [Validation(Required=false)]
            public string SrcIP { get; set; }

            /// <summary>
            /// <para>The port of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20206</para>
            /// </summary>
            [NameInMap("SrcPort")]
            [Validation(Required=false)]
            public int? SrcPort { get; set; }

            /// <summary>
            /// <para>The private source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.101.7</para>
            /// </summary>
            [NameInMap("SrcPrivateIP")]
            [Validation(Required=false)]
            public string SrcPrivateIP { get; set; }

            /// <summary>
            /// <para>The source VPC information.</para>
            /// </summary>
            [NameInMap("SrcVpc")]
            [Validation(Required=false)]
            public DescribeTrafficLogResponseBodyDataListSrcVpc SrcVpc { get; set; }
            public class DescribeTrafficLogResponseBodyDataListSrcVpc : TeaModel {
                /// <summary>
                /// <para>The region ID of the source VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <para>The instance ID of the source VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vba1c1em97h0ji71****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The instance name of the source VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yi-vpc</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

            /// <summary>
            /// <para>The start time of the data. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1751423362</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The ID of the rule that is matched by the TLS inspection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tir-xxx</para>
            /// </summary>
            [NameInMap("TlsRuleId")]
            [Validation(Required=false)]
            public string TlsRuleId { get; set; }

            /// <summary>
            /// <para>The name of the rule that is matched by the TLS inspection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TlsRuleName")]
            [Validation(Required=false)]
            public string TlsRuleName { get; set; }

            /// <summary>
            /// <para>The ID of the TLS inspection scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tls-xxx</para>
            /// </summary>
            [NameInMap("TlsScopeId")]
            [Validation(Required=false)]
            public string TlsScopeId { get; set; }

            /// <summary>
            /// <para>The instance ID of the VPC border firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vfw-4045ca7***</para>
            /// </summary>
            [NameInMap("VpcFirewallId")]
            [Validation(Required=false)]
            public string VpcFirewallId { get; set; }

            /// <summary>
            /// <para>The vulnerability level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("VulLevel")]
            [Validation(Required=false)]
            public int? VulLevel { get; set; }

        }

        /// <summary>
        /// <para>The paging information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeTrafficLogResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeTrafficLogResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>633D92D1-768A-547F-8ADC-2870CF0A99F6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
