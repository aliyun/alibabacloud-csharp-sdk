// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20170714.Models
{
    public class ListRegionsResponseBody : TeaModel {
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public ListRegionsResponseBodyRegions Regions { get; set; }
        public class ListRegionsResponseBodyRegions : TeaModel {
            [NameInMap("RegionInfo")]
            [Validation(Required=false)]
            public List<ListRegionsResponseBodyRegionsRegionInfo> RegionInfo { get; set; }
            public class ListRegionsResponseBodyRegionsRegionInfo : TeaModel {
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

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
