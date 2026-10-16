// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class SetSpecificIdentityProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configuration information of the identity provider.</para>
        /// </summary>
        [NameInMap("SpecificIdentityProviderConfiguration")]
        [Validation(Required=false)]
        public SetSpecificIdentityProviderResponseBodySpecificIdentityProviderConfiguration SpecificIdentityProviderConfiguration { get; set; }
        public class SetSpecificIdentityProviderResponseBodySpecificIdentityProviderConfiguration : TeaModel {
            /// <summary>
            /// <para>The IdP metadata content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;corpId&quot;:&quot;dingxxxxxxxxxx&quot;,&quot;appKey&quot;:&quot;dingxxxxxxxxxx&quot;,&quot;syncCallbackStatus&quot;:&quot;Enabled&quot;}</para>
            /// </summary>
            [NameInMap("IDPMetadata")]
            [Validation(Required=false)]
            public string IDPMetadata { get; set; }

            /// <summary>
            /// <para>The type of the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("IdentityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>The SSO enabling status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("SSOStatus")]
            [Validation(Required=false)]
            public string SSOStatus { get; set; }

        }

    }

}
