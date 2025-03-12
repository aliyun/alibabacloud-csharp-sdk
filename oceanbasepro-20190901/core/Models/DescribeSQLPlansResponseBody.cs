// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSQLPlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the execution plan.</para>
        /// </summary>
        [NameInMap("SQLPlans")]
        [Validation(Required=false)]
        public List<DescribeSQLPlansResponseBodySQLPlans> SQLPlans { get; set; }
        public class DescribeSQLPlansResponseBodySQLPlans : TeaModel {
            /// <summary>
            /// <para>The average execution duration, in ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AvgExecutionMS")]
            [Validation(Required=false)]
            public float? AvgExecutionMS { get; set; }

            /// <summary>
            /// <para>The average execution duration when the database uses this execution plan, in ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>288</para>
            /// </summary>
            [NameInMap("AvgExecutionTimeMS")]
            [Validation(Required=false)]
            public long? AvgExecutionTimeMS { get; set; }

            /// <summary>
            /// <para>The time when the plan was loaded for the first time, .</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641492303000</para>
            /// </summary>
            [NameInMap("FirstLoadTime")]
            [Validation(Required=false)]
            public long? FirstLoadTime { get; set; }

            /// <summary>
            /// <para>The time when the plan was loaded for the first time, in UTC +0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-06T18:05:03Z</para>
            /// </summary>
            [NameInMap("FirstLoadTimeUTCString")]
            [Validation(Required=false)]
            public string FirstLoadTimeUTCString { get; set; }

            /// <summary>
            /// <para>The number of hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HitCount")]
            [Validation(Required=false)]
            public int? HitCount { get; set; }

            /// <summary>
            /// <para>The major compaction version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132</para>
            /// </summary>
            [NameInMap("MergedVersion")]
            [Validation(Required=false)]
            public int? MergedVersion { get; set; }

            /// <summary>
            /// <para>The IP address of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp16niirq4zdmgvm****</para>
            /// </summary>
            [NameInMap("NodeIp")]
            [Validation(Required=false)]
            public string NodeIp { get; set; }

            /// <summary>
            /// <para>The outline data.</para>
            /// </summary>
            [NameInMap("OutlineData")]
            [Validation(Required=false)]
            public string OutlineData { get; set; }

            /// <summary>
            /// <para>OutlineID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public long? OutlineId { get; set; }

            /// <summary>
            /// <para>The time when the plan was bound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641492303000</para>
            /// </summary>
            [NameInMap("OutlineTime")]
            [Validation(Required=false)]
            public long? OutlineTime { get; set; }

            /// <summary>
            /// <para>The time when the plan was bound, in UTC +0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-06T18:05:03Z</para>
            /// </summary>
            [NameInMap("OutlineTimeUTCString")]
            [Validation(Required=false)]
            public string OutlineTimeUTCString { get; set; }

            /// <summary>
            /// <para>The complete execution plan of the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHY_TABLE_SCAN | bmsql_order_line | 40 ******</para>
            /// </summary>
            [NameInMap("PlanFull")]
            [Validation(Required=false)]
            public string PlanFull { get; set; }

            /// <summary>
            /// <para>The ID of the SQL execution plan in the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9114</para>
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public int? PlanId { get; set; }

            /// <summary>
            /// <para>The information about the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHY_TABLE_SCAN</para>
            /// </summary>
            [NameInMap("PlanInfo")]
            [Validation(Required=false)]
            public string PlanInfo { get; set; }

            /// <summary>
            /// <para>The unique identifier of the SQL execution plan in the diagnostic system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>859ef7ee<b><b>b23ac98cdeb2476f</b></b></para>
            /// </summary>
            [NameInMap("PlanUnionHash")]
            [Validation(Required=false)]
            public string PlanUnionHash { get; set; }

            /// <summary>
            /// <para>The query SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT ol_i_id, ***, *** FROM aaa</para>
            /// </summary>
            [NameInMap("QuerySQL")]
            [Validation(Required=false)]
            public string QuerySQL { get; set; }

        }

    }

}
