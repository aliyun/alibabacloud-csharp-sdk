// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsRegionListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsRegionListResponseBodyData Data { get; set; }
        public class OnsRegionListResponseBodyData : TeaModel {
            [NameInMap("RegionDo")]
            [Validation(Required=false)]
            public List<OnsRegionListResponseBodyDataRegionDo> RegionDo { get; set; }
            public class OnsRegionListResponseBodyDataRegionDo : TeaModel {
                public string RegionName { get; set; }
                public string OnsRegionId { get; set; }
            }
        };

    }

}
