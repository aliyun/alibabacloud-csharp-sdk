// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateIdentityProviderShrinkRequest : TeaModel {
        [NameInMap("AllowedAudience")]
        [Validation(Required=false)]
        public string AllowedAudienceShrink { get; set; }

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
        /// <para>identity-provider-okta</para>
        /// </summary>
        [NameInMap("IdentityProviderName")]
        [Validation(Required=false)]
        public string IdentityProviderName { get; set; }

    }

}
