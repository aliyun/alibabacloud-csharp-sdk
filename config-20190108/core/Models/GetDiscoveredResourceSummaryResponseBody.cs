// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class GetDiscoveredResourceSummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DiscoveredResourceSummary")]
        [Validation(Required=false)]
        public GetDiscoveredResourceSummaryResponseBodyDiscoveredResourceSummary DiscoveredResourceSummary { get; set; }
        public class GetDiscoveredResourceSummaryResponseBodyDiscoveredResourceSummary : TeaModel {
            [NameInMap("ResourceTypeCount")]
            [Validation(Required=false)]
            public int? ResourceTypeCount { get; set; }
            [NameInMap("RegionCount")]
            [Validation(Required=false)]
            public int? RegionCount { get; set; }
            [NameInMap("ResourceCount")]
            [Validation(Required=false)]
            public int? ResourceCount { get; set; }
        };

    }

}
