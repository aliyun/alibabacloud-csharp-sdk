// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DeleteRouteEntriesRequest : TeaModel {
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
        public List<DeleteRouteEntriesRequestRouteEntries> RouteEntries { get; set; }
        public class DeleteRouteEntriesRequestRouteEntries : TeaModel {
            [NameInMap("DstCidrBlock")]
            [Validation(Required=false)]
            public string DstCidrBlock { get; set; }

            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            [NameInMap("RouteEntryId")]
            [Validation(Required=false)]
            public string RouteEntryId { get; set; }

            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

    }

}
