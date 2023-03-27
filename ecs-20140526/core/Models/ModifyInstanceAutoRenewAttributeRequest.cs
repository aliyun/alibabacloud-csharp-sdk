// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable auto-renewal for the instance.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal period for the instance.
        /// 
        /// *   Valid values of `Duration` when `PeriodUnit` is set to `Year` (year): 1, 2, 3, 4, and 5.
        /// *   Valid values of `Duration` when `PeriodUnit` is set to `Month` (month): 1, 2, 3, 6, 12, 24, 36, 48, and 60.
        /// *   Valid values of `Duration` when `PeriodUnit` is set to `Week` (week): 1, 2, 3, and 4.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The ID of the instance. You can specify IDs of up to 100 subscription instances. Separate the instance IDs with commas (,).
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The unit of the renewal period (`Duration`). Default value: Month. Valid values:
        /// 
        /// *   Week
        /// *   Month
        /// *   Year
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The auto-renewal state of the instance. Valid values:
        /// 
        /// *   AutoRenewal: Auto-renewal is enabled for the instance.
        /// *   Normal: Auto-renewal is disabled for the instance.
        /// *   NotRenewal: The instance is not renewed. The system no longer sends an expiration notification. Notifications for renewal are sent three days before the expiration time of the instance. You can change the value of this parameter from NotRenewal to `Normal` for an instance, and then manually renew the instance. Alternatively, you can set the RenewalStatus parameter to AutoRenewal.
        /// 
        /// > `RenewalStatus` takes precedence over `AutoRenew`. If you do not specify `RenewalStatus`, the `AutoRenew` parameter is used by default.
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
