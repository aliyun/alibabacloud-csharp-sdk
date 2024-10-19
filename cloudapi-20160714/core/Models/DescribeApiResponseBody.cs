// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiResponseBody : TeaModel {
        /// <summary>
        /// <para>If <b>AuthType</b> is set to <b>APP</b>, this value must be passed to specify the signature algorithm. If you do not specify a value, HmacSHA256 is used by default. Valid values:</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>8afff6c8c4c6447abb035812e4d66b65</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The name of the API, which is unique in the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ApiName</para>
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// <para>If <b>AuthType</b> is set to <b>APP</b>, the valid values are:</para>
        /// <list type="bullet">
        /// <item><description><b>DEFAULT</b>: The default value that is used if no other values are passed. This value means that the setting of the group is used.</description></item>
        /// <item><description><b>DISABLE</b>: The authentication is disabled.</description></item>
        /// <item><description><b>HEADER</b>: AppCode can be placed in the Header parameter for authentication.</description></item>
        /// <item><description><b>HEADER_QUERY</b>: AppCode can be placed in the Header or Query parameter for authentication.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HEADER</para>
        /// </summary>
        [NameInMap("AppCodeAuthType")]
        [Validation(Required=false)]
        public string AppCodeAuthType { get; set; }

        /// <summary>
        /// <para>The security authentication method of the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>APP</b>: Only authorized applications can call the API.</para>
        /// </description></item>
        /// <item><description><para><b>ANONYMOUS</b>: The API can be anonymously called. In this mode, you must take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>All users who have obtained the API service information can call this API. API Gateway does not authenticate callers and cannot set user-specific throttling policies. If you make this API public, set API-specific throttling policies.</description></item>
        /// <item><description>We recommend that you do not make the API whose security authentication method is ANONYMOUS available in Alibaba Cloud Marketplace because API Gateway cannot meter calls on the caller or limit the number of calls on the API. If you want to make the API group to which the API belongs available in Alibaba Cloud Marketplace, we recommend that you move the API to another group, set its type to PRIVATE, or set its security authentication method to APP.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>APPOPENID</b>: The OpenID Connect account authentication method is used. Only applications authorized by OpenID Connect can call the API. If this method is selected, the OpenIdConnectConfig parameter is required.</para>
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
        /// <para>Backend configurations</para>
        /// </summary>
        [NameInMap("BackendConfig")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyBackendConfig BackendConfig { get; set; }
        public class DescribeApiResponseBodyBackendConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the backend service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0038e00c3dca44fcba3a94015d8f5bbf</para>
            /// </summary>
            [NameInMap("BackendId")]
            [Validation(Required=false)]
            public string BackendId { get; set; }

            /// <summary>
            /// <para>The name of the backend service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testoss</para>
            /// </summary>
            [NameInMap("BackendName")]
            [Validation(Required=false)]
            public string BackendName { get; set; }

            /// <summary>
            /// <para>Backend service type</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("BackendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable backend services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("BackendEnable")]
        [Validation(Required=false)]
        public bool? BackendEnable { get; set; }

        /// <summary>
        /// <para>System parameters sent by API Gateway to the backend service</para>
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
                /// <para>The constant parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>constance</para>
                /// </summary>
                [NameInMap("ConstantValue")]
                [Validation(Required=false)]
                public string ConstantValue { get; set; }

                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>constance</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The parameter location. Valid values: BODY, HEAD, QUERY, and PATH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HEAD</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The mapped parameter name in the backend service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>constance</para>
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// <para>The creation time of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-07-28T09:50:43Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>Custom system parameters</para>
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
                /// <para>The example value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.1</para>
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Client IP Address</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The parameter location. Valid values: BODY, HEAD, QUERY, and PATH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HEAD</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The name of the system parameter. Valid values: CaClientIp, CaDomain, CaRequestHandleTime, CaAppId, CaRequestId, CaHttpSchema, and CaProxy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CaClientIp</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The mapped parameter name in the backend service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>clientIp</para>
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// <para>The API publishing status.</para>
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
                /// <para>The deployment status. Valid values: DEPLOYED and NONDEPLOYED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEPLOYED</para>
                /// </summary>
                [NameInMap("DeployedStatus")]
                [Validation(Required=false)]
                public string DeployedStatus { get; set; }

                /// <summary>
                /// <para>The effective version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("EffectiveVersion")]
                [Validation(Required=false)]
                public string EffectiveVersion { get; set; }

                /// <summary>
                /// <para>The environment to which the API is published. Valid values: RELEASE and TEST.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RELEASE</para>
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

            }

        }

        /// <summary>
        /// <para>The description of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Api description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to limit API calls to within the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Only API calls from the VPC are supported.</description></item>
        /// <item><description><b>false</b>: API calls from the VPC and Internet are both supported.</description></item>
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
                /// <para>The returned error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The error description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The UserId parameter is missing from the request.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The returned error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Missing the parameter UserId</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[\&quot;*\&quot;]</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

            }

        }

        /// <summary>
        /// <para>The sample error response from the backend service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        /// <summary>
        /// <para>Specifies whether to carry the header : X-Ca-Nonce when calling an API. This is the unique identifier of the request and is generally identified by UUID. After receiving this parameter, API Gateway verifies the validity of this parameter. The same value can be used only once within 15 minutes. This helps prevent reply attacks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: This field is forcibly checked when an API is requested to prevent replay attacks.</description></item>
        /// <item><description><b>false</b>: This field is not checked.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceNonceCheck")]
        [Validation(Required=false)]
        public bool? ForceNonceCheck { get; set; }

        /// <summary>
        /// <para>The ID of the API group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08ae4aa0f95e4321849ee57f4e0b3077</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the API group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ApiTest</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Mock mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OPEN: The Mock mode is enabled.</description></item>
        /// <item><description>CLOSED: The Mock mode is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLOSED</para>
        /// </summary>
        [NameInMap("Mock")]
        [Validation(Required=false)]
        public string Mock { get; set; }

        /// <summary>
        /// <para>The result returned for service mocking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test result</para>
        /// </summary>
        [NameInMap("MockResult")]
        [Validation(Required=false)]
        public string MockResult { get; set; }

        /// <summary>
        /// <para>The last modification time of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-07-28T13:13:12Z</para>
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// <para>Configuration items of the third-party OpenID Connect authentication method</para>
        /// </summary>
        [NameInMap("OpenIdConnectConfig")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyOpenIdConnectConfig OpenIdConnectConfig { get; set; }
        public class DescribeApiResponseBodyOpenIdConnectConfig : TeaModel {
            /// <summary>
            /// <para>The name of the parameter that corresponds to the token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("IdTokenParamName")]
            [Validation(Required=false)]
            public string IdTokenParamName { get; set; }

            /// <summary>
            /// <para>The OpenID Connect mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IDTOKEN</b>: indicates the APIs that are called by clients to obtain tokens. If you specify this value, the PublicKeyId parameter and the PublicKey parameter are required.</description></item>
            /// <item><description><b>BUSINESS</b>: indicates business APIs. Tokens are used to call the business APIs. If you specify this value, the IdTokenParamName parameter is required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IDTOKEN</para>
            /// </summary>
            [NameInMap("OpenIdApiType")]
            [Validation(Required=false)]
            public string OpenIdApiType { get; set; }

            /// <summary>
            /// <para>The public key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EB1837F8693CCED0BF750B3AD48467BEB569E780A14591CF92</para>
            /// </summary>
            [NameInMap("PublicKey")]
            [Validation(Required=false)]
            public string PublicKey { get; set; }

            /// <summary>
            /// <para>The ID of the public key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88483727556929326703309904351185815489</para>
            /// </summary>
            [NameInMap("PublicKeyId")]
            [Validation(Required=false)]
            public string PublicKeyId { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The configuration items of API requests sent by the consumer to API Gateway.</para>
        /// </summary>
        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyRequestConfig RequestConfig { get; set; }
        public class DescribeApiResponseBodyRequestConfig : TeaModel {
            /// <summary>
            /// <para>This parameter takes effect only when the RequestMode parameter is set to MAPPING.********</para>
            /// <para>The server data transmission method used for POST and PUT requests. Valid values: FORM and STREAM. FORM indicates that data in key-value pairs is transmitted as forms. STREAM indicates that data is transmitted as byte streams.</para>
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
            /// <para><a href="https://apigateway.aliyun.com/models/3a240a127dcc4afd9ab1bf7e947b4095/9e2df550e85b4121a79ec33e2619eaab">https://apigateway.aliyun.com/models/3a240a127dcc4afd9ab1bf7e947b4095/9e2df550e85b4121a79ec33e2619eaab</a></para>
            /// </summary>
            [NameInMap("BodyModel")]
            [Validation(Required=false)]
            public string BodyModel { get; set; }

            /// <summary>
            /// <para>Whether to escape the Path parameter, if true, the [param] on the Path will be treated as a regular character.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EscapePathParam")]
            [Validation(Required=false)]
            public bool? EscapePathParam { get; set; }

            /// <summary>
            /// <para>The description of the request body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fwefwef</para>
            /// </summary>
            [NameInMap("PostBodyDescription")]
            [Validation(Required=false)]
            public string PostBodyDescription { get; set; }

            /// <summary>
            /// <para>The HTTP method used to make the request. Valid values: GET, POST, DELETE, PUT, HEADER, TRACE, PATCH, CONNECT, and OPTIONS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("RequestHttpMethod")]
            [Validation(Required=false)]
            public string RequestHttpMethod { get; set; }

            /// <summary>
            /// <para>The request mode. Valid values: MAPPING and PASSTHROUGH.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAPPING</para>
            /// </summary>
            [NameInMap("RequestMode")]
            [Validation(Required=false)]
            public string RequestMode { get; set; }

            /// <summary>
            /// <para>The API request path. If the complete API URL is <c>http://api.a.com:8080/object/add?key1=value1&amp;key2=value2</c>, the API request path is <c>/object/add </c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/api/billing/test/[type]</para>
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

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0FF585F-7966-40CF-BC60-75DB070B23D5&lt;</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The parameters of API requests sent by the consumer to API Gateway.</para>
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
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>age</para>
                /// </summary>
                [NameInMap("ApiParameterName")]
                [Validation(Required=false)]
                public string ApiParameterName { get; set; }

                /// <summary>
                /// <para>The type of the array element.</para>
                /// 
                /// <b>Example:</b>
                /// <para>String</para>
                /// </summary>
                [NameInMap("ArrayItemsType")]
                [Validation(Required=false)]
                public string ArrayItemsType { get; set; }

                /// <summary>
                /// <para>The default value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The example value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Age</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The order in which the parameter is sorted in the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DocOrder")]
                [Validation(Required=false)]
                public int? DocOrder { get; set; }

                /// <summary>
                /// <para>Indicates whether the document is public. Valid values: <b>PUBLIC</b> and <b>PRIVATE</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLIC</para>
                /// </summary>
                [NameInMap("DocShow")]
                [Validation(Required=false)]
                public string DocShow { get; set; }

                /// <summary>
                /// <para>The hash values that are supported when <b>ParameterType</b> is set to Int, Long, Float, Double, or String. Separate values with commas (,). Examples: 1,2,3,4,9 and A,B,C,E,F.</para>
                /// 
                /// <b>Example:</b>
                /// <para>boy,girl</para>
                /// </summary>
                [NameInMap("EnumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

                /// <summary>
                /// <para>The JSON Schema used for JSON validation when <b>ParameterType</b> is set to String.</para>
                /// 
                /// <b>Example:</b>
                /// <para>JSON</para>
                /// </summary>
                [NameInMap("JsonScheme")]
                [Validation(Required=false)]
                public string JsonScheme { get; set; }

                /// <summary>
                /// <para>The parameter location. Valid values: BODY, HEAD, QUERY, and PATH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HEAD</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The maximum parameter length when <b>ParameterType</b> is set to String.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public long? MaxLength { get; set; }

                /// <summary>
                /// <para>The maximum parameter value when <b>ParameterType</b> is set to Int, Long, Float, or Double.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public long? MaxValue { get; set; }

                /// <summary>
                /// <para>The minimum parameter length when <b>ParameterType</b> is set to String.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public long? MinLength { get; set; }

                /// <summary>
                /// <para>The minimum parameter value when <b>ParameterType</b> is set to Int, Long, Float, or Double.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public long? MinValue { get; set; }

                /// <summary>
                /// <para>The data type of the parameter. Valid values: String, Int, Long, Float, Double, and Boolean.</para>
                /// 
                /// <b>Example:</b>
                /// <para>String</para>
                /// </summary>
                [NameInMap("ParameterType")]
                [Validation(Required=false)]
                public string ParameterType { get; set; }

                /// <summary>
                /// <para>The regular expression that is used for parameter validation when <b>ParameterType</b> is set to String.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("RegularExpression")]
                [Validation(Required=false)]
                public string RegularExpression { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter is required. Valid values: <b>REQUIRED</b> and <b>OPTIONAL</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OPTIONAL</para>
                /// </summary>
                [NameInMap("Required")]
                [Validation(Required=false)]
                public string Required { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned description of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ResultBodyModel")]
        [Validation(Required=false)]
        public string ResultBodyModel { get; set; }

        /// <summary>
        /// <para>The sample response from the backend service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        /// <summary>
        /// <para>The format of the response from the backend service. Valid values: JSON, TEXT, BINARY, XML, and HTML.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// <para>The configuration items of API requests that API Gateway sends to the backend service.</para>
        /// </summary>
        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyServiceConfig ServiceConfig { get; set; }
        public class DescribeApiResponseBodyServiceConfig : TeaModel {
            /// <summary>
            /// <para>The application name in AONE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ib-blank</para>
            /// </summary>
            [NameInMap("AoneAppName")]
            [Validation(Required=false)]
            public string AoneAppName { get; set; }

            /// <summary>
            /// <para>The ContentType header type used when you call the backend service over HTTP.</para>
            /// <list type="bullet">
            /// <item><description><b>DEFAULT</b>: the default header type in API Gateway</description></item>
            /// <item><description><b>CUSTOM</b>: a custom header type</description></item>
            /// <item><description><b>CLIENT</b>: the ContentType header type of the client</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("ContentTypeCatagory")]
            [Validation(Required=false)]
            public string ContentTypeCatagory { get; set; }

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
            /// <para>Configuration items of EventBridge</para>
            /// </summary>
            [NameInMap("EventBridgeConfig")]
            [Validation(Required=false)]
            public DescribeApiResponseBodyServiceConfigEventBridgeConfig EventBridgeConfig { get; set; }
            public class DescribeApiResponseBodyServiceConfigEventBridgeConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the region where the EventBridge instance is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("EventBridgeRegionId")]
                [Validation(Required=false)]
                public string EventBridgeRegionId { get; set; }

                /// <summary>
                /// <para>The event bus.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testBus</para>
                /// </summary>
                [NameInMap("EventBus")]
                [Validation(Required=false)]
                public string EventBus { get; set; }

                /// <summary>
                /// <para>The event source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>baas_driver</para>
                /// </summary>
                [NameInMap("EventSource")]
                [Validation(Required=false)]
                public string EventSource { get; set; }

                /// <summary>
                /// <para>The Arn that is authorized by a RAM user to EventBridge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::1933122015759***:role/adminoidcaliyun</para>
                /// </summary>
                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

            }

            /// <summary>
            /// <para>Backend configuration items when the backend service is Function Compute</para>
            /// </summary>
            [NameInMap("FunctionComputeConfig")]
            [Validation(Required=false)]
            public DescribeApiResponseBodyServiceConfigFunctionComputeConfig FunctionComputeConfig { get; set; }
            public class DescribeApiResponseBodyServiceConfigFunctionComputeConfig : TeaModel {
                /// <summary>
                /// <para>The ContentType header type used when you call the backend service over HTTP.</para>
                /// <list type="bullet">
                /// <item><description><b>DEFAULT</b>: the default header type in API Gateway</description></item>
                /// <item><description><b>CUSTOM</b>: a custom header type</description></item>
                /// <item><description><b>CLIENT</b>: the ContentType header type of the client</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("ContentTypeCatagory")]
                [Validation(Required=false)]
                public string ContentTypeCatagory { get; set; }

                /// <summary>
                /// <para>The value of the ContentType header when the ContentTypeCatagory parameter is set to DEFAULT or CUSTOM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>application/x-www-form-urlencoded; charset=UTF-8</para>
                /// </summary>
                [NameInMap("ContentTypeValue")]
                [Validation(Required=false)]
                public string ContentTypeValue { get; set; }

                /// <summary>
                /// <para>The root path of Function Compute.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://1227****64334133.ap-southeast-1-int***al.fc.aliyuncs.com/201****-15/proxy/test****ice.LATEST/testHttp/">https://1227****64334133.ap-southeast-1-int***al.fc.aliyuncs.com/201****-15/proxy/test****ice.LATEST/testHttp/</a></para>
                /// </summary>
                [NameInMap("FcBaseUrl")]
                [Validation(Required=false)]
                public string FcBaseUrl { get; set; }

                /// <summary>
                /// <para>The type of the Function Compute instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HttpTrigger</para>
                /// </summary>
                [NameInMap("FcType")]
                [Validation(Required=false)]
                public string FcType { get; set; }

                /// <summary>
                /// <para>The function name defined in Function Compute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edge_function</para>
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// <para>The request method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The backend only receives the service path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OnlyBusinessPath")]
                [Validation(Required=false)]
                public bool? OnlyBusinessPath { get; set; }

                /// <summary>
                /// <para>The API request path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/api/offline/cacheData</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The alias of the function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Qualifier")]
                [Validation(Required=false)]
                public string Qualifier { get; set; }

                /// <summary>
                /// <para>The region where the Function Compute instance is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role to be assumed by API Gateway to access Function Compute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::111***:role/aliyunserviceroleforsas</para>
                /// </summary>
                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                /// <summary>
                /// <para>The service name defined in Function Compute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fcservicename</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the Mock mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TRUE</b>: The Mock mode is enabled.</description></item>
            /// <item><description><b>FALSE</b>: The Mock mode is not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TRUE</para>
            /// </summary>
            [NameInMap("Mock")]
            [Validation(Required=false)]
            public string Mock { get; set; }

            /// <summary>
            /// <para>The simulated headers.</para>
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
                    /// <para>The HTTP header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Content-Length</para>
                    /// </summary>
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <para>The value of the HTTP header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86400</para>
                    /// </summary>
                    [NameInMap("HeaderValue")]
                    [Validation(Required=false)]
                    public string HeaderValue { get; set; }

                }

            }

            /// <summary>
            /// <para>The result returned when the Mock mode is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test result</para>
            /// </summary>
            [NameInMap("MockResult")]
            [Validation(Required=false)]
            public string MockResult { get; set; }

            /// <summary>
            /// <para>The status code returned for service mocking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("MockStatusCode")]
            [Validation(Required=false)]
            public int? MockStatusCode { get; set; }

            /// <summary>
            /// <para>The information returned when the backend service is Object Storage Service (OSS).</para>
            /// </summary>
            [NameInMap("OssConfig")]
            [Validation(Required=false)]
            public DescribeApiResponseBodyServiceConfigOssConfig OssConfig { get; set; }
            public class DescribeApiResponseBodyServiceConfigOssConfig : TeaModel {
                /// <summary>
                /// <para>The operation options on OSS. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GetObject</description></item>
                /// <item><description>PostObject</description></item>
                /// <item><description>DeleteObject</description></item>
                /// <item><description>PutObject</description></item>
                /// <item><description>HeadObject</description></item>
                /// <item><description>GetObjectMeta</description></item>
                /// <item><description>AppendObject</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GetObject</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cbg-db</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The stored object or folder path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/folder/test.json</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The ID of the region where the OSS instance is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("OssRegionId")]
                [Validation(Required=false)]
                public string OssRegionId { get; set; }

            }

            /// <summary>
            /// <para>The URL used to call the back-end service. If the complete back-end service URL is <c>http://api.a.com:8080/object/add?key1=value1&amp;key2=value2</c>, the value of ServiceAddress is <b><a href="http://api.a.com:8080">http://api.a.com:8080</a></b>.``</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://api.a.com:8080">http://api.a.com:8080</a></para>
            /// </summary>
            [NameInMap("ServiceAddress")]
            [Validation(Required=false)]
            public string ServiceAddress { get; set; }

            /// <summary>
            /// <para>The HTTP method used to call a backend service. Valid values: GET, POST, DELETE, PUT, HEADER, TRACE, PATCH, CONNECT, and OPTIONS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("ServiceHttpMethod")]
            [Validation(Required=false)]
            public string ServiceHttpMethod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/object/add</para>
            /// </summary>
            [NameInMap("ServicePath")]
            [Validation(Required=false)]
            public string ServicePath { get; set; }

            /// <summary>
            /// <para>The protocol used by the backend service. Valid values: HTTP and HTTPS.</para>
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
            /// <para>1000</para>
            /// </summary>
            [NameInMap("ServiceTimeout")]
            [Validation(Required=false)]
            public int? ServiceTimeout { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the VPC channel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TRUE</b>: The VPC channel is enabled. You must create the corresponding VPC access authorization before you can enable a VPC channel.</description></item>
            /// <item><description><b>FALSE</b>: The VPC channel is not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TRUE</para>
            /// </summary>
            [NameInMap("ServiceVpcEnable")]
            [Validation(Required=false)]
            public string ServiceVpcEnable { get; set; }

            /// <summary>
            /// <para>Configuration items related to VPC channels</para>
            /// </summary>
            [NameInMap("VpcConfig")]
            [Validation(Required=false)]
            public DescribeApiResponseBodyServiceConfigVpcConfig VpcConfig { get; set; }
            public class DescribeApiResponseBodyServiceConfigVpcConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the ECS or SLB instance in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1h497hkijewv2***</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the VPC access authorization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>glmall-app-test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The port number that corresponds to the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zeafsc3fygk1***</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The VPC protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("VpcScheme")]
                [Validation(Required=false)]
                public string VpcScheme { get; set; }

            }

        }

        /// <summary>
        /// <para>The parameters of API requests sent by API Gateway to the backend service.</para>
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
                /// <para>The parameter location. Valid values: BODY, HEAD, QUERY, and PATH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HEAD</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The data type of the parameter. Valid values: STRING, NUMBER, and BOOLEAN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>String</para>
                /// </summary>
                [NameInMap("ParameterType")]
                [Validation(Required=false)]
                public string ParameterType { get; set; }

                /// <summary>
                /// <para>The mapped parameter name in the backend service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>clientIp</para>
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// <para>The mappings between parameters of requests sent by the consumer to API Gateway and parameters of requests sent by API Gateway to the backend service.</para>
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
                /// <para>The corresponding frontend parameter name. The value must be contained in RequestParametersObject and match RequestParam.ApiParameterName.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sex</para>
                /// </summary>
                [NameInMap("RequestParameterName")]
                [Validation(Required=false)]
                public string RequestParameterName { get; set; }

                /// <summary>
                /// <para>The mapped parameter name in the backend service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sex</para>
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// <para>System parameters sent by API Gateway to the backend service</para>
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
                /// <para>The example value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.1</para>
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Client IP Address</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The parameter location. Valid values: BODY, HEAD, QUERY, and PATH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HEAD</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The system parameter. Valid values: CaClientIp, CaDomain, CaRequestHandleTime, CaAppId, CaRequestId, CaHttpSchema, and CaProxy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CaClientIp</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The mapped parameter name in the backend service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>clientIp</para>
                /// </summary>
                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        /// <summary>
        /// <para>Tag List.</para>
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
                /// <para>Label key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>APP</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>Label value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value3</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>Specifies whether to make the API public. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PUBLIC</b>: Make the API public. If you set this parameter to PUBLIC, this API is displayed on the APIs page for all users after the API is published to the production environment.</description></item>
        /// <item><description><b>PRIVATE</b>: Make the API private. Private APIs are not displayed in the Alibaba Cloud Marketplace after the API group to which they belong is made available.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The type of the two-way communication API.</para>
        /// <list type="bullet">
        /// <item><description><b>COMMON</b>: common API</description></item>
        /// <item><description><b>REGISTER</b>: registered API</description></item>
        /// <item><description><b>UNREGISTER</b>: unregistered API</description></item>
        /// <item><description><b>NOTIFY</b>: downstream notification API</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMMON</para>
        /// </summary>
        [NameInMap("WebSocketApiType")]
        [Validation(Required=false)]
        public string WebSocketApiType { get; set; }

    }

}
