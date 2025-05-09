// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDestinationIPResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP addresses in outbound connections.</para>
        /// </summary>
        [NameInMap("DstIPList")]
        [Validation(Required=false)]
        public List<DescribeOutgoingDestinationIPResponseBodyDstIPList> DstIPList { get; set; }
        public class DescribeOutgoingDestinationIPResponseBodyDstIPList : TeaModel {
            /// <summary>
            /// <para>Indicates whether an access control policy is configured. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Uncovered</b>: no</description></item>
            /// <item><description><b>FullCoverage</b>: yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Uncovered</para>
            /// </summary>
            [NameInMap("AclCoverage")]
            [Validation(Required=false)]
            public string AclCoverage { get; set; }

            /// <summary>
            /// <para>The suggestion to configure an access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allows the traffic.</para>
            /// </summary>
            [NameInMap("AclRecommendDetail")]
            [Validation(Required=false)]
            public string AclRecommendDetail { get; set; }

            /// <summary>
            /// <para>The status of the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b>: healthy</description></item>
            /// <item><description><b>Abnormal</b>: unhealthy</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public string AclStatus { get; set; }

            /// <summary>
            /// <para>The information about the address book.</para>
            /// </summary>
            [NameInMap("AddressGroupList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDestinationIPResponseBodyDstIPListAddressGroupList> AddressGroupList { get; set; }
            public class DescribeOutgoingDestinationIPResponseBodyDstIPListAddressGroupList : TeaModel {
                /// <summary>
                /// <para>The name of the address book.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IP address book</para>
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
            /// <para>The application ports.</para>
            /// <remarks>
            /// <para> Only the first 100 application ports are displayed.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ApplicationPortList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDestinationIPResponseBodyDstIPListApplicationPortList> ApplicationPortList { get; set; }
            public class DescribeOutgoingDestinationIPResponseBodyDstIPListApplicationPortList : TeaModel {
                /// <summary>
                /// <para>The application type used in the access control policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FTP</b></description></item>
                /// <item><description><b>HTTP</b></description></item>
                /// <item><description><b>HTTPS</b></description></item>
                /// <item><description><b>Memcache</b></description></item>
                /// <item><description><b>MongoDB</b></description></item>
                /// <item><description><b>MQTT</b></description></item>
                /// <item><description><b>MySQL</b></description></item>
                /// <item><description><b>RDP</b></description></item>
                /// <item><description><b>Redis</b></description></item>
                /// <item><description><b>SMTP</b></description></item>
                /// <item><description><b>SMTPS</b></description></item>
                /// <item><description><b>SSH</b></description></item>
                /// <item><description><b>SSL_No_Cert</b></description></item>
                /// <item><description><b>SSL</b></description></item>
                /// <item><description><b>VNC</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> The value of this parameter depends on the value of the Proto parameter. If you set Proto to TCP, you can set ApplicationNameList to any valid value. If you configure both ApplicationNameList and ApplicationName, only the value of ApplicationNameList is used.</para>
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

                [NameInMap("UnknownReason")]
                [Validation(Required=false)]
                public List<string> UnknownReason { get; set; }

            }

            /// <summary>
            /// <para>The outbound asset count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AssetCount")]
            [Validation(Required=false)]
            public long? AssetCount { get; set; }

            /// <summary>
            /// <para>The type of the tag. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Suspicious</b></description></item>
            /// <item><description><b>Malicious</b></description></item>
            /// <item><description><b>Trusted</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Trusted</para>
            /// </summary>
            [NameInMap("CategoryClassId")]
            [Validation(Required=false)]
            public string CategoryClassId { get; set; }

            /// <summary>
            /// <para>The ID of the service type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Aliyun</b>: Alibaba Cloud services</description></item>
            /// <item><description><b>NotAliyun</b>: third-party services</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <para>The type of the service to which the destination IP address belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Alibaba Cloud services</b></description></item>
            /// <item><description><b>Third-party services</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud services</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The destination IP addresses in outbound connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("DstIP")]
            [Validation(Required=false)]
            public string DstIP { get; set; }

            /// <summary>
            /// <para>The name of the group to which the access control policy belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Rule_test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>Indicates whether an access control policy is configured. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasAcl")]
            [Validation(Required=false)]
            public string HasAcl { get; set; }

            /// <summary>
            /// <para>Indicates whether an access control policy is recommended. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasAclRecommend")]
            [Validation(Required=false)]
            public bool? HasAclRecommend { get; set; }

            /// <summary>
            /// <para>The inbound traffic. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>472</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <para>Indicates whether the destination IP address is added to a whitelist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsMarkNormal")]
            [Validation(Required=false)]
            public bool? IsMarkNormal { get; set; }

            /// <summary>
            /// <para>Location name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>山东省青岛市</para>
            /// </summary>
            [NameInMap("LocationName")]
            [Validation(Required=false)]
            public string LocationName { get; set; }

            /// <summary>
            /// <para>The outbound traffic. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>965</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// <para>The outbound private asset count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PrivateAssetCount")]
            [Validation(Required=false)]
            public long? PrivateAssetCount { get; set; }

            /// <summary>
            /// <para>The UUID of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fadsfd-dfadf-df****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default rule</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The reason why the domain name is secure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Intelligent policy: The destination domain name belongs to Alibaba Cloud Computing Co., Ltd. The domain name mainly provides services for Alibaba Cloud. No security risks are found, and you can add the domain name to the whitelist.</para>
            /// </summary>
            [NameInMap("SecurityReason")]
            [Validation(Required=false)]
            public string SecurityReason { get; set; }

            /// <summary>
            /// <para>The suggestion to handle the traffic of the domain name in outbound connections. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pass</b>: allow</description></item>
            /// <item><description><b>alert</b>: deny</description></item>
            /// <item><description><b>drop</b>: monitor</description></item>
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
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDestinationIPResponseBodyDstIPListTagList> TagList { get; set; }
            public class DescribeOutgoingDestinationIPResponseBodyDstIPListTagList : TeaModel {
                /// <summary>
                /// <para>The type of the tag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Suspicious</b></description></item>
                /// <item><description><b>Malicious</b></description></item>
                /// <item><description><b>Trusted</b></description></item>
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
                /// <item><description><b>1</b>: low.</description></item>
                /// <item><description><b>2</b>: medium.</description></item>
                /// <item><description><b>3</b>: high.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// <para>The description of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tag that indicates traffic is allowed</para>
                /// </summary>
                [NameInMap("TagDescribe")]
                [Validation(Required=false)]
                public string TagDescribe { get; set; }

                /// <summary>
                /// <para>The ID of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AliYun</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <para>The name of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tag that indicates traffic is allowed</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            /// <summary>
            /// <para>The total traffic. Unit: bytes</para>
            /// 
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("TotalBytes")]
            [Validation(Required=false)]
            public string TotalBytes { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0F82705-CFC7-5F83-86C8-A063892F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of destination IP addresses in outbound connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
