// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDeployedApiResponseBody : TeaModel {
        /// <summary>
        /// <para>The signature method used by the client. Valid values:</para>
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
        /// <para>4eed13a57d4e42fbb51316be8a5329ff</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The name of the API</para>
        /// 
        /// <b>Example:</b>
        /// <para>weather</para>
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

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
        /// <para>The constant parameters.</para>
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
                /// <para>The constant value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>constance</para>
                /// </summary>
                [NameInMap("ConstantValue")]
                [Validation(Required=false)]
                public string ConstantValue { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
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
                /// <para>The name of the backend service parameter.</para>
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
        public DescribeDeployedApiResponseBodyCustomSystemParameters CustomSystemParameters { get; set; }
        public class DescribeDeployedApiResponseBodyCustomSystemParameters : TeaModel {
            [NameInMap("CustomSystemParameter")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyCustomSystemParametersCustomSystemParameter> CustomSystemParameter { get; set; }
            public class DescribeDeployedApiResponseBodyCustomSystemParametersCustomSystemParameter : TeaModel {
                /// <summary>
                /// <para>Example</para>
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
                /// <para>123</para>
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
                /// <para>The name of the custom system parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>appid</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The name of the corresponding backend parameter.</para>
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
        /// <para>The deployment time. Format: yyyy-mm-ddhh:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-25T17:47:51Z</para>
        /// </summary>
        [NameInMap("DeployedTime")]
        [Validation(Required=false)]
        public string DeployedTime { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Api description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Specifies whether to set DisableInternet to <b>true</b> to limit API calls to within the VPC.</description></item>
        /// <item><description>If you set DisableInternet to <b>false</b>, the limit is lifted.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not set this parameter, the original value is not modified.</para>
        /// </remarks>
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
        public DescribeDeployedApiResponseBodyErrorCodeSamples ErrorCodeSamples { get; set; }
        public class DescribeDeployedApiResponseBodyErrorCodeSamples : TeaModel {
            [NameInMap("ErrorCodeSample")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyErrorCodeSamplesErrorCodeSample> ErrorCodeSample { get; set; }
            public class DescribeDeployedApiResponseBodyErrorCodeSamplesErrorCodeSample : TeaModel {
                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Error</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>error message</para>
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
        /// <para>bc77f5b49c974437a9912ea3755cd834</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the API group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weather</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The configuration items of the third-party OpenID Connect authentication method.</para>
        /// </summary>
        [NameInMap("OpenIdConnectConfig")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyOpenIdConnectConfig OpenIdConnectConfig { get; set; }
        public class DescribeDeployedApiResponseBodyOpenIdConnectConfig : TeaModel {
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
        /// <para>The region to which the API group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Configuration items of API requests sent by the consumer to API Gateway.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/43985.html">RequestConfig</a>.</para>
        /// </summary>
        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyRequestConfig RequestConfig { get; set; }
        public class DescribeDeployedApiResponseBodyRequestConfig : TeaModel {
            /// <summary>
            /// <para>This parameter takes effect only when the RequestMode parameter is set to MAPPING.</para>
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
            /// <para><a href="https://apigateway.aliyun.com/models/3a240a127dccXXXXXXXX947b4095/9e2df550e85b4121a79XXXXXxaab">https://apigateway.aliyun.com/models/3a240a127dccXXXXXXXX947b4095/9e2df550e85b4121a79XXXXXxaab</a></para>
            /// </summary>
            [NameInMap("BodyModel")]
            [Validation(Required=false)]
            public string BodyModel { get; set; }

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
            /// <para>The API request path. If the complete API URL is <c>http://api.a.com:8080/object/add?key1=value1&amp;key2=value2</c>, the API request path is <c>/object/add </c>.</para>
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
        /// <para>EF924FE4-2EDD-4CD3-89EC-34E4708574E7</para>
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
        public DescribeDeployedApiResponseBodyRequestParameters RequestParameters { get; set; }
        public class DescribeDeployedApiResponseBodyRequestParameters : TeaModel {
            [NameInMap("RequestParameter")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyRequestParametersRequestParameter> RequestParameter { get; set; }
            public class DescribeDeployedApiResponseBodyRequestParametersRequestParameter : TeaModel {
                /// <summary>
                /// <para>The name of the API parameter.</para>
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
                /// <para>Example</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>parameter description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The order in the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DocOrder")]
                [Validation(Required=false)]
                public int? DocOrder { get; set; }

                /// <summary>
                /// <para>Specifies whether the document is public. Valid values: PUBLIC and PRIVATE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLIC</para>
                /// </summary>
                [NameInMap("DocShow")]
                [Validation(Required=false)]
                public string DocShow { get; set; }

                /// <summary>
                /// <para>The hash values that can be entered when ParameterType is set to Int, Long, Float, Double, or String. Separate different values with commas (,), such as 1,2,3,4,9 or A,B,C,E,F.</para>
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
                /// <para>The maximum parameter length when ParameterType is set to String.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public long? MaxLength { get; set; }

                /// <summary>
                /// <para>The maximum parameter value when ParameterType is set to Int, Long, Float, or Double.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public long? MaxValue { get; set; }

                /// <summary>
                /// <para>The minimum parameter length when ParameterType is set to String.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public long? MinLength { get; set; }

                /// <summary>
                /// <para>The minimum parameter value when ParameterType is set to Int, Long, Float, or Double.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public long? MinValue { get; set; }

                /// <summary>
                /// <para>The type of a request parameter. Valid values: String, Int, Long, Float, Double, and Boolean.</para>
                /// 
                /// <b>Example:</b>
                /// <para>String</para>
                /// </summary>
                [NameInMap("ParameterType")]
                [Validation(Required=false)]
                public string ParameterType { get; set; }

                /// <summary>
                /// <para>The regular expression used for parameter validation when ParameterType is set to String.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("RegularExpression")]
                [Validation(Required=false)]
                public string RegularExpression { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter is required. Valid values: REQUIRED and OPTIONAL.</para>
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
        public DescribeDeployedApiResponseBodyResultDescriptions ResultDescriptions { get; set; }
        public class DescribeDeployedApiResponseBodyResultDescriptions : TeaModel {
            [NameInMap("ResultDescription")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyResultDescriptionsResultDescription> ResultDescription { get; set; }
            public class DescribeDeployedApiResponseBodyResultDescriptionsResultDescription : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>result description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Specifies whether a subnode exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasChild")]
                [Validation(Required=false)]
                public bool? HasChild { get; set; }

                /// <summary>
                /// <para>The ID of the result.</para>
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
                /// <para>DEMO</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Specifies whether the parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Mandatory")]
                [Validation(Required=false)]
                public bool? Mandatory { get; set; }

                /// <summary>
                /// <para>The name of the result.</para>
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
                /// <para>The type of the result.</para>
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
        /// <para>The sample response from the backend service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{code: 200, message:\&quot;success\&quot;, data: \&quot;\&quot;}</para>
        /// </summary>
        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        /// <summary>
        /// <para>The format of the response from the backend service. Valid values: JSON, TEXT, BINARY, XML, and HTML. Default value: JSON.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTML</para>
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// <para>The configuration items of API requests sent by API Gateway to the backend service.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/43987.html">ServiceConfig</a>.</para>
        /// </summary>
        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyServiceConfig ServiceConfig { get; set; }
        public class DescribeDeployedApiResponseBodyServiceConfig : TeaModel {
            /// <summary>
            /// <para>Backend configuration items when the backend service is Function Compute</para>
            /// </summary>
            [NameInMap("FunctionComputeConfig")]
            [Validation(Required=false)]
            public DescribeDeployedApiResponseBodyServiceConfigFunctionComputeConfig FunctionComputeConfig { get; set; }
            public class DescribeDeployedApiResponseBodyServiceConfigFunctionComputeConfig : TeaModel {
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
                /// <para>application/x-www-form-urlencoded; charset=UTF-8</para>
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
                /// <para>The region where the API is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
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
            /// <item><description><b>TRUE: The Mock mode is enabled.</b></description></item>
            /// <item><description>**FALSE: The Mock mode is not enabled.</description></item>
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
            public DescribeDeployedApiResponseBodyServiceConfigMockHeaders MockHeaders { get; set; }
            public class DescribeDeployedApiResponseBodyServiceConfigMockHeaders : TeaModel {
                [NameInMap("MockHeader")]
                [Validation(Required=false)]
                public List<DescribeDeployedApiResponseBodyServiceConfigMockHeadersMockHeader> MockHeader { get; set; }
                public class DescribeDeployedApiResponseBodyServiceConfigMockHeadersMockHeader : TeaModel {
                    /// <summary>
                    /// <para>The name of the HTTP header parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Content-Type</para>
                    /// </summary>
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <para>The value of the HTTP header parameter.</para>
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
            public DescribeDeployedApiResponseBodyServiceConfigVpcConfig VpcConfig { get; set; }
            public class DescribeDeployedApiResponseBodyServiceConfigVpcConfig : TeaModel {
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
        public DescribeDeployedApiResponseBodyServiceParameters ServiceParameters { get; set; }
        public class DescribeDeployedApiResponseBodyServiceParameters : TeaModel {
            [NameInMap("ServiceParameter")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyServiceParametersServiceParameter> ServiceParameter { get; set; }
            public class DescribeDeployedApiResponseBodyServiceParametersServiceParameter : TeaModel {
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
                /// <para>The data type of the back-end service parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>String</para>
                /// </summary>
                [NameInMap("ParameterType")]
                [Validation(Required=false)]
                public string ParameterType { get; set; }

                /// <summary>
                /// <para>The name of the backend service parameter.</para>
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
        public DescribeDeployedApiResponseBodyServiceParametersMap ServiceParametersMap { get; set; }
        public class DescribeDeployedApiResponseBodyServiceParametersMap : TeaModel {
            [NameInMap("ServiceParameterMap")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyServiceParametersMapServiceParameterMap> ServiceParameterMap { get; set; }
            public class DescribeDeployedApiResponseBodyServiceParametersMapServiceParameterMap : TeaModel {
                /// <summary>
                /// <para>The name of the front-end input parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sex</para>
                /// </summary>
                [NameInMap("RequestParameterName")]
                [Validation(Required=false)]
                public string RequestParameterName { get; set; }

                /// <summary>
                /// <para>The name of the backend service parameter.</para>
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
        /// <para>The name of the runtime environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RELEASE</b></description></item>
        /// <item><description><b>PRE: the pre-release environment</b></description></item>
        /// <item><description><b>TEST</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RELEASE</para>
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        /// <summary>
        /// <para>System parameters</para>
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
                /// <para>Examples</para>
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
                /// <para>QueryParamDTO</para>
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
                /// <para>The name of the corresponding backend parameter.</para>
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
        /// <item><description><b>PUBLIC</b>: Make the API public. If you set this parameter to PUBLIC, this API is displayed on the APIs page for all users after the API is published to the production environment.**</description></item>
        /// <item><description><b>PRIVATE</b>: Make the API private. Private APIs are not displayed in the Alibaba Cloud Marketplace after the API group to which they belong is made available.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
