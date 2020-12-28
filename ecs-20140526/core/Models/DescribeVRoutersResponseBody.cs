// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeVRoutersResponseBody : TeaModel {
        [NameInMap("VRouters")]
        [Validation(Required=false)]
        public List<DescribeVRoutersResponseBodyVRouters> VRouters { get; set; }
        public class DescribeVRoutersResponseBodyVRouters : TeaModel {
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("VRouterId")]
            [Validation(Required=false)]
            public string VRouterId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("VRouterName")]
            [Validation(Required=false)]
            public string VRouterName { get; set; }

            [NameInMap("RouteTableIds")]
            [Validation(Required=false)]
            public List<string> RouteTableIds { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
