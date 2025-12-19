// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetIdentityProviderResponseBody : TeaModel {
        [NameInMap("IdentityProvider")]
        [Validation(Required=false)]
        public GetIdentityProviderResponseBodyIdentityProvider IdentityProvider { get; set; }
        public class GetIdentityProviderResponseBodyIdentityProvider : TeaModel {
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
            /// <para>example agent</para>
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
        /// <para>117E1427-1D4C-59CF-A0A8-D7DCDFE88863</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
