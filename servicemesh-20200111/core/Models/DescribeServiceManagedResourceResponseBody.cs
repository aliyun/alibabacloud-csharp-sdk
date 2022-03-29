// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceManagedResourceResponseBody : TeaModel {
        [NameInMap("ManagedResource")]
        [Validation(Required=false)]
        public DescribeServiceManagedResourceResponseBodyManagedResource ManagedResource { get; set; }
        public class DescribeServiceManagedResourceResponseBodyManagedResource : TeaModel {
            [NameInMap("DestinationRules")]
            [Validation(Required=false)]
            public List<string> DestinationRules { get; set; }
            [NameInMap("LocalRateLimiters")]
            [Validation(Required=false)]
            public List<string> LocalRateLimiters { get; set; }
            [NameInMap("VirtualServices")]
            [Validation(Required=false)]
            public List<string> VirtualServices { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
