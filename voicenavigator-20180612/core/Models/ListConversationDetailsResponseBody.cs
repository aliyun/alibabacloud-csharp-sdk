// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ListConversationDetailsResponseBody : TeaModel {
        [NameInMap("ConversationDetails")]
        [Validation(Required=false)]
        public List<ListConversationDetailsResponseBodyConversationDetails> ConversationDetails { get; set; }
        public class ListConversationDetailsResponseBodyConversationDetails : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Dialogue</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ActionParams")]
            [Validation(Required=false)]
            public string ActionParams { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
            /// </summary>
            [NameInMap("ConversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1582266750353</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
            /// </summary>
            [NameInMap("SequenceId")]
            [Validation(Required=false)]
            public string SequenceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Chatbot</para>
            /// </summary>
            [NameInMap("Speaker")]
            [Validation(Required=false)]
            public string Speaker { get; set; }

            [NameInMap("Utterance")]
            [Validation(Required=false)]
            public string Utterance { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>14C39896-AE6D-4643-9C9A-E0566B2C2DDD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
