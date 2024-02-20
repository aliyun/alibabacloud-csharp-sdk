// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayAuthDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayAuthDetailResponseBodyData Data { get; set; }
        public class GetGatewayAuthDetailResponseBodyData : TeaModel {
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            [NameInMap("ClientSecret")]
            [Validation(Required=false)]
            public string ClientSecret { get; set; }

            [NameInMap("CookieDomain")]
            [Validation(Required=false)]
            public string CookieDomain { get; set; }

            [NameInMap("ExternalAuthZ")]
            [Validation(Required=false)]
            public GetGatewayAuthDetailResponseBodyDataExternalAuthZ ExternalAuthZ { get; set; }
            public class GetGatewayAuthDetailResponseBodyDataExternalAuthZ : TeaModel {
                [NameInMap("AllowRequestHeaders")]
                [Validation(Required=false)]
                public List<string> AllowRequestHeaders { get; set; }

                [NameInMap("AllowUpstreamHeaders")]
                [Validation(Required=false)]
                public List<string> AllowUpstreamHeaders { get; set; }

                [NameInMap("BodyMaxBytes")]
                [Validation(Required=false)]
                public int? BodyMaxBytes { get; set; }

                [NameInMap("IsRestrict")]
                [Validation(Required=false)]
                public bool? IsRestrict { get; set; }

                [NameInMap("PrefixPath")]
                [Validation(Required=false)]
                public string PrefixPath { get; set; }

                [NameInMap("Service")]
                [Validation(Required=false)]
                public GetGatewayAuthDetailResponseBodyDataExternalAuthZService Service { get; set; }
                public class GetGatewayAuthDetailResponseBodyDataExternalAuthZService : TeaModel {
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                }

                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                [NameInMap("TokenKey")]
                [Validation(Required=false)]
                public string TokenKey { get; set; }

                [NameInMap("WithRequestBody")]
                [Validation(Required=false)]
                public bool? WithRequestBody { get; set; }

            }

            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IsWhite")]
            [Validation(Required=false)]
            public bool? IsWhite { get; set; }

            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            [NameInMap("Jwks")]
            [Validation(Required=false)]
            public string Jwks { get; set; }

            [NameInMap("LoginUrl")]
            [Validation(Required=false)]
            public string LoginUrl { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RedirectUrl")]
            [Validation(Required=false)]
            public string RedirectUrl { get; set; }

            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<GetGatewayAuthDetailResponseBodyDataResourceList> ResourceList { get; set; }
            public class GetGatewayAuthDetailResponseBodyDataResourceList : TeaModel {
                [NameInMap("AuthId")]
                [Validation(Required=false)]
                public long? AuthId { get; set; }

                [NameInMap("AuthResourceHeaderList")]
                [Validation(Required=false)]
                public List<GetGatewayAuthDetailResponseBodyDataResourceListAuthResourceHeaderList> AuthResourceHeaderList { get; set; }
                public class GetGatewayAuthDetailResponseBodyDataResourceListAuthResourceHeaderList : TeaModel {
                    [NameInMap("HeaderKey")]
                    [Validation(Required=false)]
                    public string HeaderKey { get; set; }

                    [NameInMap("HeaderMethod")]
                    [Validation(Required=false)]
                    public string HeaderMethod { get; set; }

                    [NameInMap("HeaderValue")]
                    [Validation(Required=false)]
                    public string HeaderValue { get; set; }

                }

                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public long? DomainId { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IgnoreCase")]
                [Validation(Required=false)]
                public bool? IgnoreCase { get; set; }

                [NameInMap("IsWhite")]
                [Validation(Required=false)]
                public bool? IsWhite { get; set; }

                [NameInMap("MatchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            [NameInMap("ScopesList")]
            [Validation(Required=false)]
            public List<string> ScopesList { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

            [NameInMap("Sub")]
            [Validation(Required=false)]
            public string Sub { get; set; }

            [NameInMap("TokenName")]
            [Validation(Required=false)]
            public string TokenName { get; set; }

            [NameInMap("TokenNamePrefix")]
            [Validation(Required=false)]
            public string TokenNamePrefix { get; set; }

            [NameInMap("TokenPass")]
            [Validation(Required=false)]
            public bool? TokenPass { get; set; }

            [NameInMap("TokenPosition")]
            [Validation(Required=false)]
            public string TokenPosition { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
