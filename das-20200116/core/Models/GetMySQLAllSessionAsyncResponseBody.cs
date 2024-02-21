// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetMySQLAllSessionAsyncResponseBody : TeaModel {
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
        public GetMySQLAllSessionAsyncResponseBodyData Data { get; set; }
        public class GetMySQLAllSessionAsyncResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the asynchronous request was complete. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Complete")]
            [Validation(Required=false)]
            public bool? Complete { get; set; }

            /// <summary>
            /// Indicates whether the asynchronous request failed. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public bool? Fail { get; set; }

            /// <summary>
            /// Indicates whether the asynchronous request was complete. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("IsFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// The ID of the asynchronous request.
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// The session data.
            /// </summary>
            [NameInMap("SessionData")]
            [Validation(Required=false)]
            public GetMySQLAllSessionAsyncResponseBodyDataSessionData SessionData { get; set; }
            public class GetMySQLAllSessionAsyncResponseBodyDataSessionData : TeaModel {
                /// <summary>
                /// The total number of active sessions.
                /// </summary>
                [NameInMap("ActiveSessionCount")]
                [Validation(Required=false)]
                public long? ActiveSessionCount { get; set; }

                /// <summary>
                /// The sessions that are counted by client IP address.
                /// </summary>
                [NameInMap("ClientStats")]
                [Validation(Required=false)]
                public List<GetMySQLAllSessionAsyncResponseBodyDataSessionDataClientStats> ClientStats { get; set; }
                public class GetMySQLAllSessionAsyncResponseBodyDataSessionDataClientStats : TeaModel {
                    /// <summary>
                    /// The number of active sessions that belong to the client IP address.
                    /// 
                    /// >  If the type of the command executed in the session is Query or Execute and the session in the transaction is not terminated, the session is active.
                    /// </summary>
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    /// <summary>
                    /// The IP address of the client.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The IDs of the sessions that belong to the client IP address.
                    /// </summary>
                    [NameInMap("ThreadIdList")]
                    [Validation(Required=false)]
                    public List<long?> ThreadIdList { get; set; }

                    /// <summary>
                    /// The total number of sessions that belong to the client IP address.
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    /// <summary>
                    /// The database accounts to which the sessions belong.
                    /// </summary>
                    [NameInMap("UserList")]
                    [Validation(Required=false)]
                    public List<string> UserList { get; set; }

                }

                /// <summary>
                /// The sessions that are counted by database.
                /// </summary>
                [NameInMap("DbStats")]
                [Validation(Required=false)]
                public List<GetMySQLAllSessionAsyncResponseBodyDataSessionDataDbStats> DbStats { get; set; }
                public class GetMySQLAllSessionAsyncResponseBodyDataSessionDataDbStats : TeaModel {
                    /// <summary>
                    /// The number of active sessions of the database.
                    /// 
                    /// >  If the type of the command executed in the session is Query or Execute and the session in the transaction is not terminated, the session is active.
                    /// </summary>
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    /// <summary>
                    /// The database name.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The IDs of the sessions of the database.
                    /// </summary>
                    [NameInMap("ThreadIdList")]
                    [Validation(Required=false)]
                    public List<long?> ThreadIdList { get; set; }

                    /// <summary>
                    /// The total number of sessions of the database.
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    /// <summary>
                    /// The database accounts to which the sessions belong.
                    /// </summary>
                    [NameInMap("UserList")]
                    [Validation(Required=false)]
                    public List<string> UserList { get; set; }

                }

                /// <summary>
                /// The maximum execution duration of an active session. Unit: seconds.
                /// </summary>
                [NameInMap("MaxActiveTime")]
                [Validation(Required=false)]
                public long? MaxActiveTime { get; set; }

                /// <summary>
                /// The sessions.
                /// </summary>
                [NameInMap("SessionList")]
                [Validation(Required=false)]
                public List<GetMySQLAllSessionAsyncResponseBodyDataSessionDataSessionList> SessionList { get; set; }
                public class GetMySQLAllSessionAsyncResponseBodyDataSessionDataSessionList : TeaModel {
                    /// <summary>
                    /// The IP address of the client.
                    /// </summary>
                    [NameInMap("Client")]
                    [Validation(Required=false)]
                    public string Client { get; set; }

                    /// <summary>
                    /// The type of the command executed in the session.
                    /// </summary>
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public string Command { get; set; }

                    /// <summary>
                    /// The database name.
                    /// </summary>
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    /// <summary>
                    /// The session ID.
                    /// </summary>
                    [NameInMap("SessionId")]
                    [Validation(Required=false)]
                    public long? SessionId { get; set; }

                    /// <summary>
                    /// The SQL template ID.
                    /// 
                    /// >  This parameter is returned only when you use a PolarDB-X 2.0 instance.
                    /// </summary>
                    [NameInMap("SqlTemplateId")]
                    [Validation(Required=false)]
                    public string SqlTemplateId { get; set; }

                    /// <summary>
                    /// The SQL statement executed in the session.
                    /// </summary>
                    [NameInMap("SqlText")]
                    [Validation(Required=false)]
                    public string SqlText { get; set; }

                    /// <summary>
                    /// The status of the session.
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    /// <summary>
                    /// The execution duration of the session. Unit: seconds.
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public long? Time { get; set; }

                    /// <summary>
                    /// The duration of the transaction. Unit: seconds.
                    /// </summary>
                    [NameInMap("TrxDuration")]
                    [Validation(Required=false)]
                    public long? TrxDuration { get; set; }

                    /// <summary>
                    /// The ID of the transaction to which the session belongs.
                    /// </summary>
                    [NameInMap("TrxId")]
                    [Validation(Required=false)]
                    public string TrxId { get; set; }

                    /// <summary>
                    /// The username of the database account.
                    /// </summary>
                    [NameInMap("User")]
                    [Validation(Required=false)]
                    public string User { get; set; }

                    /// <summary>
                    /// The alias of the IP address of the client.
                    /// </summary>
                    [NameInMap("UserClientAlias")]
                    [Validation(Required=false)]
                    public string UserClientAlias { get; set; }

                }

                /// <summary>
                /// The time when the session was queried. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public long? TimeStamp { get; set; }

                /// <summary>
                /// The total number of sessions.
                /// </summary>
                [NameInMap("TotalSessionCount")]
                [Validation(Required=false)]
                public long? TotalSessionCount { get; set; }

                /// <summary>
                /// The sessions that are counted by database account.
                /// </summary>
                [NameInMap("UserStats")]
                [Validation(Required=false)]
                public List<GetMySQLAllSessionAsyncResponseBodyDataSessionDataUserStats> UserStats { get; set; }
                public class GetMySQLAllSessionAsyncResponseBodyDataSessionDataUserStats : TeaModel {
                    /// <summary>
                    /// The number of active sessions within the account.
                    /// 
                    /// >  If the type of the command executed in the session is Query or Execute and the session in the transaction is not terminated, the session is active.
                    /// </summary>
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    /// <summary>
                    /// The database account.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The IDs of the sessions within the account.
                    /// </summary>
                    [NameInMap("ThreadIdList")]
                    [Validation(Required=false)]
                    public List<long?> ThreadIdList { get; set; }

                    /// <summary>
                    /// The total number of sessions within the account.
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    /// <summary>
                    /// The database accounts to which the sessions belong.
                    /// </summary>
                    [NameInMap("UserList")]
                    [Validation(Required=false)]
                    public List<string> UserList { get; set; }

                }

            }

            /// <summary>
            /// The state of the asynchronous request. Valid values:
            /// 
            /// *   **RUNNING**
            /// *   **SUCCESS**
            /// *   **FAIL**
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The time when the asynchronous request was made. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message such as an error code is returned.
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
