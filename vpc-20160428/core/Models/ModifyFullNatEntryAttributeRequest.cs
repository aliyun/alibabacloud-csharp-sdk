// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyFullNatEntryAttributeRequest : TeaModel {
        [NameInMap("AccessIp")]
        [Validation(Required=false)]
        public string AccessIp { get; set; }

        [NameInMap("AccessPort")]
        [Validation(Required=false)]
        public string AccessPort { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("FullNatEntryDescription")]
        [Validation(Required=false)]
        public string FullNatEntryDescription { get; set; }

        [NameInMap("FullNatEntryId")]
        [Validation(Required=false)]
        public string FullNatEntryId { get; set; }

        [NameInMap("FullNatEntryName")]
        [Validation(Required=false)]
        public string FullNatEntryName { get; set; }

        [NameInMap("FullNatTableId")]
        [Validation(Required=false)]
        public string FullNatTableId { get; set; }

        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        [NameInMap("NatIp")]
        [Validation(Required=false)]
        public string NatIp { get; set; }

        [NameInMap("NatIpPort")]
        [Validation(Required=false)]
        public string NatIpPort { get; set; }

        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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
