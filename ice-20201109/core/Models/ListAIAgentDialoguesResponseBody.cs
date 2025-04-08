// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAIAgentDialoguesResponseBody : TeaModel {
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
            /// <b>Example:</b>
            /// <para>19de81b3b3d94abda22****</para>
            /// </summary>
            [NameInMap("DialogueId")]
            [Validation(Required=false)]
            public string DialogueId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Producer")]
            [Validation(Required=false)]
            public string Producer { get; set; }

            [NameInMap("ReasoningText")]
            [Validation(Required=false)]
            public string ReasoningText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f27f9b9be28642a88e18****</para>
            /// </summary>
            [NameInMap("RoundId")]
            [Validation(Required=false)]
            public string RoundId { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1734511087000</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7B117AF5-***************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
