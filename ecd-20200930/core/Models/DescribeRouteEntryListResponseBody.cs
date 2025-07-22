// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRouteEntryListResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<DescribeRouteEntryListResponseBodyRouteEntries> RouteEntries { get; set; }
        public class DescribeRouteEntryListResponseBodyRouteEntries : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            [NameInMap("NextHops")]
            [Validation(Required=false)]
            public List<DescribeRouteEntryListResponseBodyRouteEntriesNextHops> NextHops { get; set; }
            public class DescribeRouteEntryListResponseBodyRouteEntriesNextHops : TeaModel {
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

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

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
