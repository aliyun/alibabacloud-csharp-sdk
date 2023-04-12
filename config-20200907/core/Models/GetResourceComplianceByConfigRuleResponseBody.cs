// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceComplianceByConfigRuleResponseBody : TeaModel {
        /// <summary>
        /// The compliance evaluation results returned.
        /// </summary>
        [NameInMap("ComplianceResult")]
        [Validation(Required=false)]
        public GetResourceComplianceByConfigRuleResponseBodyComplianceResult ComplianceResult { get; set; }
        public class GetResourceComplianceByConfigRuleResponseBodyComplianceResult : TeaModel {
            /// <summary>
            /// The information about the compliance evaluation.
            /// </summary>
            [NameInMap("Compliances")]
            [Validation(Required=false)]
            public List<GetResourceComplianceByConfigRuleResponseBodyComplianceResultCompliances> Compliances { get; set; }
            public class GetResourceComplianceByConfigRuleResponseBodyComplianceResultCompliances : TeaModel {
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
                /// The number of resources that have the compliance evaluation result. For example, if the value of the `ComplianceType` parameter is `COMPLIANT`, this parameter value indicates the number of compliant resources.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

            }

            /// <summary>
            /// The total number of evaluated resources.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
