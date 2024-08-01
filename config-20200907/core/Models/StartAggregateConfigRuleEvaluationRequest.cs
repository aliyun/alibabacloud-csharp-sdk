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
        /// For more information about how to obtain the ID of an account group, see [ListAggregators](https://help.aliyun.com/document_detail/255797.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The ID of the compliance package.
        /// 
        /// For more information about how to obtain the ID of a compliance package, see [ListAggregateCompliancePacks](https://help.aliyun.com/document_detail/262059.html).
        /// 
        /// > You must configure either the `CompliancePackId` or `ConfigRuleId` parameter.
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <summary>
        /// The rule ID.
        /// 
        /// For more information about how to query the ID of a rule, see [ListAggregateConfigRules](https://help.aliyun.com/document_detail/264148.html).
        /// 
        /// >  You must configure either the `CompliancePackId` or `ConfigRuleId` parameter.
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// Specifies whether to re-evaluate the ignored non-compliant resource. Valid values:
        /// 
        /// *   true: re-evaluates the ignored non-compliant resource based on the rule.
        /// *   false (default): does not re-evaluate the ignored non-compliant resource based on the rule.
        /// </summary>
        [NameInMap("RevertEvaluation")]
        [Validation(Required=false)]
        public bool? RevertEvaluation { get; set; }

    }

}
