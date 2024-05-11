// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDeployedApiResponseBody : TeaModel {
        /// <summary>
        /// The signature method used by the client. Valid values:
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
        /// The name of the API
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// The security authentication method of the API. Valid values:
        /// 
        /// *   **APP: Only authorized applications can call the API.**
        /// 
        /// *   **ANONYMOUS: The API can be anonymously called. In this mode, you must take note of the following rules:**
        /// 
        ///     *   All users who have obtained the API service information can call this API. API Gateway does not authenticate callers and cannot set user-specific throttling policies. If you make this API public, set API-specific throttling policies.
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// The constant parameters.
        /// </summary>
        [NameInMap("ConstantParameters")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyConstantParameters ConstantParameters { get; set; }
        public class DescribeDeployedApiResponseBodyConstantParameters : TeaModel {
            [NameInMap("ConstantParameter")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyConstantParametersConstantParameter> ConstantParameter { get; set; }
            public class DescribeDeployedApiResponseBodyConstantParametersConstantParameter : TeaModel {
                /// <summary>
                /// The constant value.
                /// </summary>
                [NameInMap("ConstantValue")]
                [Validation(Required=false)]
                public string ConstantValue { get; set; }

                /// <summary>
                /// The description.
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
                /// The name of the backend service parameter.
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
        public DescribeDeployedApiResponseBodyCustomSystemParameters CustomSystemParameters { get; set; }
        public class DescribeDeployedApiResponseBodyCustomSystemParameters : TeaModel {
            [NameInMap("CustomSystemParameter")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyCustomSystemParametersCustomSystemParameter> CustomSystemParameter { get; set; }
            public class DescribeDeployedApiResponseBodyCustomSystemParametersCustomSystemParameter : TeaModel {
                /// <summary>
                /// Example
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// The description.
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
                /// The name of the custom system parameter.
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// The name of the corresponding backend parameter.
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// The deployment time. Format: yyyy-mm-ddhh:mm:ss.
        /// </summary>
        [NameInMap("DeployedTime")]
        [Validation(Required=false)]
        public string DeployedTime { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// *   Specifies whether to set DisableInternet to **true** to limit API calls to within the VPC.
        /// *   If you set DisableInternet to **false**, the limit is lifted.
        /// 
        /// >  If you do not set this parameter, the original value is not modified.
        /// </summary>
        [NameInMap("DisableInternet")]
        [Validation(Required=false)]
        public bool? DisableInternet { get; set; }

        /// <summary>
        /// The sample error codes returned by the backend service.
        /// 
        /// For more information, see [ErrorCodeSample](https://help.aliyun.com/document_detail/44392.html).
        /// </summary>
        [NameInMap("ErrorCodeSamples")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyErrorCodeSamples ErrorCodeSamples { get; set; }
        public class DescribeDeployedApiResponseBodyErrorCodeSamples : TeaModel {
            [NameInMap("ErrorCodeSample")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyErrorCodeSamplesErrorCodeSample> ErrorCodeSample { get; set; }
            public class DescribeDeployedApiResponseBodyErrorCodeSamplesErrorCodeSample : TeaModel {
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
        /// The sample error response from the backend service.
        /// </summary>
        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        /// <summary>
        /// *   Specifies whether to set **ForceNonceCheck** to **true** to force the check of X-Ca-Nonce during the request. This is the unique identifier of the request and is generally identified by UUID. After receiving this parameter, API Gateway verifies the validity of this parameter. The same value can be used only once within 15 minutes. This helps prevent replay attacks.
        /// *   If you set **ForceNonceCheck** to **false**, the check is not performed. The default value is false when you create an API.
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
        /// The configuration items of the third-party OpenID Connect authentication method.
        /// </summary>
        [NameInMap("OpenIdConnectConfig")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyOpenIdConnectConfig OpenIdConnectConfig { get; set; }
        public class DescribeDeployedApiResponseBodyOpenIdConnectConfig : TeaModel {
            /// <summary>
            /// The name of the parameter that corresponds to the token.
            /// </summary>
            [NameInMap("IdTokenParamName")]
            [Validation(Required=false)]
            public string IdTokenParamName { get; set; }

            /// <summary>
            /// The configuration of OpenID Connect authentication. Valid values:
            /// 
            /// *   **IDTOKEN: indicates the APIs that are called by clients to obtain tokens. If you specify this value, the PublicKeyId parameter and the PublicKey parameter are required.**
            /// *   **BUSINESS: indicates business APIs. Tokens are used to call the business APIs. If you specify this value, the IdTokenParamName parameter is required.
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
        /// The region to which the API group belongs.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Configuration items of API requests sent by the consumer to API Gateway.
        /// 
        /// For more information, see [RequestConfig](https://help.aliyun.com/document_detail/43985.html).
        /// </summary>
        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyRequestConfig RequestConfig { get; set; }
        public class DescribeDeployedApiResponseBodyRequestConfig : TeaModel {
            /// <summary>
            /// This parameter takes effect only when the RequestMode parameter is set to MAPPING.
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
            /// The request mode. Valid values:
            /// 
            /// *   MAPPING: Parameters are mapped. Unknown parameters are filtered out.
            /// *   PASSTHROUGH: Parameters are passed through.
            /// *   MAPPING_PASSTHROUGH: Parameters are mapped. Unknown parameters are passed through.
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
            /// The protocol type supported by the API. Valid values: HTTP, HTTPS, and WebSocket. Separate multiple values with commas (,), such as "HTTP,HTTPS".
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
        /// 
        /// For more information, see [RequestParameter](https://help.aliyun.com/document_detail/43986.html).
        /// </summary>
        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyRequestParameters RequestParameters { get; set; }
        public class DescribeDeployedApiResponseBodyRequestParameters : TeaModel {
            [NameInMap("RequestParameter")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyRequestParametersRequestParameter> RequestParameter { get; set; }
            public class DescribeDeployedApiResponseBodyRequestParametersRequestParameter : TeaModel {
                /// <summary>
                /// The name of the API parameter.
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
                /// Example
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// Description
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The order in the document.
                /// </summary>
                [NameInMap("DocOrder")]
                [Validation(Required=false)]
                public int? DocOrder { get; set; }

                /// <summary>
                /// Specifies whether the document is public. Valid values: PUBLIC and PRIVATE.
                /// </summary>
                [NameInMap("DocShow")]
                [Validation(Required=false)]
                public string DocShow { get; set; }

                /// <summary>
                /// The hash values that can be entered when ParameterType is set to Int, Long, Float, Double, or String. Separate different values with commas (,), such as 1,2,3,4,9 or A,B,C,E,F.
                /// </summary>
                [NameInMap("EnumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

                /// <summary>
                /// JSON scheme
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
                /// The maximum parameter length when ParameterType is set to String.
                /// </summary>
                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public long? MaxLength { get; set; }

                /// <summary>
                /// The maximum parameter value when ParameterType is set to Int, Long, Float, or Double.
                /// </summary>
                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public long? MaxValue { get; set; }

                /// <summary>
                /// The minimum parameter length when ParameterType is set to String.
                /// </summary>
                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public long? MinLength { get; set; }

                /// <summary>
                /// The minimum parameter value when ParameterType is set to Int, Long, Float, or Double.
                /// </summary>
                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public long? MinValue { get; set; }

                /// <summary>
                /// The type of a request parameter. Valid values: String, Int, Long, Float, Double, and Boolean.
                /// </summary>
                [NameInMap("ParameterType")]
                [Validation(Required=false)]
                public string ParameterType { get; set; }

                /// <summary>
                /// The regular expression used for parameter validation when ParameterType is set to String.
                /// </summary>
                [NameInMap("RegularExpression")]
                [Validation(Required=false)]
                public string RegularExpression { get; set; }

                /// <summary>
                /// Indicates whether the parameter is required. Valid values: REQUIRED and OPTIONAL.
                /// </summary>
                [NameInMap("Required")]
                [Validation(Required=false)]
                public string Required { get; set; }

            }

        }

        /// <summary>
        /// The return description of the API.
        /// </summary>
        [NameInMap("ResultBodyModel")]
        [Validation(Required=false)]
        public string ResultBodyModel { get; set; }

        /// <summary>
        /// The return description of the API.
        /// </summary>
        [NameInMap("ResultDescriptions")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyResultDescriptions ResultDescriptions { get; set; }
        public class DescribeDeployedApiResponseBodyResultDescriptions : TeaModel {
            [NameInMap("ResultDescription")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyResultDescriptionsResultDescription> ResultDescription { get; set; }
            public class DescribeDeployedApiResponseBodyResultDescriptionsResultDescription : TeaModel {
                /// <summary>
                /// The description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Specifies whether a subnode exists.
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
                /// Specifies whether the parameter is required.
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
        /// The sample response from the backend service.
        /// </summary>
        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        /// <summary>
        /// The format of the response from the backend service. Valid values: JSON, TEXT, BINARY, XML, and HTML. Default value: JSON.
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// The configuration items of API requests sent by API Gateway to the backend service.
        /// 
        /// For more information, see [ServiceConfig](https://help.aliyun.com/document_detail/43987.html).
        /// </summary>
        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyServiceConfig ServiceConfig { get; set; }
        public class DescribeDeployedApiResponseBodyServiceConfig : TeaModel {
            /// <summary>
            /// Backend configuration items when the backend service is Function Compute
            /// </summary>
            [NameInMap("FunctionComputeConfig")]
            [Validation(Required=false)]
            public DescribeDeployedApiResponseBodyServiceConfigFunctionComputeConfig FunctionComputeConfig { get; set; }
            public class DescribeDeployedApiResponseBodyServiceConfigFunctionComputeConfig : TeaModel {
                /// <summary>
                /// The ContentType header type used when you call the backend service over HTTP.
                /// 
                /// *   **DEFAULT: the default header type in API Gateway.**
                /// *   **CUSTOM: a custom header type.**
                /// *   **CLIENT: the ContentType header type of the client.
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
                /// The region where the API is located.
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
            /// *   **TRUE: The Mock mode is enabled.**
            /// *   **FALSE: The Mock mode is not enabled.
            /// </summary>
            [NameInMap("Mock")]
            [Validation(Required=false)]
            public string Mock { get; set; }

            /// <summary>
            /// The simulated Headers.
            /// </summary>
            [NameInMap("MockHeaders")]
            [Validation(Required=false)]
            public DescribeDeployedApiResponseBodyServiceConfigMockHeaders MockHeaders { get; set; }
            public class DescribeDeployedApiResponseBodyServiceConfigMockHeaders : TeaModel {
                [NameInMap("MockHeader")]
                [Validation(Required=false)]
                public List<DescribeDeployedApiResponseBodyServiceConfigMockHeadersMockHeader> MockHeader { get; set; }
                public class DescribeDeployedApiResponseBodyServiceConfigMockHeadersMockHeader : TeaModel {
                    /// <summary>
                    /// The name of the HTTP header parameter.
                    /// </summary>
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// The value of the HTTP header parameter.
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
            /// The backend service protocol. Currently, only HTTP, HTTPS, and FunctionCompute are supported.
            /// </summary>
            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }

            /// <summary>
            /// The timeout period of the backend service, in millisecond.
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
            public DescribeDeployedApiResponseBodyServiceConfigVpcConfig VpcConfig { get; set; }
            public class DescribeDeployedApiResponseBodyServiceConfigVpcConfig : TeaModel {
                /// <summary>
                /// The IDs of the ELB and SLB instances in the VPC.
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

            }

            /// <summary>
            /// The ID of the VPC.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The parameters of API requests sent by API Gateway to the backend service.
        /// 
        /// For more information, see [ServiceParameter](https://help.aliyun.com/document_detail/43988.html).
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyServiceParameters ServiceParameters { get; set; }
        public class DescribeDeployedApiResponseBodyServiceParameters : TeaModel {
            [NameInMap("ServiceParameter")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyServiceParametersServiceParameter> ServiceParameter { get; set; }
            public class DescribeDeployedApiResponseBodyServiceParametersServiceParameter : TeaModel {
                /// <summary>
                /// The parameter location. Valid values: BODY, HEAD, QUERY, and PATH.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The data type of the back-end service parameter.
                /// </summary>
                [NameInMap("ParameterType")]
                [Validation(Required=false)]
                public string ParameterType { get; set; }

                /// <summary>
                /// The name of the backend service parameter.
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// The mappings between parameters of requests sent by the consumer to API Gateway and parameters of requests sent by API Gateway to the backend service.
        /// 
        /// For more information, see [ServiceParameterMap](https://help.aliyun.com/document_detail/43989.html).
        /// </summary>
        [NameInMap("ServiceParametersMap")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyServiceParametersMap ServiceParametersMap { get; set; }
        public class DescribeDeployedApiResponseBodyServiceParametersMap : TeaModel {
            [NameInMap("ServiceParameterMap")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyServiceParametersMapServiceParameterMap> ServiceParameterMap { get; set; }
            public class DescribeDeployedApiResponseBodyServiceParametersMapServiceParameterMap : TeaModel {
                /// <summary>
                /// The name of the front-end input parameter.
                /// </summary>
                [NameInMap("RequestParameterName")]
                [Validation(Required=false)]
                public string RequestParameterName { get; set; }

                /// <summary>
                /// The name of the backend service parameter.
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// The name of the runtime environment. Valid values:
        /// 
        /// *   **RELEASE**
        /// *   **PRE: the pre-release environment**
        /// *   **TEST**
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        /// <summary>
        /// System parameters
        /// </summary>
        [NameInMap("SystemParameters")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodySystemParameters SystemParameters { get; set; }
        public class DescribeDeployedApiResponseBodySystemParameters : TeaModel {
            [NameInMap("SystemParameter")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodySystemParametersSystemParameter> SystemParameter { get; set; }
            public class DescribeDeployedApiResponseBodySystemParametersSystemParameter : TeaModel {
                /// <summary>
                /// Examples
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// The description.
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
                /// The name of the corresponding backend parameter.
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// Specifies whether to make the API public. Valid values:
        /// 
        /// *   **PUBLIC**: Make the API public. If you set this parameter to PUBLIC, this API is displayed on the APIs page for all users after the API is published to the production environment.**
        /// *   **PRIVATE**: Make the API private. Private APIs are not displayed in the Alibaba Cloud Marketplace after the API group to which they belong is made available.
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
