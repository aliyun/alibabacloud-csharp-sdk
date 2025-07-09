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
            /// <summary>
            /// <b>Example:</b>
            /// <para>c1;c2;c3</para>
            /// </summary>
            [NameInMap("ColumnNames")]
            [Validation(Required=false)]
            public string ColumnNames { get; set; }

            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<DescribeSQLTuningAdvicesResponseBodyDataColumns> Columns { get; set; }
            public class DescribeSQLTuningAdvicesResponseBodyDataColumns : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public string MaxValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public string MinValue { get; set; }

                /// <summary>
                /// <para>NDV</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Ndv")]
                [Validation(Required=false)]
                public double? Ndv { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Local/Global</para>
            /// </summary>
            [NameInMap("LocalityType")]
            [Validation(Required=false)]
            public string LocalityType { get; set; }

            [NameInMap("Plan")]
            [Validation(Required=false)]
            public DescribeSQLTuningAdvicesResponseBodyDataPlan Plan { get; set; }
            public class DescribeSQLTuningAdvicesResponseBodyDataPlan : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgApplicationWaitTime")]
                [Validation(Required=false)]
                public float? AvgApplicationWaitTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgBufferGets")]
                [Validation(Required=false)]
                public float? AvgBufferGets { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgConcurrencyWaitTime")]
                [Validation(Required=false)]
                public float? AvgConcurrencyWaitTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100.36</para>
                /// </summary>
                [NameInMap("AvgCpuTime")]
                [Validation(Required=false)]
                public float? AvgCpuTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgDiskReads")]
                [Validation(Required=false)]
                public float? AvgDiskReads { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgDiskWrites")]
                [Validation(Required=false)]
                public float? AvgDiskWrites { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>713.62</para>
                /// </summary>
                [NameInMap("AvgElapsedTime")]
                [Validation(Required=false)]
                public float? AvgElapsedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AvgRowProcessed")]
                [Validation(Required=false)]
                public float? AvgRowProcessed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgUserIoWaitTime")]
                [Validation(Required=false)]
                public float? AvgUserIoWaitTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1672358400000000</para>
                /// </summary>
                [NameInMap("CollectTimeUs")]
                [Validation(Required=false)]
                public long? CollectTimeUs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DelayedLargeQueryPercentage")]
                [Validation(Required=false)]
                public float? DelayedLargeQueryPercentage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.45</para>
                /// </summary>
                [NameInMap("ExecPs")]
                [Validation(Required=false)]
                public float? ExecPs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2062</para>
                /// </summary>
                [NameInMap("Executions")]
                [Validation(Required=false)]
                public long? Executions { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-12-30T02:25:30.576Z</para>
                /// </summary>
                [NameInMap("FirstLoadTime")]
                [Validation(Required=false)]
                public string FirstLoadTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1672367130576163</para>
                /// </summary>
                [NameInMap("FirstLoadTimeUs")]
                [Validation(Required=false)]
                public long? FirstLoadTimeUs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HitDiagnosis")]
                [Validation(Required=false)]
                public bool? HitDiagnosis { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>66.8</para>
                /// </summary>
                [NameInMap("HitPercentage")]
                [Validation(Required=false)]
                public float? HitPercentage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LargeQueryPercentage")]
                [Validation(Required=false)]
                public float? LargeQueryPercentage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MergedVersion")]
                [Validation(Required=false)]
                public long? MergedVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1108307720799259</para>
                /// </summary>
                [NameInMap("ObDbId")]
                [Validation(Required=false)]
                public long? ObDbId { get; set; }

                /// <summary>
                /// <para>server  ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObServerId")]
                [Validation(Required=false)]
                public long? ObServerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("OutlineData")]
                [Validation(Required=false)]
                public string OutlineData { get; set; }

                /// <summary>
                /// <para>Outline ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OutlineId")]
                [Validation(Required=false)]
                public long? OutlineId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>-86290582****886880</para>
                /// </summary>
                [NameInMap("PlanHash")]
                [Validation(Required=false)]
                public string PlanHash { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>818</para>
                /// </summary>
                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public long? PlanId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>49216</para>
                /// </summary>
                [NameInMap("PlanSize")]
                [Validation(Required=false)]
                public long? PlanSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LOCAL</para>
                /// </summary>
                [NameInMap("PlanType")]
                [Validation(Required=false)]
                public string PlanType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1672367130529680</para>
                /// </summary>
                [NameInMap("SchemaVersion")]
                [Validation(Required=false)]
                public long? SchemaVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-bp1<em><b><b>sw64dhb</b></b></em></para>
                /// </summary>
                [NameInMap("ServerSn")]
                [Validation(Required=false)]
                public string ServerSn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("TableScan")]
                [Validation(Required=false)]
                public bool? TableScan { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TimeoutPercentage")]
                [Validation(Required=false)]
                public float? TimeoutPercentage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AAAAAAAAAAEAAAAAAAADMgAF8QJQwIUj</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_table</para>
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PLAN_BINDING/INDEX_CREATION</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
