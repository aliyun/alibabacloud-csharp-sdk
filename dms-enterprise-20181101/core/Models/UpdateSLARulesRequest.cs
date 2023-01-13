// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateSLARulesRequest : TeaModel {
        /// <summary>
        /// The ID of the task flow. You can call the [ListTaskFlow](~~424565~~) or [ListLhTaskFlowAndScenario](~~426672~~) operation to query the task flow ID.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The list of SLA rules.
        /// </summary>
        [NameInMap("SlaRuleList")]
        [Validation(Required=false)]
        public List<UpdateSLARulesRequestSlaRuleList> SlaRuleList { get; set; }
        public class UpdateSLARulesRequestSlaRuleList : TeaModel {
            /// <summary>
            /// The ID of the task flow.
            /// </summary>
            [NameInMap("DagId")]
            [Validation(Required=false)]
            public long? DagId { get; set; }

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
            /// The rule type. Valid values:
            /// 
            /// *   **0**: SLA rules for task flows
            /// *   **1**: SLA rules for nodes
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > :To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [View information about the current tenant](~~181330~~).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
