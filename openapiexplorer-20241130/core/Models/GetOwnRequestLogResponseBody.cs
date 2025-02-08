// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GetOwnRequestLogResponseBody : TeaModel {
        [NameInMap("logInfo")]
        [Validation(Required=false)]
        public GetOwnRequestLogResponseBodyLogInfo LogInfo { get; set; }
        public class GetOwnRequestLogResponseBodyLogInfo : TeaModel {
            [NameInMap("authenticationInfo")]
            [Validation(Required=false)]
            public GetOwnRequestLogResponseBodyLogInfoAuthenticationInfo AuthenticationInfo { get; set; }
            public class GetOwnRequestLogResponseBodyLogInfoAuthenticationInfo : TeaModel {
                [NameInMap("authenticationType")]
                [Validation(Required=false)]
                public string AuthenticationType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HMAC-SHA256</para>
                /// </summary>
                [NameInMap("signatureMethod")]
                [Validation(Required=false)]
                public string SignatureMethod { get; set; }

                [NameInMap("signatureVersion")]
                [Validation(Required=false)]
                public string SignatureVersion { get; set; }

            }

            [NameInMap("basicInfo")]
            [Validation(Required=false)]
            public GetOwnRequestLogResponseBodyLogInfoBasicInfo BasicInfo { get; set; }
            public class GetOwnRequestLogResponseBodyLogInfoBasicInfo : TeaModel {
                [NameInMap("accessDeniedDetail")]
                [Validation(Required=false)]
                public GetOwnRequestLogResponseBodyLogInfoBasicInfoAccessDeniedDetail AccessDeniedDetail { get; set; }
                public class GetOwnRequestLogResponseBodyLogInfoBasicInfoAccessDeniedDetail : TeaModel {
                    [NameInMap("authAction")]
                    [Validation(Required=false)]
                    public string AuthAction { get; set; }

                    [NameInMap("authPrincipalDisplayName")]
                    [Validation(Required=false)]
                    public string AuthPrincipalDisplayName { get; set; }

                    [NameInMap("authPrincipalOwnerId")]
                    [Validation(Required=false)]
                    public string AuthPrincipalOwnerId { get; set; }

                    [NameInMap("authPrincipalType")]
                    [Validation(Required=false)]
                    public string AuthPrincipalType { get; set; }

                    [NameInMap("encodedDiagnosticMessage")]
                    [Validation(Required=false)]
                    public string EncodedDiagnosticMessage { get; set; }

                    [NameInMap("noPermissionType")]
                    [Validation(Required=false)]
                    public string NoPermissionType { get; set; }

                    [NameInMap("policyType")]
                    [Validation(Required=false)]
                    public string PolicyType { get; set; }

                }

                [NameInMap("api")]
                [Validation(Required=false)]
                public string Api { get; set; }

                [NameInMap("apiDoc")]
                [Validation(Required=false)]
                public GetOwnRequestLogResponseBodyLogInfoBasicInfoApiDoc ApiDoc { get; set; }
                public class GetOwnRequestLogResponseBodyLogInfoBasicInfoApiDoc : TeaModel {
                    [NameInMap("alibabacloudSite")]
                    [Validation(Required=false)]
                    public string AlibabacloudSite { get; set; }

                    [NameInMap("aliyunSite")]
                    [Validation(Required=false)]
                    public string AliyunSite { get; set; }

                }

                [NameInMap("apiStyle")]
                [Validation(Required=false)]
                public string ApiStyle { get; set; }

                [NameInMap("apiVersion")]
                [Validation(Required=false)]
                public string ApiVersion { get; set; }

                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("gatewayProcessTime")]
                [Validation(Required=false)]
                public string GatewayProcessTime { get; set; }

                [NameInMap("httpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                [NameInMap("httpStatusCode")]
                [Validation(Required=false)]
                public string HttpStatusCode { get; set; }

                [NameInMap("logRequestId")]
                [Validation(Required=false)]
                public string LogRequestId { get; set; }

                [NameInMap("product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                [NameInMap("productName")]
                [Validation(Required=false)]
                public GetOwnRequestLogResponseBodyLogInfoBasicInfoProductName ProductName { get; set; }
                public class GetOwnRequestLogResponseBodyLogInfoBasicInfoProductName : TeaModel {
                    [NameInMap("cnName")]
                    [Validation(Required=false)]
                    public string CnName { get; set; }

                    [NameInMap("enName")]
                    [Validation(Required=false)]
                    public string EnName { get; set; }

                }

                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("requestDuration")]
                [Validation(Required=false)]
                public string RequestDuration { get; set; }

                [NameInMap("sdkRequestTime")]
                [Validation(Required=false)]
                public string SdkRequestTime { get; set; }

                [NameInMap("throttlingResult")]
                [Validation(Required=false)]
                public string ThrottlingResult { get; set; }

            }

            [NameInMap("callerInfo")]
            [Validation(Required=false)]
            public GetOwnRequestLogResponseBodyLogInfoCallerInfo CallerInfo { get; set; }
            public class GetOwnRequestLogResponseBodyLogInfoCallerInfo : TeaModel {
                [NameInMap("callerAccountId")]
                [Validation(Required=false)]
                public string CallerAccountId { get; set; }

                [NameInMap("callerIp")]
                [Validation(Required=false)]
                public string CallerIp { get; set; }

                [NameInMap("callerType")]
                [Validation(Required=false)]
                public string CallerType { get; set; }

                [NameInMap("masterAccountId")]
                [Validation(Required=false)]
                public string MasterAccountId { get; set; }

                [NameInMap("userAgent")]
                [Validation(Required=false)]
                public string UserAgent { get; set; }

            }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public List<GetOwnRequestLogResponseBodyLogInfoParameters> Parameters { get; set; }
            public class GetOwnRequestLogResponseBodyLogInfoParameters : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            [NameInMap("responses")]
            [Validation(Required=false)]
            public GetOwnRequestLogResponseBodyLogInfoResponses Responses { get; set; }
            public class GetOwnRequestLogResponseBodyLogInfoResponses : TeaModel {
                [NameInMap("responseBody")]
                [Validation(Required=false)]
                public string ResponseBody { get; set; }

                [NameInMap("responseBodyFormat")]
                [Validation(Required=false)]
                public string ResponseBodyFormat { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
