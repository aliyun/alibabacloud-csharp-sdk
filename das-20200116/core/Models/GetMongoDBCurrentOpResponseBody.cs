// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetMongoDBCurrentOpResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The details of the sessions.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMongoDBCurrentOpResponseBodyData Data { get; set; }
        public class GetMongoDBCurrentOpResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The sessions.</para>
            /// </summary>
            [NameInMap("SessionList")]
            [Validation(Required=false)]
            public List<GetMongoDBCurrentOpResponseBodyDataSessionList> SessionList { get; set; }
            public class GetMongoDBCurrentOpResponseBodyDataSessionList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the operation is active. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Active")]
                [Validation(Required=false)]
                public bool? Active { get; set; }

                /// <summary>
                /// <para>The IP address of the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>219.143.177.4:52324</para>
                /// </summary>
                [NameInMap("Client")]
                [Validation(Required=false)]
                public string Client { get; set; }

                /// <summary>
                /// <para>The document that contains the complete command object associated with the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;command&quot; : {
                ///   &quot;find&quot; : &quot;items&quot;,
                ///   &quot;filter&quot; : {
                ///     &quot;sku&quot; : 1403978
                ///   },
                ///   ...
                ///   &quot;$db&quot; : &quot;test&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The connection ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>66378736</para>
                /// </summary>
                [NameInMap("ConnectionId")]
                [Validation(Required=false)]
                public long? ConnectionId { get; set; }

                /// <summary>
                /// <para>The description of the connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>conn1013858</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The driver for MongoDB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mongo-java-driver|<a href="mailto:legacy@3.11.2">legacy@3.11.2</a></para>
                /// </summary>
                [NameInMap("Driver")]
                [Validation(Required=false)]
                public string Driver { get; set; }

                /// <summary>
                /// <para>The host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a79******.cloud.et15:3328</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>Indicates whether the operation is marked as terminated.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("KillPending")]
                [Validation(Required=false)]
                public bool? KillPending { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin.cmd</para>
                /// </summary>
                [NameInMap("Ns")]
                [Validation(Required=false)]
                public string Ns { get; set; }

                /// <summary>
                /// <para>The type of the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>update</para>
                /// </summary>
                [NameInMap("Op")]
                [Validation(Required=false)]
                public string Op { get; set; }

                /// <summary>
                /// <para>The operation ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14508</para>
                /// </summary>
                [NameInMap("OpId")]
                [Validation(Required=false)]
                public string OpId { get; set; }

                /// <summary>
                /// <para>The architecture of the operating system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amd64</para>
                /// </summary>
                [NameInMap("OsArch")]
                [Validation(Required=false)]
                public string OsArch { get; set; }

                /// <summary>
                /// <para>The name of the operating system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Linux</para>
                /// </summary>
                [NameInMap("OsName")]
                [Validation(Required=false)]
                public string OsName { get; set; }

                /// <summary>
                /// <para>The type of the operating system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Linux</para>
                /// </summary>
                [NameInMap("OsType")]
                [Validation(Required=false)]
                public string OsType { get; set; }

                /// <summary>
                /// <para>The description of the execution plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("PlanSummary")]
                [Validation(Required=false)]
                public string PlanSummary { get; set; }

                /// <summary>
                /// <para>The platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Java/Alibaba/1.8.0_152-b5</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <para>The duration of the operation. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("SecsRunning")]
                [Validation(Required=false)]
                public long? SecsRunning { get; set; }

                /// <summary>
                /// <para>The ID of the data shard.</para>
                /// <remarks>
                /// <para> This parameter is returned for sharded cluster instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp1689995b78****</para>
                /// </summary>
                [NameInMap("Shard")]
                [Validation(Required=false)]
                public string Shard { get; set; }

            }

            /// <summary>
            /// <para>The statistics on the sessions.</para>
            /// </summary>
            [NameInMap("SessionStat")]
            [Validation(Required=false)]
            public GetMongoDBCurrentOpResponseBodyDataSessionStat SessionStat { get; set; }
            public class GetMongoDBCurrentOpResponseBodyDataSessionStat : TeaModel {
                /// <summary>
                /// <para>The number of active sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ActiveCount")]
                [Validation(Required=false)]
                public long? ActiveCount { get; set; }

                /// <summary>
                /// <para>The statistics on the IP addresses of the clients.</para>
                /// </summary>
                [NameInMap("ClientStats")]
                [Validation(Required=false)]
                public Dictionary<string, DataSessionStatClientStatsValue> ClientStats { get; set; }

                /// <summary>
                /// <para>The statistics on the namespaces.</para>
                /// </summary>
                [NameInMap("DbStats")]
                [Validation(Required=false)]
                public Dictionary<string, DataSessionStatDbStatsValue> DbStats { get; set; }

                /// <summary>
                /// <para>The longest duration of a session. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LongestSecsRunning")]
                [Validation(Required=false)]
                public long? LongestSecsRunning { get; set; }

                /// <summary>
                /// <para>The total number of sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>55</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The time when the database sessions were returned. The value is in the UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1692029584428</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. Otherwise, an error message such as an error code is returned.</para>
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
        /// <para>FC6C0929-29E1-59FD-8DFE-70D9D41E****</para>
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
