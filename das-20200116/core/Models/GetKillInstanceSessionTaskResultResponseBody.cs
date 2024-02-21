// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetKillInstanceSessionTaskResultResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetKillInstanceSessionTaskResultResponseBodyData Data { get; set; }
        public class GetKillInstanceSessionTaskResultResponseBodyData : TeaModel {
            /// <summary>
            /// The number of ignored sessions, including sessions of the accounts that are specified by IgnoredUsers, sessions of internal O\&M accounts of Alibaba Cloud, and **Binlog Dump** sessions.
            /// </summary>
            [NameInMap("IgnoredUserSessionCount")]
            [Validation(Required=false)]
            public long? IgnoredUserSessionCount { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The number of sessions that failed to be terminated.
            /// </summary>
            [NameInMap("KillFailCount")]
            [Validation(Required=false)]
            public long? KillFailCount { get; set; }

            /// <summary>
            /// The number of sessions that were terminated.
            /// </summary>
            [NameInMap("KillSuccessCount")]
            [Validation(Required=false)]
            public long? KillSuccessCount { get; set; }

            /// <summary>
            /// The node ID.
            /// 
            /// >  This parameter is returned only if the instance is a PolarDB for MySQL cluster.
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// The details of the task that terminated sessions.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetKillInstanceSessionTaskResultResponseBodyDataResult> Result { get; set; }
            public class GetKillInstanceSessionTaskResultResponseBodyDataResult : TeaModel {
                /// <summary>
                /// Indicates whether the session is active.
                /// 
                /// > If the type of the command is Query or Execute and the session in the transaction is not terminated, the session is active.
                /// </summary>
                [NameInMap("Active")]
                [Validation(Required=false)]
                public bool? Active { get; set; }

                /// <summary>
                /// The type of the command executed in the session.
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("Db")]
                [Validation(Required=false)]
                public string Db { get; set; }

                /// <summary>
                /// The IP address and port number of the host that initiated the session.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The session ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The SQL statement executed in the session.
                /// </summary>
                [NameInMap("Info")]
                [Validation(Required=false)]
                public string Info { get; set; }

                /// <summary>
                /// The description of the session when the session was terminated.
                /// 
                /// *   **SESSION_KILLED**: The session is terminated.
                /// *   **SESSION_EXPIRED**: The session has expired.
                /// *   **SESSION_NO_PERMISSION**: The account used to terminate the session has insufficient permissions.
                /// *   **SESSION_ACCOUNT_ERROR**: The account or password used to terminate the session is invalid.
                /// *   **SESSION_IGNORED_USER**: The session of the account does not need to be terminated.
                /// *   **SESSION_INTERNAL_USER_OR_COMMAND**: The session is a session initiated by or a command run by an Alibaba Cloud O\&M account.
                /// *   **SESSION_KILL_TASK_TIMEOUT**: Timeout occurs when the session is terminated.
                /// *   **SESSION_OTHER_ERROR**: Other errors occurred.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// The status of the session.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The ID of the subtask that terminates the session.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// The execution duration. Unit: seconds.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

                /// <summary>
                /// The account of the database.
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// The session IDs.
            /// 
            /// >  If all sessions are terminated, the IDs of all sessions on the instance or node are returned.
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<long?> Sessions { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The state of the task that terminates sessions.
            /// 
            /// *   **RUNNING**: The task is in progress.
            /// *   **SUCCESS**: The task is successful.
            /// *   **FAILURE**: The task failed.
            /// *   **ERROR**: Other errors occur.
            /// </summary>
            [NameInMap("TaskState")]
            [Validation(Required=false)]
            public string TaskState { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, Successful is returned. If the request failed, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
