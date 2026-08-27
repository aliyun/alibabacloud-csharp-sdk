// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetInstanceAsyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>SUCCESS</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned list. The <c>items</c> array may contain multiple tasks with the same <c>taskCode</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<GetInstanceAsyncTaskResponseBodyItems> Items { get; set; }
        public class GetInstanceAsyncTaskResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The current step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>create-cms-workspace</para>
            /// </summary>
            [NameInMap("CurrentStep")]
            [Validation(Required=false)]
            public string CurrentStep { get; set; }

            /// <summary>
            /// <para>The recovery message returned to the user when the task status is paused.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("RecoveryMessage")]
            [Validation(Required=false)]
            public GetInstanceAsyncTaskResponseBodyItemsRecoveryMessage RecoveryMessage { get; set; }
            public class GetInstanceAsyncTaskResponseBodyItemsRecoveryMessage : TeaModel {
                /// <summary>
                /// <para>The error code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CMS_WORKSPACE_QUOTA_EXCEEDED: CMS workspace quota exceeded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CMS_WORKSPACE_QUOTA_EXCEEDED</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The specific error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CMS workspace quota exceeded</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The time when the error occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-06-01T12:00:00Z</para>
                /// </summary>
                [NameInMap("OccurredAt")]
                [Validation(Required=false)]
                public string OccurredAt { get; set; }

                /// <summary>
                /// <para>The suggested recovery action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Please increase the CMS workspace quota or clean up unused workspaces.</para>
                /// </summary>
                [NameInMap("RecoverySuggestion")]
                [Validation(Required=false)]
                public string RecoverySuggestion { get; set; }

                /// <summary>
                /// <para>Indicates whether the task can be retried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Retryable")]
                [Validation(Required=false)]
                public bool? Retryable { get; set; }

                /// <summary>
                /// <para>The error source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CMS: content management system.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CMS</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The recovery type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ERROR_RECOVERY: error recovery.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ERROR_RECOVERY</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The task code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>LIFECYCLE_MAGIC_PAY_ORDER_CALLBACK_CREATE: instance creation task.</description></item>
            /// <item><description>MAGIC_BIND_IDENTITY_PROVIDER: upstream identity provider binding task.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LIFECYCLE_MAGIC_PAY_ORDER_CALLBACK_CREATE</para>
            /// </summary>
            [NameInMap("TaskCode")]
            [Validation(Required=false)]
            public string TaskCode { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-xxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PAUSED: paused.</description></item>
            /// <item><description>RUNNING: running.</description></item>
            /// <item><description>SUCCEEDED: succeeded.</description></item>
            /// <item><description>FAILED: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PAUSED</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is waiting for user action. When <c>taskStatus = PAUSED</c>, this value is true and <c>recoveryMessage</c> is returned to display recovery instructions to the user. When the task is not paused, this value is false and <c>recoveryMessage</c> is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("WaitingForUserAction")]
            [Validation(Required=false)]
            public bool? WaitingForUserAction { get; set; }

        }

        /// <summary>
        /// <para>The page size. Default value: 100. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>success</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token for the next page. This parameter is not returned for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
