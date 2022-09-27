// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AllocateDedicatedHostsResponseBody : TeaModel {
        [NameInMap("DedicatedHostIdSets")]
        [Validation(Required=false)]
        public AllocateDedicatedHostsResponseBodyDedicatedHostIdSets DedicatedHostIdSets { get; set; }
        public class AllocateDedicatedHostsResponseBodyDedicatedHostIdSets : TeaModel {
            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public List<string> DedicatedHostId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
