// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class SetSpecificIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>The IdP metadata. For the DingTalk type, the metadata is in JSON format and includes fields such as corpId, appKey, appSecret, encryptKey, verificationToken, and syncCallbackStatus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;corpId&quot;:&quot;dingxxxxxxxxxx&quot;,&quot;appKey&quot;:&quot;dingxxxxxxxxxx&quot;,&quot;appSecret&quot;:&quot;your_app_secret&quot;,&quot;encryptKey&quot;:&quot;your_encrypt_key&quot;,&quot;verificationToken&quot;:&quot;your_verification_token&quot;,&quot;syncCallbackStatus&quot;:&quot;Enabled&quot;}</para>
        /// </summary>
        [NameInMap("IDPMetadata")]
        [Validation(Required=false)]
        public string IDPMetadata { get; set; }

        /// <summary>
        /// <para>The type of the identity provider. Currently, only DingTalk is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DingTalk</para>
        /// </summary>
        [NameInMap("IdentityProviderType")]
        [Validation(Required=false)]
        public string IdentityProviderType { get; set; }

        /// <summary>
        /// <para>The SSO enabling status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: Enabled.</description></item>
        /// <item><description>Disabled: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("SSOStatus")]
        [Validation(Required=false)]
        public string SSOStatus { get; set; }

        /// <summary>
        /// <para>The name of the user pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-userpool</para>
        /// </summary>
        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
