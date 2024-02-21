// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetRedisAllSessionResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The session data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRedisAllSessionResponseBodyData Data { get; set; }
        public class GetRedisAllSessionResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the sessions.
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<GetRedisAllSessionResponseBodyDataSessions> Sessions { get; set; }
            public class GetRedisAllSessionResponseBodyDataSessions : TeaModel {
                /// <summary>
                /// The IP address and port number of the client.
                /// </summary>
                [NameInMap("Addr")]
                [Validation(Required=false)]
                public string Addr { get; set; }

                /// <summary>
                /// The connection duration of the session. Unit: seconds.
                /// </summary>
                [NameInMap("Age")]
                [Validation(Required=false)]
                public string Age { get; set; }

                /// <summary>
                /// The IP address of the client.
                /// </summary>
                [NameInMap("Client")]
                [Validation(Required=false)]
                public string Client { get; set; }

                /// <summary>
                /// The alias of the client.
                /// </summary>
                [NameInMap("ClientDesc")]
                [Validation(Required=false)]
                public string ClientDesc { get; set; }

                /// <summary>
                /// The command that was last run.
                /// </summary>
                [NameInMap("Cmd")]
                [Validation(Required=false)]
                public string Cmd { get; set; }

                /// <summary>
                /// The ID of the database that the client is using.
                /// </summary>
                [NameInMap("Db")]
                [Validation(Required=false)]
                public long? Db { get; set; }

                /// <summary>
                /// The file descriptor event. Valid values:
                /// 
                /// *   **r**: Client sockets are readable in the event loop.
                /// *   **w**: Client sockets are writable in the event loop.
                /// </summary>
                [NameInMap("Events")]
                [Validation(Required=false)]
                public string Events { get; set; }

                /// <summary>
                /// The file descriptor that is used by sockets.
                /// </summary>
                [NameInMap("Fd")]
                [Validation(Required=false)]
                public long? Fd { get; set; }

                /// <summary>
                /// The client flag. Valid values:
                /// 
                /// *   **A**: The connection needs to be closed at the earliest opportunity.
                /// *   **b**: The client is waiting for blocked events.
                /// *   **c**: The connection is closed after all replies are written.
                /// *   **d**: The monitored keys have been modified, and the `EXEC` command is about to fail.
                /// *   **i**: The client is waiting for VM I/O operations. This value is no longer used.
                /// *   **M**: The client is the primary node.
                /// *   **N**: No special flags are configured.
                /// *   **O**: The client is in monitor mode.
                /// *   **r**: The client is a cluster node in read-only mode.
                /// *   **S**: The client is a replica node in normal mode.
                /// *   **u**: The client is not blocked.
                /// *   **U**: The client is connected by using UNIX domain sockets.
                /// *   **x**: The client is executing a transaction.
                /// </summary>
                [NameInMap("Flags")]
                [Validation(Required=false)]
                public string Flags { get; set; }

                /// <summary>
                /// The client ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The duration during which the session is in the idle state. Unit: seconds.
                /// </summary>
                [NameInMap("Idle")]
                [Validation(Required=false)]
                public long? Idle { get; set; }

                /// <summary>
                /// The number of commands in `MULTI` or `EXEC`.
                /// </summary>
                [NameInMap("Multi")]
                [Validation(Required=false)]
                public long? Multi { get; set; }

                /// <summary>
                /// The name of the client.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The node ID.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// The size of the fixed output buffer. Unit: bytes.
                /// </summary>
                [NameInMap("Obl")]
                [Validation(Required=false)]
                public long? Obl { get; set; }

                /// <summary>
                /// The number of objects contained in the output list.
                /// </summary>
                [NameInMap("Oll")]
                [Validation(Required=false)]
                public long? Oll { get; set; }

                /// <summary>
                /// The size of the output buffer. Unit: bytes.
                /// </summary>
                [NameInMap("Omem")]
                [Validation(Required=false)]
                public long? Omem { get; set; }

                /// <summary>
                /// The number of subscriptions that match the pattern.
                /// </summary>
                [NameInMap("Psub")]
                [Validation(Required=false)]
                public long? Psub { get; set; }

                /// <summary>
                /// The size of the input buffer. Unit: bytes.
                /// </summary>
                [NameInMap("Qbuf")]
                [Validation(Required=false)]
                public long? Qbuf { get; set; }

                /// <summary>
                /// The remaining size of the input buffer. Unit: bytes.
                /// </summary>
                [NameInMap("QbufFree")]
                [Validation(Required=false)]
                public long? QbufFree { get; set; }

                /// <summary>
                /// The number of subscribed channels.
                /// </summary>
                [NameInMap("Sub")]
                [Validation(Required=false)]
                public long? Sub { get; set; }

            }

            /// <summary>
            /// The statistics on the access source.
            /// </summary>
            [NameInMap("SourceStats")]
            [Validation(Required=false)]
            public List<GetRedisAllSessionResponseBodyDataSourceStats> SourceStats { get; set; }
            public class GetRedisAllSessionResponseBodyDataSourceStats : TeaModel {
                /// <summary>
                /// The total number of sessions from the access source.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                /// <summary>
                /// The client IDs.
                /// </summary>
                [NameInMap("Ids")]
                [Validation(Required=false)]
                public List<long?> Ids { get; set; }

                /// <summary>
                /// The access source.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// The time when the instance sessions were returned. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// The total number of sessions.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
