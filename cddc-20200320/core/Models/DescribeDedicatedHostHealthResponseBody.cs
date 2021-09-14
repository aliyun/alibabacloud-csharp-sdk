// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedHostHealthResponseBody : TeaModel {
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        [NameInMap("ResourceEvent")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResourceEvent { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public Dictionary<string, object> HealthStatus { get; set; }

        [NameInMap("HostEvents")]
        [Validation(Required=false)]
        public DescribeDedicatedHostHealthResponseBodyHostEvents HostEvents { get; set; }
        public class DescribeDedicatedHostHealthResponseBodyHostEvents : TeaModel {
            [NameInMap("HostEvents")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostHealthResponseBodyHostEventsHostEvents> HostEvents { get; set; }
            public class DescribeDedicatedHostHealthResponseBodyHostEventsHostEvents : TeaModel {
                public string EventName { get; set; }
                public string EventTime { get; set; }
                public string EventType { get; set; }
                public string EventDescription { get; set; }
            }
        };

    }

}
