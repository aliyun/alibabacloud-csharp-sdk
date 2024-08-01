// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class StartConfigRuleEvaluationRequest : TeaModel {
        /// <summary>
        /// The compliance package ID.
        /// 
        /// For more information about how to obtain the ID of a compliance package, see [ListCompliancePacks](https://help.aliyun.com/document_detail/606968.html).
        /// 
        /// >  You must configure either the `CompliancePackId` or `ConfigRuleId` parameter.
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <summary>
        /// The rule ID.
        /// 
        /// You can call the [ListConfigRules](https://help.aliyun.com/document_detail/609222.html) operation to obtain the rule ID.
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
