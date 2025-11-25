// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListOperationPlansForRegionResponseBody : TeaModel {
        [NameInMap("plans")]
        [Validation(Required=false)]
        public List<ListOperationPlansForRegionResponseBodyPlans> Plans { get; set; }
        public class ListOperationPlansForRegionResponseBodyPlans : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>c29ced64b3dfe4f33b57ca0aa9f68****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-11-21T20:01:22+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-11-22T18:00:00+08:00</para>
            /// </summary>
            [NameInMap("end_time")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>P-655c9c127e0e6603ef00****</para>
            /// </summary>
            [NameInMap("plan_id")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-11-22T15:18:00+08:00</para>
            /// </summary>
            [NameInMap("start_time")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Scheduled</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("state_reason")]
            [Validation(Required=false)]
            public ListOperationPlansForRegionResponseBodyPlansStateReason StateReason { get; set; }
            public class ListOperationPlansForRegionResponseBodyPlansStateReason : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c29ced64b3dfe4f33b57ca0aa9f68****</para>
            /// </summary>
            [NameInMap("target_id")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("target_type")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>T-681ac448b23ced010600****</para>
            /// </summary>
            [NameInMap("task_id")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CLUSTER_UPGRADE_MASTER</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
