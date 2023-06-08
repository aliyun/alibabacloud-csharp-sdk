// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasSQLPlansResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeOasSQLPlansResponseBodyData> Data { get; set; }
        public class DescribeOasSQLPlansResponseBodyData : TeaModel {
            [NameInMap("AvgCpuTime")]
            [Validation(Required=false)]
            public double? AvgCpuTime { get; set; }

            [NameInMap("Bounded")]
            [Validation(Required=false)]
            public bool? Bounded { get; set; }

            [NameInMap("Executions")]
            [Validation(Required=false)]
            public long? Executions { get; set; }

            [NameInMap("FirstLoadTime")]
            [Validation(Required=false)]
            public string FirstLoadTime { get; set; }

            [NameInMap("HitDiagnosis")]
            [Validation(Required=false)]
            public bool? HitDiagnosis { get; set; }

            [NameInMap("HitPercentage")]
            [Validation(Required=false)]
            public double? HitPercentage { get; set; }

            [NameInMap("MergedVersion")]
            [Validation(Required=false)]
            public long? MergedVersion { get; set; }

            [NameInMap("PlanExplain")]
            [Validation(Required=false)]
            public DescribeOasSQLPlansResponseBodyDataPlanExplain PlanExplain { get; set; }
            public class DescribeOasSQLPlansResponseBodyDataPlanExplain : TeaModel {
                [NameInMap("PlanJsonString")]
                [Validation(Required=false)]
                public string PlanJsonString { get; set; }

            }

            [NameInMap("PlanHash")]
            [Validation(Required=false)]
            public string PlanHash { get; set; }

            [NameInMap("PlanType")]
            [Validation(Required=false)]
            public string PlanType { get; set; }

            [NameInMap("PlanUnionHash")]
            [Validation(Required=false)]
            public string PlanUnionHash { get; set; }

            [NameInMap("Plans")]
            [Validation(Required=false)]
            public List<DescribeOasSQLPlansResponseBodyDataPlans> Plans { get; set; }
            public class DescribeOasSQLPlansResponseBodyDataPlans : TeaModel {
                [NameInMap("AvgApplicationWaitTime")]
                [Validation(Required=false)]
                public double? AvgApplicationWaitTime { get; set; }

                [NameInMap("AvgBufferGets")]
                [Validation(Required=false)]
                public double? AvgBufferGets { get; set; }

                [NameInMap("AvgConcurrencyWaitTime")]
                [Validation(Required=false)]
                public double? AvgConcurrencyWaitTime { get; set; }

                [NameInMap("AvgCpuTime")]
                [Validation(Required=false)]
                public double? AvgCpuTime { get; set; }

                [NameInMap("AvgDiskReads")]
                [Validation(Required=false)]
                public double? AvgDiskReads { get; set; }

                [NameInMap("AvgDiskWrites")]
                [Validation(Required=false)]
                public double? AvgDiskWrites { get; set; }

                [NameInMap("AvgElapsedTime")]
                [Validation(Required=false)]
                public double? AvgElapsedTime { get; set; }

                [NameInMap("AvgRowProcessed")]
                [Validation(Required=false)]
                public double? AvgRowProcessed { get; set; }

                [NameInMap("AvgUserIoWaitTime")]
                [Validation(Required=false)]
                public double? AvgUserIoWaitTime { get; set; }

                [NameInMap("CollectTimeUs")]
                [Validation(Required=false)]
                public long? CollectTimeUs { get; set; }

                [NameInMap("DelayedLargeQueryPercentage")]
                [Validation(Required=false)]
                public double? DelayedLargeQueryPercentage { get; set; }

                [NameInMap("ExecPs")]
                [Validation(Required=false)]
                public double? ExecPs { get; set; }

                [NameInMap("Executions")]
                [Validation(Required=false)]
                public long? Executions { get; set; }

                [NameInMap("FirstLoadTime")]
                [Validation(Required=false)]
                public string FirstLoadTime { get; set; }

                [NameInMap("FirstLoadTimeUs")]
                [Validation(Required=false)]
                public long? FirstLoadTimeUs { get; set; }

                [NameInMap("HitDiagnosis")]
                [Validation(Required=false)]
                public bool? HitDiagnosis { get; set; }

                [NameInMap("HitPercentage")]
                [Validation(Required=false)]
                public double? HitPercentage { get; set; }

                [NameInMap("LargeQueryPercentage")]
                [Validation(Required=false)]
                public double? LargeQueryPercentage { get; set; }

                [NameInMap("MergedVersion")]
                [Validation(Required=false)]
                public long? MergedVersion { get; set; }

                [NameInMap("ObDbId")]
                [Validation(Required=false)]
                public long? ObDbId { get; set; }

                /// <summary>
                /// server  ID。
                /// </summary>
                [NameInMap("ObServerId")]
                [Validation(Required=false)]
                public long? ObServerId { get; set; }

                [NameInMap("OutlineData")]
                [Validation(Required=false)]
                public string OutlineData { get; set; }

                /// <summary>
                /// Outline ID。
                /// </summary>
                [NameInMap("OutlineId")]
                [Validation(Required=false)]
                public long? OutlineId { get; set; }

                [NameInMap("PlanHash")]
                [Validation(Required=false)]
                public string PlanHash { get; set; }

                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public long? PlanId { get; set; }

                [NameInMap("PlanSize")]
                [Validation(Required=false)]
                public long? PlanSize { get; set; }

                [NameInMap("PlanType")]
                [Validation(Required=false)]
                public string PlanType { get; set; }

                [NameInMap("PlanUnionHash")]
                [Validation(Required=false)]
                public string PlanUnionHash { get; set; }

                [NameInMap("SchemaVersion")]
                [Validation(Required=false)]
                public long? SchemaVersion { get; set; }

                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public long? ServerId { get; set; }

                [NameInMap("TableScan")]
                [Validation(Required=false)]
                public bool? TableScan { get; set; }

                [NameInMap("TimeoutPercentage")]
                [Validation(Required=false)]
                public double? TimeoutPercentage { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            [NameInMap("QuerySql")]
            [Validation(Required=false)]
            public string QuerySql { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
