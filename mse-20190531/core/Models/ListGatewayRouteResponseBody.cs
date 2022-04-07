// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayRouteResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayRouteResponseBodyData Data { get; set; }
        public class ListGatewayRouteResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayRouteResponseBodyDataResult> Result { get; set; }
            public class ListGatewayRouteResponseBodyDataResult : TeaModel {
                public ListGatewayRouteResponseBodyDataResultComment Comment { get; set; }
                public class ListGatewayRouteResponseBodyDataResultComment : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }
                public long? DefaultServiceId { get; set; }
                public string DefaultServiceName { get; set; }
                public string DestinationType { get; set; }
                public ListGatewayRouteResponseBodyDataResultDirectResponse DirectResponse { get; set; }
                public class ListGatewayRouteResponseBodyDataResultDirectResponse : TeaModel {
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public string Body { get; set; }

                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                }
                public long? DomainId { get; set; }
                public List<string> DomainIdList { get; set; }
                public string DomainName { get; set; }
                public List<string> DomainNameList { get; set; }
                public string EnableWaf { get; set; }
                public long? GatewayId { get; set; }
                public string GatewayUniqueId { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public long? Id { get; set; }
                public string Name { get; set; }
                public string Predicates { get; set; }
                public ListGatewayRouteResponseBodyDataResultRedirect Redirect { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRedirect : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }
                public int? RouteOrder { get; set; }
                public ListGatewayRouteResponseBodyDataResultRoutePredicates RoutePredicates { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRoutePredicates : TeaModel {
                    [NameInMap("HeaderPredicates")]
                    [Validation(Required=false)]
                    public List<ListGatewayRouteResponseBodyDataResultRoutePredicatesHeaderPredicates> HeaderPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesHeaderPredicates : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("MethodPredicates")]
                    [Validation(Required=false)]
                    public List<string> MethodPredicates { get; set; }

                    [NameInMap("PathPredicates")]
                    [Validation(Required=false)]
                    public ListGatewayRouteResponseBodyDataResultRoutePredicatesPathPredicates PathPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesPathPredicates : TeaModel {
                        [NameInMap("IgnoreCase")]
                        [Validation(Required=false)]
                        public bool? IgnoreCase { get; set; }
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }
                    };

                    [NameInMap("QueryPredicates")]
                    [Validation(Required=false)]
                    public List<ListGatewayRouteResponseBodyDataResultRoutePredicatesQueryPredicates> QueryPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesQueryPredicates : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public List<ListGatewayRouteResponseBodyDataResultRouteServices> RouteServices { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRouteServices : TeaModel {
                    public string GroupName { get; set; }
                    public string Name { get; set; }
                    public string Namespace { get; set; }
                    public int? Percent { get; set; }
                    public long? ServiceId { get; set; }
                    public string ServiceName { get; set; }
                    public string SourceType { get; set; }
                    public string Version { get; set; }
                }
                public string Services { get; set; }
                public int? Status { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
