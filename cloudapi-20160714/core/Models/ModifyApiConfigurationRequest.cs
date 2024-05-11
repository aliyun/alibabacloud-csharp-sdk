// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyApiConfigurationRequest : TeaModel {
        /// <summary>
        /// If the **AuthType** parameter is set to **APP**, you must include this parameter to specify the signature algorithm. If you do not specify a value, HmacSHA256 is used by default. Valid values:
        /// 
        /// *   HmacSHA256
        /// *   HmacSHA1,HmacSHA256
        /// </summary>
        [NameInMap("AllowSignatureMethod")]
        [Validation(Required=false)]
        public string AllowSignatureMethod { get; set; }

        /// <summary>
        /// The ID of the API.
        /// 
        /// This parameter is required.
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
        /// If the **AuthType** parameter is set to **APP**, the valid values are:
        /// 
        /// *   **DEFAULT**: The default value that is used if no other values are passed. This value indicates that the settings of the group are used.
        /// *   **DISABLE**: The authentication is disabled.
        /// *   **HEADER**: AppCode can be placed in the Header parameter for authentication.
        /// *   **HEADER_QUERY**: AppCode can be placed in the Header or Query parameter for authentication.
        /// </summary>
        [NameInMap("AppCodeAuthType")]
        [Validation(Required=false)]
        public string AppCodeAuthType { get; set; }

        /// <summary>
        /// API安全认证类型，目前可以取值：
        /// 
        /// - **APP**：只允许已授权的APP调用
        /// - **ANONYMOUS**：允许匿名调用，设置为允许匿名调用需要注意：
        ///      - 任何能够获取该API服务信息的人，都将能够调用该API。网关不会对调用者做身份认证，也无法设置按用户的流量控制，若开放该API请设置好按API的流量控制；
        ///      - AppCodeAuthType的值不会生效。
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// The name of the backend service. This parameter takes effect only when the UseBackendService parameter is set to TRUE.
        /// </summary>
        [NameInMap("BackendName")]
        [Validation(Required=false)]
        public string BackendName { get; set; }

        /// <summary>
        /// This parameter takes effect only when the **RequestMode** parameter is set to **MAPPING**.
        /// 
        /// The format in which data is transmitted to the server for POST and PUT requests. Valid values: **FORM** and **STREAM**. FORM indicates that data is transmitted in the key-value pair format. STREAM indicates that data is transmitted as byte streams.
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
        /// The ContentType configuration of the backend request.
        /// 
        /// *   DEFAULT: the default configuration in API Gateway
        /// *   CUSTOM: a custom configuration
        /// </summary>
        [NameInMap("ContentTypeCategory")]
        [Validation(Required=false)]
        public string ContentTypeCategory { get; set; }

        /// <summary>
        /// The value of the ContentType header when the ServiceProtocol parameter is set to HTTP and the ContentTypeCatagory parameter is set to DEFAULT or CUSTOM.
        /// </summary>
        [NameInMap("ContentTypeValue")]
        [Validation(Required=false)]
        public string ContentTypeValue { get; set; }

        /// <summary>
        /// The description of the API.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// *   Specifies whether to call the API only in an internal network. If the **DisableInternet** parameter is set to **true**, the API can be called only in an internal network.
        /// *   If the **DisableInternet** parameter is set to **false**, the API can be called over the Internet and in an internal network.
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
        public string ErrorCodeSamples { get; set; }

        /// <summary>
        /// The sample error response from the backend service. This value is used only to generate documents. It does not affect the returned result.
        /// </summary>
        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        /// <summary>
        /// *   Specifies whether to forcibly check X-Ca-Nonce. If the **ForceNonceCheck** parameter is set to **true**, X-Ca-Nonce is forcibly checked. X-Ca-Nonce is the unique identifier of the request and is generally identified by UUID. After receiving this parameter, API Gateway verifies the validity of this parameter. The same value can be used only once within 15 minutes. This helps prevent replay attacks.
        /// *   If the **ForceNonceCheck** parameter is set to **false**, X-Ca-Nonce is not checked. If you do not modify this parameter when you modify an API, the original value is used.
        /// </summary>
        [NameInMap("ForceNonceCheck")]
        [Validation(Required=false)]
        public bool? ForceNonceCheck { get; set; }

        /// <summary>
        /// The Function Compute configuration.
        /// </summary>
        [NameInMap("FunctionComputeConfig")]
        [Validation(Required=false)]
        public string FunctionComputeConfig { get; set; }

        /// <summary>
        /// The HTTP configuration.
        /// </summary>
        [NameInMap("HttpConfig")]
        [Validation(Required=false)]
        public string HttpConfig { get; set; }

        /// <summary>
        /// The Mock configuration.
        /// </summary>
        [NameInMap("MockConfig")]
        [Validation(Required=false)]
        public string MockConfig { get; set; }

        /// <summary>
        /// The name of the model.
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// The OSS configuration.
        /// </summary>
        [NameInMap("OssConfig")]
        [Validation(Required=false)]
        public string OssConfig { get; set; }

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
        /// The parameters of API requests sent by the consumer to API Gateway.
        /// 
        /// For more information, see [RequestParameter](https://help.aliyun.com/document_detail/43986.html).
        /// </summary>
        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public string RequestParameters { get; set; }

        /// <summary>
        /// The path of the API request. If the complete API URL is `http://api.a.com:8080/object/add?key1=value1&key2=value2`, the path of the API request is `/object/add`.
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

        /// <summary>
        /// The sample response from the backend service. This value is used only to generate documents. It does not affect the returned result.
        /// </summary>
        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        /// <summary>
        /// The format of the response from the backend service. Valid values: JSON, TEXT, BINARY, XML, and HTML. This value is used only to generate documents. It does not affect the returned result.
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The parameters of API requests sent by API Gateway to the backend service.
        /// 
        /// For more information, see [ServiceParameter](https://help.aliyun.com/document_detail/43988.html).
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

        /// <summary>
        /// The mappings between parameters of requests sent by the consumer to API Gateway and parameters of requests sent by API Gateway to the backend service.
        /// 
        /// For more information, see [ServiceParameterMap](https://help.aliyun.com/document_detail/43989.html).
        /// </summary>
        [NameInMap("ServiceParametersMap")]
        [Validation(Required=false)]
        public string ServiceParametersMap { get; set; }

        /// <summary>
        /// The protocol that is used to access backend services. Valid values:
        /// 
        /// *   Http: for backend services that use HTTP or HTTPS
        /// *   Vpc: for backend services that use VPC
        /// *   FC: for Function Compute
        /// *   OSS: for Object Storage Service
        /// *   Mock: for backend services that use the Mock mode
        /// *   EventBridge: for EventBridge
        /// 
        /// You must specify the config value for the corresponding backend service.
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
        /// Specifies whether to use the information about the created backend service. Valid values:
        /// 
        /// *   TRUE: uses the information about the created backend service.
        /// *   FALSE: uses the information about the custom backend service.
        /// </summary>
        [NameInMap("UseBackendService")]
        [Validation(Required=false)]
        public bool? UseBackendService { get; set; }

        /// <summary>
        /// Specifies whether to make the API public. Valid values:
        /// 
        /// *   **PUBLIC:** The API is public. If this parameter is set to PUBLIC, the API is displayed on the APIs page for all users after the API is published to the production environment.
        /// *   **PRIVATE:** The API is private. Private APIs are not displayed in the Alibaba Cloud Marketplace after the API group to which they belong is made available.
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// The VPC configuration.
        /// </summary>
        [NameInMap("VpcConfig")]
        [Validation(Required=false)]
        public string VpcConfig { get; set; }

    }

}
