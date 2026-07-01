// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAIAgentDialoguesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of dialogues.</para>
        /// </summary>
        [NameInMap("Dialogues")]
        [Validation(Required=false)]
        public List<ListAIAgentDialoguesResponseBodyDialogues> Dialogues { get; set; }
        public class ListAIAgentDialoguesResponseBodyDialogues : TeaModel {
            /// <summary>
            /// <para>A list of file attachments referenced in the dialogue.</para>
            /// </summary>
            [NameInMap("AttachedFileList")]
            [Validation(Required=false)]
            public List<ListAIAgentDialoguesResponseBodyDialoguesAttachedFileList> AttachedFileList { get; set; }
            public class ListAIAgentDialoguesResponseBodyDialoguesAttachedFileList : TeaModel {
                /// <summary>
                /// <para>The format of the attachment, such as mp3, wav, or pdf.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mp3</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The unique identifier of the attachment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7B117AF5-***************</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The file name of the attachment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MusicDemix</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The attachment type, represented by a numeric value. The meaning of this value is defined by your business logic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The URL of the attachment.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://media.w3.org/2010/05/sintel/trailer.mp3">https://media.w3.org/2010/05/sintel/trailer.mp3</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The unique ID of the dialogue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19de81b3b3d94abda22****</para>
            /// </summary>
            [NameInMap("DialogueId")]
            [Validation(Required=false)]
            public string DialogueId { get; set; }

            /// <summary>
            /// <para>A JSON-formatted string for extended information. Use this field to store custom data, such as sentiment labels or intent recognition results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;addTransferLock\&quot;:true}</para>
            /// </summary>
            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            /// <summary>
            /// <para>The ID of the workflow node that generated the dialogue entry, which you can use for tracing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e01-cn-to345ikn62o</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The producer of this message.</para>
            /// <list type="bullet">
            /// <item><description><para>user: A message from the user.</para>
            /// </description></item>
            /// <item><description><para>agent: A message from the agent.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Producer")]
            [Validation(Required=false)]
            public string Producer { get; set; }

            /// <summary>
            /// <para>The agent\&quot;s reasoning text, which can reveal its thought process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>我在思考</para>
            /// </summary>
            [NameInMap("ReasoningText")]
            [Validation(Required=false)]
            public string ReasoningText { get; set; }

            /// <summary>
            /// <para>The ID of the dialogue round.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f27f9b9be28642a88e18****</para>
            /// </summary>
            [NameInMap("RoundId")]
            [Validation(Required=false)]
            public string RoundId { get; set; }

            /// <summary>
            /// <para>The source channel of the message. Valid values:</para>
            /// <para>chat: The message is from a text chat.</para>
            /// <para>call: The message is from a voice call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chat</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The text content of the dialogue entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The Unix timestamp (in milliseconds) when the dialogue entry was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1734511087000</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <para>The type of the message. Valid values include:</para>
            /// <para>For a call:</para>
            /// <ol>
            /// <item><description><para>greeting: A welcome message.</para>
            /// </description></item>
            /// <item><description><para>normal: A standard voice response.</para>
            /// </description></item>
            /// <item><description><para>speech: A proactive voice broadcast.</para>
            /// </description></item>
            /// </ol>
            /// <para>For a chat:</para>
            /// <ol>
            /// <item><description><para>normal: A standard text response.</para>
            /// </description></item>
            /// <item><description><para>announcement: A proactive text push.</para>
            /// </description></item>
            /// <item><description><para>custom: A custom message.</para>
            /// </description></item>
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
