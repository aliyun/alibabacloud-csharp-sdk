// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDestinationIPResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of IP addresses for outbound connections.</para>
        /// </summary>
        [NameInMap("DstIPList")]
        [Validation(Required=false)]
        public List<DescribeOutgoingDestinationIPResponseBodyDstIPList> DstIPList { get; set; }
        public class DescribeOutgoingDestinationIPResponseBodyDstIPList : TeaModel {
            /// <summary>
            /// <para>Specifies whether to overwrite the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Uncovered</b>: Not covered.</para>
            /// </description></item>
            /// <item><description><para><b>FullCoverage</b>: Covered.</para>
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
            /// <para>The recommendation information for the ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allow recommended</para>
            /// </summary>
            [NameInMap("AclRecommendDetail")]
            [Validation(Required=false)]
            public string AclRecommendDetail { get; set; }

            /// <summary>
            /// <para>The health status of the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: Healthy.</description></item>
            /// <item><description><b>Abnormal</b>: Unhealthy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public string AclStatus { get; set; }

            /// <summary>
            /// <para>The address book information.</para>
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
            /// <para>The list of application ports.</para>
            /// <remarks>
            /// <para>The list displays only the first 99 application ports. If the number of outbound application ports exceeds 99, only the first 99 entries are displayed.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ApplicationPortList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDestinationIPResponseBodyDstIPListApplicationPortList> ApplicationPortList { get; set; }
            public class DescribeOutgoingDestinationIPResponseBodyDstIPListApplicationPortList : TeaModel {
                /// <summary>
                /// <para>The Protocol Type supported by the access control policy. Valid values:</para>
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
                /// <para>The valid values of this parameter depend on the value of the Proto parameter. If Proto is set to TCP, ApplicationNameList supports all the preceding Protocol Types. If both ApplicationNameList and ApplicationName are specified, ApplicationNameList takes precedence.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// <para>The port of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The list of reasons why the protocol is not analyzed when the identified protocol is Unknown.</para>
                /// </summary>
                [NameInMap("UnknownReason")]
                [Validation(Required=false)]
                public List<string> UnknownReason { get; set; }

            }

            /// <summary>
            /// <para>The total number of assets that initiate outbound connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AssetCount")]
            [Validation(Required=false)]
            public long? AssetCount { get; set; }

            /// <summary>
            /// <para>The categorization of the intelligence tags label. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Suspicious</b>: Suspicious.</description></item>
            /// <item><description><b>Malicious</b>: Malicious.</description></item>
            /// <item><description><b>Trusted</b>: Trusted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Trusted</para>
            /// </summary>
            [NameInMap("CategoryClassId")]
            [Validation(Required=false)]
            public string CategoryClassId { get; set; }

            /// <summary>
            /// <para>The category ID of the product. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Aliyun</b>: Alibaba Cloud service.</para>
            /// </description></item>
            /// <item><description><para><b>NotAliyun</b>: Non-Alibaba Cloud service.</para>
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
            /// <para>The category name of the product. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Alibaba Cloud service</b></para>
            /// </description></item>
            /// <item><description><para><b>Non-Alibaba Cloud service</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud service</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The destination IP address of the domain name for outbound connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("DstIP")]
            [Validation(Required=false)]
            public string DstIP { get; set; }

            /// <summary>
            /// <para>The name of the group in the rule.</para>
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
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasAcl")]
            [Validation(Required=false)]
            public string HasAcl { get; set; }

            /// <summary>
            /// <para>Indicates whether an ACL recommendation is available. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No.</para>
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
            /// <para>The inbound traffic. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>472</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <para>Indicates whether the IP address is added to the whitelist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Added.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not added.</para>
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
            /// <para>The region name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qingdao, Shandong Province</para>
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
            /// <para>The total number of private network assets that initiate outbound connections.</para>
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
            /// <para>Default rule</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The security reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Intelligent policy: The organization to which the destination domain name belongs is Alibaba Cloud Computing Ltd. Its main business is Alibaba Cloud. No security risks are found. It can be used to configure an outbound whitelist.</para>
            /// </summary>
            [NameInMap("SecurityReason")]
            [Validation(Required=false)]
            public string SecurityReason { get; set; }

            /// <summary>
            /// <para>The security policy for the domain name for outbound connections. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>pass</b>: Allow.</para>
            /// </description></item>
            /// <item><description><para><b>alert</b>: Deny.</para>
            /// </description></item>
            /// <item><description><para><b>drop</b>: Monitor.</para>
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
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDestinationIPResponseBodyDstIPListTagList> TagList { get; set; }
            public class DescribeOutgoingDestinationIPResponseBodyDstIPListTagList : TeaModel {
                /// <summary>
                /// <para>The categorization of the intelligence tags label. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Suspicious</b>: Suspicious.</description></item>
                /// <item><description><b>Malicious</b>: Malicious.</description></item>
                /// <item><description><b>Trusted</b>: Trusted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Trusted</para>
                /// </summary>
                [NameInMap("ClassId")]
                [Validation(Required=false)]
                public string ClassId { get; set; }

                /// <summary>
                /// <para>The risk assessment level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Low risk.</description></item>
                /// <item><description><b>2</b>: Medium risk.</description></item>
                /// <item><description><b>3</b>: High risk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// <para>The description of the intelligence tags label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ReleaseLabel</para>
                /// </summary>
                [NameInMap("TagDescribe")]
                [Validation(Required=false)]
                public string TagDescribe { get; set; }

                /// <summary>
                /// <para>The ID of the intelligence tags label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ReleaseLabel</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <para>The name of the intelligence label sign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ReleaseLabel</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            /// <summary>
            /// <para>The total traffic. Unit: bytes.</para>
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
        /// <para>The total number of outbound IP addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
