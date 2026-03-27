// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetThreadDataResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetThreadDataResponseBodyData> Data { get; set; }
        public class GetThreadDataResponseBodyData : TeaModel {
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<GetThreadDataResponseBodyDataMessages> Messages { get; set; }
            public class GetThreadDataResponseBodyDataMessages : TeaModel {
                [NameInMap("agents")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Agents { get; set; }

                [NameInMap("artifacts")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Artifacts { get; set; }

                [NameInMap("callId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                [NameInMap("contents")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Contents { get; set; }

                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                [NameInMap("events")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Events { get; set; }

                [NameInMap("parentCallId")]
                [Validation(Required=false)]
                public string ParentCallId { get; set; }

                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("seq")]
                [Validation(Required=false)]
                public int? Seq { get; set; }

                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                [NameInMap("tools")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Tools { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public string DigitalEmployeeName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aliding_thread_448d05c048a3481f8c19bc1a6038f8f6</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

    }

}
