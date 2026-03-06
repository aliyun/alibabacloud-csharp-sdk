// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GetOwnRequestLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the API request log.</para>
        /// </summary>
        [NameInMap("logInfo")]
        [Validation(Required=false)]
        public GetOwnRequestLogResponseBodyLogInfo LogInfo { get; set; }
        public class GetOwnRequestLogResponseBodyLogInfo : TeaModel {
            /// <summary>
            /// <para>The authentication information.</para>
            /// </summary>
            [NameInMap("authenticationInfo")]
            [Validation(Required=false)]
            public GetOwnRequestLogResponseBodyLogInfoAuthenticationInfo AuthenticationInfo { get; set; }
            public class GetOwnRequestLogResponseBodyLogInfoAuthenticationInfo : TeaModel {
                /// <summary>
                /// <para>The authentication type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>\<c>AK\\</c>: an AccessKey, which can be a permanent AccessKey, a temporary AccessKey, or an STS token.</para>
                /// </description></item>
                /// <item><description><para>\<c>PRIVATEKEY\\</c>: an AccessKey for asymmetric key encryption.</para>
                /// </description></item>
                /// <item><description><para>\<c>BEARERTOKEN\\</c>: an authentication mechanism that is widely used in the OAuth 2.0 framework and cloud services.</para>
                /// </description></item>
                /// <item><description><para>\<c>CUSTOM_SPI\\</c>: an efficient and secure authentication method that is suitable for the delivery and management of Software as a Service (SaaS) products in Alibaba Cloud Marketplace.</para>
                /// </description></item>
                /// <item><description><para>\<c>Anonymous\\</c>: anonymous access.</para>
                /// </description></item>
                /// <item><description><para>\<c>DPS\\</c>: similar to an AccessKey, but uses a product-specific signature algorithm that is different from the official Alibaba Cloud algorithm.</para>
                /// </description></item>
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
                /// <item><description><para>\<c>HMAC-SHA1\\</c>: The request is signed using the HMAC-SHA1 algorithm.</para>
                /// </description></item>
                /// <item><description><para>\<c>HMAC-SHA256\\</c>: The request is signed using the HMAC-SHA256 algorithm.</para>
                /// </description></item>
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
            /// <para>The basic information about the API request.</para>
            /// </summary>
            [NameInMap("basicInfo")]
            [Validation(Required=false)]
            public GetOwnRequestLogResponseBodyLogInfoBasicInfo BasicInfo { get; set; }
            public class GetOwnRequestLogResponseBodyLogInfoBasicInfo : TeaModel {
                /// <summary>
                /// <para>The details of the permission error.</para>
                /// </summary>
                [NameInMap("accessDeniedDetail")]
                [Validation(Required=false)]
                public GetOwnRequestLogResponseBodyLogInfoBasicInfoAccessDeniedDetail AccessDeniedDetail { get; set; }
                public class GetOwnRequestLogResponseBodyLogInfoBasicInfoAccessDeniedDetail : TeaModel {
                    /// <summary>
                    /// <para>The specific operation that caused the permission error.</para>
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
                    /// <para>The UID of the Alibaba Cloud account to which the current identity belongs.</para>
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
                    /// <para>The encoded diagnostic information. Call the \<c>DecodeDiagnosticMessage\\</c> operation of RAM to obtain more diagnostic information.</para>
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
                    /// <para>The reason why the permission was denied.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ImplicitDeny</para>
                    /// </summary>
                    [NameInMap("noPermissionType")]
                    [Validation(Required=false)]
                    public string NoPermissionType { get; set; }

                    /// <summary>
                    /// <para>The type of the policy that caused the permission error.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AccountLevelIdentityBasedPolicy</para>
                    /// </summary>
                    [NameInMap("policyType")]
                    [Validation(Required=false)]
                    public string PolicyType { get; set; }

                }

                /// <summary>
                /// <para>The name of the API in the queried log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RunInstances</para>
                /// </summary>
                [NameInMap("api")]
                [Validation(Required=false)]
                public string Api { get; set; }

                /// <summary>
                /// <para>Information about the API reference.</para>
                /// </summary>
                [NameInMap("apiDoc")]
                [Validation(Required=false)]
                public GetOwnRequestLogResponseBodyLogInfoBasicInfoApiDoc ApiDoc { get; set; }
                public class GetOwnRequestLogResponseBodyLogInfoBasicInfoApiDoc : TeaModel {
                    /// <summary>
                    /// <para>The URL of the API reference for the international site (alibabacloud.com).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://api.alibabacloud.com/document/Ecs/2014-05-26/RunInstances">https://api.alibabacloud.com/document/Ecs/2014-05-26/RunInstances</a></para>
                    /// </summary>
                    [NameInMap("alibabacloudSite")]
                    [Validation(Required=false)]
                    public string AlibabacloudSite { get; set; }

                    /// <summary>
                    /// <para>The URL of the API reference for the China site (aliyun.com).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://api.aliyun.com/document/Ecs/2014-05-26/RunInstances">https://api.aliyun.com/document/Ecs/2014-05-26/RunInstances</a></para>
                    /// </summary>
                    [NameInMap("aliyunSite")]
                    [Validation(Required=false)]
                    public string AliyunSite { get; set; }

                }

                /// <summary>
                /// <para>The API style. Valid values: \<c>ROA\\</c> and \<c>RPC\\</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rpc</para>
                /// </summary>
                [NameInMap("apiStyle")]
                [Validation(Required=false)]
                public string ApiStyle { get; set; }

                /// <summary>
                /// <para>The API version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2014-05-26</para>
                /// </summary>
                [NameInMap("apiVersion")]
                [Validation(Required=false)]
                public string ApiVersion { get; set; }

                /// <summary>
                /// <para>The endpoint of the service in the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.cn-hangzhou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The error code in the queried log. This parameter is empty if no error is reported for the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IncorrectStatus.TransitRouter</para>
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message in the queried log. This parameter is empty if no error is reported for the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The resource is not in a valid state for the operation.</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The time when the gateway received the request. The time is in the \<c>yyyy-MM-ddTHH:mm:ssZ\\</c> format and is in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-21T07:43:06Z</para>
                /// </summary>
                [NameInMap("gatewayProcessTime")]
                [Validation(Required=false)]
                public string GatewayProcessTime { get; set; }

                /// <summary>
                /// <para>The HTTP request method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("httpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// <para>The HTTP status code in the queried log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("httpStatusCode")]
                [Validation(Required=false)]
                public string HttpStatusCode { get; set; }

                /// <summary>
                /// <para>The request ID that is passed in the request.</para>
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
                /// <para>The name of the product in Chinese and English.</para>
                /// </summary>
                [NameInMap("productName")]
                [Validation(Required=false)]
                public GetOwnRequestLogResponseBodyLogInfoBasicInfoProductName ProductName { get; set; }
                public class GetOwnRequestLogResponseBodyLogInfoBasicInfoProductName : TeaModel {
                    /// <summary>
                    /// <para>The Chinese name of the product.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>云服务器 ECS</para>
                    /// </summary>
                    [NameInMap("cnName")]
                    [Validation(Required=false)]
                    public string CnName { get; set; }

                    /// <summary>
                    /// <para>The English name of the product.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Elastic Compute Service</para>
                    /// </summary>
                    [NameInMap("enName")]
                    [Validation(Required=false)]
                    public string EnName { get; set; }

                }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The time that elapses from when the gateway receives the request to when the gateway returns the response. Unit: ms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>188</para>
                /// </summary>
                [NameInMap("requestDuration")]
                [Validation(Required=false)]
                public string RequestDuration { get; set; }

                /// <summary>
                /// <para>The time when the request was initiated. The time is in the \<c>yyyy-MM-ddTHH:mm:ssZ\\</c> format and is in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-21T07:43:06Z</para>
                /// </summary>
                [NameInMap("sdkRequestTime")]
                [Validation(Required=false)]
                public string SdkRequestTime { get; set; }

                /// <summary>
                /// <para>The result of the throttling check.\<c>FC.PASS\\</c>: The request was not blocked by throttling.\<c>FC.DENY\\</c>: The request was blocked by throttling.</para>
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
            public GetOwnRequestLogResponseBodyLogInfoCallerInfo CallerInfo { get; set; }
            public class GetOwnRequestLogResponseBodyLogInfoCallerInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the caller\&quot;s account.</para>
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
                /// <item><description><para>customer: An Alibaba Cloud account.</para>
                /// </description></item>
                /// <item><description><para>sub: A RAM user.</para>
                /// </description></item>
                /// <item><description><para>AssumedRoleUser: A temporary identity that uses a Security Token Service (STS) token.</para>
                /// </description></item>
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
                /// <para>The user agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AlibabaCloud API Workbench</para>
                /// </summary>
                [NameInMap("userAgent")]
                [Validation(Required=false)]
                public string UserAgent { get; set; }

            }

            /// <summary>
            /// <para>The request parameters.</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public List<GetOwnRequestLogResponseBodyLogInfoParameters> Parameters { get; set; }
            public class GetOwnRequestLogResponseBodyLogInfoParameters : TeaModel {
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
                /// <para>Specifies whether the request parameter is required.</para>
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
            /// <para>The information returned for the request.</para>
            /// </summary>
            [NameInMap("responses")]
            [Validation(Required=false)]
            public GetOwnRequestLogResponseBodyLogInfoResponses Responses { get; set; }
            public class GetOwnRequestLogResponseBodyLogInfoResponses : TeaModel {
                /// <summary>
                /// <para>The returned information.</para>
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
                /// <para>The format of the response body. Valid values: \<c>JSON\\</c>, \<c>XML\\</c>, and \<c>HTML\\</c>.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9BFC4AC1-6BE4-5405-BDEC-CA288D404812</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
