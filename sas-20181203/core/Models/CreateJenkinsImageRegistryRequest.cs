// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateJenkinsImageRegistryRequest : TeaModel {
        /// <summary>
        /// The domain name of the image repository.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The additional parameters of the image repository. The value of this parameter contains the following fields:
        /// 
        /// *   **namespace**: the namespace
        /// *   **authToken**: the authorization token
        /// </summary>
        [NameInMap("ExtraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// The network type. Valid values:
        /// 
        /// *   **1**: Internet
        /// *   **2**: Virtual Private Cloud (VPC)
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public int? NetType { get; set; }

        /// <summary>
        /// The password.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The number of days during which assets can be retained.
        /// </summary>
        [NameInMap("PersistenceDay")]
        [Validation(Required=false)]
        public int? PersistenceDay { get; set; }

        /// <summary>
        /// The type of the protocol. Valid values:
        /// 
        /// *   **1**: HTTP
        /// *   **2**: HTTPS
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public int? ProtocolType { get; set; }

        /// <summary>
        /// The region ID of the image repository.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IP address of the image repository.
        /// </summary>
        [NameInMap("RegistryHostIp")]
        [Validation(Required=false)]
        public string RegistryHostIp { get; set; }

        /// <summary>
        /// The alias of the image repository.
        /// </summary>
        [NameInMap("RegistryName")]
        [Validation(Required=false)]
        public string RegistryName { get; set; }

        /// <summary>
        /// The type of the image repository. Valid values:
        /// 
        /// *   **CI/CD**: Jenkins
        /// </summary>
        [NameInMap("RegistryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

        /// <summary>
        /// The version of the image repository. Default value: -. Valid values:
        /// 
        /// *   **-**: the default version
        /// *   **V1**: V1.0
        /// *   **V2**: V2.0
        /// </summary>
        [NameInMap("RegistryVersion")]
        [Validation(Required=false)]
        public string RegistryVersion { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The number of images that can be scanned per hour.
        /// </summary>
        [NameInMap("TransPerHour")]
        [Validation(Required=false)]
        public int? TransPerHour { get; set; }

        /// <summary>
        /// The username.
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

        /// <summary>
        /// The whitelist of IP addresses.
        /// </summary>
        [NameInMap("WhiteList")]
        [Validation(Required=false)]
        public string WhiteList { get; set; }

    }

}
