// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateAuthorizationServerRequest : TeaModel {
        /// <summary>
        /// <para>The authorization server ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iauths_system</para>
        /// </summary>
        [NameInMap("AuthorizationServerId")]
        [Validation(Required=false)]
        public string AuthorizationServerId { get; set; }

        /// <summary>
        /// <para>The name of the authorization server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_authorization_server</para>
        /// </summary>
        [NameInMap("AuthorizationServerName")]
        [Validation(Required=false)]
        public string AuthorizationServerName { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate a parameter value, but you must make sure that the value is unique among different requests. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see References: <a href="https://www.alibabacloud.com/help/zh/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc123xyz</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The domain name used by the issuer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx.aliyunidaas.com</para>
        /// </summary>
        [NameInMap("IssuerDomain")]
        [Validation(Required=false)]
        public string IssuerDomain { get; set; }

        /// <summary>
        /// <para>The issuer mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dynamic</para>
        /// </summary>
        [NameInMap("IssuerMode")]
        [Validation(Required=false)]
        public string IssuerMode { get; set; }

    }

}
