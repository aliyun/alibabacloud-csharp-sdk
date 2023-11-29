// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSQLPlansResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the execution plan.
        /// </summary>
        [NameInMap("SQLPlans")]
        [Validation(Required=false)]
        public List<DescribeSQLPlansResponseBodySQLPlans> SQLPlans { get; set; }
        public class DescribeSQLPlansResponseBodySQLPlans : TeaModel {
            /// <summary>
            /// The average execution duration, in ms.
            /// </summary>
            [NameInMap("AvgExecutionMS")]
            [Validation(Required=false)]
            public float? AvgExecutionMS { get; set; }

            /// <summary>
            /// The average execution duration when the database uses this execution plan, in ms.
            /// </summary>
            [NameInMap("AvgExecutionTimeMS")]
            [Validation(Required=false)]
            public long? AvgExecutionTimeMS { get; set; }

            /// <summary>
            /// The time when the plan was loaded for the first time, .
            /// </summary>
            [NameInMap("FirstLoadTime")]
            [Validation(Required=false)]
            public long? FirstLoadTime { get; set; }

            /// <summary>
            /// The time when the plan was loaded for the first time, in UTC +0.
            /// </summary>
            [NameInMap("FirstLoadTimeUTCString")]
            [Validation(Required=false)]
            public string FirstLoadTimeUTCString { get; set; }

            /// <summary>
            /// The number of hits.
            /// </summary>
            [NameInMap("HitCount")]
            [Validation(Required=false)]
            public int? HitCount { get; set; }

            /// <summary>
            /// The major compaction version.
            /// </summary>
            [NameInMap("MergedVersion")]
            [Validation(Required=false)]
            public int? MergedVersion { get; set; }

            /// <summary>
            /// The IP address of the node.
            /// </summary>
            [NameInMap("NodeIp")]
            [Validation(Required=false)]
            public string NodeIp { get; set; }

            /// <summary>
            /// The outline data.
            /// </summary>
            [NameInMap("OutlineData")]
            [Validation(Required=false)]
            public string OutlineData { get; set; }

            /// <summary>
            /// OutlineID.
            /// </summary>
            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public long? OutlineId { get; set; }

            /// <summary>
            /// The time when the plan was bound.
            /// </summary>
            [NameInMap("OutlineTime")]
            [Validation(Required=false)]
            public long? OutlineTime { get; set; }

            /// <summary>
            /// The time when the plan was bound, in UTC +0.
            /// </summary>
            [NameInMap("OutlineTimeUTCString")]
            [Validation(Required=false)]
            public string OutlineTimeUTCString { get; set; }

            /// <summary>
            /// The complete execution plan of the SQL statement.
            /// </summary>
            [NameInMap("PlanFull")]
            [Validation(Required=false)]
            public string PlanFull { get; set; }

            /// <summary>
            /// The ID of the SQL execution plan in the database.
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public int? PlanId { get; set; }

            /// <summary>
            /// The information about the plan.
            /// </summary>
            [NameInMap("PlanInfo")]
            [Validation(Required=false)]
            public string PlanInfo { get; set; }

            /// <summary>
            /// The unique identifier of the SQL execution plan in the diagnostic system.
            /// </summary>
            [NameInMap("PlanUnionHash")]
            [Validation(Required=false)]
            public string PlanUnionHash { get; set; }

            /// <summary>
            /// The query SQL statement.
            /// </summary>
            [NameInMap("QuerySQL")]
            [Validation(Required=false)]
            public string QuerySQL { get; set; }

        }

    }

}
