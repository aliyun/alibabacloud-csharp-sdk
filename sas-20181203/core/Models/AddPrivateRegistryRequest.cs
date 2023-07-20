// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddPrivateRegistryRequest : TeaModel {
        /// <summary>
        /// The domain name of the image repository.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The additional parameter of the image repository. This parameter is required when you set the RegistryType parameter to **quay**. Valid values:
        /// 
        /// *   **namespace**
        /// *   **authToken**
        /// </summary>
        [NameInMap("ExtraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// The network type. Valid values:
        /// 
        /// *   **1**: Internet
        /// *   **2**: virtual private cloud (VPC)
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public long? NetType { get; set; }

        /// <summary>
        /// The password that is used to log on to the image repository.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The type of the protocol. Valid values:
        /// 
        /// *   **1**: HTTP
        /// *   **2**: HTTPS
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public long? ProtocolType { get; set; }

        /// <summary>
        /// The IP address of the image repository.
        /// </summary>
        [NameInMap("RegistryHostIp")]
        [Validation(Required=false)]
        public string RegistryHostIp { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// > You can call the [ListImageRegistryRegion](~~ListImageRegistryRegion~~) operation to query the IDs of supported regions.
        /// </summary>
        [NameInMap("RegistryRegionId")]
        [Validation(Required=false)]
        public string RegistryRegionId { get; set; }

        /// <summary>
        /// The type of the private image repository. Valid values:
        /// 
        /// *   **harbor**
        /// *   **quay**
        /// </summary>
        [NameInMap("RegistryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

        /// <summary>
        /// The version of the image repository. Valid values:
        /// 
        /// *   **V1**
        /// *   **V2**
        /// </summary>
        [NameInMap("RegistryVersion")]
        [Validation(Required=false)]
        public string RegistryVersion { get; set; }

        /// <summary>
        /// The number of images that are scanned per hour.
        /// </summary>
        [NameInMap("TransPerHour")]
        [Validation(Required=false)]
        public int? TransPerHour { get; set; }

        /// <summary>
        /// The username that is used to log on to the image repository.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The ID of the VPC.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
