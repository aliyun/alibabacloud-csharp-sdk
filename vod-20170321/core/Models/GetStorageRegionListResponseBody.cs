// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetStorageRegionListResponseBody : TeaModel {
        [NameInMap("RegionList")]
        [Validation(Required=false)]
        public GetStorageRegionListResponseBodyRegionList RegionList { get; set; }
        public class GetStorageRegionListResponseBodyRegionList : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<GetStorageRegionListResponseBodyRegionListRegion> Region { get; set; }
            public class GetStorageRegionListResponseBodyRegionListRegion : TeaModel {
                [NameInMap("RegionID")]
                [Validation(Required=false)]
                public string RegionID { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
