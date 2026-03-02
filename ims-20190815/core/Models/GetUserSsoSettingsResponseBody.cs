// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetUserSsoSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The user-based SSO settings.</para>
        /// </summary>
        [NameInMap("UserSsoSettings")]
        [Validation(Required=false)]
        public GetUserSsoSettingsResponseBodyUserSsoSettings UserSsoSettings { get; set; }
        public class GetUserSsoSettingsResponseBodyUserSsoSettings : TeaModel {
            /// <summary>
            /// <para>The signature algorithm supported by the Alibaba Cloud service provider (SP). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>rsa-sha256</para>
            /// </description></item>
            /// <item><description><para>rsa-sha1</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("AuthnSignAlgo")]
            [Validation(Required=false)]
            public string AuthnSignAlgo { get; set; }

            /// <summary>
            /// <para>The auxiliary domain name.</para>
            /// </summary>
            [NameInMap("AuxiliaryDomain")]
            [Validation(Required=false)]
            public string AuxiliaryDomain { get; set; }

            /// <summary>
            /// <para>The metadata file. The value is Base64-encoded.</para>
            /// </summary>
            [NameInMap("MetadataDocument")]
            [Validation(Required=false)]
            public string MetadataDocument { get; set; }

            /// <summary>
            /// <para>Indicates whether user-based SSO is enabled.</para>
            /// </summary>
            [NameInMap("SsoEnabled")]
            [Validation(Required=false)]
            public bool? SsoEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether the <c>&lt;saml:NameID&gt;</c> element in a SAML response must contain a domain name when a user logs on using SAML SSO. The username for SSO logon matching is specified on the identity provider (IdP) side.</para>
            /// <list type="bullet">
            /// <item><description><para>If this parameter is set to <c>true</c>, the value of the <c>&lt;saml:NameID&gt;</c> element <b>must</b> be in the <c>username@domain</c> format. The <c>domain</c> can be the default domain name or a domain alias, if a domain alias is configured.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is set to <c>false</c>, the value of the <c>&lt;saml:NameID&gt;</c> element \<em>\<em>must\</em>\</em> contain only the \<c>username\\</c> and \<em>\<em>must not\</em>\</em> contain the \<c>domain\\</c> part.</para>
            /// </description></item>
            /// </list>
            /// <para>The default value is <c>true</c>.</para>
            /// </summary>
            [NameInMap("SsoLoginWithDomain")]
            [Validation(Required=false)]
            public bool? SsoLoginWithDomain { get; set; }

        }

    }

}
