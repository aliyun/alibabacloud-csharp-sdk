// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetUserSsoSettingsRequest : TeaModel {
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
        /// <para>The file is provided by an IdP that supports SAML 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PD94bWwgdmVy****</para>
        /// </summary>
        [NameInMap("MetadataDocument")]
        [Validation(Required=false)]
        public string MetadataDocument { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable SSO for the RAM user. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SsoEnabled")]
        [Validation(Required=false)]
        public bool? SsoEnabled { get; set; }

    }

}
