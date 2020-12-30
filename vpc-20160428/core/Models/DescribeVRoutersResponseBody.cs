// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVRoutersResponseBody : TeaModel {
        [NameInMap("VRouters")]
        [Validation(Required=false)]
        public DescribeVRoutersResponseBodyVRouters VRouters { get; set; }
        public class DescribeVRoutersResponseBodyVRouters : TeaModel {
            [NameInMap("VRouter")]
            [Validation(Required=false)]
            public List<DescribeVRoutersResponseBodyVRoutersVRouter> VRouter { get; set; }
            public class DescribeVRoutersResponseBodyVRoutersVRouter : TeaModel {
                public string VpcId { get; set; }
                public string CreationTime { get; set; }
                public string VRouterId { get; set; }
                public string Description { get; set; }
                public string VRouterName { get; set; }
                public DescribeVRoutersResponseBodyVRoutersVRouterRouteTableIds RouteTableIds { get; set; }
                public class DescribeVRoutersResponseBodyVRoutersVRouterRouteTableIds : TeaModel {
                    [NameInMap("RouteTableId")]
                    [Validation(Required=false)]
                    public List<string> RouteTableId { get; set; }

                }
                public string RegionId { get; set; }
            }
        };

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
