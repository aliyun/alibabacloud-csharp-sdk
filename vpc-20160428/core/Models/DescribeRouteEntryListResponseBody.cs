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
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                [NameInMap("NextHops")]
                [Validation(Required=false)]
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

                        }

                        [NameInMap("NextHopType")]
                        [Validation(Required=false)]
                        public string NextHopType { get; set; }

                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                [NameInMap("RouteEntryId")]
                [Validation(Required=false)]
                public string RouteEntryId { get; set; }

                [NameInMap("RouteEntryName")]
                [Validation(Required=false)]
                public string RouteEntryName { get; set; }

                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
