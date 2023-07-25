// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetCompliancePackResponseBody : TeaModel {
        /// <summary>
        /// The details of the compliance package.
        /// </summary>
        [NameInMap("CompliancePack")]
        [Validation(Required=false)]
        public GetCompliancePackResponseBodyCompliancePack CompliancePack { get; set; }
        public class GetCompliancePackResponseBodyCompliancePack : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account to which the compliance package belongs.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// The ID of the compliance package.
            /// </summary>
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }

            /// <summary>
            /// The name of the compliance package.
            /// </summary>
            [NameInMap("CompliancePackName")]
            [Validation(Required=false)]
            public string CompliancePackName { get; set; }

            /// <summary>
            /// The ID of the compliance package template.
            /// </summary>
            [NameInMap("CompliancePackTemplateId")]
            [Validation(Required=false)]
            public string CompliancePackTemplateId { get; set; }

            /// <summary>
            /// The rules in the compliance package.
            /// </summary>
            [NameInMap("ConfigRules")]
            [Validation(Required=false)]
            public List<GetCompliancePackResponseBodyCompliancePackConfigRules> ConfigRules { get; set; }
            public class GetCompliancePackResponseBodyCompliancePackConfigRules : TeaModel {
                /// <summary>
                /// The rule ID.
                /// </summary>
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                /// <summary>
                /// The name of the rule.
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                /// <summary>
                /// The details of the input parameter of the rule.
                /// </summary>
                [NameInMap("ConfigRuleParameters")]
                [Validation(Required=false)]
                public List<GetCompliancePackResponseBodyCompliancePackConfigRulesConfigRuleParameters> ConfigRuleParameters { get; set; }
                public class GetCompliancePackResponseBodyCompliancePackConfigRulesConfigRuleParameters : TeaModel {
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
                /// The description of the rule.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The identifier of the managed rule.
                /// </summary>
                [NameInMap("ManagedRuleIdentifier")]
                [Validation(Required=false)]
                public string ManagedRuleIdentifier { get; set; }

                [NameInMap("ResourceTypesScope")]
                [Validation(Required=false)]
                public string ResourceTypesScope { get; set; }

                /// <summary>
                /// The risk level of the resources that are not compliant with the rule. Valid values:
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
            /// The timestamp when the compliance package was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// The description of the compliance package.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The risk level of the resources that are not compliant with the rules in the compliance package. Valid values:
            /// 
            /// *   1: high
            /// *   2: medium
            /// *   3: low
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// The resource group for which the compliance package took effect.
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public GetCompliancePackResponseBodyCompliancePackScope Scope { get; set; }
            public class GetCompliancePackResponseBodyCompliancePackScope : TeaModel {
                /// <summary>
                /// The ID of the resource that you do not want to evaluate by using the compliance package.
                /// </summary>
                [NameInMap("ExcludeResourceIdsScope")]
                [Validation(Required=false)]
                public string ExcludeResourceIdsScope { get; set; }

                /// <summary>
                /// The ID of the region whose resources you want to evaluate by using the compliance package.
                /// </summary>
                [NameInMap("RegionIdsScope")]
                [Validation(Required=false)]
                public string RegionIdsScope { get; set; }

                /// <summary>
                /// The ID of the resource group whose resources you want to evaluate by using the compliance package.
                /// </summary>
                [NameInMap("ResourceGroupIdsScope")]
                [Validation(Required=false)]
                public string ResourceGroupIdsScope { get; set; }

                /// <summary>
                /// The tag key of the resource that you want to evaluate by using the compliance package.
                /// </summary>
                [NameInMap("TagKeyScope")]
                [Validation(Required=false)]
                public string TagKeyScope { get; set; }

                /// <summary>
                /// The tag value of the resource that you want to evaluate by using the compliance package.
                /// </summary>
                [NameInMap("TagValueScope")]
                [Validation(Required=false)]
                public string TagValueScope { get; set; }

            }

            /// <summary>
            /// The status of the compliance package. Valid values:
            /// 
            /// *   ACTIVE: The compliance package is normal.
            /// *   CREATING: The compliance package is being created.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
