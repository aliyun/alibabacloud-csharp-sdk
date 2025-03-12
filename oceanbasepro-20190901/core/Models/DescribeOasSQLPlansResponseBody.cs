// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasSQLPlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of SQL execution plan.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeOasSQLPlansResponseBodyData> Data { get; set; }
        public class DescribeOasSQLPlansResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Average CPU time (in milliseconds) during the execution period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1875.34</para>
            /// </summary>
            [NameInMap("AvgCpuTime")]
            [Validation(Required=false)]
            public double? AvgCpuTime { get; set; }

            /// <summary>
            /// <para>Whether to bind the execution plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Bounded")]
            [Validation(Required=false)]
            public bool? Bounded { get; set; }

            /// <summary>
            /// <para>Execution count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Executions")]
            [Validation(Required=false)]
            public long? Executions { get; set; }

            /// <summary>
            /// <para>First loading time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-12T04:46:38Z</para>
            /// </summary>
            [NameInMap("FirstLoadTime")]
            [Validation(Required=false)]
            public string FirstLoadTime { get; set; }

            /// <summary>
            /// <para>Whether to hit the diagnosis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HitDiagnosis")]
            [Validation(Required=false)]
            public bool? HitDiagnosis { get; set; }

            /// <summary>
            /// <para>Hit rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("HitPercentage")]
            [Validation(Required=false)]
            public double? HitPercentage { get; set; }

            /// <summary>
            /// <para>Merge version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>513</para>
            /// </summary>
            [NameInMap("MergedVersion")]
            [Validation(Required=false)]
            public long? MergedVersion { get; set; }

            /// <summary>
            /// <para>The ID of the outline used by the execution plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3********</para>
            /// </summary>
            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public string OutlineId { get; set; }

            /// <summary>
            /// <para>The outline status of the execution plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Effective</b>: indicates that the outline_data and outlIne_content fields exactly match with each other. </description></item>
            /// <item><description><b>Unknown</b>: indicates that the outline status is unknown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Effective</para>
            /// </summary>
            [NameInMap("OutlineStatus")]
            [Validation(Required=false)]
            public string OutlineStatus { get; set; }

            /// <summary>
            /// <para>Execution plan.</para>
            /// </summary>
            [NameInMap("PlanExplain")]
            [Validation(Required=false)]
            public DescribeOasSQLPlansResponseBodyDataPlanExplain PlanExplain { get; set; }
            public class DescribeOasSQLPlansResponseBodyDataPlanExplain : TeaModel {
                /// <summary>
                /// <para>JSON string of the SQL execution plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;RootOperations\&quot;:[{\&quot;Children\</para>
                /// </summary>
                [NameInMap("PlanJsonString")]
                [Validation(Required=false)]
                public string PlanJsonString { get; set; }

            }

            /// <summary>
            /// <para>The internal identifier of the SQL execution plan in the diagnostic system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758<b><b>24913166</b></b></para>
            /// </summary>
            [NameInMap("PlanHash")]
            [Validation(Required=false)]
            public string PlanHash { get; set; }

            /// <summary>
            /// <para>Execution plan type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LOCAL</para>
            /// </summary>
            [NameInMap("PlanType")]
            [Validation(Required=false)]
            public string PlanType { get; set; }

            /// <summary>
            /// <para>The internal unique identifier of the SQL execution plan in the diagnostic system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;52c7c53<b><b>53e61b3f7586b17</b></b>ad&quot;</para>
            /// </summary>
            [NameInMap("PlanUnionHash")]
            [Validation(Required=false)]
            public string PlanUnionHash { get; set; }

            /// <summary>
            /// <para>The list of the execution plan.</para>
            /// </summary>
            [NameInMap("Plans")]
            [Validation(Required=false)]
            public List<DescribeOasSQLPlansResponseBodyDataPlans> Plans { get; set; }
            public class DescribeOasSQLPlansResponseBodyDataPlans : TeaModel {
                /// <summary>
                /// <para>Average Application event waiting time (in milliseconds) during the execution period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("AvgApplicationWaitTime")]
                [Validation(Required=false)]
                public double? AvgApplicationWaitTime { get; set; }

                /// <summary>
                /// <para>Average cache read count during the execution period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30137.03</para>
                /// </summary>
                [NameInMap("AvgBufferGets")]
                [Validation(Required=false)]
                public double? AvgBufferGets { get; set; }

                /// <summary>
                /// <para>Average Concurrency event waiting time (in milliseconds) during the execution period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("AvgConcurrencyWaitTime")]
                [Validation(Required=false)]
                public double? AvgConcurrencyWaitTime { get; set; }

                /// <summary>
                /// <para>Average CPU time (in milliseconds) during the execution period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1875.34</para>
                /// </summary>
                [NameInMap("AvgCpuTime")]
                [Validation(Required=false)]
                public double? AvgCpuTime { get; set; }

                /// <summary>
                /// <para>The average physical read count during the execution period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("AvgDiskReads")]
                [Validation(Required=false)]
                public double? AvgDiskReads { get; set; }

                /// <summary>
                /// <para>The average physical write count during the execution period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("AvgDiskWrites")]
                [Validation(Required=false)]
                public double? AvgDiskWrites { get; set; }

                /// <summary>
                /// <para>Average interval waiting time (in milliseconds) during the execution period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1876.78</para>
                /// </summary>
                [NameInMap("AvgElapsedTime")]
                [Validation(Required=false)]
                public double? AvgElapsedTime { get; set; }

                /// <summary>
                /// <para>Average row processing waiting time (in milliseconds) during the execution period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("AvgRowProcessed")]
                [Validation(Required=false)]
                public double? AvgRowProcessed { get; set; }

                /// <summary>
                /// <para>Average UserIo event waiting time (in milliseconds) during the execution period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("AvgUserIoWaitTime")]
                [Validation(Required=false)]
                public double? AvgUserIoWaitTime { get; set; }

                /// <summary>
                /// <para>Collection time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1684368****00000</para>
                /// </summary>
                [NameInMap("CollectTimeUs")]
                [Validation(Required=false)]
                public long? CollectTimeUs { get; set; }

                /// <summary>
                /// <para>Percentage of delayed long-running queries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("DelayedLargeQueryPercentage")]
                [Validation(Required=false)]
                public double? DelayedLargeQueryPercentage { get; set; }

                /// <summary>
                /// <para>The average execution count per second during the execution period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.31</para>
                /// </summary>
                [NameInMap("ExecPs")]
                [Validation(Required=false)]
                public double? ExecPs { get; set; }

                /// <summary>
                /// <para>The total number of executions during the execution period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Executions")]
                [Validation(Required=false)]
                public long? Executions { get; set; }

                /// <summary>
                /// <para>First time to load the plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-12T04:46:38Z</para>
                /// </summary>
                [NameInMap("FirstLoadTime")]
                [Validation(Required=false)]
                public string FirstLoadTime { get; set; }

                /// <summary>
                /// <para>First loading time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1684****03289441</para>
                /// </summary>
                [NameInMap("FirstLoadTimeUs")]
                [Validation(Required=false)]
                public long? FirstLoadTimeUs { get; set; }

                /// <summary>
                /// <para>Whether to hit the diagnosis.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HitDiagnosis")]
                [Validation(Required=false)]
                public bool? HitDiagnosis { get; set; }

                /// <summary>
                /// <para>Hit rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("HitPercentage")]
                [Validation(Required=false)]
                public double? HitPercentage { get; set; }

                /// <summary>
                /// <para>Percentage of completed long-running queries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("LargeQueryPercentage")]
                [Validation(Required=false)]
                public double? LargeQueryPercentage { get; set; }

                /// <summary>
                /// <para>Merge version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>513</para>
                /// </summary>
                [NameInMap("MergedVersion")]
                [Validation(Required=false)]
                public long? MergedVersion { get; set; }

                /// <summary>
                /// <para>Database ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11006****828</para>
                /// </summary>
                [NameInMap("ObDbId")]
                [Validation(Required=false)]
                public long? ObDbId { get; set; }

                /// <summary>
                /// <para>Server ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ObServerId")]
                [Validation(Required=false)]
                public long? ObServerId { get; set; }

                /// <summary>
                /// <para>The outline_data parameter of the SQL execution plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/*+ BEGIN_OUTLINE_DATA INDEX(@\&quot;SEL$1\</para>
                /// </summary>
                [NameInMap("OutlineData")]
                [Validation(Required=false)]
                public string OutlineData { get; set; }

                /// <summary>
                /// <para>Outline ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("OutlineId")]
                [Validation(Required=false)]
                public long? OutlineId { get; set; }

                /// <summary>
                /// <para>The internal identifier of the SQL execution plan in the diagnostic system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-86290582****886880</para>
                /// </summary>
                [NameInMap("PlanHash")]
                [Validation(Required=false)]
                public string PlanHash { get; set; }

                /// <summary>
                /// <para>The ID of the plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>590****</para>
                /// </summary>
                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public long? PlanId { get; set; }

                /// <summary>
                /// <para>Plan size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10****</para>
                /// </summary>
                [NameInMap("PlanSize")]
                [Validation(Required=false)]
                public long? PlanSize { get; set; }

                /// <summary>
                /// <para>Plan type, including LOCAL, REMOTE, DIST.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LOCAL</para>
                /// </summary>
                [NameInMap("PlanType")]
                [Validation(Required=false)]
                public string PlanType { get; set; }

                /// <summary>
                /// <para>The internal unique identifier of the SQL execution plan in the diagnostic system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;52c7c53<b><b>53e61b3f7586b17</b></b>ad&quot;</para>
                /// </summary>
                [NameInMap("PlanUnionHash")]
                [Validation(Required=false)]
                public string PlanUnionHash { get; set; }

                /// <summary>
                /// <para>Schema version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16838****3550464</para>
                /// </summary>
                [NameInMap("SchemaVersion")]
                [Validation(Required=false)]
                public long? SchemaVersion { get; set; }

                /// <summary>
                /// <para>The server where the SQL is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1db1a9us038****jio</para>
                /// </summary>
                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

                /// <summary>
                /// <para>The ID of the backend server instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public long? ServerId { get; set; }

                /// <summary>
                /// <para>SQL ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>46939C87ECA<b><b>95ED0FF64F44B</b></b></para>
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// <para>Whether a full table scan is performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("TableScan")]
                [Validation(Required=false)]
                public bool? TableScan { get; set; }

                /// <summary>
                /// <para>Percentage of timeouts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("TimeoutPercentage")]
                [Validation(Required=false)]
                public double? TimeoutPercentage { get; set; }

                /// <summary>
                /// <para>The unique identifier of the plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AAAAAAAAAAI<b><b>AAFoT2QAF--7W</b></b></para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            /// <summary>
            /// <para>The SQL for the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;select 1 from t&quot;</para>
            /// </summary>
            [NameInMap("QuerySql")]
            [Validation(Required=false)]
            public string QuerySql { get; set; }

            /// <summary>
            /// <para>Indicates whether full table scan is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("TableScan")]
            [Validation(Required=false)]
            public bool? TableScan { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
