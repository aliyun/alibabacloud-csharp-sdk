// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class DeliveryOption : TeaModel {
        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public long? Concurrency { get; set; }

        [NameInMap("eventSchema")]
        [Validation(Required=false)]
        public string EventSchema { get; set; }

        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

    }

}
