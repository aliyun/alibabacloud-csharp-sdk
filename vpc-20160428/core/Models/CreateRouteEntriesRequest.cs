// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteEntriesRequest : TeaModel {
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

        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<CreateRouteEntriesRequestRouteEntries> RouteEntries { get; set; }
        public class CreateRouteEntriesRequestRouteEntries : TeaModel {
            [NameInMap("Describption")]
            [Validation(Required=false)]
            public string Describption { get; set; }

            [NameInMap("DstCidrBlock")]
            [Validation(Required=false)]
            public string DstCidrBlock { get; set; }

            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

    }

}
