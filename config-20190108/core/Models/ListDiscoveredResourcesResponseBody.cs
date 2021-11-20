// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class ListDiscoveredResourcesResponseBody : TeaModel {
        [NameInMap("DiscoveredResourceProfiles")]
        [Validation(Required=false)]
        public ListDiscoveredResourcesResponseBodyDiscoveredResourceProfiles DiscoveredResourceProfiles { get; set; }
        public class ListDiscoveredResourcesResponseBodyDiscoveredResourceProfiles : TeaModel {
            [NameInMap("DiscoveredResourceProfileList")]
            [Validation(Required=false)]
            public List<ListDiscoveredResourcesResponseBodyDiscoveredResourceProfilesDiscoveredResourceProfileList> DiscoveredResourceProfileList { get; set; }
            public class ListDiscoveredResourcesResponseBodyDiscoveredResourceProfilesDiscoveredResourceProfileList : TeaModel {
                public long? AccountId { get; set; }
                public string Region { get; set; }
                public long? ResourceCreationTime { get; set; }
                public int? ResourceDeleted { get; set; }
                public string ResourceId { get; set; }
                public string ResourceName { get; set; }
                public string ResourceStatus { get; set; }
                public string ResourceType { get; set; }
                public string Tags { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
