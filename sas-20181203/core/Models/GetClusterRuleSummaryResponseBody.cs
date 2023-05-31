// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClusterRuleSummaryResponseBody : TeaModel {
        /// <summary>
        /// The overall information about the cluster defense rules.
        /// </summary>
        [NameInMap("ClusterRuleSummary")]
        [Validation(Required=false)]
        public GetClusterRuleSummaryResponseBodyClusterRuleSummary ClusterRuleSummary { get; set; }
        public class GetClusterRuleSummaryResponseBodyClusterRuleSummary : TeaModel {
            /// <summary>
            /// The number of disabled cluster defense rules.
            /// </summary>
            [NameInMap("CloseRuleCount")]
            [Validation(Required=false)]
            public int? CloseRuleCount { get; set; }

            /// <summary>
            /// The number of alerts that are triggered by the cluster defense rules in the last seven days.
            /// </summary>
            [NameInMap("InterceptionCount7Day")]
            [Validation(Required=false)]
            public long? InterceptionCount7Day { get; set; }

            /// <summary>
            /// The status of the container firewall feature. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
            /// </summary>
            [NameInMap("InterceptionSwitch")]
            [Validation(Required=false)]
            public int? InterceptionSwitch { get; set; }

            /// <summary>
            /// The interception mode.
            /// </summary>
            [NameInMap("InterceptionType")]
            [Validation(Required=false)]
            public int? InterceptionType { get; set; }

            /// <summary>
            /// The number of enabled cluster defense rules.
            /// </summary>
            [NameInMap("OpenRuleCount")]
            [Validation(Required=false)]
            public int? OpenRuleCount { get; set; }

            /// <summary>
            /// The total number of configured cluster defense rules.
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

            /// <summary>
            /// The number of recommended cluster defense rules.
            /// </summary>
            [NameInMap("SuggestRuleCount")]
            [Validation(Required=false)]
            public int? SuggestRuleCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
