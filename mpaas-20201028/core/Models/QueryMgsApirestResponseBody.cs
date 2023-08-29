// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryMgsApirestResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public QueryMgsApirestResponseBodyResultContent ResultContent { get; set; }
        public class QueryMgsApirestResponseBodyResultContent : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public QueryMgsApirestResponseBodyResultContentValue Value { get; set; }
            public class QueryMgsApirestResponseBodyResultContentValue : TeaModel {
                [NameInMap("ApiInvoker")]
                [Validation(Required=false)]
                public QueryMgsApirestResponseBodyResultContentValueApiInvoker ApiInvoker { get; set; }
                public class QueryMgsApirestResponseBodyResultContentValueApiInvoker : TeaModel {
                    [NameInMap("HttpInvoker")]
                    [Validation(Required=false)]
                    public QueryMgsApirestResponseBodyResultContentValueApiInvokerHttpInvoker HttpInvoker { get; set; }
                    public class QueryMgsApirestResponseBodyResultContentValueApiInvokerHttpInvoker : TeaModel {
                        [NameInMap("Charset")]
                        [Validation(Required=false)]
                        public string Charset { get; set; }

                        [NameInMap("ContentType")]
                        [Validation(Required=false)]
                        public string ContentType { get; set; }

                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        [NameInMap("Method")]
                        [Validation(Required=false)]
                        public string Method { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                    }

                    [NameInMap("RpcInvoker")]
                    [Validation(Required=false)]
                    public string RpcInvoker { get; set; }

                }

                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                [NameInMap("ApiStatus")]
                [Validation(Required=false)]
                public string ApiStatus { get; set; }

                [NameInMap("ApiType")]
                [Validation(Required=false)]
                public string ApiType { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AuthRuleName")]
                [Validation(Required=false)]
                public string AuthRuleName { get; set; }

                [NameInMap("CacheRule")]
                [Validation(Required=false)]
                public QueryMgsApirestResponseBodyResultContentValueCacheRule CacheRule { get; set; }
                public class QueryMgsApirestResponseBodyResultContentValueCacheRule : TeaModel {
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

                [NameInMap("CircuitBreakerRule")]
                [Validation(Required=false)]
                public QueryMgsApirestResponseBodyResultContentValueCircuitBreakerRule CircuitBreakerRule { get; set; }
                public class QueryMgsApirestResponseBodyResultContentValueCircuitBreakerRule : TeaModel {
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("DefaultResponse")]
                    [Validation(Required=false)]
                    public string DefaultResponse { get; set; }

                    [NameInMap("ErrorThreshold")]
                    [Validation(Required=false)]
                    public long? ErrorThreshold { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    [NameInMap("OpenTimeoutSeconds")]
                    [Validation(Required=false)]
                    public long? OpenTimeoutSeconds { get; set; }

                    [NameInMap("SlowRatioThreshold")]
                    [Validation(Required=false)]
                    public double? SlowRatioThreshold { get; set; }

                    [NameInMap("SwitchStatus")]
                    [Validation(Required=false)]
                    public string SwitchStatus { get; set; }

                    [NameInMap("WindowsInSeconds")]
                    [Validation(Required=false)]
                    public long? WindowsInSeconds { get; set; }

                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                }

                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("DefaultLimitRule")]
                [Validation(Required=false)]
                public QueryMgsApirestResponseBodyResultContentValueDefaultLimitRule DefaultLimitRule { get; set; }
                public class QueryMgsApirestResponseBodyResultContentValueDefaultLimitRule : TeaModel {
                    [NameInMap("ConfigId")]
                    [Validation(Required=false)]
                    public int? ConfigId { get; set; }

                    [NameInMap("DefaultLimit")]
                    [Validation(Required=false)]
                    public bool? DefaultLimit { get; set; }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("HeaderRule")]
                [Validation(Required=false)]
                public List<QueryMgsApirestResponseBodyResultContentValueHeaderRule> HeaderRule { get; set; }
                public class QueryMgsApirestResponseBodyResultContentValueHeaderRule : TeaModel {
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

                [NameInMap("HeaderRules")]
                [Validation(Required=false)]
                public List<QueryMgsApirestResponseBodyResultContentValueHeaderRules> HeaderRules { get; set; }
                public class QueryMgsApirestResponseBodyResultContentValueHeaderRules : TeaModel {
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

                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("InterfaceType")]
                [Validation(Required=false)]
                public string InterfaceType { get; set; }

                [NameInMap("LimitRule")]
                [Validation(Required=false)]
                public QueryMgsApirestResponseBodyResultContentValueLimitRule LimitRule { get; set; }
                public class QueryMgsApirestResponseBodyResultContentValueLimitRule : TeaModel {
                    [NameInMap("DefaultResponse")]
                    [Validation(Required=false)]
                    public string DefaultResponse { get; set; }

                    [NameInMap("I18nResponse")]
                    [Validation(Required=false)]
                    public string I18nResponse { get; set; }

                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public long? Interval { get; set; }

                    [NameInMap("Limit")]
                    [Validation(Required=false)]
                    public long? Limit { get; set; }

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
                public QueryMgsApirestResponseBodyResultContentValueMigrateRule MigrateRule { get; set; }
                public class QueryMgsApirestResponseBodyResultContentValueMigrateRule : TeaModel {
                    [NameInMap("FlowPercent")]
                    [Validation(Required=false)]
                    public long? FlowPercent { get; set; }

                    [NameInMap("NeedMigrate")]
                    [Validation(Required=false)]
                    public bool? NeedMigrate { get; set; }

                    [NameInMap("NeedSwitchCompletely")]
                    [Validation(Required=false)]
                    public bool? NeedSwitchCompletely { get; set; }

                    [NameInMap("SysId")]
                    [Validation(Required=false)]
                    public long? SysId { get; set; }

                    [NameInMap("SysName")]
                    [Validation(Required=false)]
                    public string SysName { get; set; }

                    [NameInMap("UpstreamType")]
                    [Validation(Required=false)]
                    public string UpstreamType { get; set; }

                }

                [NameInMap("MockRule")]
                [Validation(Required=false)]
                public QueryMgsApirestResponseBodyResultContentValueMockRule MockRule { get; set; }
                public class QueryMgsApirestResponseBodyResultContentValueMockRule : TeaModel {
                    [NameInMap("MockData")]
                    [Validation(Required=false)]
                    public string MockData { get; set; }

                    [NameInMap("NeedMock")]
                    [Validation(Required=false)]
                    public bool? NeedMock { get; set; }

                    [NameInMap("Percentage")]
                    [Validation(Required=false)]
                    public long? Percentage { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("NeedETag")]
                [Validation(Required=false)]
                public string NeedETag { get; set; }

                [NameInMap("NeedEncrypt")]
                [Validation(Required=false)]
                public string NeedEncrypt { get; set; }

                [NameInMap("NeedJsonp")]
                [Validation(Required=false)]
                public string NeedJsonp { get; set; }

                [NameInMap("NeedSign")]
                [Validation(Required=false)]
                public string NeedSign { get; set; }

                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                [NameInMap("ParamGetMethod")]
                [Validation(Required=false)]
                public string ParamGetMethod { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("RequestBodyModel")]
                [Validation(Required=false)]
                public string RequestBodyModel { get; set; }

                [NameInMap("RequestParams")]
                [Validation(Required=false)]
                public List<QueryMgsApirestResponseBodyResultContentValueRequestParams> RequestParams { get; set; }
                public class QueryMgsApirestResponseBodyResultContentValueRequestParams : TeaModel {
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

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

                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                }

                [NameInMap("ResponseBodyModel")]
                [Validation(Required=false)]
                public string ResponseBodyModel { get; set; }

                [NameInMap("SysId")]
                [Validation(Required=false)]
                public long? SysId { get; set; }

                [NameInMap("SysName")]
                [Validation(Required=false)]
                public string SysName { get; set; }

                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public string Timeout { get; set; }

                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
