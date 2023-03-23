// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiHistoryResponseBody : TeaModel {
        /// <summary>
        /// The signature algorithm that is used if the **AuthType** parameter is set to **APP**. If no value is specified for the AllowSignatureMethod parameter, the default value HmacSHA256 is used. Valid values:
        /// 
        /// *   HmacSHA256
        /// *   HmacSHA1,HmacSHA256
        /// </summary>
        [NameInMap("AllowSignatureMethod")]
        [Validation(Required=false)]
        public string AllowSignatureMethod { get; set; }

        /// <summary>
        /// The ID of the API.
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// The name of the API.
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// The type of AppCode authentication. Default value: DEFAULT. Valid values:
        /// 
        /// *   DEFAULT: AppCode authentication is supported after the API is published in Alibaba Cloud Marketplace.
        /// *   DISABLE: AppCode authentication is not supported.
        /// *   HEADER: AppCode authentication is supported only in Header parameters.
        /// *   HEADER_QUERY: AppCode authentication is supported in Header or Query parameters.
        /// </summary>
        [NameInMap("AppCodeAuthType")]
        [Validation(Required=false)]
        public string AppCodeAuthType { get; set; }

        /// <summary>
        /// The type of the security authentication that is used for the API. Valid values:
        /// 
        /// *   **APP**: The API can be called only by authorized applications.
        /// 
        /// *   **ANONYMOUS**: The API can be anonymously called. Take note of the following information:
        /// 
        ///     *   All users who have the permissions to obtain the API information can call this API. API Gateway neither authenticates callers nor configures user-specific throttling policies. You must configure throttling policies for public APIs.
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// The backend configurations.
        /// </summary>
        [NameInMap("BackendConfig")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyBackendConfig BackendConfig { get; set; }
        public class DescribeApiHistoryResponseBodyBackendConfig : TeaModel {
            /// <summary>
            /// The ID of the backend service.
            /// </summary>
            [NameInMap("BackendId")]
            [Validation(Required=false)]
            public string BackendId { get; set; }

            /// <summary>
            /// The name of the backend service.
            /// </summary>
            [NameInMap("BackendName")]
            [Validation(Required=false)]
            public string BackendName { get; set; }

            /// <summary>
            /// The type of the backend service.
            /// </summary>
            [NameInMap("BackendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }

        }

        /// <summary>
        /// Indicates whether the backend service is enabled.
        /// </summary>
        [NameInMap("BackendEnable")]
        [Validation(Required=false)]
        public bool? BackendEnable { get; set; }

        /// <summary>
        /// The constant parameters.
        /// </summary>
        [NameInMap("ConstantParameters")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyConstantParameters ConstantParameters { get; set; }
        public class DescribeApiHistoryResponseBodyConstantParameters : TeaModel {
            [NameInMap("ConstantParameter")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodyConstantParametersConstantParameter> ConstantParameter { get; set; }
            public class DescribeApiHistoryResponseBodyConstantParametersConstantParameter : TeaModel {
                /// <summary>
                /// The value of the constant parameter.
                /// </summary>
                [NameInMap("ConstantValue")]
                [Validation(Required=false)]
                public string ConstantValue { get; set; }

                /// <summary>
                /// The description of the parameter.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The location of the parameter. Valid values: BODY, HEAD, QUERY, and PATH.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The name of the backend parameter that corresponds to the constant parameter.
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// The custom system parameters.
        /// </summary>
        [NameInMap("CustomSystemParameters")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyCustomSystemParameters CustomSystemParameters { get; set; }
        public class DescribeApiHistoryResponseBodyCustomSystemParameters : TeaModel {
            [NameInMap("CustomSystemParameter")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodyCustomSystemParametersCustomSystemParameter> CustomSystemParameter { get; set; }
            public class DescribeApiHistoryResponseBodyCustomSystemParametersCustomSystemParameter : TeaModel {
                /// <summary>
                /// The sample value of the parameter.
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// The description of the parameter.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The location of the parameter. Valid values: BODY, HEAD, QUERY, and PATH.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// The name of the backend parameter that corresponds to the custom system parameter.
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// The time when the API was published. The time is displayed in UTC.
        /// </summary>
        [NameInMap("DeployedTime")]
        [Validation(Required=false)]
        public string DeployedTime { get; set; }

        /// <summary>
        /// The description of the API.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// *   If the **DisableInternet** parameter is set to **true**, you call the API only over internal networks.
        /// *   If the **DisableInternet** parameter is set to **false**, no limit is imposed on networks. When you create an API, the default value of this parameter is false.
        /// </summary>
        [NameInMap("DisableInternet")]
        [Validation(Required=false)]
        public bool? DisableInternet { get; set; }

        /// <summary>
        /// The sample error codes that are returned from the backend service.
        /// 
        /// For more information, see [ErrorCodeSample](~~44392~~).
        /// </summary>
        [NameInMap("ErrorCodeSamples")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyErrorCodeSamples ErrorCodeSamples { get; set; }
        public class DescribeApiHistoryResponseBodyErrorCodeSamples : TeaModel {
            [NameInMap("ErrorCodeSample")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodyErrorCodeSamplesErrorCodeSample> ErrorCodeSample { get; set; }
            public class DescribeApiHistoryResponseBodyErrorCodeSamplesErrorCodeSample : TeaModel {
                /// <summary>
                /// The error code.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        /// <summary>
        /// The sample error response that is returned from the backend service.
        /// </summary>
        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        /// <summary>
        /// *   Indicates whether to forcefully check X-Ca-Nonce. X-Ca-Nonce is the unique identifier of a request and is generally identified by UUID. If the **ForceNonceCheck** parameter is set to **true**, X-Ca-Nonce is forcefully checked. After API Gateway receives this parameter, API Gateway verifies the validity of this parameter. The same value can be used only once within 15 minutes. This helps prevent replay attacks.
        /// *   If the **ForceNonceCheck** parameter is set to **false**, X-Ca-Nonce is not checked. When you create an API, the default value of this parameter is false.
        /// </summary>
        [NameInMap("ForceNonceCheck")]
        [Validation(Required=false)]
        public bool? ForceNonceCheck { get; set; }

        /// <summary>
        /// The ID of the API group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The name of the API group.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The historical version number of the API.
        /// </summary>
        [NameInMap("HistoryVersion")]
        [Validation(Required=false)]
        public string HistoryVersion { get; set; }

        /// <summary>
        /// The configuration items of third-party OpenID Connect authentication.
        /// </summary>
        [NameInMap("OpenIdConnectConfig")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyOpenIdConnectConfig OpenIdConnectConfig { get; set; }
        public class DescribeApiHistoryResponseBodyOpenIdConnectConfig : TeaModel {
            /// <summary>
            /// The name of the parameter that corresponds to the token.
            /// </summary>
            [NameInMap("IdTokenParamName")]
            [Validation(Required=false)]
            public string IdTokenParamName { get; set; }

            /// <summary>
            /// *   ****
            /// *   ****
            /// </summary>
            [NameInMap("OpenIdApiType")]
            [Validation(Required=false)]
            public string OpenIdApiType { get; set; }

            /// <summary>
            /// The public key of the API.
            /// </summary>
            [NameInMap("PublicKey")]
            [Validation(Required=false)]
            public string PublicKey { get; set; }

            /// <summary>
            /// The ID of the public key.
            /// </summary>
            [NameInMap("PublicKeyId")]
            [Validation(Required=false)]
            public string PublicKeyId { get; set; }

        }

        /// <summary>
        /// The ID of the region where the API is deployed.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The configuration items of API requests that are sent from the consumer to API Gateway.
        /// 
        /// For more information, see [RequestConfig](~~43985~~).
        /// </summary>
        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyRequestConfig RequestConfig { get; set; }
        public class DescribeApiHistoryResponseBodyRequestConfig : TeaModel {
            /// <summary>
            /// The format in which data was transmitted to the server for POST and PUT requests. Valid values: FORM and STREAM. FORM indicates that data was transmitted as forms that consist of key-value pairs. STREAM indicates that data was transmitted as byte streams. This parameter takes effect when the RequestMode parameter is set to MAPPING.
            /// </summary>
            [NameInMap("BodyFormat")]
            [Validation(Required=false)]
            public string BodyFormat { get; set; }

            /// <summary>
            /// The body model.
            /// </summary>
            [NameInMap("BodyModel")]
            [Validation(Required=false)]
            public string BodyModel { get; set; }

            /// <summary>
            /// The description of the request body.
            /// </summary>
            [NameInMap("PostBodyDescription")]
            [Validation(Required=false)]
            public string PostBodyDescription { get; set; }

            /// <summary>
            /// The HTTP request method. Valid values: GET, POST, DELETE, PUT, HEADER, TRACE, PATCH, CONNECT, and OPTIONS.
            /// </summary>
            [NameInMap("RequestHttpMethod")]
            [Validation(Required=false)]
            public string RequestHttpMethod { get; set; }

            /// <summary>
            /// The request mode of the parameters. Valid values:
            /// 
            /// *   MAPPING: Parameters are mapped. Unknown parameters are filtered out.
            /// *   PASSTHROUGH: Parameters are passed through.
            /// *   MAPPING_PASSTHROUGH: Parameters are mapped. Unknown parameters are passed through.
            /// </summary>
            [NameInMap("RequestMode")]
            [Validation(Required=false)]
            public string RequestMode { get; set; }

            /// <summary>
            /// The request path of the API.
            /// </summary>
            [NameInMap("RequestPath")]
            [Validation(Required=false)]
            public string RequestPath { get; set; }

            /// <summary>
            /// The type of the protocol that is supported by the API. Valid values: HTTP, HTTPS, and WebSocket. Separate values with commas (,). Example: "HTTP,HTTPS".
            /// </summary>
            [NameInMap("RequestProtocol")]
            [Validation(Required=false)]
            public string RequestProtocol { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The parameters of API requests that are sent from the consumer to API Gateway.
        /// 
        /// For more information, see [RequestParameter](~~43986~~).
        /// </summary>
        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyRequestParameters RequestParameters { get; set; }
        public class DescribeApiHistoryResponseBodyRequestParameters : TeaModel {
            [NameInMap("RequestParameter")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodyRequestParametersRequestParameter> RequestParameter { get; set; }
            public class DescribeApiHistoryResponseBodyRequestParametersRequestParameter : TeaModel {
                /// <summary>
                /// The name of the parameter in the API request.
                /// </summary>
                [NameInMap("ApiParameterName")]
                [Validation(Required=false)]
                public string ApiParameterName { get; set; }

                /// <summary>
                /// The type of the array element.
                /// </summary>
                [NameInMap("ArrayItemsType")]
                [Validation(Required=false)]
                public string ArrayItemsType { get; set; }

                /// <summary>
                /// The default value.
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// The sample value of the parameter.
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// The description of the parameter.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The order in which the parameter is sorted in the document.
                /// </summary>
                [NameInMap("DocOrder")]
                [Validation(Required=false)]
                public int? DocOrder { get; set; }

                /// <summary>
                /// Indicates whether the document is public. Valid values: **PUBLIC** and **PRIVATE**.
                /// </summary>
                [NameInMap("DocShow")]
                [Validation(Required=false)]
                public string DocShow { get; set; }

                /// <summary>
                /// The hash values that are specified if the **ParameterType** parameter is set to Int, Long, Float, Double, or String. Separate hash values with commas (,). Examples: 1,2,3,4,9 and A,B,C,E,F.
                /// </summary>
                [NameInMap("EnumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

                /// <summary>
                /// The JSON scheme.
                /// </summary>
                [NameInMap("JsonScheme")]
                [Validation(Required=false)]
                public string JsonScheme { get; set; }

                /// <summary>
                /// The location of the parameter. Valid values: BODY, HEAD, QUERY, and PATH.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The maximum length of the parameter value if the **ParameterType** parameter is set to String.
                /// </summary>
                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public long? MaxLength { get; set; }

                /// <summary>
                /// The maximum value of the parameter if the **ParameterType** parameter is set to Int, Long, Float, or Double.
                /// </summary>
                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public long? MaxValue { get; set; }

                /// <summary>
                /// The minimum length of the parameter value if the **ParameterType** parameter is set to String.
                /// </summary>
                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public long? MinLength { get; set; }

                /// <summary>
                /// The minimum value of the parameter if the **ParameterType** parameter is set to Int, Long, Float, or Double.
                /// </summary>
                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public long? MinValue { get; set; }

                /// <summary>
                /// The data type of the parameter. Valid values: String, Int, Long, Float, Double, and Boolean.
                /// </summary>
                [NameInMap("ParameterType")]
                [Validation(Required=false)]
                public string ParameterType { get; set; }

                /// <summary>
                /// The regular expression that is used to validate the parameter if the **ParameterType** parameter is set to String.
                /// </summary>
                [NameInMap("RegularExpression")]
                [Validation(Required=false)]
                public string RegularExpression { get; set; }

                /// <summary>
                /// Indicates whether the parameter is required. Valid values: **REQUIRED** and **OPTIONAL**.
                /// </summary>
                [NameInMap("Required")]
                [Validation(Required=false)]
                public string Required { get; set; }

            }

        }

        /// <summary>
        /// The response of the API.
        /// </summary>
        [NameInMap("ResultBodyModel")]
        [Validation(Required=false)]
        public string ResultBodyModel { get; set; }

        /// <summary>
        /// The descriptions that are returned for the API.
        /// </summary>
        [NameInMap("ResultDescriptions")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyResultDescriptions ResultDescriptions { get; set; }
        public class DescribeApiHistoryResponseBodyResultDescriptions : TeaModel {
            [NameInMap("ResultDescription")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodyResultDescriptionsResultDescription> ResultDescription { get; set; }
            public class DescribeApiHistoryResponseBodyResultDescriptionsResultDescription : TeaModel {
                /// <summary>
                /// The description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Indicates whether a child node exists.
                /// </summary>
                [NameInMap("HasChild")]
                [Validation(Required=false)]
                public bool? HasChild { get; set; }

                /// <summary>
                /// The ID of the result.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The primary key of the result.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// Indicates whether the parameter is required.
                /// </summary>
                [NameInMap("Mandatory")]
                [Validation(Required=false)]
                public bool? Mandatory { get; set; }

                /// <summary>
                /// The name of the result.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the parent node.
                /// </summary>
                [NameInMap("Pid")]
                [Validation(Required=false)]
                public string Pid { get; set; }

                /// <summary>
                /// The type of the result.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The sample response that is returned.
        /// </summary>
        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        /// <summary>
        /// The type of data that is returned.
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// The information about backend service calls.
        /// </summary>
        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyServiceConfig ServiceConfig { get; set; }
        public class DescribeApiHistoryResponseBodyServiceConfig : TeaModel {
            /// <summary>
            /// The ContentType header that is used if the ServiceProtocol parameter is set to HTTP. Valid values:
            /// 
            /// *   DEFAULT: the default header in API Gateway
            /// *   CUSTOM: a custom header
            /// *   CLIENT: the ContentType header of the client
            /// </summary>
            [NameInMap("ContentTypeCatagory")]
            [Validation(Required=false)]
            public string ContentTypeCatagory { get; set; }

            /// <summary>
            /// The value of the ContentType header if the ServiceProtocol parameter is set to HTTP and the ContentTypeCatagory parameter is set to DEFAULT or CUSTOM.
            /// </summary>
            [NameInMap("ContentTypeValue")]
            [Validation(Required=false)]
            public string ContentTypeValue { get; set; }

            /// <summary>
            /// The configuration items of EventBridge.
            /// </summary>
            [NameInMap("EventBridgeConfig")]
            [Validation(Required=false)]
            public DescribeApiHistoryResponseBodyServiceConfigEventBridgeConfig EventBridgeConfig { get; set; }
            public class DescribeApiHistoryResponseBodyServiceConfigEventBridgeConfig : TeaModel {
                /// <summary>
                /// The ID of the region where EventBridge is deployed.
                /// </summary>
                [NameInMap("EventBridgeRegionId")]
                [Validation(Required=false)]
                public string EventBridgeRegionId { get; set; }

                /// <summary>
                /// The event bus.
                /// </summary>
                [NameInMap("EventBus")]
                [Validation(Required=false)]
                public string EventBus { get; set; }

                /// <summary>
                /// The event source.
                /// </summary>
                [NameInMap("EventSource")]
                [Validation(Required=false)]
                public string EventSource { get; set; }

                /// <summary>
                /// The ARN of the RAM role that is assigned to EventBridge.
                /// </summary>
                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

            }

            /// <summary>
            /// The configuration items of the backend service whose type is Function Compute.
            /// </summary>
            [NameInMap("FunctionComputeConfig")]
            [Validation(Required=false)]
            public DescribeApiHistoryResponseBodyServiceConfigFunctionComputeConfig FunctionComputeConfig { get; set; }
            public class DescribeApiHistoryResponseBodyServiceConfigFunctionComputeConfig : TeaModel {
                /// <summary>
                /// The ContentType header that is used if the ServiceProtocol parameter is set to HTTP. Valid values:
                /// 
                /// *   **DEFAULT**: the default header in API Gateway
                /// *   **CUSTOM**: a custom header
                /// *   **CLIENT**: the ContentType header of the client
                /// </summary>
                [NameInMap("ContentTypeCatagory")]
                [Validation(Required=false)]
                public string ContentTypeCatagory { get; set; }

                /// <summary>
                /// The value of the ContentType header if the ServiceProtocol parameter is set to HTTP and the ContentTypeCatagory parameter is set to DEFAULT or CUSTOM.
                /// </summary>
                [NameInMap("ContentTypeValue")]
                [Validation(Required=false)]
                public string ContentTypeValue { get; set; }

                /// <summary>
                /// The root path of the service in Function Compute.
                /// </summary>
                [NameInMap("FcBaseUrl")]
                [Validation(Required=false)]
                public string FcBaseUrl { get; set; }

                /// <summary>
                /// The type of the service in Function Compute.
                /// </summary>
                [NameInMap("FcType")]
                [Validation(Required=false)]
                public string FcType { get; set; }

                /// <summary>
                /// The function name that is defined in Function Compute.
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// The request method.
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// Indicates whether the backend receives only the service path.
                /// </summary>
                [NameInMap("OnlyBusinessPath")]
                [Validation(Required=false)]
                public bool? OnlyBusinessPath { get; set; }

                /// <summary>
                /// The path of the API request.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// The alias of the function.
                /// </summary>
                [NameInMap("Qualifier")]
                [Validation(Required=false)]
                public string Qualifier { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the RAM role that is assumed by API Gateway to access Function Compute.
                /// </summary>
                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                /// <summary>
                /// The service name that is defined in Function Compute.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

            /// <summary>
            /// Indicates whether the mock mode is enabled. Valid values:
            /// 
            /// *   TRUE
            /// *   FALSE
            /// </summary>
            [NameInMap("Mock")]
            [Validation(Required=false)]
            public string Mock { get; set; }

            /// <summary>
            /// The mock headers.
            /// </summary>
            [NameInMap("MockHeaders")]
            [Validation(Required=false)]
            public DescribeApiHistoryResponseBodyServiceConfigMockHeaders MockHeaders { get; set; }
            public class DescribeApiHistoryResponseBodyServiceConfigMockHeaders : TeaModel {
                [NameInMap("MockHeader")]
                [Validation(Required=false)]
                public List<DescribeApiHistoryResponseBodyServiceConfigMockHeadersMockHeader> MockHeader { get; set; }
                public class DescribeApiHistoryResponseBodyServiceConfigMockHeadersMockHeader : TeaModel {
                    /// <summary>
                    /// The name of the HTTP header
                    /// </summary>
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// The value of the HTTP header.
                    /// </summary>
                    [NameInMap("HeaderValue")]
                    [Validation(Required=false)]
                    public string HeaderValue { get; set; }

                }

            }

            /// <summary>
            /// The result that is returned if the Mock parameter is set to TRUE.
            /// </summary>
            [NameInMap("MockResult")]
            [Validation(Required=false)]
            public string MockResult { get; set; }

            /// <summary>
            /// The status code that is returned for service mocking.
            /// </summary>
            [NameInMap("MockStatusCode")]
            [Validation(Required=false)]
            public int? MockStatusCode { get; set; }

            /// <summary>
            /// The configuration items of the backend service whose type is Object Storage Service (OSS).
            /// </summary>
            [NameInMap("OssConfig")]
            [Validation(Required=false)]
            public DescribeApiHistoryResponseBodyServiceConfigOssConfig OssConfig { get; set; }
            public class DescribeApiHistoryResponseBodyServiceConfigOssConfig : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The name of the OSS bucket.
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The ID of the region where OSS is deployed.
                /// </summary>
                [NameInMap("OssRegionId")]
                [Validation(Required=false)]
                public string OssRegionId { get; set; }

            }

            /// <summary>
            /// The URL that is used to call the backend service.
            /// </summary>
            [NameInMap("ServiceAddress")]
            [Validation(Required=false)]
            public string ServiceAddress { get; set; }

            /// <summary>
            /// The HTTP request method that is used if the ServiceProtocol parameter is set to HTTP. Valid values: PUT, GET, POST, DELETE, PATCH, HEAD, OPTIONS, and ANY.
            /// </summary>
            [NameInMap("ServiceHttpMethod")]
            [Validation(Required=false)]
            public string ServiceHttpMethod { get; set; }

            /// <summary>
            /// The path that is used when the backend service is called.
            /// </summary>
            [NameInMap("ServicePath")]
            [Validation(Required=false)]
            public string ServicePath { get; set; }

            /// <summary>
            /// The protocol of the backend service. Only HTTP, HTTPS, and Function Compute are supported.
            /// </summary>
            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }

            /// <summary>
            /// The timeout period of the backend service. Unit: milliseconds.
            /// </summary>
            [NameInMap("ServiceTimeout")]
            [Validation(Required=false)]
            public int? ServiceTimeout { get; set; }

            /// <summary>
            /// Indicates whether the VPC channel is enabled. Valid values:
            /// 
            /// *   TRUE
            /// *   FALSE
            /// 
            /// Before you can enable the VPC channel, make sure that a VPC authorization is added.
            /// </summary>
            [NameInMap("ServiceVpcEnable")]
            [Validation(Required=false)]
            public string ServiceVpcEnable { get; set; }

            /// <summary>
            /// The configuration items of the VPC channel.
            /// </summary>
            [NameInMap("VpcConfig")]
            [Validation(Required=false)]
            public DescribeApiHistoryResponseBodyServiceConfigVpcConfig VpcConfig { get; set; }
            public class DescribeApiHistoryResponseBodyServiceConfigVpcConfig : TeaModel {
                /// <summary>
                /// The ID of the Elastic Compute Service (ECS) or Server Load Balancer (SLB) instance in the VPC.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the VPC.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The port number that corresponds to the instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The protocol of the VPC.
                /// </summary>
                [NameInMap("VpcScheme")]
                [Validation(Required=false)]
                public string VpcScheme { get; set; }

            }

            /// <summary>
            /// The ID of the virtual private cloud (VPC).
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The parameters of API requests that are sent from API Gateway to the backend service.
        /// 
        /// For more information, see [ServiceParameter](~~43988~~).
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyServiceParameters ServiceParameters { get; set; }
        public class DescribeApiHistoryResponseBodyServiceParameters : TeaModel {
            [NameInMap("ServiceParameter")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodyServiceParametersServiceParameter> ServiceParameter { get; set; }
            public class DescribeApiHistoryResponseBodyServiceParametersServiceParameter : TeaModel {
                /// <summary>
                /// The location of the parameter. Valid values: BODY, HEAD, QUERY, and PATH.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The data type of the parameter. Valid values: STRING, NUMBER, and BOOLEAN.
                /// </summary>
                [NameInMap("ParameterType")]
                [Validation(Required=false)]
                public string ParameterType { get; set; }

                /// <summary>
                /// The name of the backend parameter.
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// The mappings between the parameters of requests sent from the consumer to API Gateway and the parameters of requests sent from API Gateway to the backend service.
        /// 
        /// For more information, see [ServiceParameterMap](~~43989~~).
        /// </summary>
        [NameInMap("ServiceParametersMap")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyServiceParametersMap ServiceParametersMap { get; set; }
        public class DescribeApiHistoryResponseBodyServiceParametersMap : TeaModel {
            [NameInMap("ServiceParameterMap")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodyServiceParametersMapServiceParameterMap> ServiceParameterMap { get; set; }
            public class DescribeApiHistoryResponseBodyServiceParametersMapServiceParameterMap : TeaModel {
                /// <summary>
                /// The name of the frontend parameter. The name must be included in RequestParametersObject and matches ApiParameterName in RequestParameters.
                /// </summary>
                [NameInMap("RequestParameterName")]
                [Validation(Required=false)]
                public string RequestParameterName { get; set; }

                /// <summary>
                /// The name of the backend parameter.
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// The environment to which the API is published. Valid values:
        /// 
        /// *   **RELEASE**: production environment
        /// *   **PRE**: pre-release environment
        /// *   **TEST**: test environment
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The system parameters of the API in the JSON format.
        /// </summary>
        [NameInMap("SystemParameters")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodySystemParameters SystemParameters { get; set; }
        public class DescribeApiHistoryResponseBodySystemParameters : TeaModel {
            [NameInMap("SystemParameter")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodySystemParametersSystemParameter> SystemParameter { get; set; }
            public class DescribeApiHistoryResponseBodySystemParametersSystemParameter : TeaModel {
                /// <summary>
                /// The sample value of the parameter.
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// The description of the parameter.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The location of the parameter. Valid values: BODY, HEAD, QUERY, and PATH.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The name of the parameter. Valid values: CaClientIp, CaDomain, CaRequestHandleTime, CaAppId, CaRequestId, CaHttpSchema, and CaProxy.
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// The name of the backend parameter that corresponds to the system parameter.
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the API is public. Valid values:
        /// 
        /// *   **PUBLIC**: The API is public. If you publish the definition of a public API to the production environment, the definition is displayed on the APIs page for all users.
        /// *   **PRIVATE**: The API is private. If you publish an API group that contains a private API in Alibaba Cloud Marketplace, the API is not displayed in Alibaba Cloud Marketplace.
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// The type of the API that is used in bidirectional communication. Valid values:
        /// 
        /// *   **COMMON**: common API
        /// *   **REGISTER**: registered API
        /// *   **UNREGISTER**: unregistered API
        /// *   **NOTIFY**: downstream notification API
        /// </summary>
        [NameInMap("WebSocketApiType")]
        [Validation(Required=false)]
        public string WebSocketApiType { get; set; }

    }

}
