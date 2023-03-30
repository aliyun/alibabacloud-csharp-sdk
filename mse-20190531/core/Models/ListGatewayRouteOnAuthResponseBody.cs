// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayRouteOnAuthResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListGatewayRouteOnAuthResponseBodyData> Data { get; set; }
        public class ListGatewayRouteOnAuthResponseBodyData : TeaModel {
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public long? DomainId { get; set; }

            [NameInMap("DomainIdList")]
            [Validation(Required=false)]
            public List<long?> DomainIdList { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("DomainNameList")]
            [Validation(Required=false)]
            public List<string> DomainNameList { get; set; }

            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RoutePredicates")]
            [Validation(Required=false)]
            public ListGatewayRouteOnAuthResponseBodyDataRoutePredicates RoutePredicates { get; set; }
            public class ListGatewayRouteOnAuthResponseBodyDataRoutePredicates : TeaModel {
                [NameInMap("PathPredicates")]
                [Validation(Required=false)]
                public ListGatewayRouteOnAuthResponseBodyDataRoutePredicatesPathPredicates PathPredicates { get; set; }
                public class ListGatewayRouteOnAuthResponseBodyDataRoutePredicatesPathPredicates : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
