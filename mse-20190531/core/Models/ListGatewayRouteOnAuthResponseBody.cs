// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayRouteOnAuthResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListGatewayRouteOnAuthResponseBodyData> Data { get; set; }
        public class ListGatewayRouteOnAuthResponseBodyData : TeaModel {
            /// <summary>
            /// The domain ID.
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public long? DomainId { get; set; }

            /// <summary>
            /// The domain IDs.
            /// </summary>
            [NameInMap("DomainIdList")]
            [Validation(Required=false)]
            public List<long?> DomainIdList { get; set; }

            /// <summary>
            /// The domain name.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The domain names.
            /// </summary>
            [NameInMap("DomainNameList")]
            [Validation(Required=false)]
            public List<string> DomainNameList { get; set; }

            /// <summary>
            /// The gateway ID.
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// The unique ID of the gateway.
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// The route ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The name of the route.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The information about route matching.
            /// </summary>
            [NameInMap("RoutePredicates")]
            [Validation(Required=false)]
            public ListGatewayRouteOnAuthResponseBodyDataRoutePredicates RoutePredicates { get; set; }
            public class ListGatewayRouteOnAuthResponseBodyDataRoutePredicates : TeaModel {
                /// <summary>
                /// The information about route matching.
                /// </summary>
                [NameInMap("PathPredicates")]
                [Validation(Required=false)]
                public ListGatewayRouteOnAuthResponseBodyDataRoutePredicatesPathPredicates PathPredicates { get; set; }
                public class ListGatewayRouteOnAuthResponseBodyDataRoutePredicatesPathPredicates : TeaModel {
                    /// <summary>
                    /// The path.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The matching type.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
