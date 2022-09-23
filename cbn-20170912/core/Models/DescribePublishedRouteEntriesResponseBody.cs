// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribePublishedRouteEntriesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PublishedRouteEntries")]
        [Validation(Required=false)]
        public DescribePublishedRouteEntriesResponseBodyPublishedRouteEntries PublishedRouteEntries { get; set; }
        public class DescribePublishedRouteEntriesResponseBodyPublishedRouteEntries : TeaModel {
            [NameInMap("PublishedRouteEntry")]
            [Validation(Required=false)]
            public List<DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntry> PublishedRouteEntry { get; set; }
            public class DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntry : TeaModel {
                [NameInMap("ChildInstanceRouteTableId")]
                [Validation(Required=false)]
                public string ChildInstanceRouteTableId { get; set; }

                [NameInMap("Conflicts")]
                [Validation(Required=false)]
                public DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntryConflicts Conflicts { get; set; }
                public class DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntryConflicts : TeaModel {
                    [NameInMap("Conflict")]
                    [Validation(Required=false)]
                    public List<DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntryConflictsConflict> Conflict { get; set; }
                    public class DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntryConflictsConflict : TeaModel {
                        [NameInMap("DestinationCidrBlock")]
                        [Validation(Required=false)]
                        public string DestinationCidrBlock { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                [NameInMap("OperationalMode")]
                [Validation(Required=false)]
                public bool? OperationalMode { get; set; }

                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                [NameInMap("RouteType")]
                [Validation(Required=false)]
                public string RouteType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
