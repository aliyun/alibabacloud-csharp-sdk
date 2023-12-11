// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDT20210813.Models
{
    public class ListCdtTrafficTiersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficTiers")]
        [Validation(Required=false)]
        public List<ListCdtTrafficTiersResponseBodyTrafficTiers> TrafficTiers { get; set; }
        public class ListCdtTrafficTiersResponseBodyTrafficTiers : TeaModel {
            [NameInMap("HighestTraffic")]
            [Validation(Required=false)]
            public long? HighestTraffic { get; set; }

            [NameInMap("LowestTraffic")]
            [Validation(Required=false)]
            public long? LowestTraffic { get; set; }

            [NameInMap("Tier")]
            [Validation(Required=false)]
            public long? Tier { get; set; }

        }

    }

}
