// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyExpressCloudConnectionAttributeRequest : TeaModel {
        /// <summary>
        /// The BGP autonomous system number (ASN) to be configured for the Smart Access Gateway (SAG) device.
        /// </summary>
        [NameInMap("BgpAs")]
        [Validation(Required=false)]
        public string BgpAs { get; set; }

        /// <summary>
        /// The peer IP address when the SAG device is connected to the cloud.
        /// </summary>
        [NameInMap("CeIp")]
        [Validation(Required=false)]
        public string CeIp { get; set; }

        /// <summary>
        /// Descriptions of ECC.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the ECC instance.
        /// </summary>
        [NameInMap("EccId")]
        [Validation(Required=false)]
        public string EccId { get; set; }

        /// <summary>
        /// The name of the ECC instance.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The on-premises IP address when the SAG device is connected to the cloud.
        /// </summary>
        [NameInMap("PeIp")]
        [Validation(Required=false)]
        public string PeIp { get; set; }

        /// <summary>
        /// The region ID of the ECC instance.
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

    }

}
