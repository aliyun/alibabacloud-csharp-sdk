// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListRegionsResponseBody : TeaModel {
        [NameInMap("RegionModels")]
        [Validation(Required=false)]
        public List<ListRegionsResponseBodyRegionModels> RegionModels { get; set; }
        public class ListRegionsResponseBodyRegionModels : TeaModel {
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
