// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetUserSsoSettingsRequest : TeaModel {
        /// <summary>
        /// The auxiliary domain name.
        /// </summary>
        [NameInMap("AuxiliaryDomain")]
        [Validation(Required=false)]
        public string AuxiliaryDomain { get; set; }

        /// <summary>
        /// The metadata file, which is Base64-encoded.
        /// 
        /// The file is provided by an IdP that supports SAML 2.0.
        /// </summary>
        [NameInMap("MetadataDocument")]
        [Validation(Required=false)]
        public string MetadataDocument { get; set; }

        /// <summary>
        /// Specifies whether to enable SSO for the RAM user. Default value: false. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("SsoEnabled")]
        [Validation(Required=false)]
        public bool? SsoEnabled { get; set; }

    }

}
