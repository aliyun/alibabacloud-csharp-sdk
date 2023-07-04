// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVRoutersResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The details about the vRouters.
        /// </summary>
        [NameInMap("VRouters")]
        [Validation(Required=false)]
        public DescribeVRoutersResponseBodyVRouters VRouters { get; set; }
        public class DescribeVRoutersResponseBodyVRouters : TeaModel {
            [NameInMap("VRouter")]
            [Validation(Required=false)]
            public List<DescribeVRoutersResponseBodyVRoutersVRouter> VRouter { get; set; }
            public class DescribeVRoutersResponseBodyVRoutersVRouter : TeaModel {
                /// <summary>
                /// The time when the vRouter was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the vRouter.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The region to which the vRouter belongs.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the route table in the vRouter.
                /// </summary>
                [NameInMap("RouteTableIds")]
                [Validation(Required=false)]
                public DescribeVRoutersResponseBodyVRoutersVRouterRouteTableIds RouteTableIds { get; set; }
                public class DescribeVRoutersResponseBodyVRoutersVRouterRouteTableIds : TeaModel {
                    [NameInMap("RouteTableId")]
                    [Validation(Required=false)]
                    public List<string> RouteTableId { get; set; }

                }

                /// <summary>
                /// The ID of the vRouter.
                /// </summary>
                [NameInMap("VRouterId")]
                [Validation(Required=false)]
                public string VRouterId { get; set; }

                /// <summary>
                /// The name of the vRouter.
                /// </summary>
                [NameInMap("VRouterName")]
                [Validation(Required=false)]
                public string VRouterName { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC) to which the vRouter belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

    }

}
