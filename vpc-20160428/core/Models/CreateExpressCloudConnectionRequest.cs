// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateExpressCloudConnectionRequest : TeaModel {
        /// <summary>
        /// The bandwidth for ECC, which corresponds to the bandwidth for the underlying circuit.
        /// 
        /// Unit: Mbit/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The email address of the contact who applies for ECC.
        /// </summary>
        [NameInMap("ContactMail")]
        [Validation(Required=false)]
        public string ContactMail { get; set; }

        /// <summary>
        /// The phone number of the contact who applies for ECC.
        /// </summary>
        [NameInMap("ContactTel")]
        [Validation(Required=false)]
        public string ContactTel { get; set; }

        /// <summary>
        /// The description of ECC.
        /// 
        /// The description must be 2 to 256 characters in length. It must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID card number of the contact who applies for ECC.
        /// </summary>
        [NameInMap("IDCardNo")]
        [Validation(Required=false)]
        public string IDCardNo { get; set; }

        /// <summary>
        /// The Internet service provider (ISP) for the data center.
        /// </summary>
        [NameInMap("IdcSP")]
        [Validation(Required=false)]
        public string IdcSP { get; set; }

        /// <summary>
        /// The name of the ECC instance.
        /// 
        /// The name must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). It must start with a letter but cannot start with `http://` or `https://`.
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
        /// The city where the data center is located.
        /// </summary>
        [NameInMap("PeerCity")]
        [Validation(Required=false)]
        public string PeerCity { get; set; }

        /// <summary>
        /// The geographical location of the data center.
        /// 
        /// > It must be accurate to house number-floor-room number-server rack number.
        /// </summary>
        [NameInMap("PeerLocation")]
        [Validation(Required=false)]
        public string PeerLocation { get; set; }

        /// <summary>
        /// The port of the Express Connect circuit. Valid values:
        /// 
        /// *   100Base-T
        /// *   1000Base-T
        /// *   1000Base-LX
        /// *   10GBase-T
        /// *   10GBase-LR
        /// </summary>
        [NameInMap("PortType")]
        [Validation(Required=false)]
        public string PortType { get; set; }

        /// <summary>
        /// The ID of the standby Express Connect circuit.
        /// </summary>
        [NameInMap("RedundantEccId")]
        [Validation(Required=false)]
        public string RedundantEccId { get; set; }

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
