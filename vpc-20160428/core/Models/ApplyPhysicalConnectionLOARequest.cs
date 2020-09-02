// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ApplyPhysicalConnectionLOARequest : TeaModel {
        /// <summary>
        /// description: Optional. The token used for client authentication.; 
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// description: The ID of the region to which the physical connection interface belongs.; 
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        /// <summary>
        /// description: Optional. The bandwidth value of the physical connection.; 
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// description: The location where the leased line is deployed.; 
        /// </summary>
        [NameInMap("PeerLocation")]
        [Validation(Required=false)]
        public string PeerLocation { get; set; }

        /// <summary>
        /// description: The instance ID of the physical connection interface.; 
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// description: The name of the company that requires the physical connection.; 
        /// </summary>
        [NameInMap("CompanyName")]
        [Validation(Required=true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// description: The type of leased line. ; 
        /// </summary>
        [NameInMap("LineType")]
        [Validation(Required=true)]
        public string LineType { get; set; }

        /// <summary>
        /// description: The name of the installation company.; 
        /// </summary>
        [NameInMap("Si")]
        [Validation(Required=true)]
        public string Si { get; set; }

        /// <summary>
        /// description: The date and time when the data cable installation technician or representative will go to the installation site.; 
        /// </summary>
        [NameInMap("ConstructionTime")]
        [Validation(Required=true)]
        public string ConstructionTime { get; set; }

        [NameInMap("PMInfo")]
        [Validation(Required=false)]
        public List<ApplyPhysicalConnectionLOARequestPMInfo> PMInfo { get; set; }
        public class ApplyPhysicalConnectionLOARequestPMInfo : TeaModel {
            [NameInMap("PMName")]
            [Validation(Required=true)]
            public string PMName { get; set; }

            [NameInMap("PMContactInfo")]
            [Validation(Required=true)]
            public string PMContactInfo { get; set; }

            [NameInMap("PMCertificateType")]
            [Validation(Required=true)]
            public string PMCertificateType { get; set; }

            [NameInMap("PMCertificateNo")]
            [Validation(Required=true)]
            public string PMCertificateNo { get; set; }

            [NameInMap("PMGender")]
            [Validation(Required=true)]
            public string PMGender { get; set; }

        }

    }

}
