// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoTagManifestResponseBody : TeaModel {
        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The information about the image manifest.
        /// </summary>
        [NameInMap("Manifest")]
        [Validation(Required=false)]
        public GetRepoTagManifestResponseBodyManifest Manifest { get; set; }
        public class GetRepoTagManifestResponseBodyManifest : TeaModel {
            /// <summary>
            /// Architecture.
            /// </summary>
            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            /// <summary>
            /// The configuration information.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public GetRepoTagManifestResponseBodyManifestConfig Config { get; set; }
            public class GetRepoTagManifestResponseBodyManifestConfig : TeaModel {
                /// <summary>
                /// The digest of the image.
                /// </summary>
                [NameInMap("Digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                /// <summary>
                /// The MIME type of the configuration file.
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// Size
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            /// <summary>
            /// The digest of the referenced filesystem image layer.
            /// </summary>
            [NameInMap("FsLayers")]
            [Validation(Required=false)]
            public List<GetRepoTagManifestResponseBodyManifestFsLayers> FsLayers { get; set; }
            public class GetRepoTagManifestResponseBodyManifestFsLayers : TeaModel {
                /// <summary>
                /// A list of filesystem layer blob sums contained in this image.
                /// </summary>
                [NameInMap("BlobSum")]
                [Validation(Required=false)]
                public string BlobSum { get; set; }

            }

            /// <summary>
            /// A list of unstructured historical data for V1 compatibility.
            /// </summary>
            [NameInMap("History")]
            [Validation(Required=false)]
            public List<GetRepoTagManifestResponseBodyManifestHistory> History { get; set; }
            public class GetRepoTagManifestResponseBodyManifestHistory : TeaModel {
                /// <summary>
                /// The raw V1 compatibility information.
                /// </summary>
                [NameInMap("V1Compatibility")]
                [Validation(Required=false)]
                public Dictionary<string, object> V1Compatibility { get; set; }

            }

            /// <summary>
            /// The information about image layers.
            /// </summary>
            [NameInMap("Layers")]
            [Validation(Required=false)]
            public List<GetRepoTagManifestResponseBodyManifestLayers> Layers { get; set; }
            public class GetRepoTagManifestResponseBodyManifestLayers : TeaModel {
                /// <summary>
                /// The digest of the image.
                /// </summary>
                [NameInMap("Digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                /// <summary>
                /// The MIME type of the configuration file.
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// Size.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            /// <summary>
            /// The type.
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            /// <summary>
            /// The name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The schema version of the manifest.
            /// </summary>
            [NameInMap("SchemaVersion")]
            [Validation(Required=false)]
            public int? SchemaVersion { get; set; }

            /// <summary>
            /// The information about signatures.
            /// </summary>
            [NameInMap("Signatures")]
            [Validation(Required=false)]
            public List<GetRepoTagManifestResponseBodyManifestSignatures> Signatures { get; set; }
            public class GetRepoTagManifestResponseBodyManifestSignatures : TeaModel {
                /// <summary>
                /// The header information of the signature.
                /// </summary>
                [NameInMap("Header")]
                [Validation(Required=false)]
                public Dictionary<string, object> Header { get; set; }

                /// <summary>
                /// The signed protected header.
                /// </summary>
                [NameInMap("Protected")]
                [Validation(Required=false)]
                public string Protected { get; set; }

                /// <summary>
                /// The signature for the image manifest.
                /// </summary>
                [NameInMap("Signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

            }

            /// <summary>
            /// The tag of the image.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
