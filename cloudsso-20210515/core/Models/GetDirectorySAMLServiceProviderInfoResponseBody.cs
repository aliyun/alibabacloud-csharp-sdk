// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetDirectorySAMLServiceProviderInfoResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the SP.
        /// </summary>
        [NameInMap("SAMLServiceProvider")]
        [Validation(Required=false)]
        public GetDirectorySAMLServiceProviderInfoResponseBodySAMLServiceProvider SAMLServiceProvider { get; set; }
        public class GetDirectorySAMLServiceProviderInfoResponseBodySAMLServiceProvider : TeaModel {
            /// <summary>
            /// The Assertion Consumer Service (ACS) URL of the SP.
            /// </summary>
            [NameInMap("AcsUrl")]
            [Validation(Required=false)]
            public string AcsUrl { get; set; }

            /// <summary>
            /// The ID of the directory.
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// The metadata file of the SP. The value of this parameter is Base64-encoded.
            /// </summary>
            [NameInMap("EncodedMetadataDocument")]
            [Validation(Required=false)]
            public string EncodedMetadataDocument { get; set; }

            /// <summary>
            /// The entity ID of the SP.
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

        }

    }

}
