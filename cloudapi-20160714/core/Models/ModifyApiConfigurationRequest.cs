// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyApiConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>If the <b>AuthType</b> parameter is set to <b>APP</b>, you must include this parameter to specify the signature algorithm. If you do not specify a value, HmacSHA256 is used by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HmacSHA256</description></item>
        /// <item><description>HmacSHA1,HmacSHA256</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HmacSHA256</para>
        /// </summary>
        [NameInMap("AllowSignatureMethod")]
        [Validation(Required=false)]
        public string AllowSignatureMethod { get; set; }

        /// <summary>
        /// <para>The ID of the API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>baacc592e63a4cb6a41920d9d3f91f38</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The name of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testModifyApiName</para>
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// <para>If the <b>AuthType</b> parameter is set to <b>APP</b>, the valid values are:</para>
        /// <list type="bullet">
        /// <item><description><b>DEFAULT</b>: The default value that is used if no other values are passed. This value indicates that the settings of the group are used.</description></item>
        /// <item><description><b>DISABLE</b>: The authentication is disabled.</description></item>
        /// <item><description><b>HEADER</b>: AppCode can be placed in the Header parameter for authentication.</description></item>
        /// <item><description><b>HEADER_QUERY</b>: AppCode can be placed in the Header or Query parameter for authentication.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("AppCodeAuthType")]
        [Validation(Required=false)]
        public string AppCodeAuthType { get; set; }

        /// <summary>
        /// <para>API安全认证类型，目前可以取值：</para>
        /// <list type="bullet">
        /// <item><description><b>APP</b>：只允许已授权的APP调用</description></item>
        /// <item><description><b>ANONYMOUS</b>：允许匿名调用，设置为允许匿名调用需要注意：<list type="bullet">
        /// <item><description>任何能够获取该API服务信息的人，都将能够调用该API。网关不会对调用者做身份认证，也无法设置按用户的流量控制，若开放该API请设置好按API的流量控制；</description></item>
        /// <item><description>AppCodeAuthType的值不会生效。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>APP</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>The name of the backend service. This parameter takes effect only when the UseBackendService parameter is set to TRUE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testBackendService</para>
        /// </summary>
        [NameInMap("BackendName")]
        [Validation(Required=false)]
        public string BackendName { get; set; }

        /// <summary>
        /// <para>This parameter takes effect only when the <b>RequestMode</b> parameter is set to <b>MAPPING</b>.</para>
        /// <para>The format in which data is transmitted to the server for POST and PUT requests. Valid values: <b>FORM</b> and <b>STREAM</b>. FORM indicates that data is transmitted in the key-value pair format. STREAM indicates that data is transmitted as byte streams.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STREAM</para>
        /// </summary>
        [NameInMap("BodyFormat")]
        [Validation(Required=false)]
        public string BodyFormat { get; set; }

        /// <summary>
        /// <para>The body model.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://apigateway.aliyun.com/models/f4e7333c****40dcbaf7c9da553ccd8d/3ab61f775b****d4bc35e993****87aa8">https://apigateway.aliyun.com/models/f4e7333c****40dcbaf7c9da553ccd8d/3ab61f775b****d4bc35e993****87aa8</a></para>
        /// </summary>
        [NameInMap("BodyModel")]
        [Validation(Required=false)]
        public string BodyModel { get; set; }

        /// <summary>
        /// <para>The ContentType configuration of the backend request.</para>
        /// <list type="bullet">
        /// <item><description>DEFAULT: the default configuration in API Gateway</description></item>
        /// <item><description>CUSTOM: a custom configuration</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("ContentTypeCategory")]
        [Validation(Required=false)]
        public string ContentTypeCategory { get; set; }

        /// <summary>
        /// <para>The value of the ContentType header when the ServiceProtocol parameter is set to HTTP and the ContentTypeCatagory parameter is set to DEFAULT or CUSTOM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/x-www-form-urlencoded; charset=UTF-8</para>
        /// </summary>
        [NameInMap("ContentTypeValue")]
        [Validation(Required=false)]
        public string ContentTypeValue { get; set; }

        /// <summary>
        /// <para>The description of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestModifyDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Specifies whether to call the API only in an internal network. If the <b>DisableInternet</b> parameter is set to <b>true</b>, the API can be called only in an internal network.</description></item>
        /// <item><description>If the <b>DisableInternet</b> parameter is set to <b>false</b>, the API can be called over the Internet and in an internal network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableInternet")]
        [Validation(Required=false)]
        public bool? DisableInternet { get; set; }

        /// <summary>
        /// <para>The sample error codes returned by the backend service.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/44392.html">ErrorCodeSample</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Code&quot;:&quot;400&quot;,&quot;Message&quot;:&quot;Missing the userId&quot;,&quot;Description&quot;:&quot;param invalid&quot;}]</para>
        /// </summary>
        [NameInMap("ErrorCodeSamples")]
        [Validation(Required=false)]
        public string ErrorCodeSamples { get; set; }

        /// <summary>
        /// <para>The sample error response from the backend service. This value is used only to generate documents. It does not affect the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;errorCode&quot;:&quot;fail&quot;,&quot;errorMessage&quot;:&quot;param invalid&quot;}</para>
        /// </summary>
        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Specifies whether to forcibly check X-Ca-Nonce. If the <b>ForceNonceCheck</b> parameter is set to <b>true</b>, X-Ca-Nonce is forcibly checked. X-Ca-Nonce is the unique identifier of the request and is generally identified by UUID. After receiving this parameter, API Gateway verifies the validity of this parameter. The same value can be used only once within 15 minutes. This helps prevent replay attacks.</description></item>
        /// <item><description>If the <b>ForceNonceCheck</b> parameter is set to <b>false</b>, X-Ca-Nonce is not checked. If you do not modify this parameter when you modify an API, the original value is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceNonceCheck")]
        [Validation(Required=false)]
        public bool? ForceNonceCheck { get; set; }

        /// <summary>
        /// <para>The Function Compute configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FcType&quot;:&quot;FCEvent&quot;,&quot;FcRegionId&quot;:&quot;cn-hangzhou&quot;,&quot;RoleArn&quot;:&quot;acs:ram::xxxxxxxx:role/aliyunserviceroleforapigateway&quot;,&quot;selectServiceName&quot;:&quot;fcTest&quot;,&quot;FunctionName&quot;:&quot;funcTest&quot;,&quot;selectFunctionName&quot;:&quot;funcTest&quot;,&quot;Qualifier&quot;:&quot;LATEST&quot;,&quot;Path&quot;:&quot;&quot;,&quot;FcBaseUrl&quot;:&quot;&quot;,&quot;ServiceName&quot;:&quot;fcTest&quot;}</para>
        /// </summary>
        [NameInMap("FunctionComputeConfig")]
        [Validation(Required=false)]
        public string FunctionComputeConfig { get; set; }

        /// <summary>
        /// <para>The HTTP configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;serviceAddress&quot;:&quot;<a href="http://test.api.com%22,%22servicePath%22:%22/test/api%22,%22serviceHttpMethod%22:%22GET%22%7D">http://test.api.com&quot;,&quot;servicePath&quot;:&quot;/test/api&quot;,&quot;serviceHttpMethod&quot;:&quot;GET&quot;}</a></para>
        /// </summary>
        [NameInMap("HttpConfig")]
        [Validation(Required=false)]
        public string HttpConfig { get; set; }

        /// <summary>
        /// <para>The Mock configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MockResult&quot;:&quot;test&quot;,&quot;MockHeaders&quot;:[{&quot;HeaderName&quot;:&quot;testHeader&quot;,&quot;HeaderValue&quot;:&quot;testHeader&quot;}],&quot;MockStatusCode&quot;:&quot;400&quot;}</para>
        /// </summary>
        [NameInMap("MockConfig")]
        [Validation(Required=false)]
        public string MockConfig { get; set; }

        /// <summary>
        /// <para>The name of the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The OSS configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;OssRegionId&quot;:&quot;cn-hangzhou&quot;,&quot;Key&quot;:&quot;/test.html&quot;,&quot;BucketName&quot;:&quot;test-api-oss&quot;,&quot;Action&quot;:&quot;GetObject&quot;}</para>
        /// </summary>
        [NameInMap("OssConfig")]
        [Validation(Required=false)]
        public string OssConfig { get; set; }

        /// <summary>
        /// <para>The description of the request body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The description of the request body</para>
        /// </summary>
        [NameInMap("PostBodyDescription")]
        [Validation(Required=false)]
        public string PostBodyDescription { get; set; }

        /// <summary>
        /// <para>The HTTP method used to make the request. Valid values: GET, POST, DELETE, PUT, HEADER, TRACE, PATCH, CONNECT, and OPTIONS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("RequestHttpMethod")]
        [Validation(Required=false)]
        public string RequestHttpMethod { get; set; }

        /// <summary>
        /// <para>The request mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MAPPING: Parameters are mapped. Unknown parameters are filtered out.</description></item>
        /// <item><description>PASSTHROUGH: Parameters are passed through.</description></item>
        /// <item><description>MAPPING_PASSTHROUGH: Parameters are mapped. Unknown parameters are passed through.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MAPPING</para>
        /// </summary>
        [NameInMap("RequestMode")]
        [Validation(Required=false)]
        public string RequestMode { get; set; }

        /// <summary>
        /// <para>The parameters of API requests sent by the consumer to API Gateway.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/43986.html">RequestParameter</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ParameterLocation&quot;:{&quot;name&quot;:&quot;Head&quot;,&quot;orderNumber&quot;:2},&quot;ParameterType&quot;:&quot;String&quot;,&quot;Required&quot;:&quot;OPTIONAL&quot;,&quot;isHide&quot;:false,&quot;ApiParameterName&quot;:&quot;header1&quot;,&quot;DefaultValue&quot;:&quot;123124&quot;,&quot;Location&quot;:&quot;Head&quot;},{&quot;ParameterLocation&quot;:{&quot;name&quot;:&quot;Head&quot;,&quot;orderNumber&quot;:2},&quot;ParameterType&quot;:&quot;String&quot;,&quot;Required&quot;:&quot;REQUIRED&quot;,&quot;isHide&quot;:false,&quot;ApiParameterName&quot;:&quot;header2&quot;,&quot;DefaultValue&quot;:&quot;&quot;,&quot;Location&quot;:&quot;Head&quot;},{&quot;ParameterLocation&quot;:{&quot;name&quot;:&quot;Query&quot;,&quot;orderNumber&quot;:3},&quot;ParameterType&quot;:&quot;String&quot;,&quot;Required&quot;:&quot;OPTIONAL&quot;,&quot;isHide&quot;:false,&quot;ApiParameterName&quot;:&quot;query1&quot;,&quot;DefaultValue&quot;:&quot;1245&quot;,&quot;Location&quot;:&quot;Query&quot;},{&quot;ApiParameterName&quot;:&quot;CaClientIp&quot;,&quot;ParameterLocation&quot;:{&quot;name&quot;:&quot;Query&quot;,&quot;orderNumber&quot;:0},&quot;Location&quot;:&quot;Query&quot;,&quot;ParameterType&quot;:&quot;String&quot;,&quot;Required&quot;:&quot;REQUIRED&quot;,&quot;Description&quot;:&quot;ClientIP&quot;},{&quot;ApiParameterName&quot;:&quot;testConstant&quot;,&quot;ParameterLocation&quot;:{&quot;name&quot;:&quot;Head&quot;,&quot;orderNumber&quot;:0},&quot;Location&quot;:&quot;Head&quot;,&quot;ParameterType&quot;:&quot;String&quot;,&quot;Required&quot;:&quot;REQUIRED&quot;,&quot;DefaultValue&quot;:&quot;111&quot;}]</para>
        /// </summary>
        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public string RequestParameters { get; set; }

        /// <summary>
        /// <para>The path of the API request. If the complete API URL is <c>http://api.a.com:8080/object/add?key1=value1&amp;key2=value2</c>, the path of the API request is <c>/object/add</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/api</para>
        /// </summary>
        [NameInMap("RequestPath")]
        [Validation(Required=false)]
        public string RequestPath { get; set; }

        /// <summary>
        /// <para>The protocol type supported by the API. Valid values: HTTP and HTTPS. Separate multiple values with commas (,), such as &quot;HTTP,HTTPS&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("RequestProtocol")]
        [Validation(Required=false)]
        public string RequestProtocol { get; set; }

        /// <summary>
        /// <para>The sample response from the backend service. This value is used only to generate documents. It does not affect the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\n  \&quot;status\&quot;: 0,\n  \&quot;data\&quot;: {\n    \&quot;count\&quot;: 1,\n    \&quot;list\&quot;: [\n      \&quot;352\&quot;\n    ]\n  },\n  \&quot;message\&quot;: \&quot;success\&quot;\n}</para>
        /// </summary>
        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        /// <summary>
        /// <para>The format of the response from the backend service. Valid values: JSON, TEXT, BINARY, XML, and HTML. This value is used only to generate documents. It does not affect the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The parameters of API requests sent by API Gateway to the backend service.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/43988.html">ServiceParameter</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ServiceParameterName&quot;:&quot;header1&quot;,&quot;Location&quot;:&quot;Head&quot;,&quot;Type&quot;:&quot;String&quot;,&quot;ParameterCatalog&quot;:&quot;REQUEST&quot;},{&quot;ServiceParameterName&quot;:&quot;header2&quot;,&quot;Location&quot;:&quot;Query&quot;,&quot;Type&quot;:&quot;String&quot;,&quot;ParameterCatalog&quot;:&quot;REQUEST&quot;},{&quot;ServiceParameterName&quot;:&quot;query1&quot;,&quot;Location&quot;:&quot;Head&quot;,&quot;Type&quot;:&quot;String&quot;,&quot;ParameterCatalog&quot;:&quot;REQUEST&quot;},{&quot;ServiceParameterName&quot;:&quot;ipp&quot;,&quot;Location&quot;:&quot;Query&quot;,&quot;Type&quot;:&quot;String&quot;,&quot;ParameterCatalog&quot;:&quot;SYSTEM&quot;},{&quot;ServiceParameterName&quot;:&quot;testConstant&quot;,&quot;Location&quot;:&quot;Head&quot;,&quot;Type&quot;:&quot;String&quot;,&quot;ParameterCatalog&quot;:&quot;CONSTANT&quot;}]</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

        /// <summary>
        /// <para>The mappings between parameters of requests sent by the consumer to API Gateway and parameters of requests sent by API Gateway to the backend service.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/43989.html">ServiceParameterMap</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ServiceParameterName&quot;:&quot;header1&quot;,&quot;RequestParameterName&quot;:&quot;header1&quot;},{&quot;ServiceParameterName&quot;:&quot;header2&quot;,&quot;RequestParameterName&quot;:&quot;header2&quot;},{&quot;ServiceParameterName&quot;:&quot;query1&quot;,&quot;RequestParameterName&quot;:&quot;query1&quot;},{&quot;ServiceParameterName&quot;:&quot;ipp&quot;,&quot;RequestParameterName&quot;:&quot;CaClientIp&quot;},{&quot;ServiceParameterName&quot;:&quot;testConstant&quot;,&quot;RequestParameterName&quot;:&quot;testConstant&quot;}]</para>
        /// </summary>
        [NameInMap("ServiceParametersMap")]
        [Validation(Required=false)]
        public string ServiceParametersMap { get; set; }

        /// <summary>
        /// <para>The protocol that is used to access backend services. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Http: for backend services that use HTTP or HTTPS</description></item>
        /// <item><description>Vpc: for backend services that use VPC</description></item>
        /// <item><description>FC: for Function Compute</description></item>
        /// <item><description>OSS: for Object Storage Service</description></item>
        /// <item><description>Mock: for backend services that use the Mock mode</description></item>
        /// <item><description>EventBridge: for EventBridge</description></item>
        /// </list>
        /// <para>You must specify the config value for the corresponding backend service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ServiceProtocol")]
        [Validation(Required=false)]
        public string ServiceProtocol { get; set; }

        /// <summary>
        /// <para>The timeout period of the backend service. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ServiceTimeout")]
        [Validation(Required=false)]
        public int? ServiceTimeout { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the information about the created backend service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TRUE: uses the information about the created backend service.</description></item>
        /// <item><description>FALSE: uses the information about the custom backend service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TRUE</para>
        /// </summary>
        [NameInMap("UseBackendService")]
        [Validation(Required=false)]
        public bool? UseBackendService { get; set; }

        /// <summary>
        /// <para>Specifies whether to make the API public. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PUBLIC:</b> The API is public. If this parameter is set to PUBLIC, the API is displayed on the APIs page for all users after the API is published to the production environment.</description></item>
        /// <item><description><b>PRIVATE:</b> The API is private. Private APIs are not displayed in the Alibaba Cloud Marketplace after the API group to which they belong is made available.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The VPC configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VpcId&quot;:&quot;vpc-xxxxxxx&quot;,&quot;Name&quot;:&quot;testVpc&quot;,&quot;InstanceId&quot;:&quot;i-p0ssssss&quot;,&quot;Port&quot;:80,&quot;servicePath&quot;:&quot;/test/vpc&quot;,&quot;serviceHttpMethod&quot;:&quot;HEAD&quot;}</para>
        /// </summary>
        [NameInMap("VpcConfig")]
        [Validation(Required=false)]
        public string VpcConfig { get; set; }

    }

}
