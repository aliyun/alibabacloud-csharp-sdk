// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRouteTablesResponseBody : TeaModel {
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

        [NameInMap("RouteTables")]
        [Validation(Required=false)]
        public List<DescribeRouteTablesResponseBodyRouteTables> RouteTables { get; set; }
        public class DescribeRouteTablesResponseBodyRouteTables : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("VRouterId")]
            [Validation(Required=false)]
            public string VRouterId { get; set; }

            [NameInMap("RouteEntrys")]
            [Validation(Required=false)]
            public List<DescribeRouteTablesResponseBodyRouteTablesRouteEntrys> RouteEntrys { get; set; }
            public class DescribeRouteTablesResponseBodyRouteTablesRouteEntrys : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                [NameInMap("NextHops")]
                [Validation(Required=false)]
                public List<DescribeRouteTablesResponseBodyRouteTablesRouteEntrysNextHops> NextHops { get; set; }
                public class DescribeRouteTablesResponseBodyRouteTablesRouteEntrysNextHops : TeaModel {
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                    [NameInMap("NextHopId")]
                    [Validation(Required=false)]
                    public string NextHopId { get; set; }

                    [NameInMap("NextHopType")]
                    [Validation(Required=false)]
                    public string NextHopType { get; set; }

                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public int? Enabled { get; set; }

                }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

            }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("RouteTableType")]
            [Validation(Required=false)]
            public string RouteTableType { get; set; }

            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

    }

}
