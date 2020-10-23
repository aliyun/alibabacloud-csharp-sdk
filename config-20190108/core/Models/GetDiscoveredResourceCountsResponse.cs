// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class GetDiscoveredResourceCountsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("GroupedResourceCounts")]
        [Validation(Required=true)]
        public GetDiscoveredResourceCountsResponseGroupedResourceCounts GroupedResourceCounts { get; set; }
        public class GetDiscoveredResourceCountsResponseGroupedResourceCounts : TeaModel {
            [NameInMap("GroupByKey")]
            [Validation(Required=true)]
            public string GroupByKey { get; set; }
            [NameInMap("GroupedResourceCountList")]
            [Validation(Required=true)]
            public List<GetDiscoveredResourceCountsResponseGroupedResourceCountsGroupedResourceCountList> GroupedResourceCountList { get; set; }
            public class GetDiscoveredResourceCountsResponseGroupedResourceCountsGroupedResourceCountList : TeaModel {
                public string GroupName { get; set; }
                public long ResourceCount { get; set; }
            }
        };

    }

}
