// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ChatRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IntentName")]
        [Validation(Required=false)]
        public string IntentName { get; set; }

        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public string KnowledgeId { get; set; }

        [NameInMap("Perspective")]
        [Validation(Required=false)]
        public List<string> Perspective { get; set; }

        [NameInMap("SenderId")]
        [Validation(Required=false)]
        public string SenderId { get; set; }

        [NameInMap("SenderNick")]
        [Validation(Required=false)]
        public string SenderNick { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

        [NameInMap("VendorParam")]
        [Validation(Required=false)]
        public string VendorParam { get; set; }

    }

}
