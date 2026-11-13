// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateGatewayQuotaRuleSubjectUsageExportTaskResponseBody : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;taskId&quot;: &quot;finops-export-abcdef1234567890&quot;,
        ///   &quot;status&quot;: &quot;Pending&quot;
        /// }</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateGatewayQuotaRuleSubjectUsageExportTaskResponseBodyData Data { get; set; }
        public class CreateGatewayQuotaRuleSubjectUsageExportTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current status of create task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: Create task is submitted and waiting to be processed.</description></item>
            /// <item><description>Running: The system is querying details, generating the file, or uploading the file.</description></item>
            /// <item><description>Success: The export is successful. Call the query operation to obtain the file information.</description></item>
            /// <item><description>Failed: The export failed. Call the query operation to view the errorMessage.</description></item>
            /// </list>
            /// <para>A newly created task returns Pending. When an existing task is reused through clientToken, the current status of create task is returned, which is not guaranteed to be Pending.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The export task ID. When you call GetGatewayQuotaRuleSubjectUsageExportTask, pass this value along with the gatewayId, ruleId, and subjectId from this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>finops-export-abcdef1234567890</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

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
        /// <para>The request ID of this OpenAPI call, which is used to troubleshoot call issues. This is different from the request_id of each consumption record in the exported file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
