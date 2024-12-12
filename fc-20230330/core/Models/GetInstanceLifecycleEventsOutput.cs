// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class GetInstanceLifecycleEventsOutput : TeaModel {
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<InstanceEventItem> Events { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
