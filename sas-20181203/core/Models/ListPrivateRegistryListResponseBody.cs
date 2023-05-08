// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPrivateRegistryListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the image repositories.
        /// </summary>
        [NameInMap("ImageRegistryInfos")]
        [Validation(Required=false)]
        public List<ListPrivateRegistryListResponseBodyImageRegistryInfos> ImageRegistryInfos { get; set; }
        public class ListPrivateRegistryListResponseBodyImageRegistryInfos : TeaModel {
            /// <summary>
            /// The ID of the user.
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// The domain name of the image repository.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The ID of the image repository.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The information about the Jenkins environment.
            /// </summary>
            [NameInMap("JenkinsEnv")]
            [Validation(Required=false)]
            public string JenkinsEnv { get; set; }

            /// <summary>
            /// The network type. Valid values:
            /// 
            /// *   **1**: Internet
            /// *   **2**: VPC
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public long? NetType { get; set; }

            /// <summary>
            /// The password used to log on to the image repository.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// The number of days during which assets can be retained.
            /// </summary>
            [NameInMap("PersistenceDay")]
            [Validation(Required=false)]
            public long? PersistenceDay { get; set; }

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
            /// The region ID of the server.
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
            /// *   **acr**: Container Registry
            /// *   **harbor**: Harbor
            /// *   **quay**: Quay
            /// *   **CI/CD**: Jenkins
            /// </summary>
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

            /// <summary>
            /// The version of the image repository. Valid values:
            /// 
            /// *   **V1**: V1.0
            /// *   **V2**: V2.0
            /// </summary>
            [NameInMap("RegistryVersion")]
            [Validation(Required=false)]
            public string RegistryVersion { get; set; }

            /// <summary>
            /// The authentication token of the user.
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// The number of images that can be scanned per hour.
            /// </summary>
            [NameInMap("TransPerHour")]
            [Validation(Required=false)]
            public int? TransPerHour { get; set; }

            /// <summary>
            /// The username used to log on to the image repository.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC).
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

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
