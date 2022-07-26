// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEnsRouteEntryRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        [NameInMap("NextHopType")]
        [Validation(Required=false)]
        public string NextHopType { get; set; }

        [NameInMap("RouteEntryName")]
        [Validation(Required=false)]
        public string RouteEntryName { get; set; }

        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

    }

}
