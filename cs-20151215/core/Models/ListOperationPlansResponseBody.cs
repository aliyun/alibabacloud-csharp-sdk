// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListOperationPlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation plans.</para>
        /// </summary>
        [NameInMap("plans")]
        [Validation(Required=false)]
        public List<ListOperationPlansResponseBodyPlans> Plans { get; set; }
        public class ListOperationPlansResponseBodyPlans : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c29ced64b3dfe4f33b57ca0aa9f68****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The time when the operation plan was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-21T20:01:22+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The expected end time of the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-22T18:00:00+08:00</para>
            /// </summary>
            [NameInMap("end_time")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The operation plan ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>P-655c9c127e0e6603ef00****</para>
            /// </summary>
            [NameInMap("plan_id")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <para>The expected start time of the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-22T15:18:00+08:00</para>
            /// </summary>
            [NameInMap("start_time")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The plan status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>scheduled</description></item>
            /// <item><description>Canceled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>scheduled</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The target ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c29ced64b3dfe4f33b57ca0aa9f68****</para>
            /// </summary>
            [NameInMap("target_id")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The target type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("target_type")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The plan type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cluster_upgrade</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cluster_upgrade</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
