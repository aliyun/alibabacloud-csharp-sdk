// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class SetExternalSAMLIdentityProviderRequest : TeaModel {
        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The metadata file of the IdP. The value of this parameter is Base64-encoded.
        /// 
        /// The file is provided by the IdP that supports SAML 2.0.
        /// </summary>
        [NameInMap("EncodedMetadataDocument")]
        [Validation(Required=false)]
        public string EncodedMetadataDocument { get; set; }

        /// <summary>
        /// The entity ID of the IdP.
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// The logon URL of the IdP.
        /// </summary>
        [NameInMap("LoginUrl")]
        [Validation(Required=false)]
        public string LoginUrl { get; set; }

        /// <summary>
        /// The status of SSO logon. Valid values:
        /// 
        /// *   Enabled
        /// *   Disabled (default)
        /// </summary>
        [NameInMap("SSOStatus")]
        [Validation(Required=false)]
        public string SSOStatus { get; set; }

        /// <summary>
        /// Specifies whether CloudSSO needs to sign SAML requests. The requests are sent when users log on to the CloudSSO user portal to initiate SAML-based SSO. Valid values:
        /// 
        /// *   true: yes
        /// *   false: no (default)
        /// </summary>
        [NameInMap("WantRequestSigned")]
        [Validation(Required=false)]
        public bool? WantRequestSigned { get; set; }

        /// <summary>
        /// The X.509 certificate in the PEM format. If you specify this parameter, all existing certificates are replaced.
        /// </summary>
        [NameInMap("X509Certificate")]
        [Validation(Required=false)]
        public string X509Certificate { get; set; }

    }

}
