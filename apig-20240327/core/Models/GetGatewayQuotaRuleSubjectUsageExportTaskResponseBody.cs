// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetGatewayQuotaRuleSubjectUsageExportTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGatewayQuotaRuleSubjectUsageExportTaskResponseBodyData Data { get; set; }
        public class GetGatewayQuotaRuleSubjectUsageExportTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error summary when the task fails, which is used to troubleshoot issues such as disabled logs, query failures, exceeded detail limits, processing timeouts, or file generation failures. This field may be omitted if no errors occur.</para>
            /// 
            /// <b>Example:</b>
            /// <para>log delivery is not enabled</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The gateway ID recorded when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-123456</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The number of detail rows written to the exported file, excluding the header. This value is used to check the processing progress. Even if this value equals totalCount, determine whether the file is downloadable based on status=Success.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("processedCount")]
            [Validation(Required=false)]
            public int? ProcessedCount { get; set; }

            /// <summary>
            /// <para>The export conditions and file results determined when the task was created. The time range, format, and metering dimension may be returned even in non-Success states. File and download information is available only after success. Fields with values of 0, false, or empty strings are omitted.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public GetGatewayQuotaRuleSubjectUsageExportTaskResponseBodyDataResult Result { get; set; }
            public class GetGatewayQuotaRuleSubjectUsageExportTaskResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The temporary signed download URL of the exported file. It is returned only when status=Success and the file is not expired. It is dynamically generated for each query and is valid for 10 minutes from the generation time. If the link expires but fileExpiredAt is not reached, you can call this operation again to obtain the link. You do not need to pass the internal storage path as a request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.oss-cn-hangzhou.aliyuncs.com/export.csv.gz">https://example.oss-cn-hangzhou.aliyuncs.com/export.csv.gz</a></para>
                /// </summary>
                [NameInMap("downloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                /// <summary>
                /// <para>The expiration time of the downloadUrl returned in this response. It is a UNIX timestamp in seconds. It is provided only when a download link is returned and is approximately 10 minutes after the link generation time. It can be updated by querying again and cannot be used to replace fileExpiredAt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1783938800</para>
                /// </summary>
                [NameInMap("downloadUrlExpiredAt")]
                [Validation(Required=false)]
                public long? DownloadUrlExpiredAt { get; set; }

                /// <summary>
                /// <para>The start time of the actual export time range. It is a UNIX timestamp in seconds. The actual start time is also limited by the rule creation time, rule reset, or the effective start time of purging history records. No details are available if the start time is not earlier than the end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1783931600</para>
                /// </summary>
                [NameInMap("effectiveWindowStart")]
                [Validation(Required=false)]
                public long? EffectiveWindowStart { get; set; }

                /// <summary>
                /// <para>Indicates whether the exported file has exceeded the period during which the server provides download links. A value of true indicates that the file has expired, downloadUrl and downloadUrlExpiredAt are not returned, and you need to create a new export task. This field may be omitted if the value is false. To determine whether the file is downloadable, check both status and downloadUrl.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("fileExpired")]
                [Validation(Required=false)]
                public bool? FileExpired { get; set; }

                /// <summary>
                /// <para>The time when the file stops providing new download links. It is a UNIX timestamp in seconds and is usually 24 hours after the file is successfully uploaded. After this time is reached, this operation returns fileExpired=true and no longer generates downloadUrl. The task remains in the Success state. This time is different from downloadUrlExpiredAt of a single signed link.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1784021600</para>
                /// </summary>
                [NameInMap("fileExpiredAt")]
                [Validation(Required=false)]
                public long? FileExpiredAt { get; set; }

                /// <summary>
                /// <para>The size of the successfully generated and uploaded GZIP compressed file, in bytes. This field may be omitted if the task has not succeeded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <para>The usage filter switch specified when the task was created. A value of true filters out records with 0 usage and retains only records with usage. This field may be omitted if the value is false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("filterFailedRequests")]
                [Validation(Required=false)]
                public bool? FilterFailedRequests { get; set; }

                /// <summary>
                /// <para>The format of the exported file. The value is currently fixed as CSV_GZIP. The downloaded file is a .csv.gz file, which becomes a CSV file after decompression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CSV_GZIP</para>
                /// </summary>
                [NameInMap("format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The end time of the request time range determined when the task was created. It is a UNIX timestamp in seconds and excludes this moment. If no time range is specified, this value is the task creation time and is not updated when the task is queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1783935200</para>
                /// </summary>
                [NameInMap("queryWindowEnd")]
                [Validation(Required=false)]
                public long? QueryWindowEnd { get; set; }

                /// <summary>
                /// <para>The start time of the request time range determined when the task was created. It is a UNIX timestamp in seconds and includes this moment. If only one time parameter is passed, this value may be derived from the rule period. For the actual export start time, see effectiveWindowStart.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1783931600</para>
                /// </summary>
                [NameInMap("queryWindowStart")]
                [Validation(Required=false)]
                public long? QueryWindowStart { get; set; }

                /// <summary>
                /// <para>The quota metering dimension determined when the task was created. token indicates token usage, and credit indicates credit usage. The CSV file outputs the corresponding column based on this dimension. Credit usage retains decimal places.</para>
                /// 
                /// <b>Example:</b>
                /// <para>token</para>
                /// </summary>
                [NameInMap("quotaDimension")]
                [Validation(Required=false)]
                public string QuotaDimension { get; set; }

                /// <summary>
                /// <para>The number of successfully exported usage detail rows, excluding the CSV header. This field may be omitted if the task has not succeeded or the export result contains 0 rows. If the task succeeds but no matching details are found, the file contains only the header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("rowCount")]
                [Validation(Required=false)]
                public long? RowCount { get; set; }

            }

            /// <summary>
            /// <para>The quota rule ID recorded when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qr-123456</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The current status of the task.</para>
            /// <list type="bullet">
            /// <item><description>Pending: The task is submitted and pending processing.</description></item>
            /// <item><description>Running: The system is querying details, generating files, or uploading files.</description></item>
            /// <item><description>Success: The file is generated and uploaded. You still need to check whether the file is expired.</description></item>
            /// <item><description>Failed: The task failed. For the cause, see errorMessage.</description></item>
            /// </list>
            /// <para>Tasks that are not completed within 10 minutes after creation are processed as Failed. After the file expires, the task remains in the Success state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The consumer or consumer group ID recorded when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cs-123456</para>
            /// </summary>
            [NameInMap("subjectId")]
            [Validation(Required=false)]
            public string SubjectId { get; set; }

            /// <summary>
            /// <para>The subject name recorded when the task was created, which is used to match usage logs. Subsequent changes to the subject name do not modify the name recorded for this task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>consumer-name</para>
            /// </summary>
            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public string SubjectName { get; set; }

            /// <summary>
            /// <para>The export task ID, which is the same as the taskId request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>finops-export-abcdef1234567890</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task type. The value is fixed as FinOpsUsageDetailExport, which indicates the export of usage details for a quota rule subject.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinOpsUsageDetailExport</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The total number of detail rows to be exported as counted by backend queries, excluding the CSV header. This value may be 0 before counting is completed. Do not determine whether the result is empty or the task is completed based solely on this value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID of this OpenAPI query call, which is used to troubleshoot call issues. This is different from the request_id of each usage record in the exported file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
