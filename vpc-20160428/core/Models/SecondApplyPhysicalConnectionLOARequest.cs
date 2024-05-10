// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class SecondApplyPhysicalConnectionLOARequest : TeaModel {
        /// <summary>
        /// The bandwidth of the Express Connect circuit. Unit: Mbit/s.
        /// 
        /// Valid values: **2** to **10240**.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The name of the customer company that requires the Express Connect circuit.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CompanyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The time when construction started. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConstructionTime")]
        [Validation(Required=false)]
        public string ConstructionTime { get; set; }

        /// <summary>
        /// The ID of the Express Connect circuit.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The type of Express Connect circuit. Valid values:
        /// 
        /// *   **MSTP**
        /// *   **MPLSVPN**
        /// *   **FIBRE**
        /// *   **Other**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LineType")]
        [Validation(Required=false)]
        public string LineType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The information about the construction engineer.
        /// </summary>
        [NameInMap("PMInfo")]
        [Validation(Required=false)]
        public List<SecondApplyPhysicalConnectionLOARequestPMInfo> PMInfo { get; set; }
        public class SecondApplyPhysicalConnectionLOARequestPMInfo : TeaModel {
            /// <summary>
            /// The ID number of the construction engineer. You can specify the ID number of an ID card or an international passport.
            /// 
            /// You can configure information for up to 16 construction engineers.
            /// </summary>
            [NameInMap("PMCertificateNo")]
            [Validation(Required=false)]
            public string PMCertificateNo { get; set; }

            /// <summary>
            /// The type of the identity document of the construction engineer. Valid values:
            /// 
            /// *   **IDCard**
            /// *   **Passport**
            /// </summary>
            [NameInMap("PMCertificateType")]
            [Validation(Required=false)]
            public string PMCertificateType { get; set; }

            /// <summary>
            /// The contact information about the construction engineer.
            /// </summary>
            [NameInMap("PMContactInfo")]
            [Validation(Required=false)]
            public string PMContactInfo { get; set; }

            /// <summary>
            /// The gender of the construction engineer.
            /// </summary>
            [NameInMap("PMGender")]
            [Validation(Required=false)]
            public string PMGender { get; set; }

            /// <summary>
            /// The name of the construction engineer.
            /// </summary>
            [NameInMap("PMName")]
            [Validation(Required=false)]
            public string PMName { get; set; }

        }

        /// <summary>
        /// The geographic location where the Express Connect circuit is deployed.
        /// </summary>
        [NameInMap("PeerLocation")]
        [Validation(Required=false)]
        public string PeerLocation { get; set; }

        /// <summary>
        /// The region where the Express Connect circuit is deployed. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The construction company.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Si")]
        [Validation(Required=false)]
        public string Si { get; set; }

    }

}
