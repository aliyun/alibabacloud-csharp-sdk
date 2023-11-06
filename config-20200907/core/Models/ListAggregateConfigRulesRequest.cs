// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateConfigRulesRequest : TeaModel {
        /// <summary>
        /// The ID of the account group.
        /// 
        /// For more information about how to obtain the ID of an account group, see [ListAggregators](~~255797~~).
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The compliance evaluation result. Valid values:
        /// 
        /// *   COMPLIANT: The resource is evaluated as compliant.
        /// *   NON_COMPLIANT: The resource is evaluated as non-compliant.
        /// *   NOT_APPLICABLE: The rule does not apply to the resource.
        /// *   INSUFFICIENT_DATA: No resource data is available.
        /// </summary>
        [NameInMap("ComplianceType")]
        [Validation(Required=false)]
        public string ComplianceType { get; set; }

        /// <summary>
        /// The name of the rule.
        /// </summary>
        [NameInMap("ConfigRuleName")]
        [Validation(Required=false)]
        public string ConfigRuleName { get; set; }

        /// <summary>
        /// The status of the rule. Valid values:
        /// 
        /// *   ACTIVE: The rule is enabled.
        /// *   DELETING: The rule is being deleted.
        /// *   EVALUATING: The rule is being used to evaluate resource configurations.
        /// *   INACTIVE: The rule is disabled.
        /// </summary>
        [NameInMap("ConfigRuleState")]
        [Validation(Required=false)]
        public string ConfigRuleState { get; set; }

        /// <summary>
        /// The keyword that you want to use to query the rules.
        /// 
        /// You can perform a fuzzy search by rule ID, rule name, rule description, or managed rule ID.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Valid values: 1 to 100. Minimum value: 1. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Resource type for the rule to evaluate.
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

        /// <summary>
        /// The risk level of the resources that do not comply with the rule. Valid values:
        /// 
        /// *   1: high
        /// *   2: medium
        /// *   3: low
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

    }

}
