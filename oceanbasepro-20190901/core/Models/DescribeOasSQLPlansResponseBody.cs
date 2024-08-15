// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasSQLPlansResponseBody : TeaModel {
        /// <summary>
        /// The list of SQL execution plan.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeOasSQLPlansResponseBodyData> Data { get; set; }
        public class DescribeOasSQLPlansResponseBodyData : TeaModel {
            /// <summary>
            /// Average CPU time (in milliseconds) during the execution period.
            /// </summary>
            [NameInMap("AvgCpuTime")]
            [Validation(Required=false)]
            public double? AvgCpuTime { get; set; }

            /// <summary>
            /// Whether to bind the execution plan.
            /// </summary>
            [NameInMap("Bounded")]
            [Validation(Required=false)]
            public bool? Bounded { get; set; }

            /// <summary>
            /// Execution count.
            /// </summary>
            [NameInMap("Executions")]
            [Validation(Required=false)]
            public long? Executions { get; set; }

            /// <summary>
            /// First loading time.
            /// </summary>
            [NameInMap("FirstLoadTime")]
            [Validation(Required=false)]
            public string FirstLoadTime { get; set; }

            /// <summary>
            /// Whether to hit the diagnosis.
            /// </summary>
            [NameInMap("HitDiagnosis")]
            [Validation(Required=false)]
            public bool? HitDiagnosis { get; set; }

            /// <summary>
            /// Hit rate.
            /// </summary>
            [NameInMap("HitPercentage")]
            [Validation(Required=false)]
            public double? HitPercentage { get; set; }

            /// <summary>
            /// Merge version.
            /// </summary>
            [NameInMap("MergedVersion")]
            [Validation(Required=false)]
            public long? MergedVersion { get; set; }

            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public string OutlineId { get; set; }

            [NameInMap("OutlineStatus")]
            [Validation(Required=false)]
            public string OutlineStatus { get; set; }

            /// <summary>
            /// Execution plan.
            /// </summary>
            [NameInMap("PlanExplain")]
            [Validation(Required=false)]
            public DescribeOasSQLPlansResponseBodyDataPlanExplain PlanExplain { get; set; }
            public class DescribeOasSQLPlansResponseBodyDataPlanExplain : TeaModel {
                /// <summary>
                /// JSON string of the SQL execution plan.
                /// </summary>
                [NameInMap("PlanJsonString")]
                [Validation(Required=false)]
                public string PlanJsonString { get; set; }

            }

            /// <summary>
            /// The internal identifier of the SQL execution plan in the diagnostic system.
            /// </summary>
            [NameInMap("PlanHash")]
            [Validation(Required=false)]
            public string PlanHash { get; set; }

            /// <summary>
            /// Execution plan type.
            /// </summary>
            [NameInMap("PlanType")]
            [Validation(Required=false)]
            public string PlanType { get; set; }

            /// <summary>
            /// The internal unique identifier of the SQL execution plan in the diagnostic system.
            /// </summary>
            [NameInMap("PlanUnionHash")]
            [Validation(Required=false)]
            public string PlanUnionHash { get; set; }

            /// <summary>
            /// The list of the execution plan.
            /// </summary>
            [NameInMap("Plans")]
            [Validation(Required=false)]
            public List<DescribeOasSQLPlansResponseBodyDataPlans> Plans { get; set; }
            public class DescribeOasSQLPlansResponseBodyDataPlans : TeaModel {
                /// <summary>
                /// Average Application event waiting time (in milliseconds) during the execution period.
                /// </summary>
                [NameInMap("AvgApplicationWaitTime")]
                [Validation(Required=false)]
                public double? AvgApplicationWaitTime { get; set; }

                /// <summary>
                /// Average cache read count during the execution period.
                /// </summary>
                [NameInMap("AvgBufferGets")]
                [Validation(Required=false)]
                public double? AvgBufferGets { get; set; }

                /// <summary>
                /// Average Concurrency event waiting time (in milliseconds) during the execution period.
                /// </summary>
                [NameInMap("AvgConcurrencyWaitTime")]
                [Validation(Required=false)]
                public double? AvgConcurrencyWaitTime { get; set; }

                /// <summary>
                /// Average CPU time (in milliseconds) during the execution period.
                /// </summary>
                [NameInMap("AvgCpuTime")]
                [Validation(Required=false)]
                public double? AvgCpuTime { get; set; }

                /// <summary>
                /// The average physical read count during the execution period.
                /// </summary>
                [NameInMap("AvgDiskReads")]
                [Validation(Required=false)]
                public double? AvgDiskReads { get; set; }

                /// <summary>
                /// The average physical write count during the execution period.
                /// </summary>
                [NameInMap("AvgDiskWrites")]
                [Validation(Required=false)]
                public double? AvgDiskWrites { get; set; }

                /// <summary>
                /// Average interval waiting time (in milliseconds) during the execution period.
                /// </summary>
                [NameInMap("AvgElapsedTime")]
                [Validation(Required=false)]
                public double? AvgElapsedTime { get; set; }

                /// <summary>
                /// Average row processing waiting time (in milliseconds) during the execution period.
                /// </summary>
                [NameInMap("AvgRowProcessed")]
                [Validation(Required=false)]
                public double? AvgRowProcessed { get; set; }

                /// <summary>
                /// Average UserIo event waiting time (in milliseconds) during the execution period.
                /// </summary>
                [NameInMap("AvgUserIoWaitTime")]
                [Validation(Required=false)]
                public double? AvgUserIoWaitTime { get; set; }

                /// <summary>
                /// Collection time.
                /// </summary>
                [NameInMap("CollectTimeUs")]
                [Validation(Required=false)]
                public long? CollectTimeUs { get; set; }

                /// <summary>
                /// Percentage of delayed long-running queries.
                /// </summary>
                [NameInMap("DelayedLargeQueryPercentage")]
                [Validation(Required=false)]
                public double? DelayedLargeQueryPercentage { get; set; }

                /// <summary>
                /// The average execution count per second during the execution period.
                /// </summary>
                [NameInMap("ExecPs")]
                [Validation(Required=false)]
                public double? ExecPs { get; set; }

                /// <summary>
                /// The total number of executions during the execution period.
                /// </summary>
                [NameInMap("Executions")]
                [Validation(Required=false)]
                public long? Executions { get; set; }

                /// <summary>
                /// First time to load the plan.
                /// </summary>
                [NameInMap("FirstLoadTime")]
                [Validation(Required=false)]
                public string FirstLoadTime { get; set; }

                /// <summary>
                /// First loading time.
                /// </summary>
                [NameInMap("FirstLoadTimeUs")]
                [Validation(Required=false)]
                public long? FirstLoadTimeUs { get; set; }

                /// <summary>
                /// Whether to hit the diagnosis.
                /// </summary>
                [NameInMap("HitDiagnosis")]
                [Validation(Required=false)]
                public bool? HitDiagnosis { get; set; }

                /// <summary>
                /// Hit rate.
                /// </summary>
                [NameInMap("HitPercentage")]
                [Validation(Required=false)]
                public double? HitPercentage { get; set; }

                /// <summary>
                /// Percentage of completed long-running queries.
                /// </summary>
                [NameInMap("LargeQueryPercentage")]
                [Validation(Required=false)]
                public double? LargeQueryPercentage { get; set; }

                /// <summary>
                /// Merge version.
                /// </summary>
                [NameInMap("MergedVersion")]
                [Validation(Required=false)]
                public long? MergedVersion { get; set; }

                /// <summary>
                /// Database ID.
                /// </summary>
                [NameInMap("ObDbId")]
                [Validation(Required=false)]
                public long? ObDbId { get; set; }

                /// <summary>
                /// Server ID.
                /// </summary>
                [NameInMap("ObServerId")]
                [Validation(Required=false)]
                public long? ObServerId { get; set; }

                /// <summary>
                /// The outline_data parameter of the SQL execution plan.
                /// </summary>
                [NameInMap("OutlineData")]
                [Validation(Required=false)]
                public string OutlineData { get; set; }

                /// <summary>
                /// Outline ID.
                /// </summary>
                [NameInMap("OutlineId")]
                [Validation(Required=false)]
                public long? OutlineId { get; set; }

                /// <summary>
                /// The internal identifier of the SQL execution plan in the diagnostic system.
                /// </summary>
                [NameInMap("PlanHash")]
                [Validation(Required=false)]
                public string PlanHash { get; set; }

                /// <summary>
                /// The ID of the plan.
                /// </summary>
                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public long? PlanId { get; set; }

                /// <summary>
                /// Plan size.
                /// </summary>
                [NameInMap("PlanSize")]
                [Validation(Required=false)]
                public long? PlanSize { get; set; }

                /// <summary>
                /// Plan type, including LOCAL, REMOTE, DIST.
                /// </summary>
                [NameInMap("PlanType")]
                [Validation(Required=false)]
                public string PlanType { get; set; }

                /// <summary>
                /// The internal unique identifier of the SQL execution plan in the diagnostic system.
                /// </summary>
                [NameInMap("PlanUnionHash")]
                [Validation(Required=false)]
                public string PlanUnionHash { get; set; }

                /// <summary>
                /// Schema version.
                /// </summary>
                [NameInMap("SchemaVersion")]
                [Validation(Required=false)]
                public long? SchemaVersion { get; set; }

                /// <summary>
                /// The server where the SQL is executed.
                /// </summary>
                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

                /// <summary>
                /// The ID of the backend server instance.
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public long? ServerId { get; set; }

                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// Whether a full table scan is performed.
                /// </summary>
                [NameInMap("TableScan")]
                [Validation(Required=false)]
                public bool? TableScan { get; set; }

                /// <summary>
                /// Percentage of timeouts.
                /// </summary>
                [NameInMap("TimeoutPercentage")]
                [Validation(Required=false)]
                public double? TimeoutPercentage { get; set; }

                /// <summary>
                /// The unique identifier of the plan.
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            /// <summary>
            /// The SQL for the query.
            /// </summary>
            [NameInMap("QuerySql")]
            [Validation(Required=false)]
            public string QuerySql { get; set; }

            [NameInMap("TableScan")]
            [Validation(Required=false)]
            public bool? TableScan { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
