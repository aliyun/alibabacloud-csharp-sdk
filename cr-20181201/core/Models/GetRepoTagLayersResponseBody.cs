// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoTagLayersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Layers")]
        [Validation(Required=false)]
        public List<GetRepoTagLayersResponseBodyLayers> Layers { get; set; }
        public class GetRepoTagLayersResponseBodyLayers : TeaModel {
            [NameInMap("BlobDigest")]
            [Validation(Required=false)]
            public string BlobDigest { get; set; }

            [NameInMap("LayerIndex")]
            [Validation(Required=false)]
            public int? LayerIndex { get; set; }

            [NameInMap("LayerInstruction")]
            [Validation(Required=false)]
            public string LayerInstruction { get; set; }

            [NameInMap("LayerCMD")]
            [Validation(Required=false)]
            public string LayerCMD { get; set; }

            [NameInMap("BlobSize")]
            [Validation(Required=false)]
            public long? BlobSize { get; set; }

        }

    }

}
