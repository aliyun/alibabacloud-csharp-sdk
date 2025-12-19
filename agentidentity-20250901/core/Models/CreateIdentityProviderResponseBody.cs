// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateIdentityProviderResponseBody : TeaModel {
        [NameInMap("IdentityProvider")]
        [Validation(Required=false)]
        public CreateIdentityProviderResponseBodyIdentityProvider IdentityProvider { get; set; }
        public class CreateIdentityProviderResponseBodyIdentityProvider : TeaModel {
            [NameInMap("AllowedAudience")]
            [Validation(Required=false)]
            public List<string> AllowedAudience { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-18T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example identity provider</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://oauth.aliyun.com/.well-known/openid-configuration">https://oauth.aliyun.com/.well-known/openid-configuration</a></para>
            /// </summary>
            [NameInMap("DiscoveryURL")]
            [Validation(Required=false)]
            public string DiscoveryURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:123456:identityprovider/identity-provider-okta</para>
            /// </summary>
            [NameInMap("IdentityProviderArn")]
            [Validation(Required=false)]
            public string IdentityProviderArn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>identity-provider-okta</para>
            /// </summary>
            [NameInMap("IdentityProviderName")]
            [Validation(Required=false)]
            public string IdentityProviderName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-18T06:19:17Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
