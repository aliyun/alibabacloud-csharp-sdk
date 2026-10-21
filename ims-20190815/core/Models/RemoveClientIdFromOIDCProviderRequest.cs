// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class RemoveClientIdFromOIDCProviderRequest : TeaModel {
        /// <summary>
        /// <para>The specified client ID.</para>
        /// <para>Format: The client ID can contain letters, digits, and the following special characters: <c>.-_:/</c>. It cannot start with a special character.</para>
        /// <para>Length: The client ID can be up to 128 characters in length.</para>
        /// <para>The <c>ClientId</c> must be bound to the OIDC IdP specified by <c>OIDCProviderName</c>. If it is not bound, you can first call <c>CreateOIDCProvider</c> by setting <c>ClientIds</c> or call <c>AddClientIdToOIDCProvider</c> to bind it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>498469743454717****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The name of the OIDC IdP that exists and is bound to the target <c>ClientId</c>. If the OIDC IdP has not been created or the client ID has not been bound, you can first call <c>CreateOIDCProvider</c> by setting <c>ClientIds</c> or call <c>AddClientIdToOIDCProvider</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestOIDCProvider</para>
        /// </summary>
        [NameInMap("OIDCProviderName")]
        [Validation(Required=false)]
        public string OIDCProviderName { get; set; }

    }

}
