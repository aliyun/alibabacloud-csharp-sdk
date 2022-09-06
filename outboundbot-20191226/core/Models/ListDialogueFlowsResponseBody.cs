// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListDialogueFlowsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DialogueFlows")]
        [Validation(Required=false)]
        public List<ListDialogueFlowsResponseBodyDialogueFlows> DialogueFlows { get; set; }
        public class ListDialogueFlowsResponseBodyDialogueFlows : TeaModel {
            [NameInMap("DialogueFlowDefinition")]
            [Validation(Required=false)]
            public string DialogueFlowDefinition { get; set; }

            [NameInMap("DialogueFlowId")]
            [Validation(Required=false)]
            public string DialogueFlowId { get; set; }

            [NameInMap("DialogueFlowName")]
            [Validation(Required=false)]
            public string DialogueFlowName { get; set; }

            [NameInMap("DialogueFlowType")]
            [Validation(Required=false)]
            public string DialogueFlowType { get; set; }

            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("ScriptVersion")]
            [Validation(Required=false)]
            public string ScriptVersion { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
