// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyDialogueFlowRequest : TeaModel {
        [NameInMap("DialogueFlowDefinition")]
        [Validation(Required=false)]
        public string DialogueFlowDefinition { get; set; }

        [NameInMap("DialogueFlowId")]
        [Validation(Required=false)]
        public string DialogueFlowId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsDrafted")]
        [Validation(Required=false)]
        public bool? IsDrafted { get; set; }

        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

    }

}
