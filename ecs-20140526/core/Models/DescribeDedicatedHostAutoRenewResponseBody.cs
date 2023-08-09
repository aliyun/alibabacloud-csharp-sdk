// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostAutoRenewResponseBody : TeaModel {
        /// <summary>
        /// The unit of the auto-renewal period. Valid values:
        /// 
        /// *   Week
        /// *   Month
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
                /// Indicates whether the subscription dedicated host is automatically renewed along with the subscription Elastic Compute Service (ECS) instances hosted on it if the new expiration time of the renewed instances is later than the expiration time of the dedicated host. Valid values:
                /// 
                /// *   AutoRenewWithEcs: The subscription dedicated host is automatically renewed along with the subscription ECS instances hosted on it.
                /// *   StopRenewWithEcs: The subscription dedicated host is not automatically renewed along with the subscription ECS instances hosted on it.
                /// </summary>
                [NameInMap("AutoRenewEnabled")]
                [Validation(Required=false)]
                public bool? AutoRenewEnabled { get; set; }

                [NameInMap("AutoRenewWithEcs")]
                [Validation(Required=false)]
                public string AutoRenewWithEcs { get; set; }

                /// <summary>
                /// Indicates whether the subscription dedicated host is automatically renewed. Valid values:
                /// 
                /// *   AutoRenewal: The dedicated host is automatically renewed.
                /// *   Normal: The dedicated host is not automatically renewed, and you will receive notifications for renewal.
                /// *   NotRenewal: The dedicated host is not renewed, and no expiration notification is sent. Notifications for renewal are automatically sent three days before the dedicated host expires. You can change the value of this parameter from NotRenewal to Normal for the dedicated host and manually renew it by calling the [RenewDedicatedHosts](~~93287~~) operation. Alternatively, you can set this parameter to AutoRenewal to configure the dedicated host to be automatically renewed.
                /// </summary>
                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }

                /// <summary>
                /// The ID of the dedicated host.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// The auto-renewal period.
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// Indicates whether the subscription dedicated host is automatically renewed. Valid values:
                /// 
                /// *   true: The dedicated host is automatically renewed.
                /// *   false: The dedicated host is not automatically renewed.
                /// </summary>
                [NameInMap("RenewalStatus")]
                [Validation(Required=false)]
                public string RenewalStatus { get; set; }

            }

        }

        /// <summary>
        /// Details about the auto-renewal attributes of the dedicated hosts.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
