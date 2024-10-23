// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateOIDCProviderRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the client, which is provided by the external IdP Okta. If you want to specify multiple client IDs, separate the client IDs with commas (,).</para>
        /// <para>The client ID can contain letters, digits, and special characters and cannot start with the special characters. The special characters are <c>periods, (.), hyphens (-), underscores (_), colons (:), and forward slashes (/)</c>.``</para>
        /// <para>The client ID can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>498469743454717****</para>
        /// </summary>
        [NameInMap("ClientIds")]
        [Validation(Required=false)]
        public string ClientIds { get; set; }

        /// <summary>
        /// <para>The description of the OIDC IdP.</para>
        /// <para>The description can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is an OIDC Provider.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The fingerprint of the HTTPS certificate, which is provided by the external IdP Okta. If you want to specify multiple fingerprints, separate the fingerprints with commas (,).</para>
        /// <para>The fingerprint can contain letters and digits.</para>
        /// <para>The fingerprint can be up to 40 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>902ef2deeb3c5b13ea4c3d5193629309e231****</para>
        /// </summary>
        [NameInMap("Fingerprints")]
        [Validation(Required=false)]
        public string Fingerprints { get; set; }

        /// <summary>
        /// <para>The earliest time when an external IdP can issue an ID token. If the value of the iat field in the ID token is later than the current time, the request is rejected. Unit: hours. Valid values: 1 to 168.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("IssuanceLimitTime")]
        [Validation(Required=false)]
        public long? IssuanceLimitTime { get; set; }

        /// <summary>
        /// <para>The URL of the issuer, which is provided by the external IdP. The URL of the issuer must be unique within an Alibaba Cloud account.</para>
        /// <para>The URL of the issuer must start with <c>https</c> and be in the valid URL format. The URL cannot contain query parameters that follow a question mark (<c>?</c>) or logon information that is identified by at signs (<c>@</c>). The URL cannot be a fragment URL that contains number signs (<c>#</c>).</para>
        /// <para>The URL can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dev-xxxxxx.okta.com">https://dev-xxxxxx.okta.com</a></para>
        /// </summary>
        [NameInMap("IssuerUrl")]
        [Validation(Required=false)]
        public string IssuerUrl { get; set; }

        /// <summary>
        /// <para>The name of the OIDC IdP.</para>
        /// <para>The name can contain letters, digits, and special characters and cannot start or end with the special characters. The special characters are <c>periods, (.), hyphens (-), and underscores (_)</c>.``</para>
        /// <para>The name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestOIDCProvider</para>
        /// </summary>
        [NameInMap("OIDCProviderName")]
        [Validation(Required=false)]
        public string OIDCProviderName { get; set; }

    }

}
