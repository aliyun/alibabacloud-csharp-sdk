// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSQLTuningAdvicesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSQLTuningAdvicesResponseBodyData> Data { get; set; }
        public class DescribeSQLTuningAdvicesResponseBodyData : TeaModel {
            [NameInMap("ColumnNames")]
            [Validation(Required=false)]
            public string ColumnNames { get; set; }

            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<DescribeSQLTuningAdvicesResponseBodyDataColumns> Columns { get; set; }
            public class DescribeSQLTuningAdvicesResponseBodyDataColumns : TeaModel {
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public string MaxValue { get; set; }

                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public string MinValue { get; set; }

                /// <summary>
                /// NDV
                /// </summary>
                [NameInMap("Ndv")]
                [Validation(Required=false)]
                public float? Ndv { get; set; }

            }

            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("LocalityType")]
            [Validation(Required=false)]
            public string LocalityType { get; set; }

            [NameInMap("Plan")]
            [Validation(Required=false)]
            public DescribeSQLTuningAdvicesResponseBodyDataPlan Plan { get; set; }
            public class DescribeSQLTuningAdvicesResponseBodyDataPlan : TeaModel {
                [NameInMap("AvgApplicationWaitTime")]
                [Validation(Required=false)]
                public float? AvgApplicationWaitTime { get; set; }

                [NameInMap("AvgBufferGets")]
                [Validation(Required=false)]
                public float? AvgBufferGets { get; set; }

                [NameInMap("AvgConcurrencyWaitTime")]
                [Validation(Required=false)]
                public float? AvgConcurrencyWaitTime { get; set; }

                [NameInMap("AvgCpuTime")]
                [Validation(Required=false)]
                public float? AvgCpuTime { get; set; }

                [NameInMap("AvgDiskReads")]
                [Validation(Required=false)]
                public float? AvgDiskReads { get; set; }

                [NameInMap("AvgDiskWrites")]
                [Validation(Required=false)]
                public float? AvgDiskWrites { get; set; }

                [NameInMap("AvgElapsedTime")]
                [Validation(Required=false)]
                public float? AvgElapsedTime { get; set; }

                [NameInMap("AvgRowProcessed")]
                [Validation(Required=false)]
                public float? AvgRowProcessed { get; set; }

                [NameInMap("AvgUserIoWaitTime")]
                [Validation(Required=false)]
                public float? AvgUserIoWaitTime { get; set; }

                [NameInMap("CollectTimeUs")]
                [Validation(Required=false)]
                public long? CollectTimeUs { get; set; }

                [NameInMap("DelayedLargeQueryPercentage")]
                [Validation(Required=false)]
                public float? DelayedLargeQueryPercentage { get; set; }

                [NameInMap("ExecPs")]
                [Validation(Required=false)]
                public float? ExecPs { get; set; }

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
                public float? HitPercentage { get; set; }

                [NameInMap("LargeQueryPercentage")]
                [Validation(Required=false)]
                public float? LargeQueryPercentage { get; set; }

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

                [NameInMap("SchemaVersion")]
                [Validation(Required=false)]
                public long? SchemaVersion { get; set; }

                [NameInMap("ServerSn")]
                [Validation(Required=false)]
                public string ServerSn { get; set; }

                [NameInMap("TableScan")]
                [Validation(Required=false)]
                public bool? TableScan { get; set; }

                [NameInMap("TimeoutPercentage")]
                [Validation(Required=false)]
                public float? TimeoutPercentage { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
