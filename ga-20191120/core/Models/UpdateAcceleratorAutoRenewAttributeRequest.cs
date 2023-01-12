// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateAcceleratorAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// The ID of the GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for the GA instance. Default value: false. Valid values:
        /// 
        /// *   **true**: enables auto-renewal for the GA instance.
        /// *   **false**: does not enable auto-renewal for the GA instance.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal period. Unit: months.
        /// 
        /// Valid values: **1** to **12**.
        /// 
        /// >  This parameter is required only if **AutoRenew** is set to **true**.
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate a token, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The name of the GA instance.
        /// 
        /// The name must be 2 to 128 characters in length and can contain digits, underscores (\_), and hyphens (-). It must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies how to renew the GA instance. Valid values:
        /// 
        /// *   **AutoRenewal**: The GA instance is automatically renewed.
        /// *   **Normal**: You must manually renew the GA instance.
        /// *   **NotRenewal**: Choose this option if you do not want to renew the GA instance after the instance expires. The system sends only a non-renewal reminder three days before the expiration date. The system no longer sends notifications to remind you to renew the GA instance. You can change the value of this parameter from NotRenewal to **Normal** for a GA instance, and then manually renew the instance. You can also set the RenewalStatus parameter to **AutoRenewal**.
        /// 
        /// >  **RenewalStatus** takes precedence over **AutoRenew**. If you do not specify **RenewalStatus**, the **AutoRenew** parameter is used by default.
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

    }

}
