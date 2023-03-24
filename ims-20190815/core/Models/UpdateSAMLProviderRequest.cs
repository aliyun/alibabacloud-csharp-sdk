// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateSAMLProviderRequest : TeaModel {
        /// <summary>
        /// The new description.
        /// 
        /// >  You must specify at least one of the `NewDescription` and `NewEncodedSAMLMetadataDocument` parameters.
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// The new metadata file.
        /// 
        /// >  You must specify at least one of the `NewDescription` and `NewEncodedSAMLMetadataDocument` parameters.
        /// </summary>
        [NameInMap("NewEncodedSAMLMetadataDocument")]
        [Validation(Required=false)]
        public string NewEncodedSAMLMetadataDocument { get; set; }

        /// <summary>
        /// The name of the IdP whose information you want to modify.
        /// </summary>
        [NameInMap("SAMLProviderName")]
        [Validation(Required=false)]
        public string SAMLProviderName { get; set; }

    }

}
