// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class DescribeDiscoveredResourceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DiscoveredResourceDetail")]
        [Validation(Required=true)]
        public DescribeDiscoveredResourceResponseDiscoveredResourceDetail DiscoveredResourceDetail { get; set; }
        public class DescribeDiscoveredResourceResponseDiscoveredResourceDetail : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=true)]
            public long AccountId { get; set; }
            [NameInMap("ResourceId")]
            [Validation(Required=true)]
            public string ResourceId { get; set; }
            [NameInMap("ResourceType")]
            [Validation(Required=true)]
            public string ResourceType { get; set; }
            [NameInMap("ResourceName")]
            [Validation(Required=true)]
            public string ResourceName { get; set; }
            [NameInMap("Region")]
            [Validation(Required=true)]
            public string Region { get; set; }
            [NameInMap("AvailabilityZone")]
            [Validation(Required=true)]
            public string AvailabilityZone { get; set; }
            [NameInMap("ResourceCreationTime")]
            [Validation(Required=true)]
            public long ResourceCreationTime { get; set; }
            [NameInMap("ResourceStatus")]
            [Validation(Required=true)]
            public string ResourceStatus { get; set; }
            [NameInMap("ResourceDeleted")]
            [Validation(Required=true)]
            public int? ResourceDeleted { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=true)]
            public string Tags { get; set; }
            [NameInMap("Configuration")]
            [Validation(Required=true)]
            public string Configuration { get; set; }
        };

    }

}
