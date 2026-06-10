// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetAgentTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID, which can be used for end-to-end Diagnosis</para>
        /// 
        /// <b>Example:</b>
        /// <para>2E75336A-0DB2-5263-B201-A6488EC97B50</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates that authorization Succeeded.  </description></item>
        /// <item><description>Any other status code indicates Failed to Authorize. When authorization fails, View the <c>message</c> field to obtain the detailed error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned Data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAgentTaskResponseBodyData Data { get; set; }
        public class GetAgentTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of sub-Jobs</para>
            /// </summary>
            [NameInMap("jobs")]
            [Validation(Required=false)]
            public List<GetAgentTaskResponseBodyDataJobs> Jobs { get; set; }
            public class GetAgentTaskResponseBodyDataJobs : TeaModel {
                /// <summary>
                /// <para>When Job execution fails, this field contains the error message indicating the cause of the failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>已废弃（误用）</para>
                /// </summary>
                [NameInMap("error")]
                [Validation(Required=false)]
                public string Error { get; set; }

                /// <summary>
                /// <para>The error code indicating the reason for sub-job failure. Possible values:</para>
                /// <list type="bullet">
                /// <item><description>empty: The job executed normally.</description></item>
                /// <item><description>INSTANCE_NOT_SUPPORTED: The instance type is not supported.</description></item>
                /// <item><description>INSTANCE_NOT_EXISTS: The instance does not exist.</description></item>
                /// <item><description>INSTANCE_RELEASED: The instance has been released.</description></item>
                /// <item><description>INSTANCE_NOT_RUNNING: The instance is not running.</description></item>
                /// <item><description>INSTANCE_NOT_OWNED: The instance does not belong to the current account.</description></item>
                /// <item><description>AGENT_ALREADY_INSTALLED: The agent is already installed.</description></item>
                /// <item><description>AGENT_NOT_INSTALLED: The agent is not installed.</description></item>
                /// <item><description>AGENT_SAME_VERSION: The version is the same.</description></item>
                /// <item><description>HAS_RUNNING_JOB: There is a running job.</description></item>
                /// <item><description>RPM_LOCK_HELD: The RPM lock is held.</description></item>
                /// <item><description>DISK_SPACE_INSUFFICIENT: Insufficient disk space.</description></item>
                /// <item><description>NODE_LOAD_HIGH: High edge zone load.</description></item>
                /// <item><description>COMMAND_FAILED: Command execution failed.</description></item>
                /// <item><description>CLIENT_NOT_RUNNING: The Cloud Assistant agent is not running.</description></item>
                /// <item><description>CLIENT_NOT_RESPONSE: The Cloud Assistant agent is unresponsive.</description></item>
                /// <item><description>DELIVERY_TIMEOUT: Command delivery timeout.</description></item>
                /// <item><description>EXECUTION_TIMEOUT: Command execution timeout.</description></item>
                /// <item><description>TASK_CONCURRENCY_LIMIT: Task concurrency limit reached.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DISK_SPACE_INSUFFICIENT</para>
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>Detailed reason for subtask execution failure. Possible values:  </para>
                /// <list type="bullet">
                /// <item><description>Instance type is not supported  </description></item>
                /// <item><description>Instance does not exist  </description></item>
                /// <item><description>Instance has been released  </description></item>
                /// <item><description>Instance is not running  </description></item>
                /// <item><description>Instance does not belong to the current account  </description></item>
                /// <item><description>Agent is already installed  </description></item>
                /// <item><description>Agent is not installed  </description></item>
                /// <item><description>Agent version is the same; no upgrade is required  </description></item>
                /// <item><description>A task is currently running; please retry later  </description></item>
                /// <item><description>RPM lock is occupied; please retry later  </description></item>
                /// <item><description>Insufficient disk space  </description></item>
                /// <item><description>Edge zone payload is too high; please retry later  </description></item>
                /// <item><description>Command execution failed; please retry later  </description></item>
                /// <item><description>Cloud Assistant Agent is not running  </description></item>
                /// <item><description>Cloud Assistant Agent is unresponsive  </description></item>
                /// <item><description>Command sending timeout  </description></item>
                /// <item><description>Command execution timeout  </description></item>
                /// <item><description>Task concurrency limit has been reached</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>磁盘空间不足</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>Instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2zehme0rs1tc090fdl3n</para>
                /// </summary>
                [NameInMap("instance")]
                [Validation(Required=false)]
                public string Instance { get; set; }

                /// <summary>
                /// <para>Parameters of the sub-Job</para>
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
                /// <para>Region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>Result of sub-Job execution</para>
                /// 
                /// <b>Example:</b>
                /// <para>已废弃（误用）</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>Sub-Job status:  </para>
                /// <list type="bullet">
                /// <item><description>Created: Created  </description></item>
                /// <item><description>Running: Running  </description></item>
                /// <item><description>Success: Job Run Succeeded  </description></item>
                /// <item><description>Fail: Job Run failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c41d8e3506224184a714682fea86d22d</para>
            /// </summary>
            [NameInMap("task_id")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>Error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty;  </description></item>
        /// <item><description>Otherwise, this field contains the Request error message.</description></item>
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
