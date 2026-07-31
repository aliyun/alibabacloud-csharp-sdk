// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeVRoutersResponseBody : TeaModel {
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

        [NameInMap("VRouters")]
        [Validation(Required=false)]
        public DescribeVRoutersResponseBodyVRouters VRouters { get; set; }
        public class DescribeVRoutersResponseBodyVRouters : TeaModel {
            [NameInMap("VRouter")]
            [Validation(Required=false)]
            public List<DescribeVRoutersResponseBodyVRoutersVRouter> VRouter { get; set; }
            public class DescribeVRoutersResponseBodyVRoutersVRouter : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RouteTableIds")]
                [Validation(Required=false)]
                public DescribeVRoutersResponseBodyVRoutersVRouterRouteTableIds RouteTableIds { get; set; }
                public class DescribeVRoutersResponseBodyVRoutersVRouterRouteTableIds : TeaModel {
                    [NameInMap("RouteTableId")]
                    [Validation(Required=false)]
                    public List<string> RouteTableId { get; set; }

                }

                [NameInMap("VRouterId")]
                [Validation(Required=false)]
                public string VRouterId { get; set; }

                [NameInMap("VRouterName")]
                [Validation(Required=false)]
                public string VRouterName { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

    }

}
