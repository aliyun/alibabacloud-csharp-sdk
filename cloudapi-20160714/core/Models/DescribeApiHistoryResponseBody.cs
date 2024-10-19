// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiHistoryResponseBody : TeaModel {
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
        /// <para>bebf996e4b3d445d83078094b72b0d91</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The name of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Backstage_MengMeng Broadcast_Seven Niu Cloud Push Stream Callback_Official</para>
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// <para>The AppCode authentication type supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DEFAULT: supported after being made available in Alibaba Cloud Marketplace</description></item>
        /// <item><description>DISABLE: not supported.</description></item>
        /// <item><description>HEADER : supported only in the Header parameter</description></item>
        /// <item><description>HEADER_QUERY : supported in the Header or Query parameter.</description></item>
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
        /// <item><description><para><b>APP: Only authorized applications can call the API.</b></para>
        /// </description></item>
        /// <item><description><para><b>ANONYMOUS: The API can be anonymously called. In this mode, you must take note of the following rules:</b></para>
        /// <list type="bullet">
        /// <item><description>All users who have obtained the API service information can call this API. API Gateway does not authenticate callers and cannot set user-specific throttling policies. If you make this API public, set API-specific throttling policies.</description></item>
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
        /// <para>Backend configurations</para>
        /// </summary>
        [NameInMap("BackendConfig")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyBackendConfig BackendConfig { get; set; }
        public class DescribeApiHistoryResponseBodyBackendConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the backend service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a0305308908c4740aba9cbfd63ba99b7</para>
            /// </summary>
            [NameInMap("BackendId")]
            [Validation(Required=false)]
            public string BackendId { get; set; }

            /// <summary>
            /// <para>The name of the backend service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zmapi</para>
            /// </summary>
            [NameInMap("BackendName")]
            [Validation(Required=false)]
            public string BackendName { get; set; }

            /// <summary>
            /// <para>The type of the backend service.</para>
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
        /// <para>The constant parameters.</para>
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
                /// <para>The value of the constant parameter.</para>
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
                /// <para>for_test1</para>
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
        /// <para>The custom system parameters.</para>
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
                /// <para>The sample value.</para>
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
                /// <para>balabala</para>
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
                /// <para>The parameter name.</para>
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
        /// <para>The publishing time (UTC) of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-1113:57:38</para>
        /// </summary>
        [NameInMap("DeployedTime")]
        [Validation(Required=false)]
        public string DeployedTime { get; set; }

        /// <summary>
        /// <para>The description of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Queries weather based on the region name</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Specifies whether to set <b>DisableInternet</b> to <b>true</b> to limit API calls to within the VPC.</description></item>
        /// <item><description>If you set <b>DisableInternet</b> to <b>false</b>, the limit is lifted. The default value is false when you create an API.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableInternet")]
        [Validation(Required=false)]
        public bool? DisableInternet { get; set; }

        /// <summary>
        /// <para>The sample error codes returned by the backend service.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/44392.html">ErrorCodeSample</a>.</para>
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
                /// <para>Missing the parameter UserId</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The returned error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MissingParameter</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        /// <summary>
        /// <para>The sample error response from the backend service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;errorCode&quot;:&quot;fail&quot;,&quot;errorMessage&quot;:&quot;param invalid&quot;}</para>
        /// </summary>
        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Specifies whether to set <b>ForceNonceCheck</b> to <b>true</b> to force the check of X-Ca-Nonce during the request. This is the unique identifier of the request and is generally identified by UUID. After receiving this parameter, API Gateway verifies the validity of this parameter. The same value can be used only once within 15 minutes. This helps prevent replay attacks.</description></item>
        /// <item><description>If you set <b>ForceNonceCheck</b> to <b>false</b>, the check is not performed. The default value is false when you create an API.</description></item>
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
        /// <para>cfb6ef799bf54fffabb0f02019ad2581</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the API group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev_api</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The historical version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20211022134156663</para>
        /// </summary>
        [NameInMap("HistoryVersion")]
        [Validation(Required=false)]
        public string HistoryVersion { get; set; }

        /// <summary>
        /// <para>The configuration items of the third-party OpenID Connect authentication method.</para>
        /// </summary>
        [NameInMap("OpenIdConnectConfig")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyOpenIdConnectConfig OpenIdConnectConfig { get; set; }
        public class DescribeApiHistoryResponseBodyOpenIdConnectConfig : TeaModel {
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
            /// <para>The configuration of OpenID Connect authentication. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IDTOKEN: indicates the APIs that are called by clients to obtain tokens. If you specify this value, the PublicKeyId parameter and the PublicKey parameter are required.</b></description></item>
            /// <item><description>**BUSINESS: indicates business APIs. Tokens are used to call the business APIs. If you specify this value, the IdTokenParamName parameter is required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IDTOKEN</para>
            /// </summary>
            [NameInMap("OpenIdApiType")]
            [Validation(Required=false)]
            public string OpenIdApiType { get; set; }

            /// <summary>
            /// <para>The public key of the API.</para>
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
        /// <para>The region where the API is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The configuration items of API requests sent by the consumer to API Gateway.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/43985.html">RequestConfig</a>.</para>
        /// </summary>
        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyRequestConfig RequestConfig { get; set; }
        public class DescribeApiHistoryResponseBodyRequestConfig : TeaModel {
            /// <summary>
            /// <para>The server data transmission method used for POST and PUT requests. Valid values: FORM and STREAM. FORM indicates that data in key-value pairs is transmitted as forms. STREAM indicates that data is transmitted as byte streams. This parameter takes effect only when the RequestMode parameter is set to MAPPING.</para>
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
            /// <para><a href="https://apigateway.aliyun.com/models/3a240a1XXXXXXXXd9ab1bf7e947b4095/9e2df550e85b4XXXXXXXX619eaab">https://apigateway.aliyun.com/models/3a240a1XXXXXXXXd9ab1bf7e947b4095/9e2df550e85b4XXXXXXXX619eaab</a></para>
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
            /// <para>The HTTP method. Valid values: GET, POST, DELETE, PUT, HEADER, TRACE, PATCH, CONNECT, and OPTIONS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POST</para>
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
            /// <para>API path</para>
            /// 
            /// <b>Example:</b>
            /// <para>/api/billing/test/[type]</para>
            /// </summary>
            [NameInMap("RequestPath")]
            [Validation(Required=false)]
            public string RequestPath { get; set; }

            /// <summary>
            /// <para>The protocol type supported by the API. Valid values: HTTP, HTTPS, and WebSocket. Separate multiple values with commas (,), such as &quot;HTTP,HTTPS&quot;.</para>
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
        /// <para>6C87A26A-6A18-4B8E-8099-705278381A2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The parameters of API requests sent by the consumer to API Gateway.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/43986.html">RequestParameter</a>.</para>
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
                /// <para>The name of the parameter in the API request.</para>
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
                /// <para>The sample value.</para>
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
                /// <para>modidyTest</para>
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
                /// <para>JSON scheme</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
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
        /// <para>The return description of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ResultBodyModel")]
        [Validation(Required=false)]
        public string ResultBodyModel { get; set; }

        /// <summary>
        /// <para>The return description of the API.</para>
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
                /// <para>The subnode description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>for_test1</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether a subnode exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasChild")]
                [Validation(Required=false)]
                public bool? HasChild { get; set; }

                /// <summary>
                /// <para>The result ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The primary key of the result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>groupName</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Mandatory")]
                [Validation(Required=false)]
                public bool? Mandatory { get; set; }

                /// <summary>
                /// <para>The result name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fwqf</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the parent node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pid</para>
                /// </summary>
                [NameInMap("Pid")]
                [Validation(Required=false)]
                public string Pid { get; set; }

                /// <summary>
                /// <para>The result type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>String</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The sample response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\n  \&quot;status\&quot;: 0,\n  \&quot;data\&quot;: {\n    \&quot;count\&quot;: 1,\n    \&quot;list\&quot;: [\n      \&quot;352\&quot;\n    ]\n  },\n  \&quot;message\&quot;: \&quot;success\&quot;\n}</para>
        /// </summary>
        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        /// <summary>
        /// <para>The type of the data to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// <para>The information about a backend service call.</para>
        /// </summary>
        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyServiceConfig ServiceConfig { get; set; }
        public class DescribeApiHistoryResponseBodyServiceConfig : TeaModel {
            /// <summary>
            /// <para>The ContentType header type used when you call the backend service over HTTP.</para>
            /// <list type="bullet">
            /// <item><description>DEFAULT: the default header type in API Gateway</description></item>
            /// <item><description>CUSTOM: a custom header type</description></item>
            /// <item><description>CLIENT: the ContentType header type of the client</description></item>
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
            /// <para>application/json</para>
            /// </summary>
            [NameInMap("ContentTypeValue")]
            [Validation(Required=false)]
            public string ContentTypeValue { get; set; }

            /// <summary>
            /// <para>Configuration items of EventBridge</para>
            /// </summary>
            [NameInMap("EventBridgeConfig")]
            [Validation(Required=false)]
            public DescribeApiHistoryResponseBodyServiceConfigEventBridgeConfig EventBridgeConfig { get; set; }
            public class DescribeApiHistoryResponseBodyServiceConfigEventBridgeConfig : TeaModel {
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
                /// <para>The event source of the managed rule.</para>
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
            public DescribeApiHistoryResponseBodyServiceConfigFunctionComputeConfig FunctionComputeConfig { get; set; }
            public class DescribeApiHistoryResponseBodyServiceConfigFunctionComputeConfig : TeaModel {
                /// <summary>
                /// <para>The ContentType header type used when you call the backend service over HTTP.</para>
                /// <list type="bullet">
                /// <item><description><b>DEFAULT: the default header type in API Gateway.</b></description></item>
                /// <item><description><b>CUSTOM: a custom header type.</b></description></item>
                /// <item><description>**CLIENT: the ContentType header type of the client.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("ContentTypeCatagory")]
                [Validation(Required=false)]
                public string ContentTypeCatagory { get; set; }

                /// <summary>
                /// <para>The value of the ContentType header when the ServiceProtocol parameter is set to HTTP and the ContentTypeCatagory parameter is set to DEFAULT or CUSTOM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>application/json</para>
                /// </summary>
                [NameInMap("ContentTypeValue")]
                [Validation(Required=false)]
                public string ContentTypeValue { get; set; }

                /// <summary>
                /// <para>The root path of Function Compute.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://122xxxxxxx.fc.aliyun.com/2016xxxx/proxy/testSxxx.xxx/testHttp/">https://122xxxxxxx.fc.aliyun.com/2016xxxx/proxy/testSxxx.xxx/testHttp/</a></para>
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
                /// <para>domain_business_control</para>
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
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
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
            /// <para>Specifies whether to enable the MOCK mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TRUE: The Mock mode is enabled.</description></item>
            /// <item><description>FALSE: The Mock mode is not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TRUE</para>
            /// </summary>
            [NameInMap("Mock")]
            [Validation(Required=false)]
            public string Mock { get; set; }

            /// <summary>
            /// <para>The simulated Headers.</para>
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
                    /// <para>The HTTP headers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Content-Type</para>
                    /// </summary>
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <para>The values of the HTTP headers.</para>
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
            /// <para>Information when the backend service is OSS</para>
            /// </summary>
            [NameInMap("OssConfig")]
            [Validation(Required=false)]
            public DescribeApiHistoryResponseBodyServiceConfigOssConfig OssConfig { get; set; }
            public class DescribeApiHistoryResponseBodyServiceConfigOssConfig : TeaModel {
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
                /// <para>phototest02</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The stored object or folder path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENV</para>
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
            /// <para>The URL used to call the backend service.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://api.a.com:8080">http://api.a.com:8080</a></para>
            /// </summary>
            [NameInMap("ServiceAddress")]
            [Validation(Required=false)]
            public string ServiceAddress { get; set; }

            /// <summary>
            /// <para>The HTTP request method used when calling the backend service. Valid values: PUT, GET, POST, DELETE, PATCH, HEAD, OPTIONS, and ANY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("ServiceHttpMethod")]
            [Validation(Required=false)]
            public string ServiceHttpMethod { get; set; }

            /// <summary>
            /// <para>The path used when you call the backend service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/object/add</para>
            /// </summary>
            [NameInMap("ServicePath")]
            [Validation(Required=false)]
            public string ServicePath { get; set; }

            /// <summary>
            /// <para>The backend service protocol. Currently, only HTTP, HTTPS, and FunctionCompute are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }

            /// <summary>
            /// <para>The timeout period of the backend service, in millisecond.</para>
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
            /// <item><description>TRUE: The VPC channel is enabled.</description></item>
            /// <item><description>FALSE: The VPC channel is not enabled.</description></item>
            /// </list>
            /// <para>You must create the corresponding VPC access authorization before you can enable a VPC channel.</para>
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
            public DescribeApiHistoryResponseBodyServiceConfigVpcConfig VpcConfig { get; set; }
            public class DescribeApiHistoryResponseBodyServiceConfigVpcConfig : TeaModel {
                /// <summary>
                /// <para>The IDs of the ELB and SLB instances in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1h497hkijewv2***</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the VPC.</para>
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

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf6kg9x8sx2tbxxxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The parameters of API requests sent by API Gateway to the backend service.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/43988.html">ServiceParameter</a>.</para>
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
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/43989.html">ServiceParameterMap</a>.</para>
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
        /// <para>The environment in which the API is requested. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RELEASE</b>: the production environment</description></item>
        /// <item><description><b>PRE</b>: the pre-release environment</description></item>
        /// <item><description><b>TEST</b>: the test environment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RELEASE</para>
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        /// <summary>
        /// <para>The invocation status of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The common parameters of the APIs, in JSON format.</para>
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
                /// <para>The sample value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.1</para>
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>system parameters description</para>
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
        /// <para>The type of the two-way communication API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>COMMON</b>: general APIs</description></item>
        /// <item><description><b>REGISTER</b>: registered APIs</description></item>
        /// <item><description><b>UNREGISTER</b>: unregistered APIs</description></item>
        /// <item><description><b>NOTIFY</b>: downstream notification</description></item>
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
