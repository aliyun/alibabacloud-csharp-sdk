// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceComplianceByConfigRuleRequest : TeaModel {
        /// <summary>
        /// The compliance evaluation result of the resource. Valid values:
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
        /// The ID of the rule.
        /// 
        /// For more information about how to obtain the ID of a rule, see [ListConfigRules](https://help.aliyun.com/document_detail/169607.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

    }

}
