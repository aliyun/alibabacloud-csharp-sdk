// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetDynamicRouteResponseBody : TeaModel {
        [NameInMap("DynamicRoute")]
        [Validation(Required=false)]
        public GetDynamicRouteResponseBodyDynamicRoute DynamicRoute { get; set; }
        public class GetDynamicRouteResponseBodyDynamicRoute : TeaModel {
            [NameInMap("ApplicationIds")]
            [Validation(Required=false)]
            public List<string> ApplicationIds { get; set; }

            [NameInMap("ApplicationType")]
            [Validation(Required=false)]
            public string ApplicationType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DynamicRouteId")]
            [Validation(Required=false)]
            public string DynamicRouteId { get; set; }

            [NameInMap("DynamicRouteType")]
            [Validation(Required=false)]
            public string DynamicRouteType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("RegionIds")]
            [Validation(Required=false)]
            public List<string> RegionIds { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
