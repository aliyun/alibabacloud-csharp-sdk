// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ListConversationDetailsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConversationDetails")]
        [Validation(Required=false)]
        public List<ListConversationDetailsResponseBodyConversationDetails> ConversationDetails { get; set; }
        public class ListConversationDetailsResponseBodyConversationDetails : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("Speaker")]
            [Validation(Required=false)]
            public string Speaker { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("ConversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            [NameInMap("ActionParams")]
            [Validation(Required=false)]
            public string ActionParams { get; set; }

            [NameInMap("SequenceId")]
            [Validation(Required=false)]
            public string SequenceId { get; set; }

            [NameInMap("Utterance")]
            [Validation(Required=false)]
            public string Utterance { get; set; }

        }

    }

}
