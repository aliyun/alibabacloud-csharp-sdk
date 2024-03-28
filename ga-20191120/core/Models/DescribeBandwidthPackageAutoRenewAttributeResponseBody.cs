// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeBandwidthPackageAutoRenewAttributeResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether auto-renewal is enabled.
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal duration. Unit: month. Valid values: **1** to **12**.
        /// 
        /// >  This parameter is returned only if the value of **AutoRenew** is **true**.
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// The ID of the bandwidth plan.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The auto-renewal status of the bandwidth plan.
        /// 
        /// *   **AutoRenewal**: The bandwidth plan is automatically renewed.
        /// *   **Normal**: You must manually renew the bandwidth plan.
        /// *   **NotRenewal**: The bandwidth plan is not renewed after it expires. The system sends a non-renewal reminder three days before the expiration date but no longer sends reminders to renew the bandwidth plan. You can change the auto-renewal status of a bandwidth plan from NotRenewal to **Normal** or **AutoRenewal**.
        /// 
        /// >  **RenewalStatus** takes precedence over **AutoRenew**. If you do not specify **RenewalStatus**, **AutoRenew** is automatically used.
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
