// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetSAMLProviderResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the IdP.
        /// </summary>
        [NameInMap("SAMLProvider")]
        [Validation(Required=false)]
        public GetSAMLProviderResponseBodySAMLProvider SAMLProvider { get; set; }
        public class GetSAMLProviderResponseBodySAMLProvider : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the IdP.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// The creation time.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The metadata file, which is Base64 encoded.
            /// </summary>
            [NameInMap("EncodedSAMLMetadataDocument")]
            [Validation(Required=false)]
            public string EncodedSAMLMetadataDocument { get; set; }

            /// <summary>
            /// The name of the IdP.
            /// </summary>
            [NameInMap("SAMLProviderName")]
            [Validation(Required=false)]
            public string SAMLProviderName { get; set; }

            /// <summary>
            /// The update time.
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

    }

}
