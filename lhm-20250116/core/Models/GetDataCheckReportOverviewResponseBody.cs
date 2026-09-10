// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetDataCheckReportOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDataCheckReportOverviewResponseBodyData Data { get; set; }
        public class GetDataCheckReportOverviewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the validation job (batch).</para>
            /// 
            /// <b>Example:</b>
            /// <para>20001</para>
            /// </summary>
            [NameInMap("batchId")]
            [Validation(Required=false)]
            public long? BatchId { get; set; }

            /// <summary>
            /// <para>The number of validated fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("checkColumnCount")]
            [Validation(Required=false)]
            public long? CheckColumnCount { get; set; }

            /// <summary>
            /// <para>The number of validated partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("checkPtCount")]
            [Validation(Required=false)]
            public long? CheckPtCount { get; set; }

            /// <summary>
            /// <para>The validation result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No record.</description></item>
            /// <item><description>1: Passed.</description></item>
            /// <item><description>2: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("checkResult")]
            [Validation(Required=false)]
            public int? CheckResult { get; set; }

            /// <summary>
            /// <para>The number of validated data rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("checkRowCount")]
            [Validation(Required=false)]
            public long? CheckRowCount { get; set; }

            /// <summary>
            /// <para>The number of rows that passed validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("checkRowPassCount")]
            [Validation(Required=false)]
            public long? CheckRowPassCount { get; set; }

            /// <summary>
            /// <para>The row pass rate for the export report. This value is calculated by dividing the number of passed rows by the total number of validated rows. The value is returned as a percentage string with two decimal places.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.00%</para>
            /// </summary>
            [NameInMap("checkRowPassExport")]
            [Validation(Required=false)]
            public string CheckRowPassExport { get; set; }

            /// <summary>
            /// <para>The number of validation SQL statements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("checkSqlNum")]
            [Validation(Required=false)]
            public long? CheckSqlNum { get; set; }

            /// <summary>
            /// <para>The number of validated tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("checkTableNum")]
            [Validation(Required=false)]
            public long? CheckTableNum { get; set; }

            /// <summary>
            /// <para>The validation template name. This field is available only for metric validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("checkTemplateId")]
            [Validation(Required=false)]
            public string CheckTemplateId { get; set; }

            /// <summary>
            /// <para>The validation template name. This field is available only for metric validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data volume comparison built-in template</para>
            /// </summary>
            [NameInMap("checkTemplateName")]
            [Validation(Required=false)]
            public string CheckTemplateName { get; set; }

            /// <summary>
            /// <para>The validation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: data volume comparison.</description></item>
            /// <item><description>1: metric comparison.</description></item>
            /// <item><description>2: weak content comparison.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("checkType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>The name of the destination datasource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_demo</para>
            /// </summary>
            [NameInMap("dstDsName")]
            [Validation(Required=false)]
            public string DstDsName { get; set; }

            /// <summary>
            /// <para>The type of the destination datasource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hive</para>
            /// </summary>
            [NameInMap("dstDsType")]
            [Validation(Required=false)]
            public string DstDsType { get; set; }

            /// <summary>
            /// <para>The number of tables with errors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("errorTableNum")]
            [Validation(Required=false)]
            public long? ErrorTableNum { get; set; }

            /// <summary>
            /// <para>The number of fields that passed validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("passColumnCount")]
            [Validation(Required=false)]
            public long? PassColumnCount { get; set; }

            /// <summary>
            /// <para>The number of metrics that passed validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("passColumnRate")]
            [Validation(Required=false)]
            public double? PassColumnRate { get; set; }

            /// <summary>
            /// <para>The pass rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.95</para>
            /// </summary>
            [NameInMap("passProcess")]
            [Validation(Required=false)]
            public double? PassProcess { get; set; }

            /// <summary>
            /// <para>The pass rate for the export report. This value is calculated by dividing the number of passed tables by the total number of validated tables. The value is returned as a percentage string with two decimal places (for example, 100.00%). A hyphen (-) is returned when no validated table data exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.00%</para>
            /// </summary>
            [NameInMap("passProcessExport")]
            [Validation(Required=false)]
            public string PassProcessExport { get; set; }

            /// <summary>
            /// <para>The number of partitions that passed validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("passPtNum")]
            [Validation(Required=false)]
            public long? PassPtNum { get; set; }

            /// <summary>
            /// <para>The partition pass rate for the export report. This value is calculated by dividing the number of passed partitions by the total number of validated partitions. The value is returned as a percentage string with four decimal places. A hyphen (-) is returned when no partition data exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.0000%</para>
            /// </summary>
            [NameInMap("passPtProcessExport")]
            [Validation(Required=false)]
            public string PassPtProcessExport { get; set; }

            /// <summary>
            /// <para>The number of tables that passed validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("passTableNum")]
            [Validation(Required=false)]
            public long? PassTableNum { get; set; }

            /// <summary>
            /// <para>The partition pass rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("ptPassProcess")]
            [Validation(Required=false)]
            public double? PtPassProcess { get; set; }

            /// <summary>
            /// <para>The report generation message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Validation report refresh completed</para>
            /// </summary>
            [NameInMap("reportGenerateMessage")]
            [Validation(Required=false)]
            public string ReportGenerateMessage { get; set; }

            /// <summary>
            /// <para>The validation report status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Not generated.</description></item>
            /// <item><description>1: Generating.</description></item>
            /// <item><description>2: Generated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("reportStatus")]
            [Validation(Required=false)]
            public int? ReportStatus { get; set; }

            /// <summary>
            /// <para>The time when the report was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01 12:00:00</para>
            /// </summary>
            [NameInMap("reportTime")]
            [Validation(Required=false)]
            public string ReportTime { get; set; }

            /// <summary>
            /// <para>The title of the validation report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data Validation Report</para>
            /// </summary>
            [NameInMap("reportTitle")]
            [Validation(Required=false)]
            public string ReportTitle { get; set; }

            /// <summary>
            /// <para>The number of skipped partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("skipPtNum")]
            [Validation(Required=false)]
            public long? SkipPtNum { get; set; }

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
            /// <para>The name of the source datasource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_demo</para>
            /// </summary>
            [NameInMap("srcDsName")]
            [Validation(Required=false)]
            public string SrcDsName { get; set; }

            /// <summary>
            /// <para>The type of the source datasource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hive</para>
            /// </summary>
            [NameInMap("srcDsType")]
            [Validation(Required=false)]
            public string SrcDsType { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01 11:00:00</para>
            /// </summary>
            [NameInMap("taskCreateTime")]
            [Validation(Required=false)]
            public string TaskCreateTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>551</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The time when the task was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01 12:00:00</para>
            /// </summary>
            [NameInMap("taskModifyTime")]
            [Validation(Required=false)]
            public string TaskModifyTime { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data_check_task_demo</para>
            /// </summary>
            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        /// <summary>
        /// <para>The fault information code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>not supported.pos 5459, line 196, column 14, token IDENTIFIER settings</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The request ID. This value uniquely identifies the call. Provide this value when troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFF386FC-295C-5D2E-B2FE-410003095F06</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
