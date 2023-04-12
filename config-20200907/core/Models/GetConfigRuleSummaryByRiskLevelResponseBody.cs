// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigRuleSummaryByRiskLevelResponseBody : TeaModel {
        /// <summary>
        /// The summary of compliance evaluation results by rule risk level.
        /// </summary>
        [NameInMap("ConfigRuleSummaries")]
        [Validation(Required=false)]
        public List<GetConfigRuleSummaryByRiskLevelResponseBodyConfigRuleSummaries> ConfigRuleSummaries { get; set; }
        public class GetConfigRuleSummaryByRiskLevelResponseBodyConfigRuleSummaries : TeaModel {
            /// <summary>
            /// The number of rules against which specific resources are evaluated as compliant.
            /// </summary>
            [NameInMap("CompliantCount")]
            [Validation(Required=false)]
            public int? CompliantCount { get; set; }

            /// <summary>
            /// The number of rules against which specific resources are evaluated as non-compliant.
            /// </summary>
            [NameInMap("NonCompliantCount")]
            [Validation(Required=false)]
            public int? NonCompliantCount { get; set; }

            /// <summary>
            /// The risk level of the resources that are not compliant with the rules. Valid values:
            /// 
            /// *   1: high risk level.
            /// *   2: medium risk level.
            /// *   3: low risk level.
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
