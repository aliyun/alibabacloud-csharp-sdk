// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiResponseBody : TeaModel {
        /// <summary>
        /// If **AuthType** is set to **APP**, this value must be passed to specify the signature algorithm. If you do not specify a value, HmacSHA256 is used by default. Valid values:
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
        /// The name of the API, which is unique in the group.
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// If **AuthType** is set to **APP**, the valid values are:
        /// 
        /// *   **DEFAULT**: The default value that is used if no other values are passed. This value means that the setting of the group is used.
        /// *   **DISABLE**: The authentication is disabled.
        /// *   **HEADER**: AppCode can be placed in the Header parameter for authentication.
        /// *   **HEADER_QUERY**: AppCode can be placed in the Header or Query parameter for authentication.
        /// </summary>
        [NameInMap("AppCodeAuthType")]
        [Validation(Required=false)]
        public string AppCodeAuthType { get; set; }

        /// <summary>
        /// The security authentication method of the API. Valid values:
        /// 
        /// *   **APP**: Only authorized applications can call the API.
        /// 
        /// *   **ANONYMOUS**: The API can be anonymously called. In this mode, you must take note of the following rules:
        /// 
        ///     *   All users who have obtained the API service information can call this API. API Gateway does not authenticate callers and cannot set user-specific throttling policies. If you make this API public, set API-specific throttling policies.
        ///     *   We recommend that you do not make the API whose security authentication method is ANONYMOUS available in Alibaba Cloud Marketplace because API Gateway cannot meter calls on the caller or limit the number of calls on the API. If you want to make the API group to which the API belongs available in Alibaba Cloud Marketplace, we recommend that you move the API to another group, set its type to PRIVATE, or set its security authentication method to APP.
        /// 
        /// *   **APPOPENID**: The OpenID Connect account authentication method is used. Only applications authorized by OpenID Connect can call the API. If this method is selected, the OpenIdConnectConfig parameter is required.
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// Backend configurations
        /// </summary>
        [NameInMap("BackendConfig")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyBackendConfig BackendConfig { get; set; }
        public class DescribeApiResponseBodyBackendConfig : TeaModel {
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
            /// Backend service type
            /// </summary>
            [NameInMap("BackendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable backend services.
        /// </summary>
        [NameInMap("BackendEnable")]
        [Validation(Required=false)]
        public bool? BackendEnable { get; set; }

        /// <summary>
        /// System parameters sent by API Gateway to the backend service
        /// </summary>
        [NameInMap("ConstantParameters")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyConstantParameters ConstantParameters { get; set; }
        public class DescribeApiResponseBodyConstantParameters : TeaModel {
            [NameInMap("ConstantParameter")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyConstantParametersConstantParameter> ConstantParameter { get; set; }
            public class DescribeApiResponseBodyConstantParametersConstantParameter : TeaModel {
                /// <summary>
                /// The constant parameter value.
                /// </summary>
                [NameInMap("ConstantValue")]
                [Validation(Required=false)]
                public string ConstantValue { get; set; }

                /// <summary>
                /// The parameter description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The parameter location. Valid values: BODY, HEAD, QUERY, and PATH.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The mapped parameter name in the backend service.
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// The creation time of the API.
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Custom system parameters
        /// </summary>
        [NameInMap("CustomSystemParameters")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyCustomSystemParameters CustomSystemParameters { get; set; }
        public class DescribeApiResponseBodyCustomSystemParameters : TeaModel {
            [NameInMap("CustomSystemParameter")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyCustomSystemParametersCustomSystemParameter> CustomSystemParameter { get; set; }
            public class DescribeApiResponseBodyCustomSystemParametersCustomSystemParameter : TeaModel {
                /// <summary>
                /// The example value.
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// The parameter description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The parameter location. Valid values: BODY, HEAD, QUERY, and PATH.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The name of the system parameter. Valid values: CaClientIp, CaDomain, CaRequestHandleTime, CaAppId, CaRequestId, CaHttpSchema, and CaProxy.
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// The mapped parameter name in the backend service.
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// The API publishing status.
        /// </summary>
        [NameInMap("DeployedInfos")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyDeployedInfos DeployedInfos { get; set; }
        public class DescribeApiResponseBodyDeployedInfos : TeaModel {
            [NameInMap("DeployedInfo")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyDeployedInfosDeployedInfo> DeployedInfo { get; set; }
            public class DescribeApiResponseBodyDeployedInfosDeployedInfo : TeaModel {
                /// <summary>
                /// The deployment status. Valid values: DEPLOYED and NONDEPLOYED.
                /// </summary>
                [NameInMap("DeployedStatus")]
                [Validation(Required=false)]
                public string DeployedStatus { get; set; }

                /// <summary>
                /// The effective version.
                /// </summary>
                [NameInMap("EffectiveVersion")]
                [Validation(Required=false)]
                public string EffectiveVersion { get; set; }

                /// <summary>
                /// The environment to which the API is published. Valid values: RELEASE and TEST.
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

            }

        }

        /// <summary>
        /// The description of the API.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to limit API calls to within the VPC. Valid values:
        /// 
        /// *   **true**: Only API calls from the VPC are supported.
        /// *   **false**: API calls from the VPC and Internet are both supported.
        /// </summary>
        [NameInMap("DisableInternet")]
        [Validation(Required=false)]
        public bool? DisableInternet { get; set; }

        /// <summary>
        /// The sample error codes returned by the backend service.
        /// </summary>
        [NameInMap("ErrorCodeSamples")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyErrorCodeSamples ErrorCodeSamples { get; set; }
        public class DescribeApiResponseBodyErrorCodeSamples : TeaModel {
            [NameInMap("ErrorCodeSample")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyErrorCodeSamplesErrorCodeSample> ErrorCodeSample { get; set; }
            public class DescribeApiResponseBodyErrorCodeSamplesErrorCodeSample : TeaModel {
                /// <summary>
                /// The returned error code.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The error description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The returned error message.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The model.
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

            }

        }

        /// <summary>
        /// The sample error response from the backend service.
        /// </summary>
        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        /// <summary>
        /// Specifies whether to carry the header : X-Ca-Nonce when calling an API. This is the unique identifier of the request and is generally identified by UUID. After receiving this parameter, API Gateway verifies the validity of this parameter. The same value can be used only once within 15 minutes. This helps prevent reply attacks. Valid values:
        /// 
        /// *   **true**: This field is forcibly checked when an API is requested to prevent replay attacks.
        /// *   **false**: This field is not checked.
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
        /// Specifies whether to enable the Mock mode. Valid values:
        /// 
        /// *   OPEN: The Mock mode is enabled.
        /// *   CLOSED: The Mock mode is not enabled.
        /// </summary>
        [NameInMap("Mock")]
        [Validation(Required=false)]
        public string Mock { get; set; }

        /// <summary>
        /// The result returned for service mocking.
        /// </summary>
        [NameInMap("MockResult")]
        [Validation(Required=false)]
        public string MockResult { get; set; }

        /// <summary>
        /// The last modification time of the API.
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// Configuration items of the third-party OpenID Connect authentication method
        /// </summary>
        [NameInMap("OpenIdConnectConfig")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyOpenIdConnectConfig OpenIdConnectConfig { get; set; }
        public class DescribeApiResponseBodyOpenIdConnectConfig : TeaModel {
            /// <summary>
            /// The name of the parameter that corresponds to the token.
            /// </summary>
            [NameInMap("IdTokenParamName")]
            [Validation(Required=false)]
            public string IdTokenParamName { get; set; }

            /// <summary>
            /// The OpenID Connect mode. Valid values:
            /// 
            /// *   **IDTOKEN**: indicates the APIs that are called by clients to obtain tokens. If you specify this value, the PublicKeyId parameter and the PublicKey parameter are required.
            /// *   **BUSINESS**: indicates business APIs. Tokens are used to call the business APIs. If you specify this value, the IdTokenParamName parameter is required.
            /// </summary>
            [NameInMap("OpenIdApiType")]
            [Validation(Required=false)]
            public string OpenIdApiType { get; set; }

            /// <summary>
            /// The public key.
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
        /// The region ID of the API.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The configuration items of API requests sent by the consumer to API Gateway.
        /// </summary>
        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyRequestConfig RequestConfig { get; set; }
        public class DescribeApiResponseBodyRequestConfig : TeaModel {
            /// <summary>
            /// This parameter takes effect only when the RequestMode parameter is set to MAPPING.********
            /// 
            /// The server data transmission method used for POST and PUT requests. Valid values: FORM and STREAM. FORM indicates that data in key-value pairs is transmitted as forms. STREAM indicates that data is transmitted as byte streams.
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

            [NameInMap("EscapePathParam")]
            [Validation(Required=false)]
            public bool? EscapePathParam { get; set; }

            /// <summary>
            /// The description of the request body.
            /// </summary>
            [NameInMap("PostBodyDescription")]
            [Validation(Required=false)]
            public string PostBodyDescription { get; set; }

            /// <summary>
            /// The HTTP method used to make the request. Valid values: GET, POST, DELETE, PUT, HEADER, TRACE, PATCH, CONNECT, and OPTIONS.
            /// </summary>
            [NameInMap("RequestHttpMethod")]
            [Validation(Required=false)]
            public string RequestHttpMethod { get; set; }

            /// <summary>
            /// The request mode. Valid values: MAPPING and PASSTHROUGH.
            /// </summary>
            [NameInMap("RequestMode")]
            [Validation(Required=false)]
            public string RequestMode { get; set; }

            /// <summary>
            /// The API request path. If the complete API URL is `http://api.a.com:8080/object/add?key1=value1&key2=value2`, the API request path is ` /object/add  `.
            /// </summary>
            [NameInMap("RequestPath")]
            [Validation(Required=false)]
            public string RequestPath { get; set; }

            /// <summary>
            /// The protocol type supported by the API. Valid values: HTTP and HTTPS. Separate multiple values with commas (,), such as "HTTP,HTTPS".
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
        /// The parameters of API requests sent by the consumer to API Gateway.
        /// </summary>
        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyRequestParameters RequestParameters { get; set; }
        public class DescribeApiResponseBodyRequestParameters : TeaModel {
            [NameInMap("RequestParameter")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyRequestParametersRequestParameter> RequestParameter { get; set; }
            public class DescribeApiResponseBodyRequestParametersRequestParameter : TeaModel {
                /// <summary>
                /// The parameter name.
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
                /// The example value.
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// The parameter description.
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
                /// The hash values that are supported when **ParameterType** is set to Int, Long, Float, Double, or String. Separate values with commas (,). Examples: 1,2,3,4,9 and A,B,C,E,F.
                /// </summary>
                [NameInMap("EnumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

                /// <summary>
                /// The JSON Schema used for JSON validation when **ParameterType** is set to String.
                /// </summary>
                [NameInMap("JsonScheme")]
                [Validation(Required=false)]
                public string JsonScheme { get; set; }

                /// <summary>
                /// The parameter location. Valid values: BODY, HEAD, QUERY, and PATH.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The maximum parameter length when **ParameterType** is set to String.
                /// </summary>
                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public long? MaxLength { get; set; }

                /// <summary>
                /// The maximum parameter value when **ParameterType** is set to Int, Long, Float, or Double.
                /// </summary>
                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public long? MaxValue { get; set; }

                /// <summary>
                /// The minimum parameter length when **ParameterType** is set to String.
                /// </summary>
                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public long? MinLength { get; set; }

                /// <summary>
                /// The minimum parameter value when **ParameterType** is set to Int, Long, Float, or Double.
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
                /// The regular expression that is used for parameter validation when **ParameterType** is set to String.
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
        /// The returned description of the API.
        /// </summary>
        [NameInMap("ResultBodyModel")]
        [Validation(Required=false)]
        public string ResultBodyModel { get; set; }

        /// <summary>
        /// The sample response from the backend service.
        /// </summary>
        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        /// <summary>
        /// The format of the response from the backend service. Valid values: JSON, TEXT, BINARY, XML, and HTML.
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// The configuration items of API requests that API Gateway sends to the backend service.
        /// </summary>
        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyServiceConfig ServiceConfig { get; set; }
        public class DescribeApiResponseBodyServiceConfig : TeaModel {
            /// <summary>
            /// The application name in AONE.
            /// </summary>
            [NameInMap("AoneAppName")]
            [Validation(Required=false)]
            public string AoneAppName { get; set; }

            /// <summary>
            /// The ContentType header type used when you call the backend service over HTTP.
            /// 
            /// *   **DEFAULT**: the default header type in API Gateway
            /// *   **CUSTOM**: a custom header type
            /// *   **CLIENT**: the ContentType header type of the client
            /// </summary>
            [NameInMap("ContentTypeCatagory")]
            [Validation(Required=false)]
            public string ContentTypeCatagory { get; set; }

            /// <summary>
            /// The value of the ContentType header when the ServiceProtocol parameter is set to HTTP and the ContentTypeCatagory parameter is set to DEFAULT or CUSTOM.
            /// </summary>
            [NameInMap("ContentTypeValue")]
            [Validation(Required=false)]
            public string ContentTypeValue { get; set; }

            /// <summary>
            /// Configuration items of EventBridge
            /// </summary>
            [NameInMap("EventBridgeConfig")]
            [Validation(Required=false)]
            public DescribeApiResponseBodyServiceConfigEventBridgeConfig EventBridgeConfig { get; set; }
            public class DescribeApiResponseBodyServiceConfigEventBridgeConfig : TeaModel {
                /// <summary>
                /// The ID of the region where the EventBridge instance is located.
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
                /// The Arn that is authorized by a RAM user to EventBridge.
                /// </summary>
                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

            }

            /// <summary>
            /// Backend configuration items when the backend service is Function Compute
            /// </summary>
            [NameInMap("FunctionComputeConfig")]
            [Validation(Required=false)]
            public DescribeApiResponseBodyServiceConfigFunctionComputeConfig FunctionComputeConfig { get; set; }
            public class DescribeApiResponseBodyServiceConfigFunctionComputeConfig : TeaModel {
                /// <summary>
                /// The ContentType header type used when you call the backend service over HTTP.
                /// 
                /// *   **DEFAULT**: the default header type in API Gateway
                /// *   **CUSTOM**: a custom header type
                /// *   **CLIENT**: the ContentType header type of the client
                /// </summary>
                [NameInMap("ContentTypeCatagory")]
                [Validation(Required=false)]
                public string ContentTypeCatagory { get; set; }

                /// <summary>
                /// The value of the ContentType header when the ContentTypeCatagory parameter is set to DEFAULT or CUSTOM.
                /// </summary>
                [NameInMap("ContentTypeValue")]
                [Validation(Required=false)]
                public string ContentTypeValue { get; set; }

                /// <summary>
                /// The root path of Function Compute.
                /// </summary>
                [NameInMap("FcBaseUrl")]
                [Validation(Required=false)]
                public string FcBaseUrl { get; set; }

                /// <summary>
                /// The type of the Function Compute instance.
                /// </summary>
                [NameInMap("FcType")]
                [Validation(Required=false)]
                public string FcType { get; set; }

                /// <summary>
                /// The function name defined in Function Compute.
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
                /// The backend only receives the service path.
                /// </summary>
                [NameInMap("OnlyBusinessPath")]
                [Validation(Required=false)]
                public bool? OnlyBusinessPath { get; set; }

                /// <summary>
                /// The API request path.
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
                /// The region where the Function Compute instance is located.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the RAM role to be assumed by API Gateway to access Function Compute.
                /// </summary>
                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                /// <summary>
                /// The service name defined in Function Compute.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

            /// <summary>
            /// Specifies whether to enable the Mock mode. Valid values:
            /// 
            /// *   **TRUE**: The Mock mode is enabled.
            /// *   **FALSE**: The Mock mode is not enabled.
            /// </summary>
            [NameInMap("Mock")]
            [Validation(Required=false)]
            public string Mock { get; set; }

            /// <summary>
            /// The simulated headers.
            /// </summary>
            [NameInMap("MockHeaders")]
            [Validation(Required=false)]
            public DescribeApiResponseBodyServiceConfigMockHeaders MockHeaders { get; set; }
            public class DescribeApiResponseBodyServiceConfigMockHeaders : TeaModel {
                [NameInMap("MockHeader")]
                [Validation(Required=false)]
                public List<DescribeApiResponseBodyServiceConfigMockHeadersMockHeader> MockHeader { get; set; }
                public class DescribeApiResponseBodyServiceConfigMockHeadersMockHeader : TeaModel {
                    /// <summary>
                    /// The HTTP header.
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
            /// The result returned when the Mock mode is enabled.
            /// </summary>
            [NameInMap("MockResult")]
            [Validation(Required=false)]
            public string MockResult { get; set; }

            /// <summary>
            /// The status code returned for service mocking.
            /// </summary>
            [NameInMap("MockStatusCode")]
            [Validation(Required=false)]
            public int? MockStatusCode { get; set; }

            /// <summary>
            /// The information returned when the backend service is Object Storage Service (OSS).
            /// </summary>
            [NameInMap("OssConfig")]
            [Validation(Required=false)]
            public DescribeApiResponseBodyServiceConfigOssConfig OssConfig { get; set; }
            public class DescribeApiResponseBodyServiceConfigOssConfig : TeaModel {
                /// <summary>
                /// The operation options on OSS. Valid values:
                /// 
                /// *   GetObject
                /// *   PostObject
                /// *   DeleteObject
                /// *   PutObject
                /// *   HeadObject
                /// *   GetObjectMeta
                /// *   AppendObject
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The OSS bucket.
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// The stored object or folder path.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The ID of the region where the OSS instance is located.
                /// </summary>
                [NameInMap("OssRegionId")]
                [Validation(Required=false)]
                public string OssRegionId { get; set; }

            }

            /// <summary>
            /// The URL used to call the back-end service. If the complete back-end service URL is `http://api.a.com:8080/object/add?key1=value1&key2=value2`, the value of ServiceAddress is **http://api.a.com:8080**.``
            /// </summary>
            [NameInMap("ServiceAddress")]
            [Validation(Required=false)]
            public string ServiceAddress { get; set; }

            /// <summary>
            /// The HTTP method used to call a backend service. Valid values: GET, POST, DELETE, PUT, HEADER, TRACE, PATCH, CONNECT, and OPTIONS.
            /// </summary>
            [NameInMap("ServiceHttpMethod")]
            [Validation(Required=false)]
            public string ServiceHttpMethod { get; set; }

            [NameInMap("ServicePath")]
            [Validation(Required=false)]
            public string ServicePath { get; set; }

            /// <summary>
            /// The protocol used by the backend service. Valid values: HTTP and HTTPS.
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
            /// Specifies whether to enable the VPC channel. Valid values:
            /// 
            /// *   **TRUE**: The VPC channel is enabled. You must create the corresponding VPC access authorization before you can enable a VPC channel.
            /// *   **FALSE**: The VPC channel is not enabled.
            /// </summary>
            [NameInMap("ServiceVpcEnable")]
            [Validation(Required=false)]
            public string ServiceVpcEnable { get; set; }

            /// <summary>
            /// Configuration items related to VPC channels
            /// </summary>
            [NameInMap("VpcConfig")]
            [Validation(Required=false)]
            public DescribeApiResponseBodyServiceConfigVpcConfig VpcConfig { get; set; }
            public class DescribeApiResponseBodyServiceConfigVpcConfig : TeaModel {
                /// <summary>
                /// The ID of the ECS or SLB instance in the VPC.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the VPC access authorization.
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
                /// The VPC protocol.
                /// </summary>
                [NameInMap("VpcScheme")]
                [Validation(Required=false)]
                public string VpcScheme { get; set; }

            }

        }

        /// <summary>
        /// The parameters of API requests sent by API Gateway to the backend service.
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyServiceParameters ServiceParameters { get; set; }
        public class DescribeApiResponseBodyServiceParameters : TeaModel {
            [NameInMap("ServiceParameter")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyServiceParametersServiceParameter> ServiceParameter { get; set; }
            public class DescribeApiResponseBodyServiceParametersServiceParameter : TeaModel {
                /// <summary>
                /// The parameter location. Valid values: BODY, HEAD, QUERY, and PATH.
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
                /// The mapped parameter name in the backend service.
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// The mappings between parameters of requests sent by the consumer to API Gateway and parameters of requests sent by API Gateway to the backend service.
        /// </summary>
        [NameInMap("ServiceParametersMap")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyServiceParametersMap ServiceParametersMap { get; set; }
        public class DescribeApiResponseBodyServiceParametersMap : TeaModel {
            [NameInMap("ServiceParameterMap")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyServiceParametersMapServiceParameterMap> ServiceParameterMap { get; set; }
            public class DescribeApiResponseBodyServiceParametersMapServiceParameterMap : TeaModel {
                /// <summary>
                /// The corresponding frontend parameter name. The value must be contained in RequestParametersObject and match RequestParam.ApiParameterName.
                /// </summary>
                [NameInMap("RequestParameterName")]
                [Validation(Required=false)]
                public string RequestParameterName { get; set; }

                /// <summary>
                /// The mapped parameter name in the backend service.
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// System parameters sent by API Gateway to the backend service
        /// </summary>
        [NameInMap("SystemParameters")]
        [Validation(Required=false)]
        public DescribeApiResponseBodySystemParameters SystemParameters { get; set; }
        public class DescribeApiResponseBodySystemParameters : TeaModel {
            [NameInMap("SystemParameter")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodySystemParametersSystemParameter> SystemParameter { get; set; }
            public class DescribeApiResponseBodySystemParametersSystemParameter : TeaModel {
                /// <summary>
                /// The example value.
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// The parameter description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The parameter location. Valid values: BODY, HEAD, QUERY, and PATH.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The system parameter. Valid values: CaClientIp, CaDomain, CaRequestHandleTime, CaAppId, CaRequestId, CaHttpSchema, and CaProxy.
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// The mapped parameter name in the backend service.
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// Tag List.
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyTagList TagList { get; set; }
        public class DescribeApiResponseBodyTagList : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyTagListTag> Tag { get; set; }
            public class DescribeApiResponseBodyTagListTag : TeaModel {
                /// <summary>
                /// Label key.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// Label value.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// Specifies whether to make the API public. Valid values:
        /// 
        /// *   **PUBLIC**: Make the API public. If you set this parameter to PUBLIC, this API is displayed on the APIs page for all users after the API is published to the production environment.
        /// *   **PRIVATE**: Make the API private. Private APIs are not displayed in the Alibaba Cloud Marketplace after the API group to which they belong is made available.
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// The type of the two-way communication API.
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
