// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WuyingAI20260311.Models
{
    public class ChatResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<ChatResponseBodyContent> Content { get; set; }
        public class ChatResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;call_id&quot;:&quot;call_xxx&quot;,&quot;name&quot;:&quot;get_weather&quot;,&quot;arguments&quot;:&quot;{&quot;city&quot;:&quot;Beijing&quot;}&quot;}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("Object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>您好</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1773380609</para>
        /// </summary>
        [NameInMap("Created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1773380609</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>msg_xxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>response</para>
        /// </summary>
        [NameInMap("Object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EA12****-<b><b>-</b></b>-****-****E5C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SequenceNumber")]
        [Validation(Required=false)]
        public string SequenceNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>176405663****961</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>in_progress</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;hello&quot;</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>message / text</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
