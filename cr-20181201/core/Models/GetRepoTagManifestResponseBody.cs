// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoTagManifestResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("Manifest")]
        [Validation(Required=false)]
        public GetRepoTagManifestResponseBodyManifest Manifest { get; set; }
        public class GetRepoTagManifestResponseBodyManifest : TeaModel {
            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public GetRepoTagManifestResponseBodyManifestConfig Config { get; set; }
            public class GetRepoTagManifestResponseBodyManifestConfig : TeaModel {
                [NameInMap("Digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            [NameInMap("FsLayers")]
            [Validation(Required=false)]
            public List<GetRepoTagManifestResponseBodyManifestFsLayers> FsLayers { get; set; }
            public class GetRepoTagManifestResponseBodyManifestFsLayers : TeaModel {
                [NameInMap("BlobSum")]
                [Validation(Required=false)]
                public string BlobSum { get; set; }

            }

            [NameInMap("History")]
            [Validation(Required=false)]
            public List<GetRepoTagManifestResponseBodyManifestHistory> History { get; set; }
            public class GetRepoTagManifestResponseBodyManifestHistory : TeaModel {
                [NameInMap("V1Compatibility")]
                [Validation(Required=false)]
                public Dictionary<string, object> V1Compatibility { get; set; }

            }

            [NameInMap("Layers")]
            [Validation(Required=false)]
            public List<GetRepoTagManifestResponseBodyManifestLayers> Layers { get; set; }
            public class GetRepoTagManifestResponseBodyManifestLayers : TeaModel {
                [NameInMap("Digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SchemaVersion")]
            [Validation(Required=false)]
            public int? SchemaVersion { get; set; }

            [NameInMap("Signatures")]
            [Validation(Required=false)]
            public List<GetRepoTagManifestResponseBodyManifestSignatures> Signatures { get; set; }
            public class GetRepoTagManifestResponseBodyManifestSignatures : TeaModel {
                [NameInMap("Header")]
                [Validation(Required=false)]
                public Dictionary<string, object> Header { get; set; }

                [NameInMap("Protected")]
                [Validation(Required=false)]
                public string Protected { get; set; }

                [NameInMap("Signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

            }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
