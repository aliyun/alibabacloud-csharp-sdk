// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateSimulatedSystemEventsResponseBody : TeaModel {
        [NameInMap("EventIdSet")]
        [Validation(Required=false)]
        public CreateSimulatedSystemEventsResponseBodyEventIdSet EventIdSet { get; set; }
        public class CreateSimulatedSystemEventsResponseBodyEventIdSet : TeaModel {
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public List<string> EventId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
