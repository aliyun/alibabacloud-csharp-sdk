// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeRouteServicesInCenResponseBody : TeaModel {
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

        [NameInMap("RouteServiceEntries")]
        [Validation(Required=false)]
        public DescribeRouteServicesInCenResponseBodyRouteServiceEntries RouteServiceEntries { get; set; }
        public class DescribeRouteServicesInCenResponseBodyRouteServiceEntries : TeaModel {
            [NameInMap("RouteServiceEntry")]
            [Validation(Required=false)]
            public List<DescribeRouteServicesInCenResponseBodyRouteServiceEntriesRouteServiceEntry> RouteServiceEntry { get; set; }
            public class DescribeRouteServicesInCenResponseBodyRouteServiceEntriesRouteServiceEntry : TeaModel {
                public string Status { get; set; }
                public string Host { get; set; }
                public string Description { get; set; }
                public string HostVpcId { get; set; }
                public string CenId { get; set; }
                public string AccessRegionId { get; set; }
                public string HostRegionId { get; set; }
                public string UpdateInterval { get; set; }
                public DescribeRouteServicesInCenResponseBodyRouteServiceEntriesRouteServiceEntryCidrs Cidrs { get; set; }
                public class DescribeRouteServicesInCenResponseBodyRouteServiceEntriesRouteServiceEntryCidrs : TeaModel {
                    [NameInMap("Cidr")]
                    [Validation(Required=false)]
                    public List<string> Cidr { get; set; }

                }
            }
        };

    }

}
