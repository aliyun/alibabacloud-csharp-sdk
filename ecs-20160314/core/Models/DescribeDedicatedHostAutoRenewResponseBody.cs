// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeDedicatedHostAutoRenewResponseBody : TeaModel {
        [NameInMap("InstanceRenewAttributes")]
        [Validation(Required=false)]
        public DescribeDedicatedHostAutoRenewResponseBodyInstanceRenewAttributes InstanceRenewAttributes { get; set; }
        public class DescribeDedicatedHostAutoRenewResponseBodyInstanceRenewAttributes : TeaModel {
            [NameInMap("InstanceRenewAttribute")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostAutoRenewResponseBodyInstanceRenewAttributesInstanceRenewAttribute> InstanceRenewAttribute { get; set; }
            public class DescribeDedicatedHostAutoRenewResponseBodyInstanceRenewAttributesInstanceRenewAttribute : TeaModel {
                [NameInMap("AutoRenewEnabled")]
                [Validation(Required=false)]
                public bool? AutoRenewEnabled { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                [NameInMap("RenewalStatus")]
                [Validation(Required=false)]
                public string RenewalStatus { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
