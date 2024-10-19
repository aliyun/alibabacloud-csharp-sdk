// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateApiRequest : TeaModel {
        /// <summary>
        /// <para>The type of the two-way communication API.</para>
        /// <list type="bullet">
        /// <item><description><b>COMMON</b>: normal APIs</description></item>
        /// <item><description><b>REGISTER</b>: registered APIs</description></item>
        /// <item><description><b>UNREGISTER</b>: unregistered APIs</description></item>
        /// <item><description><b>NOTIFY</b>: downstream notification APIs</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HmacSHA256</para>
        /// </summary>
        [NameInMap("AllowSignatureMethod")]
        [Validation(Required=false)]
        public string AllowSignatureMethod { get; set; }

        /// <summary>
        /// <para>The name of the API that you want to create. The name must be unique within the API group. The name must be 4 to 50 characters in length. It must start with a letter and can contain letters, digits, and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ApiName</para>
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// <para>The IDof the backend service</para>
        /// 
        /// <b>Example:</b>
        /// <para>HEADER</para>
        /// </summary>
        [NameInMap("AppCodeAuthType")]
        [Validation(Required=false)]
        public string AppCodeAuthType { get; set; }

        /// <summary>
        /// <para>The configuration items of API requests sent by the consumer to API Gateway.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/43985.html">RequestConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

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
        /// <para>Specifies whether to enable backend services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a0305308908c4740aba9cbfd63ba99b7</para>
        /// </summary>
        [NameInMap("BackendId")]
        [Validation(Required=false)]
        public string BackendId { get; set; }

        [NameInMap("ConstantParameters")]
        [Validation(Required=false)]
        public string ConstantParameters { get; set; }

        /// <summary>
        /// <para>The description of the API. The description can be up to 180 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Api description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableInternet")]
        [Validation(Required=false)]
        public bool? DisableInternet { get; set; }

        [NameInMap("ErrorCodeSamples")]
        [Validation(Required=false)]
        public string ErrorCodeSamples { get; set; }

        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Specifies whether to set <b>DisableInternet</b> to <b>true</b> to limit API calls to within the VPC.</description></item>
        /// <item><description>If you set <b>DisableInternet</b> to <b>false</b>, the limit is lifted. The default value is false when you create an API.</description></item>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08ae4aa0f95e4321849ee57f4e0b3077</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>If the <b>AuthType</b> is <b>APP</b> authentication, you need to pass this value to specify the signature algorithm. If you do not specify this parameter, the default value HmacSHA256 is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HmacSHA256</description></item>
        /// <item><description>HmacSHA1,HmacSHA256</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;openIdApiType\&quot;:null,\&quot;idTokenParamName\&quot;:null,\&quot;publicKeyId\&quot;:null,\&quot;publicKey\&quot;:null}</para>
        /// </summary>
        [NameInMap("OpenIdConnectConfig")]
        [Validation(Required=false)]
        public string OpenIdConnectConfig { get; set; }

        /// <summary>
        /// <para>The configuration items of API requests sent by API Gateway to the backend service.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/43987.html">ServiceConfig</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RequestProtocol&quot;:&quot;HTTP&quot;,&quot;RequestHttpMethod&quot;:&quot;GET&quot;,&quot;RequestPath&quot;:&quot;/v3/getUserTest/[userId]&quot;,&quot;BodyFormat&quot;:&quot;FORM&quot;,&quot;PostBodyDescription&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public string RequestConfig { get; set; }

        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public string RequestParameters { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Specifies whether to set <b>ForceNonceCheck</b> to <b>true</b> to force the check of X-Ca-Nonce during the request. This is the unique identifier of the request and is generally identified by UUID. After receiving this parameter, API Gateway verifies the validity of this parameter. The same value can be used only once within 15 minutes. This helps prevent replay attacks.</description></item>
        /// <item><description>If you set <b>ForceNonceCheck</b> to <b>false</b>, the check is not performed. The default value is false when you create an API.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ResultBodyModel")]
        [Validation(Required=false)]
        public string ResultBodyModel { get; set; }

        [NameInMap("ResultDescriptions")]
        [Validation(Required=false)]
        public string ResultDescriptions { get; set; }

        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        /// <summary>
        /// <para>The sample response from the backend service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTML</para>
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The parameters of API requests sent by the consumer to API Gateway.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/43986.html">RequestParameter</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ServiceProtocol&quot;:&quot;HTTP&quot;,&quot;ServiceHttpMethod&quot;:&quot;GET&quot;,&quot;ServiceAddress&quot;:&quot;<a href="http://www.customerdomain.com%22,%22ServiceTimeout%22:%221000%22,%22ServicePath%22:%22/v3/getUserTest/%5BuserId%5D%22%7D">http://www.customerdomain.com&quot;,&quot;ServiceTimeout&quot;:&quot;1000&quot;,&quot;ServicePath&quot;:&quot;/v3/getUserTest/[userId]&quot;}</a></para>
        /// </summary>
        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public string ServiceConfig { get; set; }

        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

        [NameInMap("ServiceParametersMap")]
        [Validation(Required=false)]
        public string ServiceParametersMap { get; set; }

        [NameInMap("SystemParameters")]
        [Validation(Required=false)]
        public string SystemParameters { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateApiRequestTag> Tag { get; set; }
        public class CreateApiRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to make the API public. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PUBLIC</b>: Make the API public. If you set this parameter to PUBLIC, this API is displayed on the APIs page for all users after the API is published to the production environment.</description></item>
        /// <item><description><b>PRIVATE</b>: Make the API private. Private APIs are not displayed in the Alibaba Cloud Marketplace after the API group to which they belong is made available.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The return description of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMMON</para>
        /// </summary>
        [NameInMap("WebSocketApiType")]
        [Validation(Required=false)]
        public string WebSocketApiType { get; set; }

    }

}
