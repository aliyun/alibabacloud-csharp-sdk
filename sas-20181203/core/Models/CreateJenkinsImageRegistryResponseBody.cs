// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateJenkinsImageRegistryResponseBody : TeaModel {
        /// <summary>
        /// The result of creating the image repository.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateJenkinsImageRegistryResponseBodyData Data { get; set; }
        public class CreateJenkinsImageRegistryResponseBodyData : TeaModel {
            /// <summary>
            /// The blacklist.
            /// </summary>
            [NameInMap("BlackList")]
            [Validation(Required=false)]
            public string BlackList { get; set; }

            /// <summary>
            /// The domain name of the image repository.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The creation time. The time is in the yyyy-MM-dd HH:mm:ss format.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The update time. The time is in the yyyy-MM-dd HH:mm:ss format.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

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
            /// The whitelist.
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public string WhiteList { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time consumed. Unit: seconds.
        /// </summary>
        [NameInMap("TimeCost")]
        [Validation(Required=false)]
        public long? TimeCost { get; set; }

    }

}
