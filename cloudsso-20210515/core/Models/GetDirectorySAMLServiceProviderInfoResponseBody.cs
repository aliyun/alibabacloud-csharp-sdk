// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetDirectorySAMLServiceProviderInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SAMLServiceProvider")]
        [Validation(Required=false)]
        public GetDirectorySAMLServiceProviderInfoResponseBodySAMLServiceProvider SAMLServiceProvider { get; set; }
        public class GetDirectorySAMLServiceProviderInfoResponseBodySAMLServiceProvider : TeaModel {
            [NameInMap("AcsUrl")]
            [Validation(Required=false)]
            public string AcsUrl { get; set; }
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }
            [NameInMap("EncodedMetadataDocument")]
            [Validation(Required=false)]
            public string EncodedMetadataDocument { get; set; }
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }
        };

    }

}
