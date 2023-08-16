// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessApplicationsForDynamicRouteResponseBody : TeaModel {
        [NameInMap("DynamicRoutes")]
        [Validation(Required=false)]
        public List<ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutes> DynamicRoutes { get; set; }
        public class ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutes : TeaModel {
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutesApplications> Applications { get; set; }
            public class ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutesApplications : TeaModel {
                [NameInMap("Addresses")]
                [Validation(Required=false)]
                public List<string> Addresses { get; set; }

                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PortRanges")]
                [Validation(Required=false)]
                public List<ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutesApplicationsPortRanges> PortRanges { get; set; }
                public class ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutesApplicationsPortRanges : TeaModel {
                    [NameInMap("Begin")]
                    [Validation(Required=false)]
                    public int? Begin { get; set; }

                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public int? End { get; set; }

                }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("DynamicRouteId")]
            [Validation(Required=false)]
            public string DynamicRouteId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
