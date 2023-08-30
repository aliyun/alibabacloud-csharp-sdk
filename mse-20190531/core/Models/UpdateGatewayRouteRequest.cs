// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The destination service type.
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// The information about service mocking.
        /// </summary>
        [NameInMap("DirectResponseJSON")]
        [Validation(Required=false)]
        public UpdateGatewayRouteRequestDirectResponseJSON DirectResponseJSON { get; set; }
        public class UpdateGatewayRouteRequestDirectResponseJSON : TeaModel {
            /// <summary>
            /// The mock return value.
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// The mock return code.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public long? Code { get; set; }

        }

        /// <summary>
        /// The associated domain name.
        /// </summary>
        [NameInMap("DomainIdListJSON")]
        [Validation(Required=false)]
        public string DomainIdListJSON { get; set; }

        /// <summary>
        /// Specifies whether to activate Web Application Firewall (WAF).
        /// </summary>
        [NameInMap("EnableWaf")]
        [Validation(Required=false)]
        public bool? EnableWaf { get; set; }

        /// <summary>
        /// Specifies whether to enable the Fallback service.
        /// </summary>
        [NameInMap("Fallback")]
        [Validation(Required=false)]
        public bool? Fallback { get; set; }

        /// <summary>
        /// The information about the Fallback service.
        /// </summary>
        [NameInMap("FallbackServices")]
        [Validation(Required=false)]
        public List<UpdateGatewayRouteRequestFallbackServices> FallbackServices { get; set; }
        public class UpdateGatewayRouteRequestFallbackServices : TeaModel {
            /// <summary>
            /// The type of the protocol. Valid values:
            /// </summary>
            [NameInMap("AgreementType")]
            [Validation(Required=false)]
            public string AgreementType { get; set; }

            /// <summary>
            /// The name of the group to which the service belongs.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The namespace in which the service resides.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The weight in the form of a percentage value.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            /// <summary>
            /// The ID of the service.
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            /// <summary>
            /// The service port number.
            /// </summary>
            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public int? ServicePort { get; set; }

            /// <summary>
            /// The source type.
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// The version of the service.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The ID of the gateway.
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// The ID of the route.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The name of the route.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The route matching conditions.
        /// </summary>
        [NameInMap("Predicates")]
        [Validation(Required=false)]
        public UpdateGatewayRouteRequestPredicates Predicates { get; set; }
        public class UpdateGatewayRouteRequestPredicates : TeaModel {
            /// <summary>
            /// The information about header matching.
            /// </summary>
            [NameInMap("HeaderPredicates")]
            [Validation(Required=false)]
            public List<UpdateGatewayRouteRequestPredicatesHeaderPredicates> HeaderPredicates { get; set; }
            public class UpdateGatewayRouteRequestPredicatesHeaderPredicates : TeaModel {
                /// <summary>
                /// The key of the request header.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The matching type.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The value of the request header.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The information about method matching.
            /// </summary>
            [NameInMap("MethodPredicates")]
            [Validation(Required=false)]
            public List<string> MethodPredicates { get; set; }

            /// <summary>
            /// The information about path matching.
            /// </summary>
            [NameInMap("PathPredicates")]
            [Validation(Required=false)]
            public UpdateGatewayRouteRequestPredicatesPathPredicates PathPredicates { get; set; }
            public class UpdateGatewayRouteRequestPredicatesPathPredicates : TeaModel {
                /// <summary>
                /// Specifies whether to perform case-insensitive matching.
                /// </summary>
                [NameInMap("IgnoreCase")]
                [Validation(Required=false)]
                public bool? IgnoreCase { get; set; }

                /// <summary>
                /// The path used for route matching.
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

            /// <summary>
            /// The information about parameter matching.
            /// </summary>
            [NameInMap("QueryPredicates")]
            [Validation(Required=false)]
            public List<UpdateGatewayRouteRequestPredicatesQueryPredicates> QueryPredicates { get; set; }
            public class UpdateGatewayRouteRequestPredicatesQueryPredicates : TeaModel {
                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The matching type.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The value of the parameter.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The information about redirection.
        /// </summary>
        [NameInMap("RedirectJSON")]
        [Validation(Required=false)]
        public UpdateGatewayRouteRequestRedirectJSON RedirectJSON { get; set; }
        public class UpdateGatewayRouteRequestRedirectJSON : TeaModel {
            /// <summary>
            /// The status code returned.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// The hostname to be redirected to.
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// The path to be redirected to.
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// The sequence number of the route.
        /// </summary>
        [NameInMap("RouteOrder")]
        [Validation(Required=false)]
        public int? RouteOrder { get; set; }

        /// <summary>
        /// The information about destination services.
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<UpdateGatewayRouteRequestServices> Services { get; set; }
        public class UpdateGatewayRouteRequestServices : TeaModel {
            /// <summary>
            /// The type of the protocol. Valid values:
            /// </summary>
            [NameInMap("AgreementType")]
            [Validation(Required=false)]
            public string AgreementType { get; set; }

            /// <summary>
            /// The name of the group to which the service belongs.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The transcoder of the Dubbo protocol.
            /// </summary>
            [NameInMap("HttpDubboTranscoder")]
            [Validation(Required=false)]
            public UpdateGatewayRouteRequestServicesHttpDubboTranscoder HttpDubboTranscoder { get; set; }
            public class UpdateGatewayRouteRequestServicesHttpDubboTranscoder : TeaModel {
                /// <summary>
                /// The Dubbo service group.
                /// </summary>
                [NameInMap("DubboServiceGroup")]
                [Validation(Required=false)]
                public string DubboServiceGroup { get; set; }

                /// <summary>
                /// The name of the Dubbo service.
                /// </summary>
                [NameInMap("DubboServiceName")]
                [Validation(Required=false)]
                public string DubboServiceName { get; set; }

                /// <summary>
                /// The version of the Dubbo service.
                /// </summary>
                [NameInMap("DubboServiceVersion")]
                [Validation(Required=false)]
                public string DubboServiceVersion { get; set; }

                /// <summary>
                /// The forwarding rules of the Dubbo service.
                /// </summary>
                [NameInMap("MothedMapList")]
                [Validation(Required=false)]
                public List<UpdateGatewayRouteRequestServicesHttpDubboTranscoderMothedMapList> MothedMapList { get; set; }
                public class UpdateGatewayRouteRequestServicesHttpDubboTranscoderMothedMapList : TeaModel {
                    /// <summary>
                    /// The method name of the Dubbo service.
                    /// </summary>
                    [NameInMap("DubboMothedName")]
                    [Validation(Required=false)]
                    public string DubboMothedName { get; set; }

                    /// <summary>
                    /// The HTTP method.
                    /// 
                    /// > Valid values:
                    /// 
                    /// *   ALL_GET
                    /// 
                    /// *   ALL_POST
                    /// 
                    /// *   ALL_PUT
                    /// 
                    /// *   ALL_DELETE
                    /// 
                    /// *   ALL_PATCH
                    /// </summary>
                    [NameInMap("HttpMothed")]
                    [Validation(Required=false)]
                    public string HttpMothed { get; set; }

                    /// <summary>
                    /// The path that is used to match a method.
                    /// </summary>
                    [NameInMap("Mothedpath")]
                    [Validation(Required=false)]
                    public string Mothedpath { get; set; }

                    /// <summary>
                    /// The information of parameter mappings.
                    /// </summary>
                    [NameInMap("ParamMapsList")]
                    [Validation(Required=false)]
                    public List<UpdateGatewayRouteRequestServicesHttpDubboTranscoderMothedMapListParamMapsList> ParamMapsList { get; set; }
                    public class UpdateGatewayRouteRequestServicesHttpDubboTranscoderMothedMapListParamMapsList : TeaModel {
                        /// <summary>
                        /// The key extracted from the input parameter.
                        /// </summary>
                        [NameInMap("ExtractKey")]
                        [Validation(Required=false)]
                        public string ExtractKey { get; set; }

                        /// <summary>
                        /// The position of the input parameter.
                        /// 
                        /// > Valid values:
                        /// 
                        /// *   `ALL_QUERY_PARAMETER`: request parameter
                        /// 
                        /// *   `ALL_HEADER`: request header
                        /// 
                        /// *   `ALL_PATH`: request path
                        /// 
                        /// *   `ALL_BODY`: request body
                        /// </summary>
                        [NameInMap("ExtractKeySpec")]
                        [Validation(Required=false)]
                        public string ExtractKeySpec { get; set; }

                        /// <summary>
                        /// The type of the backend service parameter.
                        /// </summary>
                        [NameInMap("MappingType")]
                        [Validation(Required=false)]
                        public string MappingType { get; set; }

                    }

                    /// <summary>
                    /// The pass-through type of the header.
                    /// 
                    /// > Valid values:
                    /// 
                    /// *   PASS_ALL: All headers are passed through.
                    /// 
                    /// *   PASS_NOT: All headers are not passed through.
                    /// 
                    /// *   PASS_ASSIGN: Specified headers are passed through.
                    /// </summary>
                    [NameInMap("PassThroughAllHeaders")]
                    [Validation(Required=false)]
                    public string PassThroughAllHeaders { get; set; }

                    /// <summary>
                    /// The list of headers to be passed through.
                    /// </summary>
                    [NameInMap("PassThroughList")]
                    [Validation(Required=false)]
                    public List<string> PassThroughList { get; set; }

                }

            }

            /// <summary>
            /// The name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The namespace in which the service resides.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The percentage.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            /// <summary>
            /// The ID of the service.
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            /// <summary>
            /// The Dubbo port number.
            /// </summary>
            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public int? ServicePort { get; set; }

            /// <summary>
            /// The source type.
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// The version of the service.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
