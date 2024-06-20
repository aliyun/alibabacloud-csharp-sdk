// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmEmbedTaskShrinkRequest : TeaModel {
        [NameInMap("DocumentControl")]
        [Validation(Required=false)]
        public string DocumentControlShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        [NameInMap("ImageEmbedJpegQuality")]
        [Validation(Required=false)]
        public long? ImageEmbedJpegQuality { get; set; }

        [NameInMap("ImageEmbedLevel")]
        [Validation(Required=false)]
        public long? ImageEmbedLevel { get; set; }

        [NameInMap("VideoBitrate")]
        [Validation(Required=false)]
        public string VideoBitrate { get; set; }

        [NameInMap("VideoIsLong")]
        [Validation(Required=false)]
        public bool? VideoIsLong { get; set; }

        [NameInMap("WmInfoBytesB64")]
        [Validation(Required=false)]
        public string WmInfoBytesB64 { get; set; }

        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        [NameInMap("WmInfoUint")]
        [Validation(Required=false)]
        public string WmInfoUint { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WmType")]
        [Validation(Required=false)]
        public string WmType { get; set; }

    }

}
