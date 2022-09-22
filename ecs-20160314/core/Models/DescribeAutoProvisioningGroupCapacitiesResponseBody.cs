// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeAutoProvisioningGroupCapacitiesResponseBody : TeaModel {
        [NameInMap("Capacities")]
        [Validation(Required=false)]
        public DescribeAutoProvisioningGroupCapacitiesResponseBodyCapacities Capacities { get; set; }
        public class DescribeAutoProvisioningGroupCapacitiesResponseBodyCapacities : TeaModel {
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public List<DescribeAutoProvisioningGroupCapacitiesResponseBodyCapacitiesCapacity> Capacity { get; set; }
            public class DescribeAutoProvisioningGroupCapacitiesResponseBodyCapacitiesCapacity : TeaModel {
                [NameInMap("AutoProvisioningGroupId")]
                [Validation(Required=false)]
                public string AutoProvisioningGroupId { get; set; }

                [NameInMap("PayAsYouGoCapacity")]
                [Validation(Required=false)]
                public string PayAsYouGoCapacity { get; set; }

                [NameInMap("SpotCapacity")]
                [Validation(Required=false)]
                public string SpotCapacity { get; set; }

                [NameInMap("TotalCapacity")]
                [Validation(Required=false)]
                public string TotalCapacity { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
