// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiOperationInfo : TeaModel {
        /// <summary>
        /// <para>The authentication configuration.</para>
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
        /// <para>The backend service deployment information for the operation.</para>
        /// </summary>
        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfig> DeployConfigs { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Retrieve user information</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether authentication is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuth")]
        [Validation(Required=false)]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// <para>The operation method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The operation mock parameter settings.</para>
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
        /// <para>The operation request parameter definition.</para>
        /// </summary>
        [NameInMap("request")]
        [Validation(Required=false)]
        public HttpApiRequestContract Request { get; set; }

        /// <summary>
        /// <para>The operation response parameter definition.</para>
        /// </summary>
        [NameInMap("response")]
        [Validation(Required=false)]
        public HttpApiResponseContract Response { get; set; }

        /// <summary>
        /// <para>The publish status of the operation on the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Deployed</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
