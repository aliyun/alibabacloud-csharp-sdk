// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of outbound domains.</para>
        /// </summary>
        [NameInMap("DomainList")]
        [Validation(Required=false)]
        public List<DescribeOutgoingDomainResponseBodyDomainList> DomainList { get; set; }
        public class DescribeOutgoingDomainResponseBodyDomainList : TeaModel {
            /// <summary>
            /// <para>Indicates whether an access control policy is configured for the domain. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Uncovered</b>: no</para>
            /// </description></item>
            /// <item><description><para><b>FullCoverage</b>: yes</para>
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
            /// <para>The recommended action for the access control policy.</para>
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
            /// <item><description><para><b>Normal</b>: healthy</para>
            /// </description></item>
            /// <item><description><para><b>Abnormal</b>: unhealthy</para>
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
            /// <para>An array of application names.</para>
            /// </summary>
            [NameInMap("ApplicationNameList")]
            [Validation(Required=false)]
            public List<string> ApplicationNameList { get; set; }

            /// <summary>
            /// <para>The total number of assets that initiate outbound connections to the domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AssetCount")]
            [Validation(Required=false)]
            public long? AssetCount { get; set; }

            /// <summary>
            /// <para>The business to which the website belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun</para>
            /// </summary>
            [NameInMap("Business")]
            [Validation(Required=false)]
            public string Business { get; set; }

            /// <summary>
            /// <para>The category of the intelligence tag. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Suspicious</b>: suspicious</para>
            /// </description></item>
            /// <item><description><para><b>Malicious</b>: malicious</para>
            /// </description></item>
            /// <item><description><para><b>Trusted</b>: trusted</para>
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
            /// <para>The ID of the asset category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Aliyun</b>: Alibaba Cloud service</para>
            /// </description></item>
            /// <item><description><para><b>NotAliyun</b>: third-party service</para>
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
            /// <para>The name of the asset category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Alibaba Cloud product</para>
            /// </description></item>
            /// <item><description><para>Non-Alibaba Cloud product</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud product</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The outbound domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The name of the policy group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group-name</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>Indicates whether an access control policy is configured for the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no</para>
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
            /// <para>Indicates whether a recommended access control policy exists. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no</para>
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
            /// <para>The volume of inbound traffic, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3214</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <para>Indicates whether the outbound domain name is marked as normal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: normal</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: not normal</para>
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
            /// <para>The name of the organization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Computing Limited</para>
            /// </summary>
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

            /// <summary>
            /// <para>The volume of outbound traffic, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4582</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// <para>The total number of assets in a private network that initiate outbound connections to the domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PrivateAssetCount")]
            [Validation(Required=false)]
            public long? PrivateAssetCount { get; set; }

            /// <summary>
            /// <para>The ID of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>add-dfadf-f****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-name</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The reason for the security recommendation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Smart policy: The target domain name belongs to Aliyun Computing Co., Ltd., and its main business is Aliyun. No security risks have been found. It can be used to configure an outreach whitelist.</para>
            /// </summary>
            [NameInMap("SecurityReason")]
            [Validation(Required=false)]
            public string SecurityReason { get; set; }

            /// <summary>
            /// <para>The recommended security action for the outbound domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>pass</b>: allow</para>
            /// </description></item>
            /// <item><description><para><b>alert</b>: monitor</para>
            /// </description></item>
            /// <item><description><para><b>drop</b>: deny</para>
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
            /// <para>12</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <para>An array of tags.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDomainResponseBodyDomainListTagList> TagList { get; set; }
            public class DescribeOutgoingDomainResponseBodyDomainListTagList : TeaModel {
                /// <summary>
                /// <para>The category of the intelligence tag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Suspicious</b>: suspicious</para>
                /// </description></item>
                /// <item><description><para><b>Malicious</b>: malicious</para>
                /// </description></item>
                /// <item><description><para><b>Trusted</b>: trusted</para>
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
                /// <item><description><para><b>1</b>: low</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: medium</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: high</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// <para>The description of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-describe</para>
                /// </summary>
                [NameInMap("TagDescribe")]
                [Validation(Required=false)]
                public string TagDescribe { get; set; }

                /// <summary>
                /// <para>The ID of the intelligence tag.</para>
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
                /// <para>tag-name</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            /// <summary>
            /// <para>The total traffic volume, in bytes.</para>
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
        /// <para>The total number of outbound domains found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
