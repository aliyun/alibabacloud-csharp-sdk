// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateHighReliablePhysicalConnectionRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("ApList")]
        [Validation(Required=false)]
        public List<CreateHighReliablePhysicalConnectionRequestApList> ApList { get; set; }
        public class CreateHighReliablePhysicalConnectionRequestApList : TeaModel {
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            [NameInMap("CircuitCode")]
            [Validation(Required=false)]
            public string CircuitCode { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("LineOperator")]
            [Validation(Required=false)]
            public string LineOperator { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PeerLocation")]
            [Validation(Required=false)]
            public string PeerLocation { get; set; }

            [NameInMap("PortNum")]
            [Validation(Required=false)]
            public int? PortNum { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DeviceAdvancedCapacity")]
        [Validation(Required=false)]
        public List<string> DeviceAdvancedCapacity { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        [NameInMap("HighReliableType")]
        [Validation(Required=false)]
        public string HighReliableType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PortType")]
        [Validation(Required=false)]
        public string PortType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateHighReliablePhysicalConnectionRequestTag> Tag { get; set; }
        public class CreateHighReliablePhysicalConnectionRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
