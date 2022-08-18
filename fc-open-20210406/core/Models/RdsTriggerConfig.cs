// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class RdsTriggerConfig : TeaModel {
        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public long? Concurrency { get; set; }

        [NameInMap("eventFormat")]
        [Validation(Required=false)]
        public string EventFormat { get; set; }

        [NameInMap("retry")]
        [Validation(Required=false)]
        public long? Retry { get; set; }

        [NameInMap("subscriptionObjects")]
        [Validation(Required=false)]
        public List<string> SubscriptionObjects { get; set; }

    }

}
