// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiOperationInfo : TeaModel {
        /// <summary>
        /// <para>The authentication configurations of the operation.</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>The creation timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719386834548</para>
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The backend service deployment information of the operation.</para>
        /// </summary>
        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfig> DeployConfigs { get; set; }

        /// <summary>
        /// <para>The operation description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A example operation.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuth")]
        [Validation(Required=false)]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// <para>The HTTP method of the operation.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TRACE</description></item>
        /// <item><description>HEAD</description></item>
        /// <item><description>DELETE</description></item>
        /// <item><description>POST</description></item>
        /// <item><description>GET</description></item>
        /// <item><description>CONNECT</description></item>
        /// <item><description>OPTIONS</description></item>
        /// <item><description>PUT</description></item>
        /// <item><description>PATCH</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The mocked parameters of the operation.</para>
        /// </summary>
        [NameInMap("mock")]
        [Validation(Required=false)]
        public HttpApiMockContract Mock { get; set; }

        /// <summary>
        /// <para>The operation name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GetUserInfo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The operation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>op-xxx</para>
        /// </summary>
        [NameInMap("operationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// <para>The operation path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/user/123</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The request parameters of the operation.</para>
        /// </summary>
        [NameInMap("request")]
        [Validation(Required=false)]
        public HttpApiRequestContract Request { get; set; }

        /// <summary>
        /// <para>The response parameters of the operation.</para>
        /// </summary>
        [NameInMap("response")]
        [Validation(Required=false)]
        public HttpApiResponseContract Response { get; set; }

        /// <summary>
        /// <para>The operation publishing status on the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Deployed</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
