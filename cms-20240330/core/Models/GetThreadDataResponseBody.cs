// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetThreadDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The message data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetThreadDataResponseBodyData> Data { get; set; }
        public class GetThreadDataResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of messages in the session.</para>
            /// </summary>
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<GetThreadDataResponseBodyDataMessages> Messages { get; set; }
            public class GetThreadDataResponseBodyDataMessages : TeaModel {
                /// <summary>
                /// <para>A list of invoked agents.</para>
                /// </summary>
                [NameInMap("agents")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Agents { get; set; }

                /// <summary>
                /// <para>Information about the generated artifacts.</para>
                /// </summary>
                [NameInMap("artifacts")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Artifacts { get; set; }

                /// <summary>
                /// <para>The execution ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3b5287b7176360</para>
                /// </summary>
                [NameInMap("callId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>The message content.</para>
                /// </summary>
                [NameInMap("contents")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Contents { get; set; }

                /// <summary>
                /// <para>The details of the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>context of model exceed</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>A list of events.</para>
                /// </summary>
                [NameInMap("events")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Events { get; set; }

                /// <summary>
                /// <para>The execution ID of the parent level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3b5287b7176360</para>
                /// </summary>
                [NameInMap("parentCallId")]
                [Validation(Required=false)]
                public string ParentCallId { get; set; }

                /// <summary>
                /// <para>The role that sent the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The sequence number of the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("seq")]
                [Validation(Required=false)]
                public int? Seq { get; set; }

                /// <summary>
                /// <para>The timestamp in nanoseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1768702985000000000</para>
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                /// <summary>
                /// <para>A list of tools that were used.</para>
                /// </summary>
                [NameInMap("tools")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Tools { get; set; }

                /// <summary>
                /// <para>The type of the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>task_finished</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The version of the message data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v0.1.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The ID of the current message request. This is the first request ID in the root data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The ID of the current message request. This is the first trace ID in the root data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3b5287b717636040171772050d0095</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>The name of the digital employee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public string DigitalEmployeeName { get; set; }

        /// <summary>
        /// <para>The maximum number of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thread_id01</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

    }

}
