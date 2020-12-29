// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeRouteServicesInCenResponseBody : TeaModel {
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

        [NameInMap("RouteServiceEntries")]
        [Validation(Required=false)]
        public List<DescribeRouteServicesInCenResponseBodyRouteServiceEntries> RouteServiceEntries { get; set; }
        public class DescribeRouteServicesInCenResponseBodyRouteServiceEntries : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("HostVpcId")]
            [Validation(Required=false)]
            public string HostVpcId { get; set; }

            [NameInMap("Cidrs")]
            [Validation(Required=false)]
            public List<string> Cidrs { get; set; }

            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            [NameInMap("AccessRegionId")]
            [Validation(Required=false)]
            public string AccessRegionId { get; set; }

            [NameInMap("HostRegionId")]
            [Validation(Required=false)]
            public string HostRegionId { get; set; }

            [NameInMap("UpdateInterval")]
            [Validation(Required=false)]
            public string UpdateInterval { get; set; }

        }

    }

}
