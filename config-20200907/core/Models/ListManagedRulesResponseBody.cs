// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListManagedRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The managed rules.</para>
        /// </summary>
        [NameInMap("ManagedRules")]
        [Validation(Required=false)]
        public ListManagedRulesResponseBodyManagedRules ManagedRules { get; set; }
        public class ListManagedRulesResponseBodyManagedRules : TeaModel {
            /// <summary>
            /// <para>The details of the managed rule.</para>
            /// </summary>
            [NameInMap("ManagedRuleList")]
            [Validation(Required=false)]
            public List<ListManagedRulesResponseBodyManagedRulesManagedRuleList> ManagedRuleList { get; set; }
            public class ListManagedRulesResponseBodyManagedRulesManagedRuleList : TeaModel {
                /// <summary>
                /// <para>The name of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-rule-name</para>
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                /// <summary>
                /// <para>The description of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The description of the test rule.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The URL of the topic that describes how the managed rule remediates the incompliant configurations.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.aliyundoc.com">https://example.aliyundoc.com</a></para>
                /// </summary>
                [NameInMap("HelpUrls")]
                [Validation(Required=false)]
                public string HelpUrls { get; set; }

                /// <summary>
                /// <para>The unique identifier of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cdn-domain-https-enabled</para>
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <para>The classification description of the managed rule.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<string> Labels { get; set; }

                /// <summary>
                /// <para>The ID of the remediation template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS-CDN-SetDomainServerCertificate</para>
                /// </summary>
                [NameInMap("RemediationTemplateIdentifier")]
                [Validation(Required=false)]
                public string RemediationTemplateIdentifier { get; set; }

                /// <summary>
                /// <para>The name of the remediation template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Configure encryption rules for OSS buckets</para>
                /// </summary>
                [NameInMap("RemediationTemplateName")]
                [Validation(Required=false)]
                public string RemediationTemplateName { get; set; }

                /// <summary>
                /// <para>The risk level of the resources that do not comply with the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: high</description></item>
                /// <item><description>2: medium</description></item>
                /// <item><description>3: low</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// <para>The effective scope of the managed rule.</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public ListManagedRulesResponseBodyManagedRulesManagedRuleListScope Scope { get; set; }
                public class ListManagedRulesResponseBodyManagedRulesManagedRuleListScope : TeaModel {
                    /// <summary>
                    /// <para>The types of resources to which the managed rule applies.</para>
                    /// </summary>
                    [NameInMap("ComplianceResourceTypes")]
                    [Validation(Required=false)]
                    public List<string> ComplianceResourceTypes { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether precheck is supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportPreviewManagedRule")]
                [Validation(Required=false)]
                public bool? SupportPreviewManagedRule { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// <para>Page start from page 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Valid values: 1 to 500.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B3E605AB-63D5-1EE0-BFA6-0BAC247B0461</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
