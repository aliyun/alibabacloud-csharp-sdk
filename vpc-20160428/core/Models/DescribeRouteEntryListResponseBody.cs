// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteEntryListResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RouteEntrys")]
        [Validation(Required=false)]
        public DescribeRouteEntryListResponseBodyRouteEntrys RouteEntrys { get; set; }
        public class DescribeRouteEntryListResponseBodyRouteEntrys : TeaModel {
            [NameInMap("RouteEntry")]
            [Validation(Required=false)]
            public List<DescribeRouteEntryListResponseBodyRouteEntrysRouteEntry> RouteEntry { get; set; }
            public class DescribeRouteEntryListResponseBodyRouteEntrysRouteEntry : TeaModel {
                public string Description { get; set; }
                public string DestinationCidrBlock { get; set; }
                public string GmtModified { get; set; }
                public string IpVersion { get; set; }
                public DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHops NextHops { get; set; }
                public class DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHops : TeaModel {
                    [NameInMap("NextHop")]
                    [Validation(Required=false)]
                    public List<DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHopsNextHop> NextHop { get; set; }
                    public class DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHopsNextHop : TeaModel {
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public int? Enabled { get; set; }

                        [NameInMap("NextHopId")]
                        [Validation(Required=false)]
                        public string NextHopId { get; set; }

                        [NameInMap("NextHopRegionId")]
                        [Validation(Required=false)]
                        public string NextHopRegionId { get; set; }

                        [NameInMap("NextHopRelatedInfo")]
                        [Validation(Required=false)]
                        public DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHopsNextHopNextHopRelatedInfo NextHopRelatedInfo { get; set; }
                        public class DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHopsNextHopNextHopRelatedInfo : TeaModel {
                            [NameInMap("InstanceId")]
                            [Validation(Required=false)]
                            public string InstanceId { get; set; }
                            [NameInMap("InstanceType")]
                            [Validation(Required=false)]
                            public string InstanceType { get; set; }
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }
                        };

                        [NameInMap("NextHopType")]
                        [Validation(Required=false)]
                        public string NextHopType { get; set; }

                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }
                public string RouteEntryId { get; set; }
                public string RouteEntryName { get; set; }
                public string RouteTableId { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
            }
        };

    }

}
