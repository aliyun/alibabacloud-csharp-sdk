// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeClassicLinkInstancesResponseBody : TeaModel {
        [NameInMap("Links")]
        [Validation(Required=false)]
        public DescribeClassicLinkInstancesResponseBodyLinks Links { get; set; }
        public class DescribeClassicLinkInstancesResponseBodyLinks : TeaModel {
            [NameInMap("Link")]
            [Validation(Required=false)]
            public List<DescribeClassicLinkInstancesResponseBodyLinksLink> Link { get; set; }
            public class DescribeClassicLinkInstancesResponseBodyLinksLink : TeaModel {
                public string InstanceId { get; set; }
                public string VpcId { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
