// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Uis20180821.Models
{
    public class ModifyDnatEntryRequest : TeaModel {
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

        [NameInMap("UisNodeId")]
        [Validation(Required=false)]
        public string UisNodeId { get; set; }

        [NameInMap("UisDnatId")]
        [Validation(Required=false)]
        public string UisDnatId { get; set; }

        [NameInMap("DestinationIp")]
        [Validation(Required=false)]
        public string DestinationIp { get; set; }

        [NameInMap("DestinationPort")]
        [Validation(Required=false)]
        public int? DestinationPort { get; set; }

        [NameInMap("OriginalIp")]
        [Validation(Required=false)]
        public string OriginalIp { get; set; }

        [NameInMap("OriginalPort")]
        [Validation(Required=false)]
        public int? OriginalPort { get; set; }

        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
