// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetDiscoveredResourceCountsGroupByRegionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DiscoveredResourceCountsSummary")]
        [Validation(Required=false)]
        public List<GetDiscoveredResourceCountsGroupByRegionResponseBodyDiscoveredResourceCountsSummary> DiscoveredResourceCountsSummary { get; set; }
        public class GetDiscoveredResourceCountsGroupByRegionResponseBodyDiscoveredResourceCountsSummary : TeaModel {
            [NameInMap("ResourceCount")]
            [Validation(Required=false)]
            public long? ResourceCount { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

    }

}
