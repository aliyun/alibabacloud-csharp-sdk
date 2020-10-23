// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class GetDiscoveredResourceSummaryResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DiscoveredResourceSummary")]
        [Validation(Required=true)]
        public GetDiscoveredResourceSummaryResponseDiscoveredResourceSummary DiscoveredResourceSummary { get; set; }
        public class GetDiscoveredResourceSummaryResponseDiscoveredResourceSummary : TeaModel {
            [NameInMap("ResourceCount")]
            [Validation(Required=true)]
            public int? ResourceCount { get; set; }
            [NameInMap("ResourceTypeCount")]
            [Validation(Required=true)]
            public int? ResourceTypeCount { get; set; }
            [NameInMap("RegionCount")]
            [Validation(Required=true)]
            public int? RegionCount { get; set; }
        };

    }

}
