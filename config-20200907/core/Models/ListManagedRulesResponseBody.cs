// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListManagedRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The rule templates.</para>
        /// </summary>
        [NameInMap("ManagedRules")]
        [Validation(Required=false)]
        public ListManagedRulesResponseBodyManagedRules ManagedRules { get; set; }
        public class ListManagedRulesResponseBodyManagedRules : TeaModel {
            /// <summary>
            /// <para>The details of the rule templates.</para>
            /// </summary>
            [NameInMap("ManagedRuleList")]
            [Validation(Required=false)]
            public List<ListManagedRulesResponseBodyManagedRulesManagedRuleList> ManagedRuleList { get; set; }
            public class ListManagedRulesResponseBodyManagedRulesManagedRuleList : TeaModel {
                /// <summary>
                /// <para>The name of the rule template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CDN域名开启HTTPS加密</para>
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                /// <summary>
                /// <para>The description of the rule template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CDN域名开启HTTPS协议加密，视为“合规”。</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The URL of the document that provides remediation guidance.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.aliyundoc.com">https://example.aliyundoc.com</a></para>
                /// </summary>
                [NameInMap("HelpUrls")]
                [Validation(Required=false)]
                public string HelpUrls { get; set; }

                /// <summary>
                /// <para>The unique identifier of the rule template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cdn-domain-https-enabled</para>
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <para>The list of labels of the rule template.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<string> Labels { get; set; }

                /// <summary>
                /// <para>The identifier of the supported remediation template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS-CDN-SetDomainServerCertificate</para>
                /// </summary>
                [NameInMap("RemediationTemplateIdentifier")]
                [Validation(Required=false)]
                public string RemediationTemplateIdentifier { get; set; }

                /// <summary>
                /// <para>The name of the supported remediation template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>开启CDN域名HTTPS监听</para>
                /// </summary>
                [NameInMap("RemediationTemplateName")]
                [Validation(Required=false)]
                public string RemediationTemplateName { get; set; }

                /// <summary>
                /// <para>The risk level of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>1: high</para>
                /// </description></item>
                /// <item><description><para>2: medium</para>
                /// </description></item>
                /// <item><description><para>3: low</para>
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
                /// <para>The effective scope of the rule template.</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public ListManagedRulesResponseBodyManagedRulesManagedRuleListScope Scope { get; set; }
                public class ListManagedRulesResponseBodyManagedRulesManagedRuleListScope : TeaModel {
                    /// <summary>
                    /// <para>The types of resources that are evaluated based on the rule template.</para>
                    /// </summary>
                    [NameInMap("ComplianceResourceTypes")]
                    [Validation(Required=false)]
                    public List<string> ComplianceResourceTypes { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the rule supports dry runs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The rule supports dry runs.</para>
                /// </description></item>
                /// <item><description><para>false: The rule does not support dry runs.</para>
                /// </description></item>
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
            /// <para>The page number of the returned page.</para>
            /// <para>The value must be greater than or equal to 1.</para>
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
            /// <para>The total number of rule templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B3E605AB-63D5-1EE0-BFA6-0BAC247B0461</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
