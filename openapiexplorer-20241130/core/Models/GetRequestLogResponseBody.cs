// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GetRequestLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the log of the API call.</para>
        /// </summary>
        [NameInMap("logInfo")]
        [Validation(Required=false)]
        public GetRequestLogResponseBodyLogInfo LogInfo { get; set; }
        public class GetRequestLogResponseBodyLogInfo : TeaModel {
            /// <summary>
            /// <para>The authentication information.</para>
            /// </summary>
            [NameInMap("authenticationInfo")]
            [Validation(Required=false)]
            public GetRequestLogResponseBodyLogInfoAuthenticationInfo AuthenticationInfo { get; set; }
            public class GetRequestLogResponseBodyLogInfoAuthenticationInfo : TeaModel {
                /// <summary>
                /// <para>The authentication type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AK: includes a permanent AccessKey pair, a temporary AccessKey pair, and a STS token.</description></item>
                /// <item><description>PRIVATEKEY: an AccessKey pair for an asymmetric cryptography algorithm.</description></item>
                /// <item><description>BEARETOKEN: an authentication mechanism that is widely used in the OAuth 2.0 framework and cloud services.</description></item>
                /// <item><description>CUSTOM_SPI: an efficient and secure authentication method that is suitable for the delivery and management of Software as a Service (SaaS) services in Alibaba Cloud Marketplace.</description></item>
                /// <item><description>Anonymous: anonymous access.</description></item>
                /// <item><description>DPS: an authentication method that is similar to AK. Its signature algorithm is different from that of Alibaba Cloud services and is exclusive to specific products.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AK</para>
                /// </summary>
                [NameInMap("authenticationType")]
                [Validation(Required=false)]
                public string AuthenticationType { get; set; }

                /// <summary>
                /// <para>The signature algorithm. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>HMAC-SHA1</description></item>
                /// <item><description>HMAC-SHA256</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HMAC-SHA256</para>
                /// </summary>
                [NameInMap("signatureMethod")]
                [Validation(Required=false)]
                public string SignatureMethod { get; set; }

                /// <summary>
                /// <para>The signature version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>unknown</para>
                /// </summary>
                [NameInMap("signatureVersion")]
                [Validation(Required=false)]
                public string SignatureVersion { get; set; }

            }

            /// <summary>
            /// <para>The basic information about the log of the API call.</para>
            /// </summary>
            [NameInMap("basicInfo")]
            [Validation(Required=false)]
            public GetRequestLogResponseBodyLogInfoBasicInfo BasicInfo { get; set; }
            public class GetRequestLogResponseBodyLogInfoBasicInfo : TeaModel {
                /// <summary>
                /// <para>The error message returned if the operator does not have the required permissions. This parameter is available only if an authentication error is reported for the request ID.</para>
                /// </summary>
                [NameInMap("accessDeniedDetail")]
                [Validation(Required=false)]
                public GetRequestLogResponseBodyLogInfoBasicInfoAccessDeniedDetail AccessDeniedDetail { get; set; }
                public class GetRequestLogResponseBodyLogInfoBasicInfoAccessDeniedDetail : TeaModel {
                    /// <summary>
                    /// <para>The operation that the operator does not have permissions to perform.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>openapiexplorer:GetRequestLog</para>
                    /// </summary>
                    [NameInMap("authAction")]
                    [Validation(Required=false)]
                    public string AuthAction { get; set; }

                    /// <summary>
                    /// <para>The identity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>205618123456123456</para>
                    /// </summary>
                    [NameInMap("authPrincipalDisplayName")]
                    [Validation(Required=false)]
                    public string AuthPrincipalDisplayName { get; set; }

                    /// <summary>
                    /// <para>The ID of the Alibaba Cloud account to which the current identity belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1001234561234567</para>
                    /// </summary>
                    [NameInMap("authPrincipalOwnerId")]
                    [Validation(Required=false)]
                    public string AuthPrincipalOwnerId { get; set; }

                    /// <summary>
                    /// <para>The identity type of the operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SubUser</para>
                    /// </summary>
                    [NameInMap("authPrincipalType")]
                    [Validation(Required=false)]
                    public string AuthPrincipalType { get; set; }

                    /// <summary>
                    /// <para>The information after encoding, which can be used for troubleshooting. You can call the DecodeDiagnosticMessage operation of Resource Access Management (RAM) for further diagnostics.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("encodedDiagnosticMessage")]
                    [Validation(Required=false)]
                    public string EncodedDiagnosticMessage { get; set; }

                    /// <summary>
                    /// <para>The cause of the permission-related error.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ImplicitDeny</para>
                    /// </summary>
                    [NameInMap("noPermissionType")]
                    [Validation(Required=false)]
                    public string NoPermissionType { get; set; }

                    /// <summary>
                    /// <para>The type of the policy that causes the permission-related error.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AccountLevelIdentityBasedPolicy</para>
                    /// </summary>
                    [NameInMap("policyType")]
                    [Validation(Required=false)]
                    public string PolicyType { get; set; }

                }

                /// <summary>
                /// <para>The name of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RunInstances</para>
                /// </summary>
                [NameInMap("api")]
                [Validation(Required=false)]
                public string Api { get; set; }

                /// <summary>
                /// <para>The information about the API documentation.</para>
                /// </summary>
                [NameInMap("apiDoc")]
                [Validation(Required=false)]
                public GetRequestLogResponseBodyLogInfoBasicInfoApiDoc ApiDoc { get; set; }
                public class GetRequestLogResponseBodyLogInfoBasicInfoApiDoc : TeaModel {
                    /// <summary>
                    /// <para>The documentation URL on the international site (alibabacloud.com).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://api.alibabacloud.com/document/Ecs/2014-05-26/RunInstances">https://api.alibabacloud.com/document/Ecs/2014-05-26/RunInstances</a></para>
                    /// </summary>
                    [NameInMap("alibabacloudSite")]
                    [Validation(Required=false)]
                    public string AlibabacloudSite { get; set; }

                    /// <summary>
                    /// <para>The documentation URL on the China site (aliyun.com).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://api.aliyun.com/document/Ecs/2014-05-26/RunInstances">https://api.aliyun.com/document/Ecs/2014-05-26/RunInstances</a></para>
                    /// </summary>
                    [NameInMap("aliyunSite")]
                    [Validation(Required=false)]
                    public string AliyunSite { get; set; }

                }

                /// <summary>
                /// <para>The API style. Valid values: roa and rpc.</para>
                /// 
                /// <b>Example:</b>
                /// <para>roa</para>
                /// </summary>
                [NameInMap("apiStyle")]
                [Validation(Required=false)]
                public string ApiStyle { get; set; }

                /// <summary>
                /// <para>The version of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-30</para>
                /// </summary>
                [NameInMap("apiVersion")]
                [Validation(Required=false)]
                public string ApiVersion { get; set; }

                /// <summary>
                /// <para>The endpoint of the service region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.cn-hangzhou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The error code in the log. This parameter is left empty if no error is reported in the API call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IncorrectStatus.TransitRouter</para>
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message in the log. This parameter is left empty if no error is reported in the API call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The resource is not in a valid state for the operation.</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The time when the gateway receives the request. Indicate the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-21T07:43:06Z</para>
                /// </summary>
                [NameInMap("gatewayProcessTime")]
                [Validation(Required=false)]
                public string GatewayProcessTime { get; set; }

                /// <summary>
                /// <para>The HTTP request method. Valid values: GET, PUT, and POST.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("httpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// <para>The HTTP status code in the log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>404</para>
                /// </summary>
                [NameInMap("httpStatusCode")]
                [Validation(Required=false)]
                public string HttpStatusCode { get; set; }

                /// <summary>
                /// <para>The request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123E4567-E89B-12D3-A456-426614174000</para>
                /// </summary>
                [NameInMap("logRequestId")]
                [Validation(Required=false)]
                public string LogRequestId { get; set; }

                /// <summary>
                /// <para>The product code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ecs</para>
                /// </summary>
                [NameInMap("product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// <para>The product name, which includes the Chinese name and English name.</para>
                /// </summary>
                [NameInMap("productName")]
                [Validation(Required=false)]
                public GetRequestLogResponseBodyLogInfoBasicInfoProductName ProductName { get; set; }
                public class GetRequestLogResponseBodyLogInfoBasicInfoProductName : TeaModel {
                    /// <summary>
                    /// <para>The product name in Chinese.</para>
                    /// </summary>
                    [NameInMap("cnName")]
                    [Validation(Required=false)]
                    public string CnName { get; set; }

                    /// <summary>
                    /// <para>The product name in English.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Elastic Compute Service</para>
                    /// </summary>
                    [NameInMap("enName")]
                    [Validation(Required=false)]
                    public string EnName { get; set; }

                }

                /// <summary>
                /// <para>The service region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The duration from when the gateway receives the request to when the client receives a response. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>188</para>
                /// </summary>
                [NameInMap("requestDuration")]
                [Validation(Required=false)]
                public string RequestDuration { get; set; }

                /// <summary>
                /// <para>The time when the request is initiated. Indicate the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-21T07:43:06Z</para>
                /// </summary>
                [NameInMap("sdkRequestTime")]
                [Validation(Required=false)]
                public string SdkRequestTime { get; set; }

                /// <summary>
                /// <para>The throttling result. Valid values: FC.PASS: The task is not blocked by throttling. FC.DENY: The task is blocked by throttling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FC.PASS</para>
                /// </summary>
                [NameInMap("throttlingResult")]
                [Validation(Required=false)]
                public string ThrottlingResult { get; set; }

            }

            /// <summary>
            /// <para>The information about the caller.</para>
            /// </summary>
            [NameInMap("callerInfo")]
            [Validation(Required=false)]
            public GetRequestLogResponseBodyLogInfoCallerInfo CallerInfo { get; set; }
            public class GetRequestLogResponseBodyLogInfoCallerInfo : TeaModel {
                /// <summary>
                /// <para>The account ID of the caller.</para>
                /// 
                /// <b>Example:</b>
                /// <para>241009849925897811</para>
                /// </summary>
                [NameInMap("callerAccountId")]
                [Validation(Required=false)]
                public string CallerAccountId { get; set; }

                /// <summary>
                /// <para>The IP address of the caller.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.68.xxx.xxx</para>
                /// </summary>
                [NameInMap("callerIp")]
                [Validation(Required=false)]
                public string CallerIp { get; set; }

                /// <summary>
                /// <para>The type of the caller. Valid values:</para>
                /// <ol>
                /// <item><description>customer: an Alibaba Cloud account</description></item>
                /// <item><description>sub: a RAM user</description></item>
                /// <item><description>AssumedRoleUser: a user that uses a temporary Security Token Service (STS) token</description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>sub</para>
                /// </summary>
                [NameInMap("callerType")]
                [Validation(Required=false)]
                public string CallerType { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1973374733454118</para>
                /// </summary>
                [NameInMap("masterAccountId")]
                [Validation(Required=false)]
                public string MasterAccountId { get; set; }

                /// <summary>
                /// <para>The information about the user agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AlibabaCloud API Workbench</para>
                /// </summary>
                [NameInMap("userAgent")]
                [Validation(Required=false)]
                public string UserAgent { get; set; }

            }

            /// <summary>
            /// <para>The information about the request parameters.</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public List<GetRequestLogResponseBodyLogInfoParameters> Parameters { get; set; }
            public class GetRequestLogResponseBodyLogInfoParameters : TeaModel {
                /// <summary>
                /// <para>The name of the request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceType</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether the request parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                /// <summary>
                /// <para>The type of the request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value of the request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g6.large</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// <para>The information that is returned for the request.</para>
            /// </summary>
            [NameInMap("responses")]
            [Validation(Required=false)]
            public GetRequestLogResponseBodyLogInfoResponses Responses { get; set; }
            public class GetRequestLogResponseBodyLogInfoResponses : TeaModel {
                /// <summary>
                /// <para>The response body.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("responseBody")]
                [Validation(Required=false)]
                public string ResponseBody { get; set; }

                /// <summary>
                /// <para>The type of the response body. Valid values: JSON, XML, and HTML.</para>
                /// 
                /// <b>Example:</b>
                /// <para>JSON</para>
                /// </summary>
                [NameInMap("responseBodyFormat")]
                [Validation(Required=false)]
                public string ResponseBodyFormat { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9BFC4AC1-6BE4-5405-BDEC-CA288D404812</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
