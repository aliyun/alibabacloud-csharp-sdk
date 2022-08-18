// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class UpdateTriggerRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("invocationRole")]
        [Validation(Required=false)]
        public string InvocationRole { get; set; }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfig { get; set; }

    }

}
