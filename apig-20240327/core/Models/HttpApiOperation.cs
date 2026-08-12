// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiOperation : TeaModel {
        /// <summary>
        /// <para>The authentication configurations.</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>The deployment configurations.</para>
        /// </summary>
        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfig> DeployConfigs { get; set; }

        /// <summary>
        /// <para>The operation description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a operation description.</para>
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
        /// <para>The HTTP method.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The mocking configuration of the operation. This field takes effect only when the API publishing scenario is Mock.</para>
        /// </summary>
        [NameInMap("mock")]
        [Validation(Required=false)]
        public HttpApiMockContract Mock { get; set; }

        /// <summary>
        /// <para>The operation name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GetUserInfo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The operation path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/user</para>
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

    }

}
