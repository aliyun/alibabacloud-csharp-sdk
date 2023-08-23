// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoTagLayersResponseBody : TeaModel {
        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   `true`: The request is successful.
        /// *   `false`: The request fails.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The queried image layers.
        /// </summary>
        [NameInMap("Layers")]
        [Validation(Required=false)]
        public List<GetRepoTagLayersResponseBodyLayers> Layers { get; set; }
        public class GetRepoTagLayersResponseBodyLayers : TeaModel {
            /// <summary>
            /// The digest of a single image layer.
            /// </summary>
            [NameInMap("BlobDigest")]
            [Validation(Required=false)]
            public string BlobDigest { get; set; }

            /// <summary>
            /// The size of the image layer.
            /// </summary>
            [NameInMap("BlobSize")]
            [Validation(Required=false)]
            public long? BlobSize { get; set; }

            /// <summary>
            /// Operation on the image layer.
            /// </summary>
            [NameInMap("LayerCMD")]
            [Validation(Required=false)]
            public string LayerCMD { get; set; }

            /// <summary>
            /// The sequence number of the layer stack.
            /// </summary>
            [NameInMap("LayerIndex")]
            [Validation(Required=false)]
            public int? LayerIndex { get; set; }

            /// <summary>
            /// The command for the image layer.
            /// </summary>
            [NameInMap("LayerInstruction")]
            [Validation(Required=false)]
            public string LayerInstruction { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
