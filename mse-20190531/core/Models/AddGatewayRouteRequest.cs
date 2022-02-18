// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewayRouteRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        [NameInMap("DirectResponseJSON")]
        [Validation(Required=false)]
        public AddGatewayRouteRequestDirectResponseJSON DirectResponseJSON { get; set; }
        public class AddGatewayRouteRequestDirectResponseJSON : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public long? Code { get; set; }
        };

        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public long? DomainId { get; set; }

        [NameInMap("DomainIdListJSON")]
        [Validation(Required=false)]
        public string DomainIdListJSON { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Predicates")]
        [Validation(Required=false)]
        public AddGatewayRouteRequestPredicates Predicates { get; set; }
        public class AddGatewayRouteRequestPredicates : TeaModel {
            [NameInMap("HeaderPredicates")]
            [Validation(Required=false)]
            public List<AddGatewayRouteRequestPredicatesHeaderPredicates> HeaderPredicates { get; set; }
            public class AddGatewayRouteRequestPredicatesHeaderPredicates : TeaModel {
                public string Key { get; set; }
                public string Type { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("MethodPredicates")]
            [Validation(Required=false)]
            public List<string> MethodPredicates { get; set; }
            [NameInMap("PathPredicates")]
            [Validation(Required=false)]
            public AddGatewayRouteRequestPredicatesPathPredicates PathPredicates { get; set; }
            public class AddGatewayRouteRequestPredicatesPathPredicates : TeaModel {
                [NameInMap("IgnoreCase")]
                [Validation(Required=false)]
                public bool? IgnoreCase { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }
            [NameInMap("QueryPredicates")]
            [Validation(Required=false)]
            public List<AddGatewayRouteRequestPredicatesQueryPredicates> QueryPredicates { get; set; }
            public class AddGatewayRouteRequestPredicatesQueryPredicates : TeaModel {
                public string Key { get; set; }
                public string Type { get; set; }
                public string Value { get; set; }
            }
        };

        [NameInMap("RedirectJSON")]
        [Validation(Required=false)]
        public AddGatewayRouteRequestRedirectJSON RedirectJSON { get; set; }
        public class AddGatewayRouteRequestRedirectJSON : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }
        };

        [NameInMap("RouteOrder")]
        [Validation(Required=false)]
        public int? RouteOrder { get; set; }

        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<AddGatewayRouteRequestServices> Services { get; set; }
        public class AddGatewayRouteRequestServices : TeaModel {
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
