// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class DeliveryOption : TeaModel {
        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public long? Concurrency { get; set; }

        [NameInMap("eventSchema")]
        [Validation(Required=false)]
        public string EventSchema { get; set; }

    }

}
