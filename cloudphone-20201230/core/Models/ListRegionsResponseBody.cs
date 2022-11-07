// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListRegionsResponseBody : TeaModel {
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public ListRegionsResponseBodyRegions Regions { get; set; }
        public class ListRegionsResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<ListRegionsResponseBodyRegionsRegion> Region { get; set; }
            public class ListRegionsResponseBodyRegionsRegion : TeaModel {
                [NameInMap("RegionEndpoint")]
                [Validation(Required=false)]
                public string RegionEndpoint { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
