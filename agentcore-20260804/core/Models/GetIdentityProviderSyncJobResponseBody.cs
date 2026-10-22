// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetIdentityProviderSyncJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code of the API request. SUCCESS indicates that the request is successful, but does not indicate that the asynchronous synchronization task is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned by the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;taskId&quot;:&quot;12345678-1234-4234-8234-123456789abc&quot;,&quot;status&quot;:&quot;SUCCESS&quot;,&quot;currentStep&quot;:&quot;SYNC&quot;,&quot;synchronizationJobId&quot;:&quot;syncjob_0123456789abcdef0123456789abcdef&quot;,&quot;syncedUserCount&quot;:12}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetIdentityProviderSyncJobResponseBodyData Data { get; set; }
        public class GetIdentityProviderSyncJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current execution step of the AgentCore asynchronous task. This field may not be returned if the task has not started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYNC</para>
            /// </summary>
            [NameInMap("currentStep")]
            [Validation(Required=false)]
            public string CurrentStep { get; set; }

            /// <summary>
            /// <para>The failure summary of the asynchronous task. This field is not returned if there is no failure information. You can use the taskId and requestId for troubleshooting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The identity provider synchronization job failed.</para>
            /// </summary>
            [NameInMap("failureReason")]
            [Validation(Required=false)]
            public string FailureReason { get; set; }

            /// <summary>
            /// <para>The status of the synchronization task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PENDING: The task is pending execution.</description></item>
            /// <item><description>RUNNING: The task is running.</description></item>
            /// <item><description>PAUSED: The task is paused.</description></item>
            /// <item><description>SUCCESS: The task is successful.</description></item>
            /// <item><description>FAILED: The task failed.</description></item>
            /// <item><description>CANCELED: The task is canceled.
            /// The first three values are non-terminal states, and the last three values are terminal states. Query the task until it reaches a terminal state to determine the result.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of user entries that have been locally read and written or updated, including existing users. This value does not represent the number of newly added users or the synchronization percentage. This field is not returned when no statistics are available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("syncedUserCount")]
            [Validation(Required=false)]
            public int? SyncedUserCount { get; set; }

            /// <summary>
            /// <para>The downstream synchronization task ID of AgentIdentity. This field is not returned if the task has not been created. It cannot replace the taskId to call GetIdentityProviderSyncJob.</para>
            /// 
            /// <b>Example:</b>
            /// <para>syncjob_0123456789abcdef0123456789abcdef</para>
            /// </summary>
            [NameInMap("synchronizationJobId")]
            [Validation(Required=false)]
            public string SynchronizationJobId { get; set; }

            /// <summary>
            /// <para>The local task ID of AgentCore returned by CreateIdentityProviderSyncJob. It is not the synchronizationJobId of AgentIdentity. The same workspace and identity provider must be used for the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678-1234-4234-8234-123456789abc</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code of the API request. It does not indicate the execution result of the asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message of the API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. Provide this value when you troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01234567-89AB-CDEF-0123-456789ABCDEF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API request is successful. To determine whether the asynchronous task is completed, query the task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
