// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDestinationIPResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of destination IP addresses for outgoing connections.</para>
        /// </summary>
        [NameInMap("DstIPList")]
        [Validation(Required=false)]
        public List<DescribeOutgoingDestinationIPResponseBodyDstIPList> DstIPList { get; set; }
        public class DescribeOutgoingDestinationIPResponseBodyDstIPList : TeaModel {
            /// <summary>
            /// <para>Indicates whether an access control policy is applied. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Uncovered</b>: No policy is applied.</para>
            /// </description></item>
            /// <item><description><para><b>FullCoverage</b>: A policy is applied.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Uncovered</para>
            /// </summary>
            [NameInMap("AclCoverage")]
            [Validation(Required=false)]
            public string AclCoverage { get; set; }

            /// <summary>
            /// <para>Details of the ACL recommendation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>建议放行</para>
            /// </summary>
            [NameInMap("AclRecommendDetail")]
            [Validation(Required=false)]
            public string AclRecommendDetail { get; set; }

            /// <summary>
            /// <para>The health status of the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Normal</b>: Healthy.</para>
            /// </description></item>
            /// <item><description><para><b>Abnormal</b>: Unhealthy.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public string AclStatus { get; set; }

            /// <summary>
            /// <para>A list of address books that contain this destination IP address.</para>
            /// </summary>
            [NameInMap("AddressGroupList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDestinationIPResponseBodyDstIPListAddressGroupList> AddressGroupList { get; set; }
            public class DescribeOutgoingDestinationIPResponseBodyDstIPListAddressGroupList : TeaModel {
                /// <summary>
                /// <para>The name of the address book.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IP地址簿</para>
                /// </summary>
                [NameInMap("AddressGroupName")]
                [Validation(Required=false)]
                public string AddressGroupName { get; set; }

                /// <summary>
                /// <para>The UUID of the address book.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f04ac7ce-628b-4cb7-be61-310222b7****</para>
                /// </summary>
                [NameInMap("AddressGroupUUID")]
                [Validation(Required=false)]
                public string AddressGroupUUID { get; set; }

            }

            /// <summary>
            /// <para>The list of application ports.</para>
            /// <remarks>
            /// <para>This response returns a maximum of 99 application ports. If more than 99 ports exist, only the first 99 are returned.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ApplicationPortList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDestinationIPResponseBodyDstIPListApplicationPortList> ApplicationPortList { get; set; }
            public class DescribeOutgoingDestinationIPResponseBodyDstIPListApplicationPortList : TeaModel {
                /// <summary>
                /// <para>The application protocol detected for the connection. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>FTP</b></para>
                /// </description></item>
                /// <item><description><para><b>HTTP</b></para>
                /// </description></item>
                /// <item><description><para><b>HTTPS</b></para>
                /// </description></item>
                /// <item><description><para><b>Memcache</b></para>
                /// </description></item>
                /// <item><description><para><b>MongoDB</b></para>
                /// </description></item>
                /// <item><description><para><b>MQTT</b></para>
                /// </description></item>
                /// <item><description><para><b>MySQL</b></para>
                /// </description></item>
                /// <item><description><para><b>RDP</b></para>
                /// </description></item>
                /// <item><description><para><b>Redis</b></para>
                /// </description></item>
                /// <item><description><para><b>SMTP</b></para>
                /// </description></item>
                /// <item><description><para><b>SMTPS</b></para>
                /// </description></item>
                /// <item><description><para><b>SSH</b></para>
                /// </description></item>
                /// <item><description><para><b>SSL_No_Cert</b></para>
                /// </description></item>
                /// <item><description><para><b>SSL</b></para>
                /// </description></item>
                /// <item><description><para><b>VNC</b></para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// <para>The application port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>A list of reasons why the application protocol was not identified.</para>
                /// </summary>
                [NameInMap("UnknownReason")]
                [Validation(Required=false)]
                public List<string> UnknownReason { get; set; }

            }

            /// <summary>
            /// <para>The total number of assets that initiated outgoing connections to this destination IP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AssetCount")]
            [Validation(Required=false)]
            public long? AssetCount { get; set; }

            /// <summary>
            /// <para>The threat intelligence category of the destination IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Suspicious</b></para>
            /// </description></item>
            /// <item><description><para><b>Malicious</b></para>
            /// </description></item>
            /// <item><description><para><b>Trusted</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Trusted</para>
            /// </summary>
            [NameInMap("CategoryClassId")]
            [Validation(Required=false)]
            public string CategoryClassId { get; set; }

            /// <summary>
            /// <para>The ID of the service category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Aliyun</b>: The destination is an Alibaba Cloud product.</para>
            /// </description></item>
            /// <item><description><para><b>NotAliyun</b>: The destination is a non-Alibaba Cloud product.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <para>The service category of the destination IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Alibaba Cloud product</b></para>
            /// </description></item>
            /// <item><description><para><b>non-Alibaba Cloud product</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云产品</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The destination IP address of the outgoing connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("DstIP")]
            [Validation(Required=false)]
            public string DstIP { get; set; }

            /// <summary>
            /// <para>The name of the rule group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rules_test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>Indicates whether an access control rule exists. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: An access control rule exists.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No access control rule exists.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasAcl")]
            [Validation(Required=false)]
            public string HasAcl { get; set; }

            /// <summary>
            /// <para>Indicates whether an ACL is recommended. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: An ACL is recommended.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No ACL is recommended.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasAclRecommend")]
            [Validation(Required=false)]
            public bool? HasAclRecommend { get; set; }

            /// <summary>
            /// <para>The total inbound traffic in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>472</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <para>Indicates whether the destination IP address is added to the allowlist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The destination IP address is on the allowlist.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The destination IP address is not on the allowlist.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsMarkNormal")]
            [Validation(Required=false)]
            public bool? IsMarkNormal { get; set; }

            /// <summary>
            /// <para>The geographical location of the destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>山东省青岛市</para>
            /// </summary>
            [NameInMap("LocationName")]
            [Validation(Required=false)]
            public string LocationName { get; set; }

            /// <summary>
            /// <para>The total outbound traffic in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>965</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// <para>The total number of private assets that initiated outgoing connections to this destination IP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PrivateAssetCount")]
            [Validation(Required=false)]
            public long? PrivateAssetCount { get; set; }

            /// <summary>
            /// <para>The UUID of the ACL rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fadsfd-dfadf-df****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the ACL rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>默认规则</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The reason for the security recommendation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>智能策略：该目的域名所属组织为阿里云计算有限公司，主要业务为阿里云，未发现安全风险，可用于配置外联白名单。</para>
            /// </summary>
            [NameInMap("SecurityReason")]
            [Validation(Required=false)]
            public string SecurityReason { get; set; }

            /// <summary>
            /// <para>The recommended security action for the outgoing connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>pass</b>: Allows the connection.</para>
            /// </description></item>
            /// <item><description><para><b>alert</b>: Rejects the connection.</para>
            /// </description></item>
            /// <item><description><para><b>drop</b>: Drops the connection.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("SecuritySuggest")]
            [Validation(Required=false)]
            public string SecuritySuggest { get; set; }

            /// <summary>
            /// <para>The number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <para>A list of tags associated with the destination IP.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDestinationIPResponseBodyDstIPListTagList> TagList { get; set; }
            public class DescribeOutgoingDestinationIPResponseBodyDstIPListTagList : TeaModel {
                /// <summary>
                /// <para>The category of the threat intelligence tag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Suspicious</b></para>
                /// </description></item>
                /// <item><description><para><b>Malicious</b></para>
                /// </description></item>
                /// <item><description><para><b>Trusted</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Trusted</para>
                /// </summary>
                [NameInMap("ClassId")]
                [Validation(Required=false)]
                public string ClassId { get; set; }

                /// <summary>
                /// <para>The risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: Low</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Medium</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: High</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// <para>The description of the threat intelligence tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ReleaseLabel</para>
                /// </summary>
                [NameInMap("TagDescribe")]
                [Validation(Required=false)]
                public string TagDescribe { get; set; }

                /// <summary>
                /// <para>The ID of the threat intelligence tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ReleaseLabel</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <para>The name of the threat intelligence tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ReleaseLabel</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            /// <summary>
            /// <para>The total traffic volume in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("TotalBytes")]
            [Validation(Required=false)]
            public string TotalBytes { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0F82705-CFC7-5F83-86C8-A063892F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of outgoing IPs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
