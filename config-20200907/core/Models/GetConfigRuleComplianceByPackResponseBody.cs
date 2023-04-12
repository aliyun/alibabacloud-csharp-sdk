// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigRuleComplianceByPackResponseBody : TeaModel {
        /// <summary>
        /// The information about the compliance evaluation results returned.
        /// </summary>
        [NameInMap("ConfigRuleComplianceResult")]
        [Validation(Required=false)]
        public GetConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResult ConfigRuleComplianceResult { get; set; }
        public class GetConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResult : TeaModel {
            /// <summary>
            /// The ID of the compliance package.
            /// </summary>
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }

            /// <summary>
            /// The rule enabled in the compliance package and the compliance evaluation result returned by the rule.
            /// </summary>
            [NameInMap("ConfigRuleCompliances")]
            [Validation(Required=false)]
            public List<GetConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResultConfigRuleCompliances> ConfigRuleCompliances { get; set; }
            public class GetConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResultConfigRuleCompliances : TeaModel {
                /// <summary>
                /// The compliance evaluation result. Valid values:
                /// 
                /// *   COMPLIANT: The relevant resources are evaluated as compliant.
                /// *   NON_COMPLIANT: The relevant resources are evaluated as non-compliant.
                /// *   NOT_APPLICABLE: The rule does not apply to your resources.
                /// *   INSUFFICIENT_DATA: No resource data is available.
                /// </summary>
                [NameInMap("ComplianceType")]
                [Validation(Required=false)]
                public string ComplianceType { get; set; }

                /// <summary>
                /// The ID of the rule enabled in the compliance package.
                /// </summary>
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                /// <summary>
                /// The name of the rule enabled in the compliance package.
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

            }

            /// <summary>
            /// The number of rules against which specific resources are evaluated as non-compliant.
            /// </summary>
            [NameInMap("NonCompliantCount")]
            [Validation(Required=false)]
            public int? NonCompliantCount { get; set; }

            /// <summary>
            /// The total number of rules enabled in the compliance package.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
