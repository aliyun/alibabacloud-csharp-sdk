// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateAggregateCompliancePackRequest : TeaModel {
        /// <summary>
        /// The ID of the account group.
        /// 
        /// For more information about how to obtain the ID of an account group, see [ListAggregators](~~255797~~).
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The client token that you want to use to ensure the idempotency of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.``
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the compliance package.
        /// 
        /// For more information about how to obtain the ID of a compliance package, see [ListAggregateCompliancePacks](~~262059~~).
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <summary>
        /// The name of the compliance package.
        /// 
        /// For more information about how to obtain the name of a compliance package, see [ListAggregateCompliancePacks](~~262059~~).
        /// </summary>
        [NameInMap("CompliancePackName")]
        [Validation(Required=false)]
        public string CompliancePackName { get; set; }

        /// <summary>
        /// The rules in the compliance package.
        /// 
        /// If you leave this parameter empty, the rules in the compliance package remain unchanged. If you configure this parameter, Cloud Config replaces the existing rules in the compliance package with the specified rules.
        /// </summary>
        [NameInMap("ConfigRules")]
        [Validation(Required=false)]
        public List<UpdateAggregateCompliancePackRequestConfigRules> ConfigRules { get; set; }
        public class UpdateAggregateCompliancePackRequestConfigRules : TeaModel {
            /// <summary>
            /// The ID of the rule. If you configure this parameter, Cloud Config adds the rule of the specified ID to the compliance package.
            /// 
            /// You only need to configure the `ManagedRuleIdentifier` or `ConfigRuleId` parameter. If you configure both parameters, the value of the `ConfigRuleId` parameter takes precedence. For more information about how to obtain the ID of a rule, see [ListAggregateConfigRules](~~264148~~).
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
            /// The input parameter settings of the rule.
            /// </summary>
            [NameInMap("ConfigRuleParameters")]
            [Validation(Required=false)]
            public List<UpdateAggregateCompliancePackRequestConfigRulesConfigRuleParameters> ConfigRuleParameters { get; set; }
            public class UpdateAggregateCompliancePackRequestConfigRulesConfigRuleParameters : TeaModel {
                /// <summary>
                /// The name of the input parameter.
                /// 
                /// You must configure the `ParameterName` and `ParameterValue` parameters or neither of them. If the managed rule has an input parameter but no default value exists, you must configure this parameter. For more information about how to obtain the name of an input parameter for a managed rule, see [ListCompliancePackTemplates](~~261176~~).
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// The value of the input parameter.
                /// 
                /// You must configure the `ParameterName` and `ParameterValue` parameters or neither of them. If the managed rule has an input parameter but no default value exists you must configure this parameter. For more information about how to obtain the value of an input parameter for a managed rule, see [ListCompliancePackTemplates](~~261176~~).
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// The description of the rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the managed rule. Cloud Config automatically creates a managed rule based on the specified ID and adds the rule to the compliance package.
            /// 
            /// You only need to configure the `ManagedRuleIdentifier` or `ConfigRuleId` parameter. If you configure both parameters, the value of the `ConfigRuleId` parameter takes precedence. For more information about how to obtain the ID of a managed rule, see [ListCompliancePackTemplates](~~261176~~).
            /// </summary>
            [NameInMap("ManagedRuleIdentifier")]
            [Validation(Required=false)]
            public string ManagedRuleIdentifier { get; set; }

            /// <summary>
            /// The risk level of the resources that are not compliant with the rule. Valid values:
            /// 
            /// *   1: high risk level
            /// *   2: medium risk level
            /// *   3: low risk level
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

        }

        /// <summary>
        /// The description of the compliance package.
        /// 
        /// For more information about how to obtain the description of a compliance package, see [ListCompliancePacks](~~262059~~).
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the resource that you do not want to evaluate by using the compliance package. Separate multiple resource IDs with commas (,).
        /// </summary>
        [NameInMap("ExcludeResourceIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceIdsScope { get; set; }

        /// <summary>
        /// The ID of the region whose resources you want to evaluate by using the compliance package. Separate multiple region IDs with commas (,).
        /// </summary>
        [NameInMap("RegionIdsScope")]
        [Validation(Required=false)]
        public string RegionIdsScope { get; set; }

        /// <summary>
        /// The ID of the resource group whose resources you want to evaluate by using the compliance package. Separate multiple resource group IDs with commas (,).
        /// </summary>
        [NameInMap("ResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ResourceGroupIdsScope { get; set; }

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
        /// The tag key of the resource that you want to evaluate by using the compliance package.
        /// </summary>
        [NameInMap("TagKeyScope")]
        [Validation(Required=false)]
        public string TagKeyScope { get; set; }

        /// <summary>
        /// The tag value of the resource that you want to evaluate by using the compliance package.
        /// 
        /// >  You must configure the TagValueScope parameter together with the TagKeyScope parameter.
        /// </summary>
        [NameInMap("TagValueScope")]
        [Validation(Required=false)]
        public string TagValueScope { get; set; }

    }

}
