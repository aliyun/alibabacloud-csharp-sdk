// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListCompliancePackTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the compliance package templates returned.</para>
        /// </summary>
        [NameInMap("CompliancePackTemplatesResult")]
        [Validation(Required=false)]
        public ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResult CompliancePackTemplatesResult { get; set; }
        public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResult : TeaModel {
            /// <summary>
            /// <para>The compliance package templates.</para>
            /// </summary>
            [NameInMap("CompliancePackTemplates")]
            [Validation(Required=false)]
            public List<ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplates> CompliancePackTemplates { get; set; }
            public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplates : TeaModel {
                /// <summary>
                /// <para>The ID of the compliance package template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ct-d254ff4e06a300cf****</para>
                /// </summary>
                [NameInMap("CompliancePackTemplateId")]
                [Validation(Required=false)]
                public string CompliancePackTemplateId { get; set; }

                /// <summary>
                /// <para>The name of the compliance package template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BestPracticesForResourceStability</para>
                /// </summary>
                [NameInMap("CompliancePackTemplateName")]
                [Validation(Required=false)]
                public string CompliancePackTemplateName { get; set; }

                /// <summary>
                /// <para>The default rules in the compliance package.</para>
                /// </summary>
                [NameInMap("ConfigRules")]
                [Validation(Required=false)]
                public List<ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRules> ConfigRules { get; set; }
                public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRules : TeaModel {
                    /// <summary>
                    /// <para>The input parameter of the managed rule.</para>
                    /// </summary>
                    [NameInMap("ConfigRuleParameters")]
                    [Validation(Required=false)]
                    public List<ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRulesConfigRuleParameters> ConfigRuleParameters { get; set; }
                    public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRulesConfigRuleParameters : TeaModel {
                        /// <summary>
                        /// <para>The name of the input parameter of the managed rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>days</para>
                        /// </summary>
                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                        /// <summary>
                        /// <para>The value of the input parameter of the managed rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>90</para>
                        /// </summary>
                        [NameInMap("ParameterValue")]
                        [Validation(Required=false)]
                        public string ParameterValue { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the parameter is required in the managed rule. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true: required</description></item>
                        /// <item><description>false: optional</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                    }

                    /// <summary>
                    /// <para>The description of the regulation. This parameter is available only for regulation compliance packages.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>No classic networks exist.</para>
                    /// </summary>
                    [NameInMap("ControlDescription")]
                    [Validation(Required=false)]
                    public string ControlDescription { get; set; }

                    /// <summary>
                    /// <para>The regulation ID.</para>
                    /// <remarks>
                    /// <para> This parameter is available only for regulation compliance packages.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3.1</para>
                    /// </summary>
                    [NameInMap("ControlId")]
                    [Validation(Required=false)]
                    public string ControlId { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the rules are enabled together with the compliance package. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("DefaultEnable")]
                    [Validation(Required=false)]
                    public bool? DefaultEnable { get; set; }

                    /// <summary>
                    /// <para>The description of the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>If the expiration time of the SLB certificate is later than the specified number of days after the check time, the configuration is considered compliant. Default value: 90 days.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The identifier of the managed rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>slb-servercertificate-expired-check</para>
                    /// </summary>
                    [NameInMap("ManagedRuleIdentifier")]
                    [Validation(Required=false)]
                    public string ManagedRuleIdentifier { get; set; }

                    /// <summary>
                    /// <para>The name of the managed rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>slb-servercertificate-expired-check</para>
                    /// </summary>
                    [NameInMap("ManagedRuleName")]
                    [Validation(Required=false)]
                    public string ManagedRuleName { get; set; }

                    /// <summary>
                    /// <para>The types of the resources evaluated based on the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACS::SLB::ServerCertificate</para>
                    /// </summary>
                    [NameInMap("ResourceTypesScope")]
                    [Validation(Required=false)]
                    public string ResourceTypesScope { get; set; }

                    /// <summary>
                    /// <para>The risk level of the managed rule. Valid values:</para>
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

                }

                /// <summary>
                /// <para>The description of the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The tag of the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tagKey-1</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <para>The time when the compliance package was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1663408308</para>
                /// </summary>
                [NameInMap("LastUpdate")]
                [Validation(Required=false)]
                public int? LastUpdate { get; set; }

                /// <summary>
                /// <para>The risk level of the managed rule in the compliance package. Valid values:</para>
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

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of the compliance package templates returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D67FC82F-25AE-4268-A94C-3348340748F9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
