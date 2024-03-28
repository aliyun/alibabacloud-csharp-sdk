// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateBandwidthPackagaAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable auto-renewal. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// 
        /// >  You must specify **AutoRenew** or **RenewalStatus**.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal duration. Unit: months. Valid values: **1** to **12**.
        /// 
        /// > This parameter takes effect only if **AutoRenew** is set to **true**.
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
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
        /// *   **NotRenewal**: The bandwidth plan is not renewed after it expires. The system sends only a non-renewal reminder three days before the expiration date. To renew a bandwidth plan for which you set RenewalStatus to NotRenewal, you can change the value of RenewalStatus from NotRenewal to Normal, and then manually renew the bandwidth plan. You can also set RenewalStatus to **AutoRenewal**.
        /// > *   You must specify **AutoRenew** or **RenewalStatus**.
        /// > *   **RenewalStatus** takes precedence over **AutoRenew**. If you do not specify **RenewalStatus**, **AutoRenew** is used.
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

    }

}
