// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class GetDiscoveredResourceCountsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("GroupedResourceCounts")]
        [Validation(Required=false)]
        public GetDiscoveredResourceCountsResponseBodyGroupedResourceCounts GroupedResourceCounts { get; set; }
        public class GetDiscoveredResourceCountsResponseBodyGroupedResourceCounts : TeaModel {
            [NameInMap("GroupedResourceCountList")]
            [Validation(Required=false)]
            public List<GetDiscoveredResourceCountsResponseBodyGroupedResourceCountsGroupedResourceCountList> GroupedResourceCountList { get; set; }
            public class GetDiscoveredResourceCountsResponseBodyGroupedResourceCountsGroupedResourceCountList : TeaModel {
                public long? ResourceCount { get; set; }
                public string GroupName { get; set; }
            }
            [NameInMap("GroupByKey")]
            [Validation(Required=false)]
            public string GroupByKey { get; set; }
        };

    }

}
