// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GetRequestLogResponseBody : TeaModel {
        [NameInMap("logInfo")]
        [Validation(Required=false)]
        public GetRequestLogResponseBodyLogInfo LogInfo { get; set; }
        public class GetRequestLogResponseBodyLogInfo : TeaModel {
            [NameInMap("authenticationInfo")]
            [Validation(Required=false)]
            public GetRequestLogResponseBodyLogInfoAuthenticationInfo AuthenticationInfo { get; set; }
            public class GetRequestLogResponseBodyLogInfoAuthenticationInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>AK</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>unknown</para>
                /// </summary>
                [NameInMap("signatureVersion")]
                [Validation(Required=false)]
                public string SignatureVersion { get; set; }

            }

            [NameInMap("basicInfo")]
            [Validation(Required=false)]
            public GetRequestLogResponseBodyLogInfoBasicInfo BasicInfo { get; set; }
            public class GetRequestLogResponseBodyLogInfoBasicInfo : TeaModel {
                [NameInMap("accessDeniedDetail")]
                [Validation(Required=false)]
                public GetRequestLogResponseBodyLogInfoBasicInfoAccessDeniedDetail AccessDeniedDetail { get; set; }
                public class GetRequestLogResponseBodyLogInfoBasicInfoAccessDeniedDetail : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>openapiexplorer:GetRequestLog</para>
                    /// </summary>
                    [NameInMap("authAction")]
                    [Validation(Required=false)]
                    public string AuthAction { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>205618123456123456</para>
                    /// </summary>
                    [NameInMap("authPrincipalDisplayName")]
                    [Validation(Required=false)]
                    public string AuthPrincipalDisplayName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1001234561234567</para>
                    /// </summary>
                    [NameInMap("authPrincipalOwnerId")]
                    [Validation(Required=false)]
                    public string AuthPrincipalOwnerId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SubUser</para>
                    /// </summary>
                    [NameInMap("authPrincipalType")]
                    [Validation(Required=false)]
                    public string AuthPrincipalType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("encodedDiagnosticMessage")]
                    [Validation(Required=false)]
                    public string EncodedDiagnosticMessage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ImplicitDeny</para>
                    /// </summary>
                    [NameInMap("noPermissionType")]
                    [Validation(Required=false)]
                    public string NoPermissionType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>AccountLevelIdentityBasedPolicy</para>
                    /// </summary>
                    [NameInMap("policyType")]
                    [Validation(Required=false)]
                    public string PolicyType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RunInstances</para>
                /// </summary>
                [NameInMap("api")]
                [Validation(Required=false)]
                public string Api { get; set; }

                [NameInMap("apiDoc")]
                [Validation(Required=false)]
                public GetRequestLogResponseBodyLogInfoBasicInfoApiDoc ApiDoc { get; set; }
                public class GetRequestLogResponseBodyLogInfoBasicInfoApiDoc : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://api.alibabacloud.com/document/Ecs/2014-05-26/RunInstances">https://api.alibabacloud.com/document/Ecs/2014-05-26/RunInstances</a></para>
                    /// </summary>
                    [NameInMap("alibabacloudSite")]
                    [Validation(Required=false)]
                    public string AlibabacloudSite { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://api.aliyun.com/document/Ecs/2014-05-26/RunInstances">https://api.aliyun.com/document/Ecs/2014-05-26/RunInstances</a></para>
                    /// </summary>
                    [NameInMap("aliyunSite")]
                    [Validation(Required=false)]
                    public string AliyunSite { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>roa</para>
                /// </summary>
                [NameInMap("apiStyle")]
                [Validation(Required=false)]
                public string ApiStyle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-11-30</para>
                /// </summary>
                [NameInMap("apiVersion")]
                [Validation(Required=false)]
                public string ApiVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ecs.cn-hangzhou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IncorrectStatus.TransitRouter</para>
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>The resource is not in a valid state for the operation.</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-21T07:43:06Z</para>
                /// </summary>
                [NameInMap("gatewayProcessTime")]
                [Validation(Required=false)]
                public string GatewayProcessTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("httpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>404</para>
                /// </summary>
                [NameInMap("httpStatusCode")]
                [Validation(Required=false)]
                public string HttpStatusCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123E4567-E89B-12D3-A456-426614174000</para>
                /// </summary>
                [NameInMap("logRequestId")]
                [Validation(Required=false)]
                public string LogRequestId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Ecs</para>
                /// </summary>
                [NameInMap("product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                [NameInMap("productName")]
                [Validation(Required=false)]
                public GetRequestLogResponseBodyLogInfoBasicInfoProductName ProductName { get; set; }
                public class GetRequestLogResponseBodyLogInfoBasicInfoProductName : TeaModel {
                    [NameInMap("cnName")]
                    [Validation(Required=false)]
                    public string CnName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Elastic Compute Service</para>
                    /// </summary>
                    [NameInMap("enName")]
                    [Validation(Required=false)]
                    public string EnName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>188</para>
                /// </summary>
                [NameInMap("requestDuration")]
                [Validation(Required=false)]
                public string RequestDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-21T07:43:06Z</para>
                /// </summary>
                [NameInMap("sdkRequestTime")]
                [Validation(Required=false)]
                public string SdkRequestTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FC.PASS</para>
                /// </summary>
                [NameInMap("throttlingResult")]
                [Validation(Required=false)]
                public string ThrottlingResult { get; set; }

            }

            [NameInMap("callerInfo")]
            [Validation(Required=false)]
            public GetRequestLogResponseBodyLogInfoCallerInfo CallerInfo { get; set; }
            public class GetRequestLogResponseBodyLogInfoCallerInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>241009849925897811</para>
                /// </summary>
                [NameInMap("callerAccountId")]
                [Validation(Required=false)]
                public string CallerAccountId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100.68.xxx.xxx</para>
                /// </summary>
                [NameInMap("callerIp")]
                [Validation(Required=false)]
                public string CallerIp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sub</para>
                /// </summary>
                [NameInMap("callerType")]
                [Validation(Required=false)]
                public string CallerType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1973374733454118</para>
                /// </summary>
                [NameInMap("masterAccountId")]
                [Validation(Required=false)]
                public string MasterAccountId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AlibabaCloud API Workbench</para>
                /// </summary>
                [NameInMap("userAgent")]
                [Validation(Required=false)]
                public string UserAgent { get; set; }

            }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public List<GetRequestLogResponseBodyLogInfoParameters> Parameters { get; set; }
            public class GetRequestLogResponseBodyLogInfoParameters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>InstanceType</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ecs.g6.large</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            [NameInMap("responses")]
            [Validation(Required=false)]
            public GetRequestLogResponseBodyLogInfoResponses Responses { get; set; }
            public class GetRequestLogResponseBodyLogInfoResponses : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("responseBody")]
                [Validation(Required=false)]
                public string ResponseBody { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>JSON</para>
                /// </summary>
                [NameInMap("responseBodyFormat")]
                [Validation(Required=false)]
                public string ResponseBodyFormat { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9BFC4AC1-6BE4-5405-BDEC-CA288D404812</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
