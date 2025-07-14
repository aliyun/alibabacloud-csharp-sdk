// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class RemoveClientIdFromOIDCProviderRequest : TeaModel {
        /// <summary>
        /// <para>The client ID that you want to remove.</para>
        /// <para>The client ID can contain letters, digits, and special characters and cannot start with the special characters. The special characters are <c>periods, (.), hyphens (-), underscores (_), colons (:), and forward slashes (/)</c>.``</para>
        /// <para>The client ID can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>498469743454717****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The name of the OIDC IdP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestOIDCProvider</para>
        /// </summary>
        [NameInMap("OIDCProviderName")]
        [Validation(Required=false)]
        public string OIDCProviderName { get; set; }

    }

}
