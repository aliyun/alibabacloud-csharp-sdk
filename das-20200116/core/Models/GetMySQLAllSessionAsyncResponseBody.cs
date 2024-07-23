// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetMySQLAllSessionAsyncResponseBody : TeaModel {
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
        public GetMySQLAllSessionAsyncResponseBodyData Data { get; set; }
        public class GetMySQLAllSessionAsyncResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the asynchronous request was complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Complete")]
            [Validation(Required=false)]
            public bool? Complete { get; set; }

            /// <summary>
            /// <para>Indicates whether the asynchronous request failed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public bool? Fail { get; set; }

            /// <summary>
            /// <para>Indicates whether the asynchronous request was complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// <para>The ID of the asynchronous request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>async__507044db6c4eadfa2dab9b084e80****</para>
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <para>The session data.</para>
            /// </summary>
            [NameInMap("SessionData")]
            [Validation(Required=false)]
            public GetMySQLAllSessionAsyncResponseBodyDataSessionData SessionData { get; set; }
            public class GetMySQLAllSessionAsyncResponseBodyDataSessionData : TeaModel {
                /// <summary>
                /// <para>The total number of active sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ActiveSessionCount")]
                [Validation(Required=false)]
                public long? ActiveSessionCount { get; set; }

                /// <summary>
                /// <para>The sessions that are counted by client IP address.</para>
                /// </summary>
                [NameInMap("ClientStats")]
                [Validation(Required=false)]
                public List<GetMySQLAllSessionAsyncResponseBodyDataSessionDataClientStats> ClientStats { get; set; }
                public class GetMySQLAllSessionAsyncResponseBodyDataSessionDataClientStats : TeaModel {
                    /// <summary>
                    /// <para>The number of active sessions that belong to the client IP address.</para>
                    /// <remarks>
                    /// <para> If the type of the command executed in the session is Query or Execute and the session in the transaction is not terminated, the session is active.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    /// <summary>
                    /// <para>The IP address of the client.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>47.100.XX.XX</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The IDs of the sessions that belong to the client IP address.</para>
                    /// </summary>
                    [NameInMap("ThreadIdList")]
                    [Validation(Required=false)]
                    public List<long?> ThreadIdList { get; set; }

                    /// <summary>
                    /// <para>The total number of sessions that belong to the client IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    /// <summary>
                    /// <para>The database accounts to which the sessions belong.</para>
                    /// </summary>
                    [NameInMap("UserList")]
                    [Validation(Required=false)]
                    public List<string> UserList { get; set; }

                }

                /// <summary>
                /// <para>The sessions that are counted by database.</para>
                /// </summary>
                [NameInMap("DbStats")]
                [Validation(Required=false)]
                public List<GetMySQLAllSessionAsyncResponseBodyDataSessionDataDbStats> DbStats { get; set; }
                public class GetMySQLAllSessionAsyncResponseBodyDataSessionDataDbStats : TeaModel {
                    /// <summary>
                    /// <para>The number of active sessions of the database.</para>
                    /// <remarks>
                    /// <para> If the type of the command executed in the session is Query or Execute and the session in the transaction is not terminated, the session is active.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    /// <summary>
                    /// <para>The database name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dbTest</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The IDs of the sessions of the database.</para>
                    /// </summary>
                    [NameInMap("ThreadIdList")]
                    [Validation(Required=false)]
                    public List<long?> ThreadIdList { get; set; }

                    /// <summary>
                    /// <para>The total number of sessions of the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    /// <summary>
                    /// <para>The database accounts to which the sessions belong.</para>
                    /// </summary>
                    [NameInMap("UserList")]
                    [Validation(Required=false)]
                    public List<string> UserList { get; set; }

                }

                /// <summary>
                /// <para>The maximum execution duration of an active session. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("MaxActiveTime")]
                [Validation(Required=false)]
                public long? MaxActiveTime { get; set; }

                /// <summary>
                /// <para>The sessions.</para>
                /// </summary>
                [NameInMap("SessionList")]
                [Validation(Required=false)]
                public List<GetMySQLAllSessionAsyncResponseBodyDataSessionDataSessionList> SessionList { get; set; }
                public class GetMySQLAllSessionAsyncResponseBodyDataSessionDataSessionList : TeaModel {
                    /// <summary>
                    /// <para>The IP address of the client.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>47.100.XX.XX</para>
                    /// </summary>
                    [NameInMap("Client")]
                    [Validation(Required=false)]
                    public string Client { get; set; }

                    /// <summary>
                    /// <para>The type of the command executed in the session.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Query</para>
                    /// </summary>
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public string Command { get; set; }

                    /// <summary>
                    /// <para>The database name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dbTest</para>
                    /// </summary>
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    /// <summary>
                    /// <para>The session ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14521783</para>
                    /// </summary>
                    [NameInMap("SessionId")]
                    [Validation(Required=false)]
                    public long? SessionId { get; set; }

                    /// <summary>
                    /// <para>The SQL template ID.</para>
                    /// <remarks>
                    /// <para> This parameter is returned only when you use a PolarDB-X 2.0 instance.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a7cac1a9</para>
                    /// </summary>
                    [NameInMap("SqlTemplateId")]
                    [Validation(Required=false)]
                    public string SqlTemplateId { get; set; }

                    /// <summary>
                    /// <para>The SQL statement executed in the session.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>INSERT INTO ...</para>
                    /// </summary>
                    [NameInMap("SqlText")]
                    [Validation(Required=false)]
                    public string SqlText { get; set; }

                    /// <summary>
                    /// <para>The status of the session.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>starting</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    /// <summary>
                    /// <para>The execution duration of the session. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public long? Time { get; set; }

                    /// <summary>
                    /// <para>The duration of the transaction. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("TrxDuration")]
                    [Validation(Required=false)]
                    public long? TrxDuration { get; set; }

                    /// <summary>
                    /// <para>The ID of the transaction to which the session belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>754300775132</para>
                    /// </summary>
                    [NameInMap("TrxId")]
                    [Validation(Required=false)]
                    public string TrxId { get; set; }

                    /// <summary>
                    /// <para>The username of the database account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testUser</para>
                    /// </summary>
                    [NameInMap("User")]
                    [Validation(Required=false)]
                    public string User { get; set; }

                    /// <summary>
                    /// <para>The alias of the IP address of the client.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>master-shanghai</para>
                    /// </summary>
                    [NameInMap("UserClientAlias")]
                    [Validation(Required=false)]
                    public string UserClientAlias { get; set; }

                }

                /// <summary>
                /// <para>The time when the session was queried. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1659581514000020</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public long? TimeStamp { get; set; }

                /// <summary>
                /// <para>The total number of sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>988</para>
                /// </summary>
                [NameInMap("TotalSessionCount")]
                [Validation(Required=false)]
                public long? TotalSessionCount { get; set; }

                /// <summary>
                /// <para>The sessions that are counted by database account.</para>
                /// </summary>
                [NameInMap("UserStats")]
                [Validation(Required=false)]
                public List<GetMySQLAllSessionAsyncResponseBodyDataSessionDataUserStats> UserStats { get; set; }
                public class GetMySQLAllSessionAsyncResponseBodyDataSessionDataUserStats : TeaModel {
                    /// <summary>
                    /// <para>The number of active sessions within the account.</para>
                    /// <remarks>
                    /// <para> If the type of the command executed in the session is Query or Execute and the session in the transaction is not terminated, the session is active.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ActiveCount")]
                    [Validation(Required=false)]
                    public long? ActiveCount { get; set; }

                    /// <summary>
                    /// <para>The database account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testUser</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The IDs of the sessions within the account.</para>
                    /// </summary>
                    [NameInMap("ThreadIdList")]
                    [Validation(Required=false)]
                    public List<long?> ThreadIdList { get; set; }

                    /// <summary>
                    /// <para>The total number of sessions within the account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    /// <summary>
                    /// <para>The database accounts to which the sessions belong.</para>
                    /// </summary>
                    [NameInMap("UserList")]
                    [Validation(Required=false)]
                    public List<string> UserList { get; set; }

                }

            }

            /// <summary>
            /// <para>The state of the asynchronous request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RUNNING</b></description></item>
            /// <item><description><b>SUCCESS</b></description></item>
            /// <item><description><b>FAIL</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the asynchronous request was made. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1660100753556</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
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
