// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListDataCheckReportStepResponseBody : TeaModel {
        /// <summary>
        /// <para>The data list returned by the operation. For the structure of each element, see the child field descriptions.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListDataCheckReportStepResponseBodyData> Data { get; set; }
        public class ListDataCheckReportStepResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The shard boundary information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R[1-&gt;1000)</para>
            /// </summary>
            [NameInMap("boundary")]
            [Validation(Required=false)]
            public string Boundary { get; set; }

            /// <summary>
            /// <para>The number of verified fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("checkColumCount")]
            [Validation(Required=false)]
            public long? CheckColumCount { get; set; }

            /// <summary>
            /// <para>The destination data volume. For single-SQL verification, this indicates the data volume of the destination result set. For data volume verification and full verification, this indicates the total data volume on the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("dstCount")]
            [Validation(Required=false)]
            public string DstCount { get; set; }

            /// <summary>
            /// <para>The SQL statement executed on the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM dst_table;</para>
            /// </summary>
            [NameInMap("dstSql")]
            [Validation(Required=false)]
            public string DstSql { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("errMessage")]
            [Validation(Required=false)]
            public string ErrMessage { get; set; }

            /// <summary>
            /// <para>The reserved field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The job end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("gmtEnd")]
            [Validation(Required=false)]
            public string GmtEnd { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The job start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("gmtStart")]
            [Validation(Required=false)]
            public string GmtStart { get; set; }

            /// <summary>
            /// <para>The primary key ID that uniquely identifies a record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the data is consistent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: inconsistent.</description></item>
            /// <item><description>1: consistent.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isConsistent")]
            [Validation(Required=false)]
            public int? IsConsistent { get; set; }

            /// <summary>
            /// <para>The unique job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            /// <summary>
            /// <para>The number of verified metrics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("metricColumCount")]
            [Validation(Required=false)]
            public long? MetricColumCount { get; set; }

            /// <summary>
            /// <para>The number of metrics that passed verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("metricPassColumCount")]
            [Validation(Required=false)]
            public long? MetricPassColumCount { get; set; }

            /// <summary>
            /// <para>The number of fields that passed verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("passColumCount")]
            [Validation(Required=false)]
            public long? PassColumCount { get; set; }

            /// <summary>
            /// <para>The unique ID of the verification result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30001</para>
            /// </summary>
            [NameInMap("resultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <para>The list of label names.</para>
            /// </summary>
            [NameInMap("signNameList")]
            [Validation(Required=false)]
            public List<string> SignNameList { get; set; }

            /// <summary>
            /// <para>The source partition name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=20260116</para>
            /// </summary>
            [NameInMap("sourcePtName")]
            [Validation(Required=false)]
            public string SourcePtName { get; set; }

            /// <summary>
            /// <para>The source data volume. For single-SQL verification, this indicates the data volume of the source result set. For data volume verification and full verification, this indicates the total data volume on the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("srcCount")]
            [Validation(Required=false)]
            public string SrcCount { get; set; }

            /// <summary>
            /// <para>The SQL statement executed on the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM src_table;</para>
            /// </summary>
            [NameInMap("srcSql")]
            [Validation(Required=false)]
            public string SrcSql { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: created.</description></item>
            /// <item><description>1: running.</description></item>
            /// <item><description>2: completed.</description></item>
            /// <item><description>3: stopped.</description></item>
            /// <item><description>4: canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The step ID that uniquely identifies an execution step within the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("stepId")]
            [Validation(Required=false)]
            public string StepId { get; set; }

            /// <summary>
            /// <para>The destination partition name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=20260116</para>
            /// </summary>
            [NameInMap("targetPtName")]
            [Validation(Required=false)]
            public string TargetPtName { get; set; }

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
        /// <para>Indicates whether the call is successful. A value of true indicates success. A value of false indicates failure. If the call fails, check errCode and errMessage for troubleshooting.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records that meet the query conditions. This value is used for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
