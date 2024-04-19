// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListOperationPlansResponseBody : TeaModel {
        /// <summary>
        /// The operation plans.
        /// </summary>
        [NameInMap("plans")]
        [Validation(Required=false)]
        public List<ListOperationPlansResponseBodyPlans> Plans { get; set; }
        public class ListOperationPlansResponseBodyPlans : TeaModel {
            /// <summary>
            /// The cluster ID.
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The time when the operation plan was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// The expected end time of the plan.
            /// </summary>
            [NameInMap("end_time")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The operation plan ID.
            /// </summary>
            [NameInMap("plan_id")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// The expected start time of the plan.
            /// </summary>
            [NameInMap("start_time")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The plan status. Valid values:
            /// 
            /// *   scheduled
            /// *   Canceled
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The target ID.
            /// </summary>
            [NameInMap("target_id")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// The target type.
            /// </summary>
            [NameInMap("target_type")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// The plan type. Valid values:
            /// 
            /// *   cluster_upgrade
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
