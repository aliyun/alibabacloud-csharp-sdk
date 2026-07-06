// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class AddClientIdToOIDCProviderRequest : TeaModel {
        /// <summary>
        /// <para>The specified client ID.</para>
        /// <para>Format: letters, digits, and the special characters <c>.-_:/</c> are allowed. The value cannot start with the special characters <c>.-_:/</c>.</para>
        /// <para>Length: up to 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>598469743454717****</para>
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
