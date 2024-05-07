// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostAutoRenewResponseBody : TeaModel {
        /// <summary>
        /// The array that consists of dedicated host auto-renewal attributes.
        /// </summary>
        [NameInMap("DedicatedHostRenewAttributes")]
        [Validation(Required=false)]
        public DescribeDedicatedHostAutoRenewResponseBodyDedicatedHostRenewAttributes DedicatedHostRenewAttributes { get; set; }
        public class DescribeDedicatedHostAutoRenewResponseBodyDedicatedHostRenewAttributes : TeaModel {
            [NameInMap("DedicatedHostRenewAttribute")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostAutoRenewResponseBodyDedicatedHostRenewAttributesDedicatedHostRenewAttribute> DedicatedHostRenewAttribute { get; set; }
            public class DescribeDedicatedHostAutoRenewResponseBodyDedicatedHostRenewAttributesDedicatedHostRenewAttribute : TeaModel {
                /// <summary>
                /// Indicates whether auto-renewal is enabled. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("AutoRenewEnabled")]
                [Validation(Required=false)]
                public bool? AutoRenewEnabled { get; set; }

                /// <summary>
                /// Indicates whether the dedicated host is automatically renewed if a subscription ECS instance it hosts, after being automatically renewed, has a new expiration time that is later than that of the dedicated host. Valid values:
                /// 
                /// *   AutoRenewWithEcs: The dedicated host is automatically renewed along with the ECS instance.
                /// *   StopRenewWithEcs: The dedicated host is not automatically renewed along with the ECS instance.
                /// </summary>
                [NameInMap("AutoRenewWithEcs")]
                [Validation(Required=false)]
                public string AutoRenewWithEcs { get; set; }

                /// <summary>
                /// The ID of the dedicated host.
                /// </summary>
                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }

                /// <summary>
                /// The auto-renewal period.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// The unit of the auto-renewal duration. Valid values:
                /// 
                /// *   Week
                /// *   Month
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// Indicates whether the subscription dedicated host is automatically renewed. Valid values:
                /// 
                /// *   AutoRenewal: The dedicated host is automatically renewed.
                /// *   Normal: The dedicated host is not automatically renewed, but renewal notifications are sent.
                /// *   NotRenewal: The dedicated host is not automatically renewed, and no expiration notification is sent. Alibaba Cloud sends only a non-renewal notice three days before the host expires. If the renewal status of a dedicated host is NotRenewal, you can change the value to Normal and then call [RenewDedicatedHosts](~~93287~~) to manually renew the dedicated host, or directly change the value to AutoRenewal.
                /// </summary>
                [NameInMap("RenewalStatus")]
                [Validation(Required=false)]
                public string RenewalStatus { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
