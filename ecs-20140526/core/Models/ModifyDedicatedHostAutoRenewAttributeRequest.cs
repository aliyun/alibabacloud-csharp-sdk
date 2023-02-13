// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDedicatedHostAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically renew the subscription dedicated host. Valid values:
        /// 
        /// *   true: automatically renews the subscription dedicated host.
        /// *   false: does not automatically renew the subscription dedicated host.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// Specifies whether to automatically renew the subscription dedicated host along with the subscription ECS instances hosted on it.
        /// 
        /// If auto-renewal is enabled for the subscription ECS instances hosted on your subscription dedicated host, you can specify this parameter to automatically renew the dedicated host along with the subscription ECS instances. When the subscription ECS instances hosted on your dedicated host are automatically renewed, the dedicated host is also automatically renewed if the expiration time of the dedicated host is earlier than the expiration time of the renewed instances.
        /// 
        /// When the dedicated host is configured to be automatically renewed along with the subscription ECS instances hosted on it, the dedicated host determines the expiration time of the renewed instances, and selects a minimum value from the valid values of the Duration parameter so that the dedicated host is renewed by a duration that expires later than the expiration time of the renewed instances. For more information about supported renewal durations, see the descriptions of the `PeriodUnit` and `Duration` parameters.
        /// 
        /// For example, assume that you have a subscription dedicated host that expires on January 15 of the current year. Subscription ECS instances hosted on the dedicated host have the auto-renewal feature enabled, and are automatically renewed to November 15 of the same year. The expiration time of the dedicated host is earlier than the expiration time of the ECS instances by 10 months. In this case, the dedicated host selects a renewal duration of 12 months, which is the minimum value of the `Duration` parameter (`PeriodUnit=Month`) that allows the dedicated host to expire later than the ECS instances.
        /// 
        /// Valid values:
        /// 
        /// *   AutoRenewWithEcs: automatically renews the subscription dedicated host along with the subscription ECS instances hosted on it.
        /// *   StopRenewWithEcs: does not automatically renew the subscription dedicated host along with the subscription ECS instances hosted on it.
        /// *   NoOperation: does not change the current settings for the dedicated host.
        /// 
        /// >  If you set this parameter to AutoRenewWithEcs, make sure that `AutoRenew` is set to true to enable auto-renewal for the dedicated host. Otherwise, only the parameter value is changed. The dedicated host is not automatically renewed along with the subscription ECS instances hosted on it.
        /// 
        /// Default value: NoOperation.
        /// </summary>
        [NameInMap("AutoRenewWithEcs")]
        [Validation(Required=false)]
        public string AutoRenewWithEcs { get; set; }

        /// <summary>
        /// The IDs of the dedicated hosts. You can specify up to 100 subscription dedicated host IDs. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("DedicatedHostIds")]
        [Validation(Required=false)]
        public string DedicatedHostIds { get; set; }

        /// <summary>
        /// The renewal duration of the dedicated host. Valid values:
        /// 
        /// *   When the PeriodUnit parameter is set to Week, the valid values of the Duration parameter are 1, 2, and 3.
        /// *   When the PeriodUnit parameter is set to Month, the valid values of the Duration parameter are 1, 2, 3, 6, and 12.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The unit of the renewal duration. Valid values:
        /// 
        /// *   Week
        /// *   Month
        /// 
        /// Default value: Month.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The region ID of the dedicated host.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to automatically renew the subscription dedicated host. The `RenewalStatus` parameter takes precedence over the `AutoRenew` parameter. Valid values:
        /// 
        /// *   AutoRenewal: automatically renews the subscription dedicated host.
        /// *   Normal: does not automatically renew the subscription dedicated host, but notifications for renewal are sent.
        /// *   NotRenewal: does not automatically renew the subscription dedicated host, and no expiration notification is sent. Notifications for renewal are automatically sent three days before the expiration time of the subscription dedicated host. You can change the value of this parameter from NotRenewal to Normal for the dedicated host and manually renew it by calling the [RenewDedicatedHosts](~~134250~~) operation. Alternatively, you can renew it by setting this parameter to AutoRenewal.
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
