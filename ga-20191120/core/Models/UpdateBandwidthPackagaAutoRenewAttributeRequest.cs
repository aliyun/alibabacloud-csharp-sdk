// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateBandwidthPackagaAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable auto-renewal for the bandwidth plan. Valid values:
        /// 
        /// *   **true**: enables auto-renewal.
        /// *   **false** (default): disables auto-renewal.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal duration. Unit: months. Valid values: **1** to **12**.
        /// 
        /// > : This parameter takes effect only if **AutoRenew** is set to **true**.
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the bandwidth plan.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the bandwidth plan.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The auto-renewal status of the bandwidth plan. Valid values:
        /// 
        /// *   **AutoRenewal**: The bandwidth plan is automatically renewed.
        /// *   **Normal**: You must manually renew the bandwidth plan.
        /// *   **NotRenewal**: Choose this option if you do not want to renew the bandwidth plan after it expires. The system sends only a non-renewal reminder three days before the expiration date. The system no longer sends notifications to remind you to renew the bandwidth plan. You can change the value of this parameter from NotRenewal to Normal for a bandwidth plan, and then manually renew the bandwidth plan. You can also set the RenewalStatus parameter to **AutoRenewal**.
        /// 
        /// > The **RenewalStatus** parameter takes precedence over the **AutoRenew** parameter. If you do not set **RenewalStatus**, the **AutoRenew** parameter is used by default.
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

    }

}
