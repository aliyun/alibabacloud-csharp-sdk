// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateGatewayQuotaRuleSubjectUsageExportTaskRequest : TeaModel {
        /// <summary>
        /// <para>An optional token used for request idempotency. The maximum length is 128 bytes after leading and trailing whitespaces are removed. Use ASCII characters.</para>
        /// <para>When the same user retries with the same token and request parameters in the current region, the existing task is reused and its current status is returned. If the same token corresponds to different parameters, a parameter error is returned. The compared parameters include gatewayId, ruleId, subjectId, filterFailedRequests, format, and whether startTime and endTime are passed and their values. Omitting the time is not equivalent to explicitly passing 0.</para>
        /// <para>Reusing a task does not recalculate the time range or regenerate the file. When you need to re-export data, including when the original task fails or the file expires, use a new token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>usage-export-20260729-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The end time of the export time range. Use a non-negative UNIX timestamp in seconds. This time is exclusive.</para>
        /// <para>If only endTime is specified, one rule period before this time is deduced as the startTime. If neither is specified, the end time is the task creation time. If both are specified, endTime must be greater than or equal to startTime, and the span cannot exceed one rule period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1783935200</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to export only consumption details with valid usage. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description>false: Does not filter records by usage.</description></item>
        /// <item><description>true: Filters records with zero usage based on the token or credit metering dimension of the rule, and retains only records with usage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("filterFailedRequests")]
        [Validation(Required=false)]
        public bool? FilterFailedRequests { get; set; }

        /// <summary>
        /// <para>The export file format. Only CSV_GZIP is supported. If omitted or an empty string is passed, this format is used by default. The file is a GZIP-compressed CSV file named {taskId}.csv.gz. Decompress the file before reading.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CSV_GZIP</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// <para>The start time of the export time range. Use a non-negative UNIX timestamp in seconds. This time is inclusive.</para>
        /// <list type="bullet">
        /// <item><description>If neither startTime nor endTime is specified: The start point of the current rule period to the task creation time is used.</description></item>
        /// <item><description>If only startTime is specified: One rule period after this time is deduced as the endTime.</description></item>
        /// <item><description>If both are specified: endTime must be greater than or equal to startTime, and the span cannot exceed one rule period.</description></item>
        /// </list>
        /// <para>The actual export start point is also limited by the rule creation time, rule reset, or the effective start point of clearing history records. You can confirm this by querying the effectiveWindowStart returned by the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1783931600</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
