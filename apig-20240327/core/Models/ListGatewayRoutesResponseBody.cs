// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayRoutesResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListGatewayRoutesResponseBodyData Data { get; set; }
        public class ListGatewayRoutesResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListGatewayRoutesResponseBodyDataItems> Items { get; set; }
            public class ListGatewayRoutesResponseBodyDataItems : TeaModel {
                [NameInMap("backend")]
                [Validation(Required=false)]
                public GatewayRouteBackend Backend { get; set; }

                [NameInMap("createTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("domainInfo")]
                [Validation(Required=false)]
                public GatewayRouteDomainInfo DomainInfo { get; set; }

                [NameInMap("gatewayRouteId")]
                [Validation(Required=false)]
                public string GatewayRouteId { get; set; }

                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpRouteMatch Match { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("updateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
