// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class SetExternalSAMLIdentityProviderResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The configurations of the IdP.
        /// </summary>
        [NameInMap("SAMLIdentityProviderConfiguration")]
        [Validation(Required=false)]
        public SetExternalSAMLIdentityProviderResponseBodySAMLIdentityProviderConfiguration SAMLIdentityProviderConfiguration { get; set; }
        public class SetExternalSAMLIdentityProviderResponseBodySAMLIdentityProviderConfiguration : TeaModel {
            /// <summary>
            /// The ID of the SAML signing certificate.
            /// </summary>
            [NameInMap("CertificateIds")]
            [Validation(Required=false)]
            public List<string> CertificateIds { get; set; }

            /// <summary>
            /// The time when the IdP was configured for the first time.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the directory.
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// The metadata file of the IdP. The value of this parameter is Base64-encoded.
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
            /// *   Disabled
            /// </summary>
            [NameInMap("SSOStatus")]
            [Validation(Required=false)]
            public string SSOStatus { get; set; }

            /// <summary>
            /// The time when the IdP configurations were last modified.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// Indicates whether CloudSSO needs to sign SAML requests. The requests are sent when users log on to the CloudSSO user portal to initiate SAML-based SSO. Valid values:
            /// 
            /// *   true: yes
            /// *   false: no (default)
            /// </summary>
            [NameInMap("WantRequestSigned")]
            [Validation(Required=false)]
            public bool? WantRequestSigned { get; set; }

        }

    }

}
