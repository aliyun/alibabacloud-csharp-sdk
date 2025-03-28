// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ModelFilePreview : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("hash")]
        [Validation(Required=false)]
        public string Hash { get; set; }

        [NameInMap("isCompressedImage")]
        [Validation(Required=false)]
        public bool? IsCompressedImage { get; set; }

        [NameInMap("isDir")]
        [Validation(Required=false)]
        public bool? IsDir { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("unpreviewable")]
        [Validation(Required=false)]
        public bool? Unpreviewable { get; set; }

    }

}
