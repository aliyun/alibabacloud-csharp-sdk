// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateChatRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>create</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public string DigitalEmployeeName { get; set; }

        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<CreateChatRequestMessages> Messages { get; set; }
        public class CreateChatRequestMessages : TeaModel {
            [NameInMap("contents")]
            [Validation(Required=false)]
            public List<CreateChatRequestMessagesContents> Contents { get; set; }
            public class CreateChatRequestMessagesContents : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>message_id02</para>
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Tools { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>thread_id01</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public Dictionary<string, object> Variables { get; set; }

    }

}
