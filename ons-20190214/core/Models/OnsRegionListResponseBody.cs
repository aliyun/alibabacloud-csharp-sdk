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
        public List<OnsRegionListResponseBodyData> Data { get; set; }
        public class OnsRegionListResponseBodyData : TeaModel {
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            [NameInMap("OnsRegionId")]
            [Validation(Required=false)]
            public string OnsRegionId { get; set; }

        }

    }

}
