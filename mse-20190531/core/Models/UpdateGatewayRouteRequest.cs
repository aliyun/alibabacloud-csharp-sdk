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
        /// - zh: Chinese
        /// - en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The type of the destination service.
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
            /// The return value for service mocking.
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// The status code returned for service mocking.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public long? Code { get; set; }

        }

        /// <summary>
        /// The IDs of domain names with which the route is associated.
        /// </summary>
        [NameInMap("DomainIdListJSON")]
        [Validation(Required=false)]
        public string DomainIdListJSON { get; set; }

        [NameInMap("EnableWaf")]
        [Validation(Required=false)]
        public bool? EnableWaf { get; set; }

        [NameInMap("Fallback")]
        [Validation(Required=false)]
        public bool? Fallback { get; set; }

        [NameInMap("FallbackServices")]
        [Validation(Required=false)]
        public List<UpdateGatewayRouteRequestFallbackServices> FallbackServices { get; set; }
        public class UpdateGatewayRouteRequestFallbackServices : TeaModel {
            [NameInMap("AgreementType")]
            [Validation(Required=false)]
            public string AgreementType { get; set; }

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

            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public int? ServicePort { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

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
        /// The matching rules of the route.
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
                /// The matching mode.
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
                /// Specifies whether to perform case-insensitive matches.
                /// </summary>
                [NameInMap("IgnoreCase")]
                [Validation(Required=false)]
                public bool? IgnoreCase { get; set; }

                /// <summary>
                /// The path.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// The matching mode.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The information about URL parameter matching.
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
                /// The matching mode.
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
        /// The configuration of the redirect action.
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
        /// The information about services.
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<UpdateGatewayRouteRequestServices> Services { get; set; }
        public class UpdateGatewayRouteRequestServices : TeaModel {
            [NameInMap("AgreementType")]
            [Validation(Required=false)]
            public string AgreementType { get; set; }

            /// <summary>
            /// The name of the group to which the service belongs.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("HttpDubboTranscoder")]
            [Validation(Required=false)]
            public UpdateGatewayRouteRequestServicesHttpDubboTranscoder HttpDubboTranscoder { get; set; }
            public class UpdateGatewayRouteRequestServicesHttpDubboTranscoder : TeaModel {
                [NameInMap("DubboServiceGroup")]
                [Validation(Required=false)]
                public string DubboServiceGroup { get; set; }

                [NameInMap("DubboServiceName")]
                [Validation(Required=false)]
                public string DubboServiceName { get; set; }

                [NameInMap("DubboServiceVersion")]
                [Validation(Required=false)]
                public string DubboServiceVersion { get; set; }

                [NameInMap("MothedMapList")]
                [Validation(Required=false)]
                public List<UpdateGatewayRouteRequestServicesHttpDubboTranscoderMothedMapList> MothedMapList { get; set; }
                public class UpdateGatewayRouteRequestServicesHttpDubboTranscoderMothedMapList : TeaModel {
                    [NameInMap("DubboMothedName")]
                    [Validation(Required=false)]
                    public string DubboMothedName { get; set; }

                    [NameInMap("HttpMothed")]
                    [Validation(Required=false)]
                    public string HttpMothed { get; set; }

                    [NameInMap("Mothedpath")]
                    [Validation(Required=false)]
                    public string Mothedpath { get; set; }

                    [NameInMap("ParamMapsList")]
                    [Validation(Required=false)]
                    public List<UpdateGatewayRouteRequestServicesHttpDubboTranscoderMothedMapListParamMapsList> ParamMapsList { get; set; }
                    public class UpdateGatewayRouteRequestServicesHttpDubboTranscoderMothedMapListParamMapsList : TeaModel {
                        [NameInMap("ExtractKey")]
                        [Validation(Required=false)]
                        public string ExtractKey { get; set; }

                        [NameInMap("ExtractKeySpec")]
                        [Validation(Required=false)]
                        public string ExtractKeySpec { get; set; }

                        [NameInMap("MappingType")]
                        [Validation(Required=false)]
                        public string MappingType { get; set; }

                    }

                    [NameInMap("PassThroughAllHeaders")]
                    [Validation(Required=false)]
                    public string PassThroughAllHeaders { get; set; }

                    [NameInMap("PassThroughList")]
                    [Validation(Required=false)]
                    public List<string> PassThroughList { get; set; }

                }

            }

            /// <summary>
            /// The name of the service.
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

            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public int? ServicePort { get; set; }

            /// <summary>
            /// The source type of the service.
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
