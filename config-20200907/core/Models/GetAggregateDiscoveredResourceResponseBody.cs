// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateDiscoveredResourceResponseBody : TeaModel {
        [NameInMap("DiscoveredResourceDetail")]
        [Validation(Required=false)]
        public GetAggregateDiscoveredResourceResponseBodyDiscoveredResourceDetail DiscoveredResourceDetail { get; set; }
        public class GetAggregateDiscoveredResourceResponseBodyDiscoveredResourceDetail : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }
            [NameInMap("AvailabilityZone")]
            [Validation(Required=false)]
            public string AvailabilityZone { get; set; }
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public string Configuration { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("ResourceCreationTime")]
            [Validation(Required=false)]
            public long? ResourceCreationTime { get; set; }
            [NameInMap("ResourceDeleted")]
            [Validation(Required=false)]
            public int? ResourceDeleted { get; set; }
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
