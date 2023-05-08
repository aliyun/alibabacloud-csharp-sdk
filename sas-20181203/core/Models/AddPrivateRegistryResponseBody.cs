// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddPrivateRegistryResponseBody : TeaModel {
        /// <summary>
        /// The handling result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddPrivateRegistryResponseBodyData Data { get; set; }
        public class AddPrivateRegistryResponseBodyData : TeaModel {
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
            /// The network type. Valid values:
            /// 
            /// *   **1**: Internet
            /// *   **2**: VPC
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public long? NetType { get; set; }

            /// <summary>
            /// The password.
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
            /// The type of the image repository. Valid values:
            /// 
            /// *   **harbor**
            /// *   **quay**
            /// </summary>
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

            /// <summary>
            /// The version of the image repository. Default value: -. Valid values:
            /// 
            /// *   **-**: the default version
            /// *   **V1**
            /// *   **V2**
            /// </summary>
            [NameInMap("RegistryVersion")]
            [Validation(Required=false)]
            public string RegistryVersion { get; set; }

            /// <summary>
            /// The value of the token.
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// The number of scan tasks that are performed per hour.
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

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
