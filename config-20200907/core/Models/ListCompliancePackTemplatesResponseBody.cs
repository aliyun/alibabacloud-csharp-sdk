// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListCompliancePackTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the compliance pack templates.</para>
        /// </summary>
        [NameInMap("CompliancePackTemplatesResult")]
        [Validation(Required=false)]
        public ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResult CompliancePackTemplatesResult { get; set; }
        public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResult : TeaModel {
            /// <summary>
            /// <para>A list of compliance pack templates.</para>
            /// </summary>
            [NameInMap("CompliancePackTemplates")]
            [Validation(Required=false)]
            public List<ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplates> CompliancePackTemplates { get; set; }
            public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplates : TeaModel {
                /// <summary>
                /// <para>The ID of the compliance pack template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ct-5f26ff4e06a300c4****</para>
                /// </summary>
                [NameInMap("CompliancePackTemplateId")]
                [Validation(Required=false)]
                public string CompliancePackTemplateId { get; set; }

                /// <summary>
                /// <para>The name of the compliance pack template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ClassifiedProtectionPreCheck</para>
                /// </summary>
                [NameInMap("CompliancePackTemplateName")]
                [Validation(Required=false)]
                public string CompliancePackTemplateName { get; set; }

                /// <summary>
                /// <para>A list of default rules in the compliance pack.</para>
                /// </summary>
                [NameInMap("ConfigRules")]
                [Validation(Required=false)]
                public List<ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRules> ConfigRules { get; set; }
                public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRules : TeaModel {
                    /// <summary>
                    /// <para>The parameters of the managed rule.</para>
                    /// </summary>
                    [NameInMap("ConfigRuleParameters")]
                    [Validation(Required=false)]
                    public List<ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRulesConfigRuleParameters> ConfigRuleParameters { get; set; }
                    public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRulesConfigRuleParameters : TeaModel {
                        /// <summary>
                        /// <para>The name of the parameter for the managed rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>necessity</para>
                        /// </summary>
                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                        /// <summary>
                        /// <para>The value of the parameter for the managed rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>asap</para>
                        /// </summary>
                        [NameInMap("ParameterValue")]
                        [Validation(Required=false)]
                        public string ParameterValue { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the parameter is required for the managed rule. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true: The parameter is required.</description></item>
                        /// <item><description>false: The parameter is not required.</description></item>
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
                    /// <para>The description of the control. This parameter is returned only for compliance packs that are created based on a regulation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>e) Possible known vulnerabilities should be found and remedied in a timely manner after adequate testing and evaluation.\nf) It shall be able to detect intrusion into important nodes and provide an alarm in case of serious intrusion events.</para>
                    /// </summary>
                    [NameInMap("ControlDescription")]
                    [Validation(Required=false)]
                    public string ControlDescription { get; set; }

                    /// <summary>
                    /// <para>The ID of the control.</para>
                    /// <remarks>
                    /// <para>This parameter appears only for regulatory compliance packages.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8.1.4.4</para>
                    /// </summary>
                    [NameInMap("ControlId")]
                    [Validation(Required=false)]
                    public string ControlId { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the rule can be quickly enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: The rule can be quickly enabled.</description></item>
                    /// <item><description>false: The rule cannot be quickly enabled.</description></item>
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
                    /// <para>If no vulnerabilities that are of the specified type and severity level and to be fixed exist on the running ECS instances that are protected by Security Center, the configuration is considered compliant. This rule does not apply to ECS instances that are not in the running state.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The identifier of the managed rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs-instance-updated-security-vul</para>
                    /// </summary>
                    [NameInMap("ManagedRuleIdentifier")]
                    [Validation(Required=false)]
                    public string ManagedRuleIdentifier { get; set; }

                    /// <summary>
                    /// <para>The name of the managed rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs-instance-updated-security-vul</para>
                    /// </summary>
                    [NameInMap("ManagedRuleName")]
                    [Validation(Required=false)]
                    public string ManagedRuleName { get; set; }

                    /// <summary>
                    /// <para>The resource types that are evaluated by the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACS::ECS::Instance</para>
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
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public int? RiskLevel { get; set; }

                }

                /// <summary>
                /// <para>The description of the compliance pack.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Checks the compliance of Alibaba Cloud resources based on the specific requirements of MLPS 2.0 Level 3.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The classification labels of the compliance pack.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Regulation</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp when the compliance pack was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1747983081</para>
                /// </summary>
                [NameInMap("LastUpdate")]
                [Validation(Required=false)]
                public int? LastUpdate { get; set; }

                /// <summary>
                /// <para>The risk level of the rules in the compliance pack. Valid values:</para>
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
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of compliance pack templates.</para>
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
        /// <para>D67FC82F-25AE-4268-A94C-3348340748F9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
