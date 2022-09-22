// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class RenewDedicatedHostsResponseBody : TeaModel {
        [NameInMap("DedicatedHostIdSets")]
        [Validation(Required=false)]
        public RenewDedicatedHostsResponseBodyDedicatedHostIdSets DedicatedHostIdSets { get; set; }
        public class RenewDedicatedHostsResponseBodyDedicatedHostIdSets : TeaModel {
            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public List<string> DedicatedHostId { get; set; }

        }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
