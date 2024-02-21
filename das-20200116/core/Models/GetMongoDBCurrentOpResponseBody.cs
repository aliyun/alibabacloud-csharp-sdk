// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetMongoDBCurrentOpResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The details of the sessions.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMongoDBCurrentOpResponseBodyData Data { get; set; }
        public class GetMongoDBCurrentOpResponseBodyData : TeaModel {
            /// <summary>
            /// The sessions.
            /// </summary>
            [NameInMap("SessionList")]
            [Validation(Required=false)]
            public List<GetMongoDBCurrentOpResponseBodyDataSessionList> SessionList { get; set; }
            public class GetMongoDBCurrentOpResponseBodyDataSessionList : TeaModel {
                /// <summary>
                /// Indicates whether the operation is active. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Active")]
                [Validation(Required=false)]
                public bool? Active { get; set; }

                /// <summary>
                /// The IP address of the client.
                /// </summary>
                [NameInMap("Client")]
                [Validation(Required=false)]
                public string Client { get; set; }

                /// <summary>
                /// The document that contains the complete command object associated with the operation.
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// The connection ID.
                /// </summary>
                [NameInMap("ConnectionId")]
                [Validation(Required=false)]
                public long? ConnectionId { get; set; }

                /// <summary>
                /// The description of the connection.
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// The driver for MongoDB.
                /// </summary>
                [NameInMap("Driver")]
                [Validation(Required=false)]
                public string Driver { get; set; }

                /// <summary>
                /// The host.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// Indicates whether the operation is marked as terminated.
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("KillPending")]
                [Validation(Required=false)]
                public bool? KillPending { get; set; }

                /// <summary>
                /// The namespace.
                /// </summary>
                [NameInMap("Ns")]
                [Validation(Required=false)]
                public string Ns { get; set; }

                /// <summary>
                /// The type of the operation.
                /// </summary>
                [NameInMap("Op")]
                [Validation(Required=false)]
                public string Op { get; set; }

                /// <summary>
                /// The operation ID.
                /// </summary>
                [NameInMap("OpId")]
                [Validation(Required=false)]
                public string OpId { get; set; }

                /// <summary>
                /// The architecture of the operating system.
                /// </summary>
                [NameInMap("OsArch")]
                [Validation(Required=false)]
                public string OsArch { get; set; }

                /// <summary>
                /// The name of the operating system.
                /// </summary>
                [NameInMap("OsName")]
                [Validation(Required=false)]
                public string OsName { get; set; }

                /// <summary>
                /// The type of the operating system.
                /// </summary>
                [NameInMap("OsType")]
                [Validation(Required=false)]
                public string OsType { get; set; }

                /// <summary>
                /// The description of the execution plan.
                /// </summary>
                [NameInMap("PlanSummary")]
                [Validation(Required=false)]
                public string PlanSummary { get; set; }

                /// <summary>
                /// The platform.
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// The duration of the operation. Unit: seconds.
                /// </summary>
                [NameInMap("SecsRunning")]
                [Validation(Required=false)]
                public long? SecsRunning { get; set; }

                /// <summary>
                /// The ID of the data shard.
                /// 
                /// >  This parameter is returned for sharded cluster instances.
                /// </summary>
                [NameInMap("Shard")]
                [Validation(Required=false)]
                public string Shard { get; set; }

            }

            /// <summary>
            /// The statistics on the sessions.
            /// </summary>
            [NameInMap("SessionStat")]
            [Validation(Required=false)]
            public GetMongoDBCurrentOpResponseBodyDataSessionStat SessionStat { get; set; }
            public class GetMongoDBCurrentOpResponseBodyDataSessionStat : TeaModel {
                /// <summary>
                /// The number of active sessions.
                /// </summary>
                [NameInMap("ActiveCount")]
                [Validation(Required=false)]
                public long? ActiveCount { get; set; }

                /// <summary>
                /// The statistics on the IP addresses of the clients.
                /// </summary>
                [NameInMap("ClientStats")]
                [Validation(Required=false)]
                public Dictionary<string, DataSessionStatClientStatsValue> ClientStats { get; set; }

                /// <summary>
                /// The statistics on the namespaces.
                /// </summary>
                [NameInMap("DbStats")]
                [Validation(Required=false)]
                public Dictionary<string, DataSessionStatDbStatsValue> DbStats { get; set; }

                /// <summary>
                /// The longest duration of a session. Unit: seconds.
                /// </summary>
                [NameInMap("LongestSecsRunning")]
                [Validation(Required=false)]
                public long? LongestSecsRunning { get; set; }

                /// <summary>
                /// The total number of sessions.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// The time when the database sessions were returned. The value is in the UNIX timestamp format. Unit: milliseconds.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. Otherwise, an error message such as an error code is returned.
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
