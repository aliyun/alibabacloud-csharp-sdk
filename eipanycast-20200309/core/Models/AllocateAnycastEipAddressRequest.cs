/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class AllocateAnycastEipAddressRequest : TeaModel {
        /// <summary>
        /// The maximum bandwidth of the Anycast EIP. Unit: Mbit/s.
        /// 
        /// Valid values: **200** to **1000**.
        /// 
        /// Default value: **1000**.
        /// 
        /// >  The maximum bandwidth value is not a guaranteed value. It indicates the upper limit of bandwidth and is for reference only.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **ClientToken**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the Anycast EIP.
        /// 
        /// The description must be 0 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The billing method of the Anycast EIP.
        /// 
        /// Set the value to **PostPaid**, which specifies the pay-as-you-go billing method.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The metering method of the Anycast EIP.
        /// 
        /// Set the value to **PayByTraffic**, which specifies the pay-by-data-transfer metering method.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The name of the Anycast EIP.
        /// 
        /// The name must be 0 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). It must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The access area of the Anycast EIP.
        /// 
        /// Set the value to **international**, which specifies the regions outside the Chinese mainland.
        /// </summary>
        [NameInMap("ServiceLocation")]
        [Validation(Required=false)]
        public string ServiceLocation { get; set; }

    }

}
