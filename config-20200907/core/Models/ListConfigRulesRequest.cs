// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigRulesRequest : TeaModel {
        /// <summary>
        /// The compliance evaluation result of the rule. Valid values:
        /// 
        /// *   COMPLIANT: The resources are evaluated as compliant.
        /// *   NON_COMPLIANT: The resources are evaluated as non-compliant.
        /// *   NOT_APPLICABLE: The rule does not apply to the resources.
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
        /// The query keyword.
        /// 
        /// You can perform a fuzzy search by rule ID, rule name, rule description, or managed rule ID.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Page numbers start from 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Valid values: 1 to 100. A minimum of 1 entry can be returned per page. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The type of the resources to be evaluated based on the rule.
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

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

}
