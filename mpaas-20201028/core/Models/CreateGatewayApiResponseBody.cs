// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CreateGatewayApiResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Api")]
        [Validation(Required=false)]
        public CreateGatewayApiResponseBodyApi Api { get; set; }
        public class CreateGatewayApiResponseBodyApi : TeaModel {
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public long? ApiId { get; set; }

            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            [NameInMap("ApiStatus")]
            [Validation(Required=false)]
            public string ApiStatus { get; set; }

            [NameInMap("ApiType")]
            [Validation(Required=false)]
            public string ApiType { get; set; }

            [NameInMap("AuthRuleName")]
            [Validation(Required=false)]
            public string AuthRuleName { get; set; }

            [NameInMap("CacheRule")]
            [Validation(Required=false)]
            public CreateGatewayApiResponseBodyApiCacheRule CacheRule { get; set; }
            public class CreateGatewayApiResponseBodyApiCacheRule : TeaModel {
                [NameInMap("CacheKey")]
                [Validation(Required=false)]
                public string CacheKey { get; set; }

                [NameInMap("NeedCache")]
                [Validation(Required=false)]
                public bool? NeedCache { get; set; }

                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public long? Ttl { get; set; }

            }

            [NameInMap("Charset")]
            [Validation(Required=false)]
            public string Charset { get; set; }

            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            [NameInMap("DefaultLimitRule")]
            [Validation(Required=false)]
            public CreateGatewayApiResponseBodyApiDefaultLimitRule DefaultLimitRule { get; set; }
            public class CreateGatewayApiResponseBodyApiDefaultLimitRule : TeaModel {
                [NameInMap("DefaultLimit")]
                [Validation(Required=false)]
                public bool? DefaultLimit { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            [NameInMap("HeaderRules")]
            [Validation(Required=false)]
            public List<CreateGatewayApiResponseBodyApiHeaderRules> HeaderRules { get; set; }
            public class CreateGatewayApiResponseBodyApiHeaderRules : TeaModel {
                [NameInMap("HeaderKey")]
                [Validation(Required=false)]
                public string HeaderKey { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("InterfaceType")]
            [Validation(Required=false)]
            public string InterfaceType { get; set; }

            [NameInMap("LimitRule")]
            [Validation(Required=false)]
            public CreateGatewayApiResponseBodyApiLimitRule LimitRule { get; set; }
            public class CreateGatewayApiResponseBodyApiLimitRule : TeaModel {
                [NameInMap("DefaultResponse")]
                [Validation(Required=false)]
                public string DefaultResponse { get; set; }

                [NameInMap("Limit")]
                [Validation(Required=false)]
                public double? Limit { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("MethodName")]
            [Validation(Required=false)]
            public string MethodName { get; set; }

            [NameInMap("MigrateRule")]
            [Validation(Required=false)]
            public CreateGatewayApiResponseBodyApiMigrateRule MigrateRule { get; set; }
            public class CreateGatewayApiResponseBodyApiMigrateRule : TeaModel {
                [NameInMap("FlowPercent")]
                [Validation(Required=false)]
                public int? FlowPercent { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("NeedMigrate")]
                [Validation(Required=false)]
                public bool? NeedMigrate { get; set; }

                [NameInMap("NeedSwitchCompletely")]
                [Validation(Required=false)]
                public bool? NeedSwitchCompletely { get; set; }

                [NameInMap("UpstreamType")]
                [Validation(Required=false)]
                public string UpstreamType { get; set; }

            }

            [NameInMap("MockRule")]
            [Validation(Required=false)]
            public CreateGatewayApiResponseBodyApiMockRule MockRule { get; set; }
            public class CreateGatewayApiResponseBodyApiMockRule : TeaModel {
                [NameInMap("MockData")]
                [Validation(Required=false)]
                public string MockData { get; set; }

                [NameInMap("NeedMock")]
                [Validation(Required=false)]
                public bool? NeedMock { get; set; }

                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("NeedEncrypt")]
            [Validation(Required=false)]
            public bool? NeedEncrypt { get; set; }

            [NameInMap("NeedJsonp")]
            [Validation(Required=false)]
            public bool? NeedJsonp { get; set; }

            [NameInMap("NeedSign")]
            [Validation(Required=false)]
            public bool? NeedSign { get; set; }

            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("RequestBodyModel")]
            [Validation(Required=false)]
            public string RequestBodyModel { get; set; }

            [NameInMap("RequestParams")]
            [Validation(Required=false)]
            public List<CreateGatewayApiResponseBodyApiRequestParams> RequestParams { get; set; }
            public class CreateGatewayApiResponseBodyApiRequestParams : TeaModel {
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RefType")]
                [Validation(Required=false)]
                public string RefType { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("ResponseBodyModel")]
            [Validation(Required=false)]
            public string ResponseBodyModel { get; set; }

            [NameInMap("RpcParameterTypes")]
            [Validation(Required=false)]
            public List<string> RpcParameterTypes { get; set; }

            [NameInMap("Serialization")]
            [Validation(Required=false)]
            public string Serialization { get; set; }

            [NameInMap("SysName")]
            [Validation(Required=false)]
            public string SysName { get; set; }

            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

        }

        [NameInMap("ErrorField")]
        [Validation(Required=false)]
        public string ErrorField { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
