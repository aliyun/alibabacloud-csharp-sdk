// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostAutoRenewResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DedicatedHostRenewAttributes")]
        [Validation(Required=false)]
        public List<DescribeDedicatedHostAutoRenewResponseBodyDedicatedHostRenewAttributes> DedicatedHostRenewAttributes { get; set; }
        public class DescribeDedicatedHostAutoRenewResponseBodyDedicatedHostRenewAttributes : TeaModel {
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

            [NameInMap("RenewalStatus")]
            [Validation(Required=false)]
            public string RenewalStatus { get; set; }

            [NameInMap("AutoRenewEnabled")]
            [Validation(Required=false)]
            public bool? AutoRenewEnabled { get; set; }

        }

    }

}
