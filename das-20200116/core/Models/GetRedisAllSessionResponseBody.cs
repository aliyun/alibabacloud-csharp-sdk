// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetRedisAllSessionResponseBody : TeaModel {
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
        /// <para>The session data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRedisAllSessionResponseBodyData Data { get; set; }
        public class GetRedisAllSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the sessions.</para>
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<GetRedisAllSessionResponseBodyDataSessions> Sessions { get; set; }
            public class GetRedisAllSessionResponseBodyDataSessions : TeaModel {
                /// <summary>
                /// <para>The IP address and port number of the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.XX.XX:53458</para>
                /// </summary>
                [NameInMap("Addr")]
                [Validation(Required=false)]
                public string Addr { get; set; }

                /// <summary>
                /// <para>The connection duration of the session. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Age")]
                [Validation(Required=false)]
                public string Age { get; set; }

                /// <summary>
                /// <para>The IP address of the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.XX.XX</para>
                /// </summary>
                [NameInMap("Client")]
                [Validation(Required=false)]
                public string Client { get; set; }

                /// <summary>
                /// <para>The alias of the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod ip</para>
                /// </summary>
                [NameInMap("ClientDesc")]
                [Validation(Required=false)]
                public string ClientDesc { get; set; }

                /// <summary>
                /// <para>The command that was last run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PING</para>
                /// </summary>
                [NameInMap("Cmd")]
                [Validation(Required=false)]
                public string Cmd { get; set; }

                /// <summary>
                /// <para>The ID of the database that the client is using.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Db")]
                [Validation(Required=false)]
                public long? Db { get; set; }

                /// <summary>
                /// <para>The file descriptor event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>r</b>: Client sockets are readable in the event loop.</description></item>
                /// <item><description><b>w</b>: Client sockets are writable in the event loop.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>r</para>
                /// </summary>
                [NameInMap("Events")]
                [Validation(Required=false)]
                public string Events { get; set; }

                /// <summary>
                /// <para>The file descriptor that is used by sockets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>73</para>
                /// </summary>
                [NameInMap("Fd")]
                [Validation(Required=false)]
                public long? Fd { get; set; }

                /// <summary>
                /// <para>The client flag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>A</b>: The connection needs to be closed at the earliest opportunity.</description></item>
                /// <item><description><b>b</b>: The client is waiting for blocked events.</description></item>
                /// <item><description><b>c</b>: The connection is closed after all replies are written.</description></item>
                /// <item><description><b>d</b>: The monitored keys have been modified, and the <c>EXEC</c> command is about to fail.</description></item>
                /// <item><description><b>i</b>: The client is waiting for VM I/O operations. This value is no longer used.</description></item>
                /// <item><description><b>M</b>: The client is the primary node.</description></item>
                /// <item><description><b>N</b>: No special flags are configured.</description></item>
                /// <item><description><b>O</b>: The client is in monitor mode.</description></item>
                /// <item><description><b>r</b>: The client is a cluster node in read-only mode.</description></item>
                /// <item><description><b>S</b>: The client is a replica node in normal mode.</description></item>
                /// <item><description><b>u</b>: The client is not blocked.</description></item>
                /// <item><description><b>U</b>: The client is connected by using UNIX domain sockets.</description></item>
                /// <item><description><b>x</b>: The client is executing a transaction.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>N</para>
                /// </summary>
                [NameInMap("Flags")]
                [Validation(Required=false)]
                public string Flags { get; set; }

                /// <summary>
                /// <para>The client ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9080586</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The duration during which the session is in the idle state. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("Idle")]
                [Validation(Required=false)]
                public long? Idle { get; set; }

                /// <summary>
                /// <para>The number of commands in <c>MULTI</c> or <c>EXEC</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("Multi")]
                [Validation(Required=false)]
                public long? Multi { get; set; }

                /// <summary>
                /// <para>The name of the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-2zemyfd1sh1u2i****-proxy-14#1679****</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The size of the fixed output buffer. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Obl")]
                [Validation(Required=false)]
                public long? Obl { get; set; }

                /// <summary>
                /// <para>The number of objects contained in the output list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Oll")]
                [Validation(Required=false)]
                public long? Oll { get; set; }

                /// <summary>
                /// <para>The size of the output buffer. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Omem")]
                [Validation(Required=false)]
                public long? Omem { get; set; }

                /// <summary>
                /// <para>The number of subscriptions that match the pattern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Psub")]
                [Validation(Required=false)]
                public long? Psub { get; set; }

                /// <summary>
                /// <para>The size of the input buffer. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Qbuf")]
                [Validation(Required=false)]
                public long? Qbuf { get; set; }

                /// <summary>
                /// <para>The remaining size of the input buffer. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("QbufFree")]
                [Validation(Required=false)]
                public long? QbufFree { get; set; }

                /// <summary>
                /// <para>The number of subscribed channels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Sub")]
                [Validation(Required=false)]
                public long? Sub { get; set; }

            }

            /// <summary>
            /// <para>The statistics on the access source.</para>
            /// </summary>
            [NameInMap("SourceStats")]
            [Validation(Required=false)]
            public List<GetRedisAllSessionResponseBodyDataSourceStats> SourceStats { get; set; }
            public class GetRedisAllSessionResponseBodyDataSourceStats : TeaModel {
                /// <summary>
                /// <para>The total number of sessions from the access source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                /// <summary>
                /// <para>The client IDs.</para>
                /// </summary>
                [NameInMap("Ids")]
                [Validation(Required=false)]
                public List<long?> Ids { get; set; }

                /// <summary>
                /// <para>The access source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.XX.XX</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <para>The time when the instance sessions were returned. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1660100753556</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The total number of sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
        /// <para>40C6E9AF-6C23-5614-AA83-34344CC6****</para>
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
