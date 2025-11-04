// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAIAgentDialoguesResponseBody : TeaModel {
        /// <summary>
        /// <para>The dialog records.</para>
        /// </summary>
        [NameInMap("Dialogues")]
        [Validation(Required=false)]
        public List<ListAIAgentDialoguesResponseBodyDialogues> Dialogues { get; set; }
        public class ListAIAgentDialoguesResponseBodyDialogues : TeaModel {
            [NameInMap("AttachedFileList")]
            [Validation(Required=false)]
            public List<ListAIAgentDialoguesResponseBodyDialoguesAttachedFileList> AttachedFileList { get; set; }
            public class ListAIAgentDialoguesResponseBodyDialoguesAttachedFileList : TeaModel {
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The unique ID of the dialog.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19de81b3b3d94abda22****</para>
            /// </summary>
            [NameInMap("DialogueId")]
            [Validation(Required=false)]
            public string DialogueId { get; set; }

            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The speaker. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>user</description></item>
            /// <item><description>agent</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Producer")]
            [Validation(Required=false)]
            public string Producer { get; set; }

            /// <summary>
            /// <para>The reasoning trace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>I\&quot;m thinking</para>
            /// </summary>
            [NameInMap("ReasoningText")]
            [Validation(Required=false)]
            public string ReasoningText { get; set; }

            /// <summary>
            /// <para>The ID of the conversational turn.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f27f9b9be28642a88e18****</para>
            /// </summary>
            [NameInMap("RoundId")]
            [Validation(Required=false)]
            public string RoundId { get; set; }

            /// <summary>
            /// <para>The source of the message. Valid values:</para>
            /// <para>chat: messaging conversations.</para>
            /// <para>call: voice calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chat</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The specific content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp, measured in milliseconds, which indicates the time when the message was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1734511087000</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <para>The message type. Valid values:</para>
            /// <para>Voice calls:</para>
            /// <ol>
            /// <item><description>greeting: the welcome message.</description></item>
            /// <item><description>normal: the voice response.</description></item>
            /// <item><description>speech: the proactive message.</description></item>
            /// </ol>
            /// <para>Messaging conversations:</para>
            /// <ol>
            /// <item><description>normal: the text reply.</description></item>
            /// <item><description>announcement: the proactive text message.</description></item>
            /// <item><description>custom: the custom message.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>announcement</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B117AF5-***************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
