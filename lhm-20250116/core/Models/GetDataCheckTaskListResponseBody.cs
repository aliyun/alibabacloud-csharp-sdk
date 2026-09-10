// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetDataCheckTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The task list.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetDataCheckTaskListResponseBodyData> Data { get; set; }
        public class GetDataCheckTaskListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The check result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: no record.</description></item>
            /// <item><description>1: passed.</description></item>
            /// <item><description>2: failed.</description></item>
            /// </list>
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
            /// <para>The check template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("checkTemplateId")]
            [Validation(Required=false)]
            public string CheckTemplateId { get; set; }

            /// <summary>
            /// <para>The check type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: data volume comparison.</description></item>
            /// <item><description>1: metric comparison.</description></item>
            /// <item><description>2: weak content comparison.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("checkType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>The destination data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2001</para>
            /// </summary>
            [NameInMap("dstDsId")]
            [Validation(Required=false)]
            public string DstDsId { get; set; }

            /// <summary>
            /// <para>The destination data source name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_demo</para>
            /// </summary>
            [NameInMap("dstDsName")]
            [Validation(Required=false)]
            public string DstDsName { get; set; }

            /// <summary>
            /// <para>The destination data source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hive</para>
            /// </summary>
            [NameInMap("dstDsType")]
            [Validation(Required=false)]
            public string DstDsType { get; set; }

            /// <summary>
            /// <para>The destination check engine ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2001</para>
            /// </summary>
            [NameInMap("dstEngineId")]
            [Validation(Required=false)]
            public string DstEngineId { get; set; }

            /// <summary>
            /// <para>The destination check engine name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>engine_demo</para>
            /// </summary>
            [NameInMap("dstEngineName")]
            [Validation(Required=false)]
            public string DstEngineName { get; set; }

            /// <summary>
            /// <para>The destination check engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tez</para>
            /// </summary>
            [NameInMap("dstEngineType")]
            [Validation(Required=false)]
            public string DstEngineType { get; set; }

            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16 10:00:00</para>
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
            /// <para>The execution status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: pending.</description></item>
            /// <item><description>1: running.</description></item>
            /// <item><description>2: stopped.</description></item>
            /// <item><description>3: failed.</description></item>
            /// <item><description>4: completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("execStatus")]
            [Validation(Required=false)]
            public int? ExecStatus { get; set; }

            /// <summary>
            /// <para>The execution duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16 10:00:00</para>
            /// </summary>
            [NameInMap("execTime")]
            [Validation(Required=false)]
            public string ExecTime { get; set; }

            /// <summary>
            /// <para>The execution type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: immediate execution.</description></item>
            /// <item><description>1: scheduled execution.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("executeType")]
            [Validation(Required=false)]
            public int? ExecuteType { get; set; }

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
            /// <para>The last modified time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16 10:00:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether scheduling is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Disabled.</description></item>
            /// <item><description>1: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("isScheduled")]
            [Validation(Required=false)]
            public int? IsScheduled { get; set; }

            /// <summary>
            /// <para>The latest batch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20001</para>
            /// </summary>
            [NameInMap("lastBatchId")]
            [Validation(Required=false)]
            public long? LastBatchId { get; set; }

            /// <summary>
            /// <para>The latest completed batch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>833</para>
            /// </summary>
            [NameInMap("lastFinishedId")]
            [Validation(Required=false)]
            public long? LastFinishedId { get; set; }

            /// <summary>
            /// <para>The check pass rate.</para>
            /// </summary>
            [NameInMap("passProcess")]
            [Validation(Required=false)]
            public Dictionary<string, object> PassProcess { get; set; }

            /// <summary>
            /// <para>The execution progress (0-1).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("process")]
            [Validation(Required=false)]
            public double? Process { get; set; }

            /// <summary>
            /// <para>The report time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01 12:00:00</para>
            /// </summary>
            [NameInMap("reportTime")]
            [Validation(Required=false)]
            public string ReportTime { get; set; }

            /// <summary>
            /// <para>The report title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data validation report</para>
            /// </summary>
            [NameInMap("reportTitle")]
            [Validation(Required=false)]
            public string ReportTitle { get; set; }

            /// <summary>
            /// <para>The number of skipped tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("skipTableNum")]
            [Validation(Required=false)]
            public long? SkipTableNum { get; set; }

            /// <summary>
            /// <para>The source data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("srcDsId")]
            [Validation(Required=false)]
            public string SrcDsId { get; set; }

            /// <summary>
            /// <para>The source data source name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_demo</para>
            /// </summary>
            [NameInMap("srcDsName")]
            [Validation(Required=false)]
            public string SrcDsName { get; set; }

            /// <summary>
            /// <para>The source data source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hive</para>
            /// </summary>
            [NameInMap("srcDsType")]
            [Validation(Required=false)]
            public string SrcDsType { get; set; }

            /// <summary>
            /// <para>The source check engine ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("srcEngineId")]
            [Validation(Required=false)]
            public string SrcEngineId { get; set; }

            /// <summary>
            /// <para>The source check engine name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>engine_demo</para>
            /// </summary>
            [NameInMap("srcEngineName")]
            [Validation(Required=false)]
            public string SrcEngineName { get; set; }

            /// <summary>
            /// <para>The source check engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tez</para>
            /// </summary>
            [NameInMap("srcEngineType")]
            [Validation(Required=false)]
            public string SrcEngineType { get; set; }

            /// <summary>
            /// <para>The start time.</para>
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

            /// <summary>
            /// <para>The task description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data validation task description</para>
            /// </summary>
            [NameInMap("taskDescription")]
            [Validation(Required=false)]
            public string TaskDescription { get; set; }

            /// <summary>
            /// <para>The creation mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: table-by-table fine-grained mode.</description></item>
            /// <item><description>1: same-schema batch mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("taskMode")]
            [Validation(Required=false)]
            public int? TaskMode { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data_check_task_demo</para>
            /// </summary>
            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The check template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Row Count Validation Template</para>
            /// </summary>
            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

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
        /// <para>The page size, which indicates the number of records returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues related to this call.</para>
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
        /// <para>The total number of records that match the query conditions. This parameter is used for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
