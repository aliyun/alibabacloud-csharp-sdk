// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateSAMLProviderRequest : TeaModel {
        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The metadata file, which is Base64 encoded.
        /// 
        /// The file is provided by an IdP that supports SAML 2.0.
        /// </summary>
        [NameInMap("EncodedSAMLMetadataDocument")]
        [Validation(Required=false)]
        public string EncodedSAMLMetadataDocument { get; set; }

        /// <summary>
        /// The name of the IdP.
        /// 
        /// The value can be up to 128 characters in length. The name can contain letters, digits,`  periods (.), hyphens (-), and underscores (_) `. The name cannot start or end with`  periods (.), hyphens (-), or underscores (_) `.
        /// </summary>
        [NameInMap("SAMLProviderName")]
        [Validation(Required=false)]
        public string SAMLProviderName { get; set; }

    }

}
