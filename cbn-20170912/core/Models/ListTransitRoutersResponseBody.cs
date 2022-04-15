// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRoutersResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TransitRouters")]
        [Validation(Required=false)]
        public List<ListTransitRoutersResponseBodyTransitRouters> TransitRouters { get; set; }
        public class ListTransitRoutersResponseBodyTransitRouters : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SupportMulticast")]
            [Validation(Required=false)]
            public bool? SupportMulticast { get; set; }

            [NameInMap("TransitRouterDescription")]
            [Validation(Required=false)]
            public string TransitRouterDescription { get; set; }

            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            [NameInMap("TransitRouterName")]
            [Validation(Required=false)]
            public string TransitRouterName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
