// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeRouteConflictResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RouteConflicts")]
        [Validation(Required=false)]
        public DescribeRouteConflictResponseBodyRouteConflicts RouteConflicts { get; set; }
        public class DescribeRouteConflictResponseBodyRouteConflicts : TeaModel {
            [NameInMap("RouteConflict")]
            [Validation(Required=false)]
            public List<DescribeRouteConflictResponseBodyRouteConflictsRouteConflict> RouteConflict { get; set; }
            public class DescribeRouteConflictResponseBodyRouteConflictsRouteConflict : TeaModel {
                public string Status { get; set; }
                public string DestinationCidrBlock { get; set; }
                public string InstanceId { get; set; }
                public string InstanceType { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
