// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteEntryRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RouteTableId")]
        [Validation(Required=true)]
        public string RouteTableId { get; set; }

        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=true)]
        public string DestinationCidrBlock { get; set; }

        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("RouteEntryName")]
        [Validation(Required=false)]
        public string RouteEntryName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("NextHopType")]
        [Validation(Required=false)]
        public string NextHopType { get; set; }

        [NameInMap("NextHopList")]
        [Validation(Required=false)]
        public List<CreateRouteEntryRequestNextHopList> NextHopList { get; set; }
        public class CreateRouteEntryRequestNextHopList : TeaModel {
            [NameInMap("NextHopType")]
            [Validation(Required=true)]
            public string NextHopType { get; set; }

            [NameInMap("NextHopId")]
            [Validation(Required=true)]
            public string NextHopId { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=true)]
            public int? Weight { get; set; }

        }

    }

}
