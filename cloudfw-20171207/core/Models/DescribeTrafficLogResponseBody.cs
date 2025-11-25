// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrafficLogResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeTrafficLogResponseBodyDataList> DataList { get; set; }
        public class DescribeTrafficLogResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AclPreRuleId")]
            [Validation(Required=false)]
            public string AclPreRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AclPreRuleName")]
            [Validation(Required=false)]
            public string AclPreRuleName { get; set; }

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
            /// <para>6</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WebLogic</para>
            /// </summary>
            [NameInMap("AttackApp")]
            [Validation(Required=false)]
            public string AttackApp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public int? AttackType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FI</para>
            /// </summary>
            [NameInMap("CityId")]
            [Validation(Required=false)]
            public string CityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tcp_fin</para>
            /// </summary>
            [NameInMap("CloseReason")]
            [Validation(Required=false)]
            public string CloseReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ngw-*</para>
            /// </summary>
            [NameInMap("CloudInstanceId")]
            [Validation(Required=false)]
            public string CloudInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>US</para>
            /// </summary>
            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx.com</para>
            /// </summary>
            [NameInMap("DomainUrl")]
            [Validation(Required=false)]
            public string DomainUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.2.2.2</para>
            /// </summary>
            [NameInMap("DstIP")]
            [Validation(Required=false)]
            public string DstIP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public int? DstPort { get; set; }

            [NameInMap("DstVpc")]
            [Validation(Required=false)]
            public DescribeTrafficLogResponseBodyDataListDstVpc DstVpc { get; set; }
            public class DescribeTrafficLogResponseBodyDataListDstVpc : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-8vba1c1em97h0ji71b****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yi-vpc</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1751423363</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Ext")]
            [Validation(Required=false)]
            public string Ext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>125</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public string InBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("InPackets")]
            [Validation(Required=false)]
            public string InPackets { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FOP Dmytro Nedilskyi</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50075069</para>
            /// </summary>
            [NameInMap("IspId")]
            [Validation(Required=false)]
            public string IspId { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>14151892****7022</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>230</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public string OutBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("OutPackets")]
            [Validation(Required=false)]
            public string OutPackets { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>355</para>
            /// </summary>
            [NameInMap("PacketBytes")]
            [Validation(Required=false)]
            public long? PacketBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("PacketCount")]
            [Validation(Required=false)]
            public long? PacketCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172.21.234.XXX</para>
            /// </summary>
            [NameInMap("PrivateIp")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("PrivatePort")]
            [Validation(Required=false)]
            public int? PrivatePort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>00000000-0000-0000-0000-000000000000</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("RuleResult")]
            [Validation(Required=false)]
            public int? RuleResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RuleSource")]
            [Validation(Required=false)]
            public string RuleSource { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeTrafficLogResponseBodyDataListRules> Rules { get; set; }
            public class DescribeTrafficLogResponseBodyDataListRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>17</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sharepoint</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("SrcIP")]
            [Validation(Required=false)]
            public string SrcIP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20206</para>
            /// </summary>
            [NameInMap("SrcPort")]
            [Validation(Required=false)]
            public int? SrcPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172.16.101.7</para>
            /// </summary>
            [NameInMap("SrcPrivateIP")]
            [Validation(Required=false)]
            public string SrcPrivateIP { get; set; }

            [NameInMap("SrcVpc")]
            [Validation(Required=false)]
            public DescribeTrafficLogResponseBodyDataListSrcVpc SrcVpc { get; set; }
            public class DescribeTrafficLogResponseBodyDataListSrcVpc : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-8vba1c1em97h0ji71****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yi-vpc</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1751423362</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tir-xxx</para>
            /// </summary>
            [NameInMap("TlsRuleId")]
            [Validation(Required=false)]
            public string TlsRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TlsRuleName")]
            [Validation(Required=false)]
            public string TlsRuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tls-xxx</para>
            /// </summary>
            [NameInMap("TlsScopeId")]
            [Validation(Required=false)]
            public string TlsScopeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vfw-4045ca7***</para>
            /// </summary>
            [NameInMap("VpcFirewallId")]
            [Validation(Required=false)]
            public string VpcFirewallId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("VulLevel")]
            [Validation(Required=false)]
            public int? VulLevel { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeTrafficLogResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeTrafficLogResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>633D92D1-768A-547F-8ADC-2870CF0A99F6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
