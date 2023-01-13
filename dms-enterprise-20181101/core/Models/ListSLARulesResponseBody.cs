// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSLARulesResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of SLA rules.
        /// </summary>
        [NameInMap("SLARuleList")]
        [Validation(Required=false)]
        public ListSLARulesResponseBodySLARuleList SLARuleList { get; set; }
        public class ListSLARulesResponseBodySLARuleList : TeaModel {
            [NameInMap("SLARule")]
            [Validation(Required=false)]
            public List<ListSLARulesResponseBodySLARuleListSLARule> SLARule { get; set; }
            public class ListSLARulesResponseBodySLARuleListSLARule : TeaModel {
                /// <summary>
                /// The ID of the task flow.
                /// </summary>
                [NameInMap("DagId")]
                [Validation(Required=false)]
                public long? DagId { get; set; }

                /// <summary>
                /// The ID of the SLA rule.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The timeout period. Unit: minutes.
                /// </summary>
                [NameInMap("IntervalMinutes")]
                [Validation(Required=false)]
                public int? IntervalMinutes { get; set; }

                /// <summary>
                /// The ID of the task node.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The type of the rule. Valid values:
                /// 
                /// *   **0**: an SLA rule for a task flow
                /// *   **1**: an SLA rule for a task node
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public int? RuleType { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
