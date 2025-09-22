// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetUserSsoSettingsRequest : TeaModel {
        [NameInMap("AuthnSignAlgo")]
        [Validation(Required=false)]
        public string AuthnSignAlgo { get; set; }

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
        /// <para>The file is provided by an identity provider (IdP) that supports Security Assertion Markup Language (SAML) 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PD94bWwgdmVy****</para>
        /// </summary>
        [NameInMap("MetadataDocument")]
        [Validation(Required=false)]
        public string MetadataDocument { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable SSO for the RAM user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SsoEnabled")]
        [Validation(Required=false)]
        public bool? SsoEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether the SAML SSO requires a domain name in the <c>&lt;saml:NameID&gt;</c> element of the SAML response. If yes, the username specified by the IdP for SSO must have a domain name as the suffix.</para>
        /// <list type="bullet">
        /// <item><description>If the value of the parameter is <c>true</c>, the <c>&lt;saml:NameID&gt;</c> element <b>must</b> be in the <c>username@domain</c> format. You can set <c>domain</c> to the default domain name or the configured domain alias.</description></item>
        /// <item><description>If the value of the parameter is <c>false</c>, the <c>&lt;saml:NameID&gt;</c> element <b>must</b> be in the <c>username</c> format and <b>cannot</b> contain the <c>domain</c> suffix.</description></item>
        /// </list>
        /// <para>Set the value to the default <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SsoLoginWithDomain")]
        [Validation(Required=false)]
        public bool? SsoLoginWithDomain { get; set; }

    }

}
