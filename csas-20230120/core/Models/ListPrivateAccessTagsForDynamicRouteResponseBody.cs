// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessTagsForDynamicRouteResponseBody : TeaModel {
        [NameInMap("DynamicRoutes")]
        [Validation(Required=false)]
        public List<ListPrivateAccessTagsForDynamicRouteResponseBodyDynamicRoutes> DynamicRoutes { get; set; }
        public class ListPrivateAccessTagsForDynamicRouteResponseBodyDynamicRoutes : TeaModel {
            [NameInMap("DynamicRouteId")]
            [Validation(Required=false)]
            public string DynamicRouteId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPrivateAccessTagsForDynamicRouteResponseBodyDynamicRoutesTags> Tags { get; set; }
            public class ListPrivateAccessTagsForDynamicRouteResponseBodyDynamicRoutesTags : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                [NameInMap("TagType")]
                [Validation(Required=false)]
                public string TagType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
