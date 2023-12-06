// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class UpdateFoundationComponentReferenceRequest : TeaModel {
        [NameInMap("componentOrchestrationValues")]
        [Validation(Required=false)]
        public string ComponentOrchestrationValues { get; set; }

        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

    }

}
