// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Outbound Domain names.</para>
        /// </summary>
        [NameInMap("DomainList")]
        [Validation(Required=false)]
        public List<DescribeOutgoingDomainResponseBodyDomainList> DomainList { get; set; }
        public class DescribeOutgoingDomainResponseBodyDomainList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the access control policy covers the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Uncovered</b>: Not covered.</description></item>
            /// <item><description><b>FullCoverage</b>: Covered.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Uncovered</para>
            /// </summary>
            [NameInMap("AclCoverage")]
            [Validation(Required=false)]
            public string AclCoverage { get; set; }

            /// <summary>
            /// <para>The ACL recommendation details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RecommendedRelease</para>
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
            /// <para>The name of the address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Outreach Address Book</para>
            /// </summary>
            [NameInMap("AddressGroupName")]
            [Validation(Required=false)]
            public string AddressGroupName { get; set; }

            /// <summary>
            /// <para>The UUID of the address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fdad-fdafa-dafa-dfa****</para>
            /// </summary>
            [NameInMap("AddressGroupUUID")]
            [Validation(Required=false)]
            public string AddressGroupUUID { get; set; }

            /// <summary>
            /// <para>The application names.</para>
            /// </summary>
            [NameInMap("ApplicationNameList")]
            [Validation(Required=false)]
            public List<string> ApplicationNameList { get; set; }

            [NameInMap("ApplicationPortList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDomainResponseBodyDomainListApplicationPortList> ApplicationPortList { get; set; }
            public class DescribeOutgoingDomainResponseBodyDomainListApplicationPortList : TeaModel {
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

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
            /// <para>The website business.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun</para>
            /// </summary>
            [NameInMap("Business")]
            [Validation(Required=false)]
            public string Business { get; set; }

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
            /// <para>The product category ID. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Aliyun</b>: Alibaba Cloud product.</description></item>
            /// <item><description><b>NotAliyun</b>: Non-Alibaba Cloud product.</description></item>
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
            /// <item><description><b>Alibaba Cloud product</b></description></item>
            /// <item><description><b>Non-Alibaba Cloud product</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud product</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The domain name of outbound connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The group name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group-name</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>Indicates whether an ACL already covers this domain name. Valid values:</para>
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
            /// <para>Indicates whether an ACL recommendation exists. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasAclRecommend")]
            [Validation(Required=false)]
            public bool? HasAclRecommend { get; set; }

            /// <summary>
            /// <para>The inbound traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3214</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <para>Indicates whether the Outbound Domain is marked as normal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Normal.</description></item>
            /// <item><description><b>false</b>: Abnormal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsMarkNormal")]
            [Validation(Required=false)]
            public bool? IsMarkNormal { get; set; }

            /// <summary>
            /// <para>The organization name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Computing Limited</para>
            /// </summary>
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

            /// <summary>
            /// <para>The outbound traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4582</para>
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
            /// <para>The ACL rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>add-dfadf-f****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The ACL rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-name</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The security reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Smart policy: The target domain name belongs to Aliyun Computing Co., Ltd., and its main business is Aliyun. No security risks have been found. It can be used to configure an outreach whitelist.</para>
            /// </summary>
            [NameInMap("SecurityReason")]
            [Validation(Required=false)]
            public string SecurityReason { get; set; }

            /// <summary>
            /// <para>The security policy for the Outbound Domain of outbound connections. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pass</b>: Allow.</description></item>
            /// <item><description><b>alert</b>: Monitor.</description></item>
            /// <item><description><b>drop</b>: Deny.</description></item>
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
            /// <para>12</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <para>The tag list.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDomainResponseBodyDomainListTagList> TagList { get; set; }
            public class DescribeOutgoingDomainResponseBodyDomainListTagList : TeaModel {
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
                /// <item><description><b>1</b>: Low.</description></item>
                /// <item><description><b>2</b>: Medium.</description></item>
                /// <item><description><b>3</b>: High.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// <para>The tag description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-describe</para>
                /// </summary>
                [NameInMap("TagDescribe")]
                [Validation(Required=false)]
                public string TagDescribe { get; set; }

                /// <summary>
                /// <para>The intelligence tags label ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AliYun</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <para>The tag name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-name</para>
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
        /// <para>The total number of Outbound Domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
