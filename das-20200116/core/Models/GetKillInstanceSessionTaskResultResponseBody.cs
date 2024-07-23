// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetKillInstanceSessionTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetKillInstanceSessionTaskResultResponseBodyData Data { get; set; }
        public class GetKillInstanceSessionTaskResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of ignored sessions, including sessions of the accounts that are specified by IgnoredUsers, sessions of internal O\&amp;M accounts of Alibaba Cloud, and <b>Binlog Dump</b> sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("IgnoredUserSessionCount")]
            [Validation(Required=false)]
            public long? IgnoredUserSessionCount { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2ze1jdv45i7l6****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The number of sessions that failed to be terminated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("KillFailCount")]
            [Validation(Required=false)]
            public long? KillFailCount { get; set; }

            /// <summary>
            /// <para>The number of sessions that were terminated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("KillSuccessCount")]
            [Validation(Required=false)]
            public long? KillSuccessCount { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the instance is a PolarDB for MySQL cluster.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>pi-bp1h12rv501cv****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The details of the task that terminated sessions.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetKillInstanceSessionTaskResultResponseBodyDataResult> Result { get; set; }
            public class GetKillInstanceSessionTaskResultResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>Indicates whether the session is active.</para>
                /// <remarks>
                /// <para>If the type of the command is Query or Execute and the session in the transaction is not terminated, the session is active.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Active")]
                [Validation(Required=false)]
                public bool? Active { get; set; }

                /// <summary>
                /// <para>The type of the command executed in the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sleep</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dbTest</para>
                /// </summary>
                [NameInMap("Db")]
                [Validation(Required=false)]
                public string Db { get; set; }

                /// <summary>
                /// <para>The IP address and port number of the host that initiated the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.104.XX.XX:23428</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8357518</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The SQL statement executed in the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT sleep(60)</para>
                /// </summary>
                [NameInMap("Info")]
                [Validation(Required=false)]
                public string Info { get; set; }

                /// <summary>
                /// <para>The description of the session when the session was terminated.</para>
                /// <list type="bullet">
                /// <item><description><b>SESSION_KILLED</b>: The session is terminated.</description></item>
                /// <item><description><b>SESSION_EXPIRED</b>: The session has expired.</description></item>
                /// <item><description><b>SESSION_NO_PERMISSION</b>: The account used to terminate the session has insufficient permissions.</description></item>
                /// <item><description><b>SESSION_ACCOUNT_ERROR</b>: The account or password used to terminate the session is invalid.</description></item>
                /// <item><description><b>SESSION_IGNORED_USER</b>: The session of the account does not need to be terminated.</description></item>
                /// <item><description><b>SESSION_INTERNAL_USER_OR_COMMAND</b>: The session is a session initiated by or a command run by an Alibaba Cloud O\&amp;M account.</description></item>
                /// <item><description><b>SESSION_KILL_TASK_TIMEOUT</b>: Timeout occurs when the session is terminated.</description></item>
                /// <item><description><b>SESSION_OTHER_ERROR</b>: Other errors occurred.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SESSION_KILLED</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The status of the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sending data</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The ID of the subtask that terminates the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>task_d9e94107-6116-4ac3-b874-81466aff****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The execution duration. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

                /// <summary>
                /// <para>The account of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testUser</para>
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// <para>The session IDs.</para>
            /// <remarks>
            /// <para> If all sessions are terminated, the IDs of all sessions on the instance or node are returned.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<long?> Sessions { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f77d535b45405bd462b21caa3ee8****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The state of the task that terminates sessions.</para>
            /// <list type="bullet">
            /// <item><description><b>RUNNING</b>: The task is in progress.</description></item>
            /// <item><description><b>SUCCESS</b>: The task is successful.</description></item>
            /// <item><description><b>FAILURE</b>: The task failed.</description></item>
            /// <item><description><b>ERROR</b>: Other errors occur.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("TaskState")]
            [Validation(Required=false)]
            public string TaskState { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>164882191396****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, Successful is returned. If the request failed, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
