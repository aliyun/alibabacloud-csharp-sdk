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

        }

        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public long? DomainId { get; set; }

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
        public List<AddGatewayRouteRequestFallbackServices> FallbackServices { get; set; }
        public class AddGatewayRouteRequestFallbackServices : TeaModel {
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

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        [NameInMap("MseSessionId")]
        [Validation(Required=false)]
        public string MseSessionId { get; set; }

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

        }

        [NameInMap("RouteOrder")]
        [Validation(Required=false)]
        public int? RouteOrder { get; set; }

        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<AddGatewayRouteRequestServices> Services { get; set; }
        public class AddGatewayRouteRequestServices : TeaModel {
            [NameInMap("AgreementType")]
            [Validation(Required=false)]
            public string AgreementType { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("HttpDubboTranscoder")]
            [Validation(Required=false)]
            public AddGatewayRouteRequestServicesHttpDubboTranscoder HttpDubboTranscoder { get; set; }
            public class AddGatewayRouteRequestServicesHttpDubboTranscoder : TeaModel {
                [NameInMap("DubboServiceName")]
                [Validation(Required=false)]
                public string DubboServiceName { get; set; }

                [NameInMap("DubboServiceVersion")]
                [Validation(Required=false)]
                public string DubboServiceVersion { get; set; }

                [NameInMap("MothedMapList")]
                [Validation(Required=false)]
                public List<AddGatewayRouteRequestServicesHttpDubboTranscoderMothedMapList> MothedMapList { get; set; }
                public class AddGatewayRouteRequestServicesHttpDubboTranscoderMothedMapList : TeaModel {
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
                    public List<AddGatewayRouteRequestServicesHttpDubboTranscoderMothedMapListParamMapsList> ParamMapsList { get; set; }
                    public class AddGatewayRouteRequestServicesHttpDubboTranscoderMothedMapListParamMapsList : TeaModel {
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

    }

}
