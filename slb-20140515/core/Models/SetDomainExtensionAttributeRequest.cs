// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetDomainExtensionAttributeRequest : TeaModel {
        /// <summary>
        /// The ID of the domain name that is associated with the additional certificate to be replaced.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainExtensionId")]
        [Validation(Required=false)]
        public string DomainExtensionId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the SLB instance is created.
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
        /// The ID of the new certificate.
        /// </summary>
        [NameInMap("ServerCertificateId")]
        [Validation(Required=false)]
        public string ServerCertificateId { get; set; }

    }

}
