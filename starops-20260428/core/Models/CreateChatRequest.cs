// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class CreateChatRequest : TeaModel {
        /// <summary>
        /// <para>The operation type. Valid values: <c>create</c> (default), <c>reconnect</c>, and <c>stop</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

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
        /// <para>The message list.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<CreateChatRequestMessages> Messages { get; set; }
        public class CreateChatRequestMessages : TeaModel {
            /// <summary>
            /// <para>The multimodal content of the message.</para>
            /// </summary>
            [NameInMap("contents")]
            [Validation(Required=false)]
            public List<CreateChatRequestMessagesContents> Contents { get; set; }
            public class CreateChatRequestMessagesContents : TeaModel {
                /// <summary>
                /// <para>The content type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value of the content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>A unique identifier for the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>message_id02</para>
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The role of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The tool call list.</para>
            /// </summary>
            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Tools { get; set; }

        }

        /// <summary>
        /// <para>The session thread ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thread_id01</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// <para>The set of variables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;workspace&quot;: &quot;test&quot;,
        ///   &quot;region&quot;: &quot;cn-beijing&quot;,
        ///   &quot;project&quot;: &quot;test&quot;,
        ///   &quot;language&quot;: &quot;zh&quot;,
        ///   &quot;timeZone&quot;: &quot;Asia/Shanghai&quot;,
        ///   &quot;timeStamp&quot;: &quot;1768893948&quot;,
        ///   &quot;startTime&quot;: 1768887171,
        ///   &quot;endTime&quot;: 1768890771,
        ///   &quot;skill&quot;: &quot;trace&quot;
        /// }</para>
        /// </summary>
        [NameInMap("variables")]
        [Validation(Required=false)]
        public Dictionary<string, object> Variables { get; set; }

    }

}
