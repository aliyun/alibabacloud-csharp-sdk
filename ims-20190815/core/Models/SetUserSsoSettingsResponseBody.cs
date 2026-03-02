// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetUserSsoSettingsResponseBody : TeaModel {
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
        public SetUserSsoSettingsResponseBodyUserSsoSettings UserSsoSettings { get; set; }
        public class SetUserSsoSettingsResponseBodyUserSsoSettings : TeaModel {
            /// <summary>
            /// <para>The signature algorithm that is supported by the Alibaba Cloud SP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>rsa-sha256</para>
            /// </description></item>
            /// <item><description><para>rsa-sha1 (default)</para>
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
            /// <para>The metadata file. The file is Base64-encoded.</para>
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
            /// <para>Indicates whether the <c>&lt;saml:NameID&gt;</c> element in a SAML response must contain a domain name when a user logs on using SAML-based SSO. This applies if the username that is specified on the IdP for logon matching contains a domain name suffix.</para>
            /// <list type="bullet">
            /// <item><description><para>If this parameter is set to <c>true</c>, the value of the <c>&lt;saml:NameID&gt;</c> element <b>must</b> be in the <c>username@domain</c> format, which includes a domain name suffix. The <c>domain</c> can be the default domain name or a domain alias if one is configured.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is set to <c>false</c>, the value of the <c>&lt;saml:NameID&gt;</c> element <b>must</b> be the <c>username</c> only. The value <b>must not</b> contain the <c>domain</c> part.</para>
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
