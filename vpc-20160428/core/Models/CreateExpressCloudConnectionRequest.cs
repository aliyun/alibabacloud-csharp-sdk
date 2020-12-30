// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateExpressCloudConnectionRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("PeerCity")]
        [Validation(Required=false)]
        public string PeerCity { get; set; }

        [NameInMap("PeerLocation")]
        [Validation(Required=false)]
        public string PeerLocation { get; set; }

        [NameInMap("IdcSP")]
        [Validation(Required=false)]
        public string IdcSP { get; set; }

        [NameInMap("PortType")]
        [Validation(Required=false)]
        public string PortType { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("ContactTel")]
        [Validation(Required=false)]
        public string ContactTel { get; set; }

        [NameInMap("ContactMail")]
        [Validation(Required=false)]
        public string ContactMail { get; set; }

        [NameInMap("IDCardNo")]
        [Validation(Required=false)]
        public string IDCardNo { get; set; }

        [NameInMap("RedundantEccId")]
        [Validation(Required=false)]
        public string RedundantEccId { get; set; }

    }

}
