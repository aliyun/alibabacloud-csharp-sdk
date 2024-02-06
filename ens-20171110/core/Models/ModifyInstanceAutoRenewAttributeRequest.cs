// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyInstanceAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the auto-renewal feature. Valid values: **True and False**. Default value: False.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal period of the instance. Unit: months. Valid values: 1 to 9 and 12. This parameter is required if the AutoRenew parameter is set to true.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// The IDs of the instances. Separate IDs with semicolons (;).
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Specifies whether to renew the instance. The **RenewalStatus** parameter has a higher priority than the **AutoRenew** parameter. If you do not specify **RenewalStatus**, the **AutoRenew** parameter is used by default.
        /// 
        /// *   AutoRenewal: Auto-renewal is enabled for the instance.
        /// *   Normal: Auto-renewal is disabled for the instance.
        /// *   NotRenewal: The instance is not renewed.
        /// 
        /// The system no longer sends an expiration notification but sends only a renewal notification three days before the instance expires. To renew the instance, you can change the value of this parameter from NotRenewal to Normal and then manually renew the instance, or change the value of this parameter from NotRenewal to AutoRenewal.
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

    }

}
