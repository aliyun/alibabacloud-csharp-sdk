// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateOIDCProviderRequest : TeaModel {
        /// <summary>
        /// The ID of the client, which is provided by the external IdP Okta. If you want to specify multiple client IDs, separate the client IDs with commas (,).
        /// 
        /// The client ID can contain letters, digits, and special characters and cannot start with the special characters. The special characters are `periods, (.), hyphens (-), underscores (_), colons (:), and forward slashes (/)`.``
        /// 
        /// The client ID can be up to 64 characters in length.
        /// </summary>
        [NameInMap("ClientIds")]
        [Validation(Required=false)]
        public string ClientIds { get; set; }

        /// <summary>
        /// The description of the OIDC IdP.
        /// 
        /// The description can be up to 256 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The fingerprint of the HTTPS certificate, which is provided by the external IdP Okta. If you want to specify multiple fingerprints, separate the fingerprints with commas (,).
        /// 
        /// The fingerprint can contain letters and digits.
        /// 
        /// The fingerprint can be up to 40 characters in length.
        /// </summary>
        [NameInMap("Fingerprints")]
        [Validation(Required=false)]
        public string Fingerprints { get; set; }

        /// <summary>
        /// The URL of the issuer, which is provided by the external IdP Okta. The URL of the issuer must be unique within an Alibaba Cloud account.
        /// 
        /// The URL of the issuer must start with `https` and be in the valid URL format. The URL cannot contain query parameters that follow a question mark (`?`) or logon information that is identified by at signs (`@`). The URL cannot be a fragment URL that contains number signs (`#`).
        /// 
        /// The URL can be up to 255 characters in length.
        /// </summary>
        [NameInMap("IssuerUrl")]
        [Validation(Required=false)]
        public string IssuerUrl { get; set; }

        /// <summary>
        /// The name of the OIDC IdP.
        /// 
        /// The name can contain letters, digits, and special characters and cannot start or end with the special characters. The special characters are `periods, (.), hyphens (-), and underscores (_)`.
        /// 
        /// The name can be up to 128 characters in length.
        /// </summary>
        [NameInMap("OIDCProviderName")]
        [Validation(Required=false)]
        public string OIDCProviderName { get; set; }

    }

}
