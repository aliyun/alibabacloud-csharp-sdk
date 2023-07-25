// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListCompliancePackTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The information about the compliance package templates returned.
        /// </summary>
        [NameInMap("CompliancePackTemplatesResult")]
        [Validation(Required=false)]
        public ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResult CompliancePackTemplatesResult { get; set; }
        public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResult : TeaModel {
            /// <summary>
            /// An array that contains the compliance package templates.
            /// </summary>
            [NameInMap("CompliancePackTemplates")]
            [Validation(Required=false)]
            public List<ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplates> CompliancePackTemplates { get; set; }
            public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplates : TeaModel {
                /// <summary>
                /// The ID of the compliance package template.
                /// </summary>
                [NameInMap("CompliancePackTemplateId")]
                [Validation(Required=false)]
                public string CompliancePackTemplateId { get; set; }

                /// <summary>
                /// The name of the compliance package template.
                /// </summary>
                [NameInMap("CompliancePackTemplateName")]
                [Validation(Required=false)]
                public string CompliancePackTemplateName { get; set; }

                /// <summary>
                /// An array that contains the managed rules in the compliance package.
                /// </summary>
                [NameInMap("ConfigRules")]
                [Validation(Required=false)]
                public List<ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRules> ConfigRules { get; set; }
                public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRules : TeaModel {
                    /// <summary>
                    /// The input parameters of the managed rule.
                    /// </summary>
                    [NameInMap("ConfigRuleParameters")]
                    [Validation(Required=false)]
                    public List<ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRulesConfigRuleParameters> ConfigRuleParameters { get; set; }
                    public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRulesConfigRuleParameters : TeaModel {
                        /// <summary>
                        /// The name of the input parameter.
                        /// </summary>
                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                        /// <summary>
                        /// The value of the input parameter.
                        /// </summary>
                        [NameInMap("ParameterValue")]
                        [Validation(Required=false)]
                        public string ParameterValue { get; set; }

                        /// <summary>
                        /// Indicates whether the input parameter is required. Valid values:
                        /// 
                        /// *   true: The input parameter is required.
                        /// *   false: The input parameter is optional.
                        /// </summary>
                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                    }

                    /// <summary>
                    /// The description of the regulation. This parameter is available only for regulation compliance packages.
                    /// </summary>
                    [NameInMap("ControlDescription")]
                    [Validation(Required=false)]
                    public string ControlDescription { get; set; }

                    /// <summary>
                    /// The ID of the regulation.
                    /// 
                    /// > This parameter is available only for regulation compliance packages.
                    /// </summary>
                    [NameInMap("ControlId")]
                    [Validation(Required=false)]
                    public string ControlId { get; set; }

                    /// <summary>
                    /// Indicates whether the rule was enabled together with the compliance package. Default value: false. The value true indicates that the rule was enabled together with the compliance package. Valid values:
                    /// 
                    /// *   true
                    /// *   false
                    /// </summary>
                    [NameInMap("DefaultEnable")]
                    [Validation(Required=false)]
                    public bool? DefaultEnable { get; set; }

                    /// <summary>
                    /// The description of the managed rule.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The ID of the managed rule.
                    /// </summary>
                    [NameInMap("ManagedRuleIdentifier")]
                    [Validation(Required=false)]
                    public string ManagedRuleIdentifier { get; set; }

                    /// <summary>
                    /// The name of the managed rule.
                    /// </summary>
                    [NameInMap("ManagedRuleName")]
                    [Validation(Required=false)]
                    public string ManagedRuleName { get; set; }

                    /// <summary>
                    /// 规则评估的资源类型。
                    /// </summary>
                    [NameInMap("ResourceTypesScope")]
                    [Validation(Required=false)]
                    public string ResourceTypesScope { get; set; }

                    /// <summary>
                    /// The risk level of the resources that are not compliant with the managed rule. Valid values:
                    /// 
                    /// *   1: high
                    /// *   2: medium
                    /// *   3: low
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public int? RiskLevel { get; set; }

                }

                /// <summary>
                /// The description of the compliance package.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The tag of the compliance package.
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// The time when the compliance package was last updated.
                /// </summary>
                [NameInMap("LastUpdate")]
                [Validation(Required=false)]
                public int? LastUpdate { get; set; }

                /// <summary>
                /// The risk level of the resources that are not compliant with the managed rules in the compliance package. Valid values:
                /// 
                /// *   1: high
                /// *   2: medium
                /// *   3: low
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of the compliance package templates returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
