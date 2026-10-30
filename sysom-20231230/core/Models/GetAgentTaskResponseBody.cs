// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetAgentTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which can be used for end-to-end diagnostics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2E75336A-0DB2-5263-B201-A6488EC97B50</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description>If the value of code is Success, the authorization is successful.</description></item>
        /// <item><description>Other status codes indicate that the authorization failed. If the authorization fails, check the message field for the detailed fault message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAgentTaskResponseBodyData Data { get; set; }
        public class GetAgentTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of subtasks.</para>
            /// </summary>
            [NameInMap("jobs")]
            [Validation(Required=false)]
            public List<GetAgentTaskResponseBodyDataJobs> Jobs { get; set; }
            public class GetAgentTaskResponseBodyDataJobs : TeaModel {
                /// <summary>
                /// <para>The cause of the task failure. This field returns an error when the task execution fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deprecated (misused)</para>
                /// </summary>
                [NameInMap("error")]
                [Validation(Required=false)]
                public string Error { get; set; }

                /// <summary>
                /// <para>The error code for the subtask execution failure. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Empty: The task is executed normally.</description></item>
                /// <item><description>INSTANCE_NOT_SUPPORTED: The instance type is not supported.</description></item>
                /// <item><description>INSTANCE_NOT_EXISTS: The instance does not exist.</description></item>
                /// <item><description>INSTANCE_RELEASED: The instance is released.</description></item>
                /// <item><description>INSTANCE_NOT_RUNNING: The instance is not running.</description></item>
                /// <item><description>INSTANCE_NOT_OWNED: The instance does not belong to the current account.</description></item>
                /// <item><description>AGENT_ALREADY_INSTALLED: The agent is already installed.</description></item>
                /// <item><description>AGENT_NOT_INSTALLED: The agent is not installed.</description></item>
                /// <item><description>AGENT_SAME_VERSION: The version is the same.</description></item>
                /// <item><description>HAS_RUNNING_JOB: A task is running.</description></item>
                /// <item><description>RPM_LOCK_HELD: The RPM lock is occupied.</description></item>
                /// <item><description>DISK_SPACE_INSUFFICIENT: Insufficient disk space.</description></item>
                /// <item><description>NODE_LOAD_HIGH: The node load is high.</description></item>
                /// <item><description>COMMAND_FAILED: The command execution failed.</description></item>
                /// <item><description>CLIENT_NOT_RUNNING: The Cloud Assistant agent is not running.</description></item>
                /// <item><description>CLIENT_NOT_RESPONSE: The Cloud Assistant agent is not responding.</description></item>
                /// <item><description>DELIVERY_TIMEOUT: The command delivery timed out.</description></item>
                /// <item><description>EXECUTION_TIMEOUT: The command execution timed out.</description></item>
                /// <item><description>TASK_CONCURRENCY_LIMIT: The task concurrency limit is reached.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DISK_SPACE_INSUFFICIENT</para>
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The detailed error message for the subtask execution failure. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>The instance type is not supported.</description></item>
                /// <item><description>The instance does not exist.</description></item>
                /// <item><description>The instance is released.</description></item>
                /// <item><description>The instance is not running.</description></item>
                /// <item><description>The instance does not belong to the current account.</description></item>
                /// <item><description>The agent is already installed.</description></item>
                /// <item><description>The agent is not installed.</description></item>
                /// <item><description>The agent version is the same. No upgrade is required.</description></item>
                /// <item><description>A task is running. Please try again later.</description></item>
                /// <item><description>The RPM lock is occupied. Please try again later.</description></item>
                /// <item><description>Insufficient disk space.</description></item>
                /// <item><description>The node load is too high. Please try again later.</description></item>
                /// <item><description>The command execution failed. Please try again later.</description></item>
                /// <item><description>The Cloud Assistant agent is not running.</description></item>
                /// <item><description>The Cloud Assistant agent is not responding.</description></item>
                /// <item><description>The command delivery timed out.</description></item>
                /// <item><description>The command execution timed out.</description></item>
                /// <item><description>The task concurrency limit is reached.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Insufficient disk space</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2zehme0rs1tc090fdl3n</para>
                /// </summary>
                [NameInMap("instance")]
                [Validation(Required=false)]
                public string Instance { get; set; }

                /// <summary>
                /// <para>The subtask parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;agent_version&quot;: &quot;3.5.0-beta&quot;,
                ///     &quot;opt&quot;: &quot;install&quot;,
                ///     &quot;agent_id&quot;: &quot;74a86327-3170-412c-8fd67-da3389ec56a9&quot;,
                ///     &quot;install_type&quot;: &quot;InstallAndUpgrade&quot;
                /// }</para>
                /// </summary>
                [NameInMap("params")]
                [Validation(Required=false)]
                public object Params { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The subtask execution result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deprecated (misused)</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>The subtask status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Created: The task is created.</description></item>
                /// <item><description>Running: The task is running.</description></item>
                /// <item><description>Success: The task is successful.</description></item>
                /// <item><description>Fail: The task failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The running status of the agent task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c41d8e3506224184a714682fea86d22d</para>
            /// </summary>
            [NameInMap("task_id")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// <list type="bullet">
        /// <item><description>If the value of code is Success, this field is empty.</description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPIException: SysomOpenAPI.InvalidParameter Invalid params, should be json string or dict</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
