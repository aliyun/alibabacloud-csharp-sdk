// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateResourceComplianceByConfigRuleRequest : TeaModel {
        /// <summary>
        /// The ID of the account group.
        /// 
        /// For more information about how to query the ID of an account group, see [ListAggregators](~~255797~~).
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The compliance evaluation result of the resources. Valid values:
        /// 
        /// *   COMPLIANT: The resources are evaluated as compliant.
        /// *   NON_COMPLIANT: The resources are evaluated as non-compliant.
        /// *   NOT_APPLICABLE: The rule does not apply to your resources.
        /// *   INSUFFICIENT_DATA: No resource data is available.
        /// </summary>
        [NameInMap("ComplianceType")]
        [Validation(Required=false)]
        public string ComplianceType { get; set; }

        /// <summary>
        /// The ID of the rule.
        /// 
        /// For more information about how to query the ID of a rule, see [ListAggregateConfigRules](~~264148~~).
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        [NameInMap("ResourceAccountId")]
        [Validation(Required=false)]
        public long? ResourceAccountId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? ResourceOwnerId { get; set; }

    }

}
