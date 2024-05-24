// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class PipelineTriggerEventSpec : TeaModel {
        [NameInMap("payload")]
        [Validation(Required=false)]
        public EventPayload Payload { get; set; }

        [NameInMap("triggerName")]
        [Validation(Required=false)]
        public string TriggerName { get; set; }

    }

}
