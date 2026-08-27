// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class UpdateIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>The client idempotency token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ct-1234abcd</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The identity provider type. Currently, only DingTalk is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DingTalk</para>
        /// </summary>
        [NameInMap("IdentityProviderType")]
        [Validation(Required=false)]
        public string IdentityProviderType { get; set; }

        /// <summary>
        /// <para>The identity provider metadata. In the DingTalk scenario, this is a JSON object string that contains the appKey, appSecret, corpId, encryptKey, and verificationToken fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;appKey&quot;:&quot;dingxxxx&quot;,&quot;appSecret&quot;:&quot;xxxxx&quot;,&quot;corpId&quot;:&quot;dingxxxx&quot;,&quot;encryptKey&quot;:&quot;xxxxx&quot;,&quot;verificationToken&quot;:&quot;xxxxx&quot;}</para>
        /// </summary>
        [NameInMap("IdpMetadata")]
        [Validation(Required=false)]
        public string IdpMetadata { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentteams-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable logon. If this parameter is not specified, the existing configuration is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LoginEnabled")]
        [Validation(Required=false)]
        public bool? LoginEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable user synchronization. If this parameter is not specified, the existing configuration is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SyncEnabled")]
        [Validation(Required=false)]
        public bool? SyncEnabled { get; set; }

    }

}
