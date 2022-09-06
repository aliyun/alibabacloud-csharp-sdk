// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateIntentRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IntentDescription")]
        [Validation(Required=false)]
        public string IntentDescription { get; set; }

        [NameInMap("IntentName")]
        [Validation(Required=false)]
        public string IntentName { get; set; }

        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        [NameInMap("Utterances")]
        [Validation(Required=false)]
        public string Utterances { get; set; }

    }

}
