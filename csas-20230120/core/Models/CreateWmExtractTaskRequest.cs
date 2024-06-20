// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmExtractTaskRequest : TeaModel {
        [NameInMap("DocumentIsCapture")]
        [Validation(Required=false)]
        public bool? DocumentIsCapture { get; set; }

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

        [NameInMap("VideoIsLong")]
        [Validation(Required=false)]
        public bool? VideoIsLong { get; set; }

        [NameInMap("VideoSpeed")]
        [Validation(Required=false)]
        public string VideoSpeed { get; set; }

        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WmType")]
        [Validation(Required=false)]
        public string WmType { get; set; }

    }

}
