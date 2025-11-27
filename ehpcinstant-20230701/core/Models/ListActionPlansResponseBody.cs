// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListActionPlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of execution plan results.</para>
        /// </summary>
        [NameInMap("ActionPlans")]
        [Validation(Required=false)]
        public List<ListActionPlansResponseBodyActionPlans> ActionPlans { get; set; }
        public class ListActionPlansResponseBodyActionPlans : TeaModel {
            /// <summary>
            /// <para>The ID of the execution plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-hz036ubmx2qmw93k****</para>
            /// </summary>
            [NameInMap("ActionPlanId")]
            [Validation(Required=false)]
            public string ActionPlanId { get; set; }

            /// <summary>
            /// <para>The name of the execution plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestActionPlan</para>
            /// </summary>
            [NameInMap("ActionPlanName")]
            [Validation(Required=false)]
            public string ActionPlanName { get; set; }

            /// <summary>
            /// <para>The time when the execution plan was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-10 17:58:24</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The status of the execution plan. The possible values are as follows:</para>
            /// <list type="bullet">
            /// <item><description>Active Instant tasks are dynamically managed only when the execution plan is in the Active state.</description></item>
            /// <item><description>Inactive Instant tasks are no longer managed by execution plans in the Inactive state.</description></item>
            /// <item><description>Deleting: The execution plan is being deleted. You cannot modify the parameters of an execution plan in this state.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the execution plan was last modified. The time follows the ISO 8601 standard and UTC +0. The format is yyyy-MM-ddTHH:mmZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-10 17:58:24</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Indicates the read position returned by the current call. An empty value means all data has been read.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d2db86scXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total data count under the current request conditions (optional; not returned by default).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
