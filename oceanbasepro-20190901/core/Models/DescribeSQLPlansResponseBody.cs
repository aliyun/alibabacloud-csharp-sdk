// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSQLPlansResponseBody : TeaModel {
        /// <summary>
        /// The return result of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// master
        /// </summary>
        [NameInMap("SQLPlans")]
        [Validation(Required=false)]
        public List<DescribeSQLPlansResponseBodySQLPlans> SQLPlans { get; set; }
        public class DescribeSQLPlansResponseBodySQLPlans : TeaModel {
            /// <summary>
            /// The time when the plan was bound.
            /// </summary>
            [NameInMap("AvgExecutionMS")]
            [Validation(Required=false)]
            public float? AvgExecutionMS { get; set; }

            /// <summary>
            /// The time when the plan was loaded for the first time, in UTC +0.
            /// </summary>
            [NameInMap("AvgExecutionTimeMS")]
            [Validation(Required=false)]
            public long? AvgExecutionTimeMS { get; set; }

            [NameInMap("FirstLoadTime")]
            [Validation(Required=false)]
            public long? FirstLoadTime { get; set; }

            /// <summary>
            /// Example 1
            /// </summary>
            [NameInMap("FirstLoadTimeUTCString")]
            [Validation(Required=false)]
            public string FirstLoadTimeUTCString { get; set; }

            /// <summary>
            /// It is an Alibaba Cloud asset management and configuration tool, with which you can manage multiple Alibaba Cloud products and services by using commands. It is easy to use and a good helper in migration to cloud.
            /// </summary>
            [NameInMap("HitCount")]
            [Validation(Required=false)]
            public int? HitCount { get; set; }

            /// <summary>
            /// The unique identifier of the SQL execution plan in the diagnostic system.
            /// </summary>
            [NameInMap("MergedVersion")]
            [Validation(Required=false)]
            public int? MergedVersion { get; set; }

            /// <summary>
            /// The complete execution plan of the SQL statement.
            /// </summary>
            [NameInMap("NodeIp")]
            [Validation(Required=false)]
            public string NodeIp { get; set; }

            /// <summary>
            /// The information about the plan.
            /// </summary>
            [NameInMap("OutlineData")]
            [Validation(Required=false)]
            public string OutlineData { get; set; }

            /// <summary>
            /// SQLID.
            /// </summary>
            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public long? OutlineId { get; set; }

            /// <summary>
            /// The ID of the SQL execution plan in the database.
            /// </summary>
            [NameInMap("OutlineTime")]
            [Validation(Required=false)]
            public long? OutlineTime { get; set; }

            /// <summary>
            /// The major compaction version.
            /// </summary>
            [NameInMap("OutlineTimeUTCString")]
            [Validation(Required=false)]
            public string OutlineTimeUTCString { get; set; }

            /// <summary>
            /// The information about the execution plan.
            /// </summary>
            [NameInMap("PlanFull")]
            [Validation(Required=false)]
            public string PlanFull { get; set; }

            /// <summary>
            /// OutlineID.
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public int? PlanId { get; set; }

            [NameInMap("PlanInfo")]
            [Validation(Required=false)]
            public string PlanInfo { get; set; }

            /// <summary>
            /// The return result of the request.
            /// </summary>
            [NameInMap("PlanUnionHash")]
            [Validation(Required=false)]
            public string PlanUnionHash { get; set; }

            /// <summary>
            /// The request ID.
            /// </summary>
            [NameInMap("QuerySQL")]
            [Validation(Required=false)]
            public string QuerySQL { get; set; }

        }

    }

}
