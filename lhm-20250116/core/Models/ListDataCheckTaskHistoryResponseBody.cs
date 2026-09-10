// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListDataCheckTaskHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The data list returned by the operation. For the element structure, see the child field descriptions.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListDataCheckTaskHistoryResponseBodyData> Data { get; set; }
        public class ListDataCheckTaskHistoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The batch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20001</para>
            /// </summary>
            [NameInMap("batchId")]
            [Validation(Required=false)]
            public long? BatchId { get; set; }

            /// <summary>
            /// <para>The business field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lhm</para>
            /// </summary>
            [NameInMap("biz")]
            [Validation(Required=false)]
            public string Biz { get; set; }

            /// <summary>
            /// <para>The execution result. Valid values: no record, passed, or not passed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("checkResult")]
            [Validation(Required=false)]
            public int? CheckResult { get; set; }

            /// <summary>
            /// <para>The number of checked tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("checkTableNum")]
            [Validation(Required=false)]
            public long? CheckTableNum { get; set; }

            /// <summary>
            /// <para>The concurrency of the batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("concurrency")]
            [Validation(Required=false)]
            public long? Concurrency { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user001</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The scheduling cycle expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 2 * * ?</para>
            /// </summary>
            [NameInMap("cronExp")]
            [Validation(Required=false)]
            public string CronExp { get; set; }

            /// <summary>
            /// <para>The end time, in the format of YYYY-MM-DD HH:MM:SS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16 12:00:00</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

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
            /// <para>The number of error tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("errorTableNum")]
            [Validation(Required=false)]
            public long? ErrorTableNum { get; set; }

            /// <summary>
            /// <para>The execution status. Valid values: pending, running, stopped, failed, or completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("execStatus")]
            [Validation(Required=false)]
            public int? ExecStatus { get; set; }

            /// <summary>
            /// <para>The execution duration, in the format of HH:MM:SS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16 10:00:00</para>
            /// </summary>
            [NameInMap("execTime")]
            [Validation(Required=false)]
            public string ExecTime { get; set; }

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
            /// <para>2026-01-16 10:00:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16 10:00:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The updater.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user001</para>
            /// </summary>
            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The original batch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("originBatchId")]
            [Validation(Required=false)]
            public long? OriginBatchId { get; set; }

            /// <summary>
            /// <para>The check pass rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.95</para>
            /// </summary>
            [NameInMap("passProcess")]
            [Validation(Required=false)]
            public double? PassProcess { get; set; }

            /// <summary>
            /// <para>The pass rate (export report field), calculated by dividing the number of passed tables by the total number of checked tables. The value is returned as a string with a percent sign and two decimal places (for example, 100.00%). If no checked table data exists, the value is -.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.00%</para>
            /// </summary>
            [NameInMap("passProcessExport")]
            [Validation(Required=false)]
            public string PassProcessExport { get; set; }

            /// <summary>
            /// <para>The task progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.95</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public double? Progress { get; set; }

            /// <summary>
            /// <para>The check report time, which is the completion time of the last job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01 12:00:00</para>
            /// </summary>
            [NameInMap("reportTime")]
            [Validation(Required=false)]
            public string ReportTime { get; set; }

            /// <summary>
            /// <para>The check report title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data Validation Report</para>
            /// </summary>
            [NameInMap("reportTitle")]
            [Validation(Required=false)]
            public string ReportTitle { get; set; }

            /// <summary>
            /// <para>The scheduled task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("scheduleId")]
            [Validation(Required=false)]
            public long? ScheduleId { get; set; }

            /// <summary>
            /// <para>The task number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SEQ20260116001</para>
            /// </summary>
            [NameInMap("seqId")]
            [Validation(Required=false)]
            public string SeqId { get; set; }

            /// <summary>
            /// <para>The number of skipped tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("skipTableNum")]
            [Validation(Required=false)]
            public int? SkipTableNum { get; set; }

            /// <summary>
            /// <para>The start time, in the format of YYYY-MM-DD HH:MM:SS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16 10:00:00</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The number of successful tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95</para>
            /// </summary>
            [NameInMap("successfulTableNum")]
            [Validation(Required=false)]
            public long? SuccessfulTableNum { get; set; }

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
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
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
