// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListDataCheckReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The data list returned by the operation. For the structure of each element, see the child field descriptions.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListDataCheckReportResponseBodyData> Data { get; set; }
        public class ListDataCheckReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The validation job (batch) ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20001</para>
            /// </summary>
            [NameInMap("batchId")]
            [Validation(Required=false)]
            public long? BatchId { get; set; }

            /// <summary>
            /// <para>The number of columns checked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("checkColumCount")]
            [Validation(Required=false)]
            public long? CheckColumCount { get; set; }

            /// <summary>
            /// <para>The check result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No records.</description></item>
            /// <item><description>1: Passed.</description></item>
            /// <item><description>2: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("checkResult")]
            [Validation(Required=false)]
            public int? CheckResult { get; set; }

            /// <summary>
            /// <para>The number of rows compared.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("compareRowCount")]
            [Validation(Required=false)]
            public long? CompareRowCount { get; set; }

            /// <summary>
            /// <para>The job completion rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95.00%</para>
            /// </summary>
            [NameInMap("completionRate")]
            [Validation(Required=false)]
            public string CompletionRate { get; set; }

            /// <summary>
            /// <para>The difference rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.00%</para>
            /// </summary>
            [NameInMap("diffRate")]
            [Validation(Required=false)]
            public string DiffRate { get; set; }

            /// <summary>
            /// <para>The primary key or composite primary key of the destination. This is the comparison column on the destination used during row-by-row, column-by-column comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("dstCompareColumn")]
            [Validation(Required=false)]
            public string DstCompareColumn { get; set; }

            [NameInMap("dstHint")]
            [Validation(Required=false)]
            public string DstHint { get; set; }

            /// <summary>
            /// <para>The metric field of the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amount</para>
            /// </summary>
            [NameInMap("dstMetricName")]
            [Validation(Required=false)]
            public string DstMetricName { get; set; }

            /// <summary>
            /// <para>The SQL list of the destination.</para>
            /// </summary>
            [NameInMap("dstSqlList")]
            [Validation(Required=false)]
            public List<string> DstSqlList { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connection timeout</para>
            /// </summary>
            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The execution time of this check report detail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16 10:00:00</para>
            /// </summary>
            [NameInMap("execTime")]
            [Validation(Required=false)]
            public string ExecTime { get; set; }

            /// <summary>
            /// <para>The expected number of different rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("expDiffCount")]
            [Validation(Required=false)]
            public string ExpDiffCount { get; set; }

            /// <summary>
            /// <para>The completion time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("finishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the check is skipped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("isSkipped")]
            [Validation(Required=false)]
            public int? IsSkipped { get; set; }

            /// <summary>
            /// <para>The ID of the check sub-job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: INIT (pending).</description></item>
            /// <item><description>1: RUNNING (running).</description></item>
            /// <item><description>2: FINISHED (completed).</description></item>
            /// <item><description>3: STOPPED (stopped).</description></item>
            /// <item><description>4: FAIL (failed).</description></item>
            /// <item><description>6: READY (ready).</description></item>
            /// <item><description>7: SKIPPED (skipped).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public int? JobStatus { get; set; }

            /// <summary>
            /// <para>The number of metrics checked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("metricColumCount")]
            [Validation(Required=false)]
            public long? MetricColumCount { get; set; }

            /// <summary>
            /// <para>The number of metrics that passed the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("metricPassColumCount")]
            [Validation(Required=false)]
            public long? MetricPassColumCount { get; set; }

            /// <summary>
            /// <para>The number of rows that exist only on the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("onlyDstCount")]
            [Validation(Required=false)]
            public long? OnlyDstCount { get; set; }

            /// <summary>
            /// <para>The number of rows that exist only on the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("onlySrcCount")]
            [Validation(Required=false)]
            public long? OnlySrcCount { get; set; }

            /// <summary>
            /// <para>The number of columns that passed the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("passColumCount")]
            [Validation(Required=false)]
            public long? PassColumCount { get; set; }

            /// <summary>
            /// <para>The actual number of different rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("realDiffCount")]
            [Validation(Required=false)]
            public long? RealDiffCount { get; set; }

            /// <summary>
            /// <para>The actual number of identical rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("realSameCount")]
            [Validation(Required=false)]
            public long? RealSameCount { get; set; }

            /// <summary>
            /// <para>The ID of the check result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30001</para>
            /// </summary>
            [NameInMap("resultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <para>The name of the source column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amount</para>
            /// </summary>
            [NameInMap("sourceColumn")]
            [Validation(Required=false)]
            public string SourceColumn { get; set; }

            /// <summary>
            /// <para>The number of rows in the source data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("sourceCount")]
            [Validation(Required=false)]
            public string SourceCount { get; set; }

            /// <summary>
            /// <para>The source data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_demo</para>
            /// </summary>
            [NameInMap("sourceDataSource")]
            [Validation(Required=false)]
            public string SourceDataSource { get; set; }

            /// <summary>
            /// <para>The error message of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Table \&quot;src_db.src_table\&quot; doesn\&quot;t exist</para>
            /// </summary>
            [NameInMap("sourceError")]
            [Validation(Required=false)]
            public string SourceError { get; set; }

            /// <summary>
            /// <para>The GROUP BY clause of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("sourceGroupClause")]
            [Validation(Required=false)]
            public string SourceGroupClause { get; set; }

            /// <summary>
            /// <para>The source partition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=20260116</para>
            /// </summary>
            [NameInMap("sourcePartition")]
            [Validation(Required=false)]
            public string SourcePartition { get; set; }

            /// <summary>
            /// <para>The name of the source table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_demo</para>
            /// </summary>
            [NameInMap("sourceTable")]
            [Validation(Required=false)]
            public string SourceTable { get; set; }

            /// <summary>
            /// <para>The data type of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hive</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The WHERE clause of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a &gt; 0 and col_b = \&quot;x\&quot;</para>
            /// </summary>
            [NameInMap("sourceWhereClause")]
            [Validation(Required=false)]
            public string SourceWhereClause { get; set; }

            /// <summary>
            /// <para>The primary key or composite primary key of the source. This is the comparison column on the source used during row-by-row, column-by-column comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("srcCompareColumn")]
            [Validation(Required=false)]
            public string SrcCompareColumn { get; set; }

            [NameInMap("srcHint")]
            [Validation(Required=false)]
            public string SrcHint { get; set; }

            /// <summary>
            /// <para>The metric field of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amount</para>
            /// </summary>
            [NameInMap("srcMetricName")]
            [Validation(Required=false)]
            public string SrcMetricName { get; set; }

            /// <summary>
            /// <para>The SQL list of the source.</para>
            /// </summary>
            [NameInMap("srcSqlList")]
            [Validation(Required=false)]
            public List<string> SrcSqlList { get; set; }

            /// <summary>
            /// <para>The column of the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amount</para>
            /// </summary>
            [NameInMap("targetColumn")]
            [Validation(Required=false)]
            public string TargetColumn { get; set; }

            /// <summary>
            /// <para>The number of rows in the destination data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("targetCount")]
            [Validation(Required=false)]
            public string TargetCount { get; set; }

            /// <summary>
            /// <para>The data source of the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_demo</para>
            /// </summary>
            [NameInMap("targetDataSource")]
            [Validation(Required=false)]
            public string TargetDataSource { get; set; }

            /// <summary>
            /// <para>The error message of the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Table \&quot;dst_db.dst_table\&quot; doesn\&quot;t exist</para>
            /// </summary>
            [NameInMap("targetError")]
            [Validation(Required=false)]
            public string TargetError { get; set; }

            /// <summary>
            /// <para>The GROUP BY clause of the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("targetGroupClause")]
            [Validation(Required=false)]
            public string TargetGroupClause { get; set; }

            /// <summary>
            /// <para>The destination partition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=20260116</para>
            /// </summary>
            [NameInMap("targetPartition")]
            [Validation(Required=false)]
            public string TargetPartition { get; set; }

            /// <summary>
            /// <para>The destination table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_demo</para>
            /// </summary>
            [NameInMap("targetTable")]
            [Validation(Required=false)]
            public string TargetTable { get; set; }

            /// <summary>
            /// <para>The destination data source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hive</para>
            /// </summary>
            [NameInMap("targetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The destination WHERE clause.</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a &gt; 0 and col_b = \&quot;x\&quot;</para>
            /// </summary>
            [NameInMap("targetWhereClause")]
            [Validation(Required=false)]
            public string TargetWhereClause { get; set; }

            /// <summary>
            /// <para>The ID of the validation task configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("taskConfigId")]
            [Validation(Required=false)]
            public long? TaskConfigId { get; set; }

            /// <summary>
            /// <para>The validation template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data Volume Validation Template</para>
            /// </summary>
            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

            /// <summary>
            /// <para>The threshold for comparing grouped data volumes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("totalCountThreshold")]
            [Validation(Required=false)]
            public string TotalCountThreshold { get; set; }

        }

        /// <summary>
        /// <para>The error code. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The page size, which is the number of records returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues with this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success. A value of false indicates failure. If the call fails, check errCode and errMessage for details.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records that match the query conditions. This value is used for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
