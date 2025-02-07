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
        /// 
        /// <b>Example:</b>
        /// <para>87F2E3F6-28A0-43F3-A77F-F7760E62F61E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configurations of user-based SSO.</para>
        /// </summary>
        [NameInMap("UserSsoSettings")]
        [Validation(Required=false)]
        public SetUserSsoSettingsResponseBodyUserSsoSettings UserSsoSettings { get; set; }
        public class SetUserSsoSettingsResponseBodyUserSsoSettings : TeaModel {
            /// <summary>
            /// <para>The auxiliary domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("AuxiliaryDomain")]
            [Validation(Required=false)]
            public string AuxiliaryDomain { get; set; }

            /// <summary>
            /// <para>The metadata file, which is Base64-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PD94bWwgdmVy****</para>
            /// </summary>
            [NameInMap("MetadataDocument")]
            [Validation(Required=false)]
            public string MetadataDocument { get; set; }

            /// <summary>
            /// <para>Indicates whether user-based SSO is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SsoEnabled")]
            [Validation(Required=false)]
            public bool? SsoEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the SAML SSO requires a domain name in the <c>&lt;saml:NameID&gt;</c> element of the SAML response. If yes, the username specified by the IdP for SSO must have a domain name as the suffix.</para>
            /// <list type="bullet">
            /// <item><description>If the value of the parameter is <c>true</c>, the <c>&lt;saml:NameID&gt;</c> element <b>must</b> be in the <c>username@domain</c> format. You can set <c>domain</c> to the default domain name or the configured domain alias.</description></item>
            /// <item><description>If the value of the parameter is <c>false</c>, the <c>&lt;saml:NameID&gt;</c> element <b>must</b> be in the <c>username</c> format and <b>cannot</b> contain the <c>domain</c> suffix.</description></item>
            /// </list>
            /// <para>The default value is <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SsoLoginWithDomain")]
            [Validation(Required=false)]
            public bool? SsoLoginWithDomain { get; set; }

        }

    }

}
