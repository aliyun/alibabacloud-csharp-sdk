// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class StartAggregateConfigRuleEvaluationRequest : TeaModel {
        /// <summary>
        /// The ID of the account group.
        /// 
        /// For more information about how to obtain the ID of an account group, see [ListAggregators](~~255797~~).
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The ID of the compliance package.
        /// 
        /// For more information about how to obtain the ID of a compliance package, see [ListAggregateCompliancePacks](~~262059~~).
        /// 
        /// > You must configure either the `CompliancePackId` or `ConfigRuleId` parameter.
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <summary>
        /// The rule ID.
        /// 
        /// For more information about how to obtain the ID of a rule, see [ListAggregateConfigRules](~~264148~~).
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// Specifies whether to re-evaluate the ignored incompliant resource. Valid values:
        /// 
        /// *   true: The ignored incompliant resource based on the rule are re-evaluated.
        /// *   false: The ignored incompliant resource based on the rule are not re-evaluated.
        /// </summary>
        [NameInMap("RevertEvaluation")]
        [Validation(Required=false)]
        public bool? RevertEvaluation { get; set; }

    }

}
