// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class ListDiscoveredResourcesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DiscoveredResourceProfiles")]
        [Validation(Required=true)]
        public ListDiscoveredResourcesResponseDiscoveredResourceProfiles DiscoveredResourceProfiles { get; set; }
        public class ListDiscoveredResourcesResponseDiscoveredResourceProfiles : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("DiscoveredResourceProfileList")]
            [Validation(Required=true)]
            public List<ListDiscoveredResourcesResponseDiscoveredResourceProfilesDiscoveredResourceProfileList> DiscoveredResourceProfileList { get; set; }
            public class ListDiscoveredResourcesResponseDiscoveredResourceProfilesDiscoveredResourceProfileList : TeaModel {
                public long AccountId { get; set; }
                public string Region { get; set; }
                public long ResourceCreationTime { get; set; }
                public int? ResourceDeleted { get; set; }
                public string ResourceId { get; set; }
                public string ResourceName { get; set; }
                public string ResourceStatus { get; set; }
                public string ResourceType { get; set; }
                public string Tags { get; set; }
            }
        };

    }

}
